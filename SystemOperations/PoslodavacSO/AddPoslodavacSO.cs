using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.PoslodavacSO
{
    public class AddPoslodavacSO : SOBase
    {
        protected override void ExecuteOperation(object entity)
        {
            repository.Add((Poslodavac)entity);
        }
    }
}
