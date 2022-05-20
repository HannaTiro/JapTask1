using API.Helper;
using API.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.Interfaces
{
    public  interface ICategoryService
    {
       Task< PagedList<Models.Category>> GetCategoriesPag(PaginationParams paginationP);
       Task<List<Models.Category>> GetCategories();
       Task<Category> GetCategoryId(int id);
       Task< Models.Category> GetCategoryByName(string categoryName);

    }
}
