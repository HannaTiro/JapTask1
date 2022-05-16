using API.Extentions;
using API.Helper;
using API.Interfaces;
using API.Models;
using API.Requests.Category;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
   [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _service;

        public CategoryController(ICategoryService service)
        {
            _service = service;
        }

        [HttpGet]
      
        public  ActionResult<IEnumerable<Models.Category>> GetCategories()
        {

            return _service.GetCategories();

        }


        [HttpGet("getCategoriesPag")]

        public async Task<ActionResult<IEnumerable<Models.Category>>> GetCategoriesPag([FromQuery] PaginationParams paginationP)
        {
            var categories = await _service.GetCategoriesPag(paginationP);
            Response.AddPaginationHeader(categories.CurrentPage, categories.PageSize, categories.TotalCount, categories.TotalPages);
            return Ok(categories);

        }

        //[HttpGet("{id}")]

        //public async Task<Category> GetCategoryId(int id)
        //{
        //    return await _service.GetCategoryId(id);
        //}

        [HttpGet("{categoryName}")]

        public Models.Category GetCategoryByName(string categoryName)
        {
            return _service.GetCategoryByName(categoryName);
        }

    }
}
