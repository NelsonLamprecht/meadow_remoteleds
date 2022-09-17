using System;
using System.Collections.Generic;
using System.Text;

namespace meadow_remoteleds
{
    public class AppConfigRoot
    {
        public Network Network { get; set; }
    }

    public class Network
    {
        public Wifi Wifi { get; set; }
    }

    public class Wifi
    {
        public string SSID { get; set; }
        public string Password { get; set; }
    }
}
