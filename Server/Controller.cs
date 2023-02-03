using Common;
using Repository.Implementation;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Security.Principal;

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

        private IDBRepository<IDomenskiObjekat> repository;
        private Controller()
        {
            repository = new GenericDBRepository();
        }

        internal object Login(Administrator administrator)
        {
            foreach (Administrator a in repository.GetAll(new Administrator()))
                if (a.Equals(administrator))
                    return a;
            return null;
            
        }
    }
}