using System;
using System.Threading.Tasks;

using Meadow;
using Meadow.Devices;
using Meadow.Foundation;
using Meadow.Foundation.Web.Maple.Server;
using Meadow.Gateway.WiFi;

namespace meadow_remoteleds
{
    // Change F7FeatherV2 to F7FeatherV1 for V1.x boards
    public class MeadowApp : App<F7FeatherV1, MeadowApp>
    {
        MapleServer mapleServer;

        public MeadowApp()
        {
            Initialize().Wait();

            mapleServer.Start();

            LedController.Current.SetColor(Color.Green);
        }

        async Task Initialize()
        {
            Console.WriteLine("Initializing hardware...");

            LedController.Current.Initialize();

            var connectionResult = await Device.WiFiAdapter.Connect(Secrets.WIFI_NAME,Secrets.WIFI_PASSWORD);
            if (connectionResult.ConnectionStatus != ConnectionStatus.Success)
            {
                throw new Exception($"Cannot connect to network: {connectionResult.ConnectionStatus}");
            }

            mapleServer = new MapleServer(Device.WiFiAdapter.IpAddress, 5417, true);
        }

    }
}
