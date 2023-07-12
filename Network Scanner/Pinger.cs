using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Network_Scanner
{
    public static class Pinger
    {
        public static bool Try(string IP)
        {
            using (Ping ping = new Ping())
            {
                try
                {
                    PingReply reply = ping.Send(IP);

                    if (reply.Status == IPStatus.Success)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }
    }
}
