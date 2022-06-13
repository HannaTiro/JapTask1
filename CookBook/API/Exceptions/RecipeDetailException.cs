using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Exceptions
{
    public class RecipeDetailException:Exception
    {
       public RecipeDetailException() : base(String.Format("Recipe not found"))
       {

       }
    }
}
