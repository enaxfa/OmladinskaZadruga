using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.PoslodavacSO
{
    public class GetPoslodavciSO : SOBase
    {
        public List<Poslodavac> Result { get; set; }
        protected override void ExecuteOperation(object entity)
        {
            Result = repository.GetAll((Poslodavac)entity).Cast<Poslodavac>().ToList();
        }
    }
}
