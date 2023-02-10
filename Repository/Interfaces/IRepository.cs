using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface IRepository<IDomenskiObjekat> where IDomenskiObjekat : class
    {
        void Add(IDomenskiObjekat entity);
        void Update(IDomenskiObjekat entity);
        void Delete(IDomenskiObjekat entity);
        
        List<IDomenskiObjekat> GetAll(IDomenskiObjekat entity);

        List<IDomenskiObjekat> GetAllWithCondition(IDomenskiObjekat entity);
        
    }
}
