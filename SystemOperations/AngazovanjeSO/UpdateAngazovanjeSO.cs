﻿using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.AngazovanjeSO
{
    public class UpdateAngazovanjeSO : SOBase
    {
        protected override void ExecuteOperation(object entity)
        {
            repository.Update((Angazovanje)entity);
        }
    }
}
