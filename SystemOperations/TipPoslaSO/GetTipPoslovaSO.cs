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
        protected override void ExecuteOperation(IDomenskiObjekat entity)
        {
            Result = repository.GetAll(entity).Cast<TipPosla>().ToList();
        }
    }
}
