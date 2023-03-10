using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.AngazovanjeSO
{
    
    public class GetAngazovanjaSO : SOBase
    {
        public List<Angazovanje> Result { get; set; }
        protected override void ExecuteOperation(IDomenskiObjekat entity)
        {
            Result = repository.GetAll(entity).Cast<Angazovanje>().ToList();
        }

    }
}
