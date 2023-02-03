using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Configuration;

namespace Server
{
    internal class Server
    {
        private Socket socket;
        private bool kraj = false;

        public void Connect()
        {
            
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            socket.Bind(new IPEndPoint(IPAddress.Parse(ConfigurationManager.AppSettings["ip"]), int.Parse(ConfigurationManager.AppSettings["port"])));
            socket.Listen(5);
           
        }

        public void Listen()
        {
            try
            {
                while (!kraj)
                {
                    Socket klijentskiSoket = socket.Accept();
                    ClientHandler handler = new ClientHandler(klijentskiSoket);
                    Thread nitKlijent = new Thread(handler.HandleRequests);
                    nitKlijent.Start();
                }
            }
            catch (SocketException ex)
            {
                Debug.WriteLine(">>>>" + ex.Message);
            }
        }

        public void Stop()
        {
            kraj = true;
            socket.Dispose();
        }
    }
}
