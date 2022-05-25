using API.Helper;
using API.Models;
using API.Requests;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.Interfaces
{
    public  interface ICategoryService
    {
        Task<PagedResult<Models.Category>> GetCategoriesPag(BaseSearch search);
        Task<List<Models.Category>> GetCategories();
        Task<Category> GetCategoryId(int id);
        Task< Models.Category> GetCategoryByName(string categoryName);
    }
}
