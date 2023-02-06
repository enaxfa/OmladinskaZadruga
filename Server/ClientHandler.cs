using Common;
using System;
using System.Diagnostics;
using System.IO;
using System.Net.Sockets;

namespace Server
{
    internal class ClientHandler
    {
        private Socket socket;
        private Transfer transfer;

        public ClientHandler(Socket socket)
        {
            this.socket = socket;
            transfer = new Transfer(socket);
        }

        internal void HandleRequests()
        {
            try
            {
                while (true)
                {
                    Request request = transfer.Receive<Request>();
                    Response response = ProcessRequest(request);
                    transfer.Send(response);
                }
            }
            catch (SocketException ex)
            {
                Debug.WriteLine(">>>" + ex.Message);
            }
            catch (IOException ex)
            {
                Debug.WriteLine(">>>" + ex.Message);
            }
        }

        private Response ProcessRequest(Request request)
        {
            Response response = new Response();
            try
            {
                switch (request.Operation)
                {
                    case Operation.Login:
                        response.Result = Controller.Instance.Login((Administrator)request.RequestObject);
                        break;
                    case Operation.AddOmladinac:
                        Controller.Instance.AddOmladinac((Omladinac)request.RequestObject);
                        break;
                    case Operation.SearchOmladinac:
                        response.Result = Controller.Instance.SearchOmladinac((Omladinac)request.RequestObject);
                        break;
                    case Operation.UpdateOmladinac:
                        Controller.Instance.UpdateOmladinac((Omladinac)request.RequestObject);
                        break;
                    case Operation.DeleteOmladinac:
                        Controller.Instance.DeleteOmladinac((Omladinac)request.RequestObject);
                        break;
                    case Operation.AddPoslodavac:
                        Controller.Instance.AddPoslodavac((Poslodavac)request.RequestObject);
                        break;
                    default:
                        response.Exception = new Exception("Operation is not yet implemented!");
                        break;
                }
            }
            catch (Exception ex)
            {
                response.Exception = new Exception(ex.Message);
            }
            return response;
        }
    }
}