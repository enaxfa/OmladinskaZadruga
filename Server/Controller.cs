using Common;
using System;
using System.Collections.Generic;

namespace Server
{
    internal class Controller
    {
        private static Controller instance;
        public static Controller Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Controller();
                }
                return instance;
            }
        }

        private List<Administrator> administrators;
        private Controller()
        {
            administrators = new List<Administrator>();
            Administrator a = new Administrator
            {
                Ime = "Ena",
                Prezime = "Fazlic",
                KorisnickoIme = "enaxfa",
                Sifra = "123"
            };
            administrators.Add(a);
        }

        internal object Login(Administrator administrator)
        {
            foreach (Administrator a in administrators)
                if (a.Equals(administrator))
                    return a;
            return null;

        }
    }
}