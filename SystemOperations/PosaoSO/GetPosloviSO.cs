using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.PosaoSO
{
    public class GetPosloviSO : SOBase
    {
        public List<Posao> Result { get; set; }
        protected override void ExecuteOperation(IDomenskiObjekat entity)
        {
           Result = repository.GetAll(entity).Cast<Posao>().ToList();
        }
    }
}
