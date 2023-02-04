﻿using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.OmladinacSO
{
    public class AddOmladinacSO : SOBase
    {
        protected override void ExecuteOperation(IDomenskiObjekat entity)
        {
            repository.Add(entity);
        }
    }
}
