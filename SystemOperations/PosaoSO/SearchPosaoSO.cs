using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.PosaoSO
{
    public class SearchPosaoSO : SOBase
    {
        public List<Posao> Result { get; set; }
        protected override void ExecuteOperation(IDomenskiObjekat entity)
        {
            Result = repository.GetAllWithCondition(entity).Cast<Posao>().ToList();
        }
    }
}
