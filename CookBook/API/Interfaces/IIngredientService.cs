using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.Interfaces
{
    public interface IIngredientService
    {
       Task<List<Models.Ingredient>> GetAll();
        List<string> GetUnits();
    }
}
