﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Interfaces
{
   public interface IIngredientService
    {
       Task<List<Models.Ingredient>> GetAll();
        List<string> GetUnits();
    }
}
