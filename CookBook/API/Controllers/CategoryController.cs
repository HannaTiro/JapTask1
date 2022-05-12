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
      
        public ActionResult<List<Models.Category>> GetCategories()
        {
            return _service.GetCategories();
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
