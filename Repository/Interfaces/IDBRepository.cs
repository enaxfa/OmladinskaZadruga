using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interfaces
{
    public interface IDBRepository<IDomenskiObjekat> : IRepository<IDomenskiObjekat> where IDomenskiObjekat : class
    {
        void Commit();
        void Rollback();
        void Close();
    }
}
