using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Requests.RecipeDetail
{
    public class InsertIngredientRequest
    {
        public int  IngredientId { get; set; }
        public int Amount { get; set; }
        public string Measure { get; set; }
        
    }
}
