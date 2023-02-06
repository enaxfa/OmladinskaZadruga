using Common;
using Repository.Implementation;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Security.Principal;
using SystemOperations;
using SystemOperations.AdministratorSO;
using SystemOperations.OmladinacSO;
using SystemOperations.PoslodavacSO;

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

        
        private Controller()
        {
           
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

        internal List<Omladinac> SearchOmladinac(Omladinac omladinac)
        {
            SearchOmladinacSO so = new SearchOmladinacSO();
            so.ExecuteTemplate(omladinac);
            return so.Result;
        }

        internal void UpdateOmladinac(Omladinac omladinac)
        {
            UpdateOmladinacSO so = new UpdateOmladinacSO();
            so.ExecuteTemplate(omladinac);
        }

        internal void DeleteOmladinac(Omladinac omladinac)
        {
            DeleteOmladinacSO so = new DeleteOmladinacSO();
            so.ExecuteTemplate(omladinac);
        }

        internal void AddPoslodavac(Poslodavac poslodavac)
        {
            AddPoslodavacSO so = new AddPoslodavacSO();
            so.ExecuteTemplate(poslodavac);
        }

        internal object SearchPoslodavac(Poslodavac poslodavac)
        {
           SearchPoslodavac so = new SearchPoslodavac();
            so.ExecuteTemplate(poslodavac);
            return so.Result;
        }
    }
}