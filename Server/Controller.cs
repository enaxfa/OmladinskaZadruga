using Common;
using Repository.Implementation;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Security.Principal;
using SystemOperations;
using SystemOperations.AdministratorSO;
using SystemOperations.AngazovanjeSO;
using SystemOperations.OmladinacSO;
using SystemOperations.PosaoSO;
using SystemOperations.PoslodavacSO;
using SystemOperations.TipPoslaSO;

namespace Server
{
    internal class Controller
    {
        #region singlton
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
        #endregion

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

        internal List<Omladinac> GetOmladinci(Omladinac omladinac)
        {
            GetOmladinciSO so = new GetOmladinciSO();
            so.ExecuteTemplate(omladinac);
            return so.Result;
        }

        internal void AddPoslodavac(Poslodavac poslodavac)
        {
            AddPoslodavacSO so = new AddPoslodavacSO();
            so.ExecuteTemplate(poslodavac);
        }

        internal List<Poslodavac> SearchPoslodavac(Poslodavac poslodavac)
        {
           SearchPoslodavacSO so = new SearchPoslodavacSO();
            so.ExecuteTemplate(poslodavac);
            return so.Result;
        }

        internal void UpdatePoslodavac(Poslodavac poslodavac)
        {
            UpdatePoslodavacSO so = new UpdatePoslodavacSO();
            so.ExecuteTemplate(poslodavac);
        }

        internal void DeletePoslodavac(Poslodavac poslodavac)
        {
            DeletePoslodavacSO so = new DeletePoslodavacSO();
            so.ExecuteTemplate(poslodavac);
        }

        internal List<Poslodavac> GetPoslodavci(Poslodavac poslodavac)
        {
            GetPoslodavciSO so = new GetPoslodavciSO();
            so.ExecuteTemplate(poslodavac);
            return so.Result;
        }

        internal List<TipPosla> GetTipPoslova(TipPosla tipPosla)
        {
            GetTipPoslovaSO so = new GetTipPoslovaSO();
            so.ExecuteTemplate(tipPosla);
            return so.Result;
        }

        internal void AddPosao(Posao posao)
        {
            AddPosaoSO so = new AddPosaoSO();
            so.ExecuteTemplate(posao);
        }

        internal List<Posao> SearchPosao(Posao posao)
        {
            SearchPosaoSO so = new SearchPosaoSO();
            so.ExecuteTemplate(posao);
            return so.Result;
        }
        internal void UpdatePosao(Posao posao)
        {
            UpdatePosaoSO so = new UpdatePosaoSO();
            so.ExecuteTemplate(posao);
        }


        internal object GetPoslovi(Posao posao)
        {
            GetPosloviSO so = new GetPosloviSO();
            so.ExecuteTemplate(posao);
            return so.Result;
        }

        internal void AddAngazovanja(List<Angazovanje> angazovanja)
        {
            AddAngazovanjaSO so = new AddAngazovanjaSO();
            so.ExecuteTemplate(angazovanja);
            
        }

        

        internal List<Angazovanje> GetAngazovanja(Angazovanje angazovanje)
        {
            GetAngazovanjaSO so = new GetAngazovanjaSO();
            so.ExecuteTemplate(angazovanje);
            return so.Result;
        }

        internal object SearchAngazovanja(Angazovanje angazovanje)
        {
            SearchAngazovanjaSO so = new SearchAngazovanjaSO();
            so.ExecuteTemplate(angazovanje);
            return so.Result;
        }


        internal void UpdateAngazovanje(Angazovanje angazovanje)
        {
            UpdateAngazovanjeSO so = new UpdateAngazovanjeSO();
            so.ExecuteTemplate(angazovanje);
        }
    }
}