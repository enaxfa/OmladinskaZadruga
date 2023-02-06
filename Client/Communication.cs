using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    internal class Communication
    {
        #region singlton
        private static Communication instance;

        public static Communication Instance
        {
            get
            {
                if (instance == null)
                    instance = new Communication();
                return instance;
            }
        }

        private Communication() { }
        #endregion

        private Socket socket;
        private Transfer transfer;

        public void Connect()
        {
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            socket.Connect("127.0.0.1", 9999);
            transfer = new Transfer(socket);
        }

        public void Stop()
        {
            socket.Shutdown(SocketShutdown.Both);
            socket.Dispose();
        }

        
        internal Administrator Login(Administrator a)
        {
            Request request = new Request()
            {
                Operation = Operation.Login,
                RequestObject = a
            };
            transfer.Send(request);
            Response response = transfer.Receive<Response>();
            return response.GetResponseResult<Administrator>();
        }

        internal void AddOmladinca(Omladinac omladinac)
        {
            Request request = new Request()
            {
                Operation = Operation.AddOmladinac,
                RequestObject = omladinac
            };
            transfer.Send(request);
            Response response = transfer.Receive<Response>();
            response.GetResponseResult<Omladinac>();
        }

        internal List<Omladinac> SearchOmladinac(Omladinac omladinac)
        {
            Request request = new Request
            {
                Operation = Operation.SearchOmladinac,
                RequestObject = omladinac
            };
            transfer.Send(request);
            Response response = transfer.Receive<Response>();
            return response.GetResponseResult<List<Omladinac>>();
        }

        internal void UpdateOmladinca(Omladinac omladinac)
        {
            Request request = new Request()
            {
                Operation = Operation.UpdateOmladinac,
                RequestObject = omladinac
            };
            transfer.Send(request);
            Response response = transfer.Receive<Response>();
            response.GetResponseResult<Omladinac>();
        }
    }
}
