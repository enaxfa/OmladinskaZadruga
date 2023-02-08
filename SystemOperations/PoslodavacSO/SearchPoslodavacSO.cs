using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.PoslodavacSO
{
    public class SearchPoslodavacSO : SOBase
    {
        public List<Poslodavac> Result { get; set; }
        protected override void ExecuteOperation(IDomenskiObjekat entity)
        {
            Result = repository.GetAllWithCondition(entity).Cast<Poslodavac>().ToList();
        }
    }
}
