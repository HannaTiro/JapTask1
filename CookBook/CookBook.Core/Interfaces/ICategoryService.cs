using CookBook.Common.Helper;
using CookBook.Core.Models.Requests.SearchObjects;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CookBook.Core.Interfaces
{
    public  interface ICategoryService
    {
        Task<PagedResult<Core.Models.Category>> GetCategoriesPage(CategorySearch search);
        Task<List<CookBook.Core.Models.Category>> GetCategories();
        Task<CookBook.Core.Models.Category> GetCategoryById(int id);
        //Task< Models.Category> GetCategoryByName(string categoryName);
    }
}
