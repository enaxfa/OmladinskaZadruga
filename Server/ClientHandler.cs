using System;
using System.Net.Sockets;

namespace Server
{
    internal class ClientHandler
    {
        private Socket socket;

        public ClientHandler(Socket socket)
        {
            this.socket = socket;
        }

        internal void HandleRequests()
        {
            throw new NotImplementedException();
        }
    }
}