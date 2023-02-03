﻿using Common;
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
            socket.Connect("127.0.0.1", 9000);
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
            return response.ParseResponse<Administrator>();
        }
    }
}