using API.Entities;
using API.Interfaces;
using API.Models;
using API.Requests.Category;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Services
{
    public class CategoryService : ICategoryService
    {
        protected readonly CookBookContext _context;
        protected readonly IMapper _mapper;
        public CategoryService(CookBookContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public List<Models.Category> GetCategories( )
        {
            var query = _context.Categories
              .AsQueryable();
           
         
            var list = query.ToList();
            return _mapper.Map<List<Models.Category>>(list);
        }

        public async Task<Models.Category> GetCategoryId(int id)
        {
            var cat= await _context.Categories.FindAsync(id);
            return _mapper.Map<Models.Category>(cat);

        }

        public Models.Category GetCategoryByName(string categoryName)
        {
          var cat= _context.Categories.Where(j => j.CategoryName == categoryName).FirstOrDefault();

            return _mapper.Map<Models.Category>(cat);

           

        }
    }
}
