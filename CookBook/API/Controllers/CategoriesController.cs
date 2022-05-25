﻿using API.Extentions;
using API.Helper;
using API.Interfaces;
using API.Requests;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

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
        public async Task<PagedResult<Models.Category>> GetPage([FromQuery] BaseSearch search)
        {
            return await _categoryService.GetCategoriesPag(search);
        }

        [HttpGet("{categoryName}")]
        public async Task<IActionResult> GetCategoryByName(string categoryName)
        {
            return Ok(await _categoryService.GetCategoryByName(categoryName));
        }

    }
}
