using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.OmladinacSO
{
    public class SearchOmladinacSO : SOBase
    {
        public List<Omladinac> Result { get; set; }

        protected override void ExecuteOperation(IDomenskiObjekat entity)
        {
            Result = repository.Search(entity).Cast<Omladinac>().ToList();
        }
    }
}
