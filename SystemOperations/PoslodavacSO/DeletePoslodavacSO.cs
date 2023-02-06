﻿using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.PoslodavacSO
{
    public class DeletePoslodavacSO : SOBase
    {
        protected override void ExecuteOperation(IDomenskiObjekat entity)
        {
            repository.Delete(entity);
        }
    }
}
