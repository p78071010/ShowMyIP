using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace ShowMyIP
{
    class Project_Help
    {
        /// <summary>
        /// 取得本機 IP Address
        /// </summary>
        /// <returns></returns>
        static public List<string> GetHostIPAddress()
        {
            List<string> showIPAddress = new List<string>();
            IPHostEntry IpEntry = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ipa in IpEntry.AddressList)
            {
                if (ipa.AddressFamily == AddressFamily.InterNetwork)
                    showIPAddress.Add(ipa.ToString());
            }
            return showIPAddress; 
        }
    }
}
