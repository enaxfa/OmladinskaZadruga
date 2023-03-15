using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.TipPoslaSO
{
    public class GetTipPoslovaSO : SOBase
    {
        public List<TipPosla> Result { get; set; }
        protected override void ExecuteOperation(object entity)
        {
            Result = repository.GetAll((TipPosla)entity).Cast<TipPosla>().ToList();
        }
    }
}
