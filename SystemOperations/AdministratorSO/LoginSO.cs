using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.AdministratorSO
{
    public class LoginSO : SOBase
    {
        public Administrator Result { get; private set; }
        protected override void ExecuteOperation(object entity)
        {
            Administrator a = (Administrator)entity;
            foreach (Administrator admin in repository.GetAll(new Administrator()))
            {
                if (admin.Equals(a))
                    Result = admin;
            }
        }
    }
}
