using API.Extentions;
using API.Helper;
using API.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("api/Categories")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
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
        public async Task<IActionResult> GetPage([FromQuery] PaginationParams paginationP)
        {
            var categories = await _categoryService.GetCategoriesPag(paginationP);
            
            Response.AddPaginationHeader(categories.CurrentPage, categories.PageSize, categories.TotalCount, categories.TotalPages);

            return Ok(categories);
        }

        //[HttpGet("{id}")]

        //public async Task<Category> GetCategoryId(int id)
        //{
        //    return await _service.GetCategoryId(id);
        //}

        [HttpGet("{categoryName}")]

        public async Task<IActionResult> GetCategoryByName(string categoryName)
        {
            return Ok(await _categoryService.GetCategoryByName(categoryName));
        }

    }
}
