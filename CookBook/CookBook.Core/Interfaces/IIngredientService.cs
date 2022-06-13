using System.Collections.Generic;
using System.Threading.Tasks;

namespace CookBook.Core.Interfaces
{
    public interface IIngredientService
    {
       Task<List<Models.Ingredient>> GetAll();
        
    }
}
