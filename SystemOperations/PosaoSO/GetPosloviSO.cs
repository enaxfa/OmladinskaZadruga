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
        protected override void ExecuteOperation(object entity)
        {
           Result = repository.GetAll((Posao)entity).Cast<Posao>().ToList();
        }
    }
}
