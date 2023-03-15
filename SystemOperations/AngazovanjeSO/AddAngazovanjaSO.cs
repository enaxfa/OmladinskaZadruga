using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.AngazovanjeSO
{
    public class AddAngazovanjaSO : SOBase
    {
        protected override void ExecuteOperation(object entity)
        {
            List<Angazovanje> angazovanja = (List<Angazovanje>)entity;
            List<Angazovanje> postojecaAngazovanja = repository.GetAll(new Angazovanje()).Cast<Angazovanje>().ToList();
            foreach (Angazovanje angazovanje in postojecaAngazovanja)
            {
                foreach(Angazovanje a in angazovanja)
                {
                    if (angazovanje.Omladinac.Equals(a.Omladinac) && angazovanje.DatumAngazovanja == a.DatumAngazovanja)
                        throw new Exception("Omladinac vec radi tog dana");
                }
            }
            foreach(Angazovanje a in angazovanja)
                repository.Add(a);
        }
    }
}
