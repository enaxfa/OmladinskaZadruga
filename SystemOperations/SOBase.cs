using Common;
using Repository.DBConnection;
using Repository.Implementation;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations
{
    public abstract class SOBase
    {
        protected IDBRepository<IDomenskiObjekat> repository;

        public SOBase()
        {
            repository = new GenericDBRepository();
        }

        public void ExecuteTemplate(IDomenskiObjekat entity)
        {
            try
            {
                ExecuteOperation(entity);
                repository.Commit();
            }
            catch (Exception)
            {
                repository.Rollback();
                throw;
            }
            finally
            {
                repository.Close();
            }
        }

        protected abstract void ExecuteOperation(IDomenskiObjekat entity);
    }
}
