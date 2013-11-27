using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.NetworkInformation;

namespace ludo_client
{
    class PingHandler
    {
        public PingHandler()
        {
            Ping ping = new Ping();
            PingReply pingReply = ping.Send("logon.chronic-domination.com");
            //label4.Text = (pingReply.RoundtripTime.ToString() + "ms");
        }
    }
}
