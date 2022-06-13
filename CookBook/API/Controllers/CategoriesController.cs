using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using CookBook.Core.Models.Requests.SearchObjects;
using CookBook.Core.Interfaces;
using CookBook.Common.Helper;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        
        //get(), get(id), post(obj), put(id, obj), delete(id)

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {  
            return Ok(await _categoryService.GetCategories());
        }

        [HttpGet("page")]
        public async Task<PagedResult<CookBook.Core.Models.Category>> GetPage([FromQuery] CategorySearch search)
        {
            return await _categoryService.GetCategoriesPage(search);
        }

        //[HttpGet("{categoryName}")]
        //public async Task<IActionResult> GetCategoryByName(string categoryName)
        //{
        //    return Ok(await _categoryService.GetCategoryByName(categoryName));
        //}

    }
}
