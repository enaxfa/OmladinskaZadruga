using Common;
using Repository.Implementation;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Security.Principal;
using SystemOperations;
using SystemOperations.AdministratorSO;
using SystemOperations.OmladinacSO;

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

        internal Administrator Login(Administrator administrator)
        {
            LoginSO so = new LoginSO();
            so.ExecuteTemplate(administrator);
            return so.Result;
        }

        internal void AddOmladinac(Omladinac omladinac)
        {
            AddOmladinacSO so = new AddOmladinacSO();
            so.ExecuteTemplate(omladinac);
        }
    }
}