using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.OmladinacSO
{
    public class DeleteOmladinacSO : SOBase
    {
        protected override void ExecuteOperation(object entity)
        {
            repository.Delete((Omladinac)entity);
        }
    }
}
