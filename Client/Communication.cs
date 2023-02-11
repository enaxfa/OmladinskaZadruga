using Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        internal void AddOmladinac(Omladinac omladinac)
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

        internal void UpdateOmladinac(Omladinac omladinac)
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

        internal void DeleteOmladinac(Omladinac omladinac)
        {
            Request request = new Request()
            {
                Operation = Operation.DeleteOmladinac,
                RequestObject = omladinac
            };
            transfer.Send(request);
            Response response = transfer.Receive<Response>();
            response.GetResponseResult<Omladinac>();
        }

        internal void AddPoslodavac(Poslodavac poslodavac)
        {
            Request request = new Request()
            {
                Operation = Operation.AddPoslodavac,
                RequestObject = poslodavac
            };
            transfer.Send(request);
            Response response = transfer.Receive<Response>();
            response.GetResponseResult<Poslodavac>();
        }

        internal List<Poslodavac> SearchPoslodavac(Poslodavac poslodavac)
        {
            Request request = new Request
            {
                Operation = Operation.SearchPoslodavac,
                RequestObject = poslodavac
            };
            transfer.Send(request);
            Response response = transfer.Receive<Response>();
            return response.GetResponseResult<List<Poslodavac>>();
        }

        internal void UpdatePoslodavac(Poslodavac poslodavac)
        {
            Request request = new Request()
            {
                Operation = Operation.UpdatePoslodavac,
                RequestObject = poslodavac
            };
            transfer.Send(request);
            Response response = transfer.Receive<Response>();
            response.GetResponseResult<Poslodavac>();
        }

        internal void DeletePoslodavac(Poslodavac poslodavac)
        {
            Request request = new Request()
            {
                Operation = Operation.DeletePoslodavac,
                RequestObject = poslodavac
            };
            transfer.Send(request);
            Response response = transfer.Receive<Response>();
            response.GetResponseResult<Poslodavac>();
        }

        internal List<Poslodavac> GetPoslodavci()
        {
            Request request = new Request()
            {
                Operation = Operation.GetPoslodavce,
                RequestObject = new Poslodavac()
            };
            transfer.Send(request);
            Response response = transfer.Receive<Response>();
            return response.GetResponseResult<List<Poslodavac>>();
        }

        internal List<TipPosla> GetTipPoslova()
        {
            Request request = new Request()
            {
                Operation = Operation.GetTipPoslova,
                RequestObject = new TipPosla()
            };
            transfer.Send(request);
            Response response = transfer.Receive<Response>();
            return response.GetResponseResult<List<TipPosla>>();
        }

        internal void AddPosao(Posao posao)
        {
            Request request = new Request()
            {
                Operation = Operation.AddPosao,
                RequestObject = posao
            };
            transfer.Send(request);
            Response response = transfer.Receive<Response>();
            response.GetResponseResult<Posao>();
        }

        internal List<Posao> SearchPosao(Posao posao)
        {
            Request request = new Request
            {
                Operation = Operation.SearchPosao,
                RequestObject = posao
            };
            transfer.Send(request);
            Response response = transfer.Receive<Response>();
            return response.GetResponseResult<List<Posao>>();
        }

        internal List<Omladinac> GetOmladinci()
        {
            Request request = new Request()
            {
                Operation = Operation.GetOmladinci,
                RequestObject = new Omladinac()
            };
            transfer.Send(request);
            Response response = transfer.Receive<Response>();
            return response.GetResponseResult<List<Omladinac>>();
        }

        internal List<Posao> GetPoslovi()
        {
            Request request = new Request()
            {
                Operation = Operation.GetPoslovi,
                RequestObject = new Posao()
            };
            transfer.Send(request);
            Response response = transfer.Receive<Response>();
            return response.GetResponseResult<List<Posao>>();
        }

        internal void AddAngazovanja(List<Angazovanje> angazovanja)
        {
            Request request = new Request()
            {
                Operation = Operation.AddAngazovanja,
                RequestObject = angazovanja
            };
            transfer.Send(request);
            Response response = transfer.Receive<Response>();
            response.GetResponseResult<Angazovanje>();
        }

        internal void UpdatePosao(Posao posao)
        {
            Request request = new Request()
            {
                Operation = Operation.UpdatePosao,
                RequestObject = posao
            };
            transfer.Send(request);
            Response response = transfer.Receive<Response>();
            response.GetResponseResult<Posao>();
        }

        internal List<Angazovanje> GetAngazovanja()
        {
            Request request = new Request()
            {
                Operation = Operation.GetAngazovanja,
                RequestObject = new Angazovanje()
            };
            transfer.Send(request);
            Response response = transfer.Receive<Response>();
            return response.GetResponseResult<List<Angazovanje>>();
        }

        internal List<Angazovanje> SearchAngazovanje(Angazovanje angazovanje)
        {
            Request request = new Request
            {
                Operation = Operation.SearchAngazovanje,
                RequestObject = angazovanje
            };
            transfer.Send(request);
            Response response = transfer.Receive<Response>();
            return response.GetResponseResult<List<Angazovanje>>();
        }


        internal void UpdateAngazovanje(Angazovanje angazovanje)
        {
            Request request = new Request()
            {
                Operation = Operation.UpdateAngazovanje,
                RequestObject = angazovanje
            };
            transfer.Send(request);
            Response response = transfer.Receive<Response>();
            response.GetResponseResult<Angazovanje>();
        }
    }
}
