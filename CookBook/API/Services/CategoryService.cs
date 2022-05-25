using API.Entities;
using API.Helper;
using API.Interfaces;
using API.Requests;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
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
        public async Task<PagedResult<Models.Category>> GetCategoriesPag(BaseSearch search)
        {
            var res = new PagedResult<Models.Category>();
            var query = _context.Categories.AsQueryable();
           // query = query.OrderBy(x => x.Name);
            if (search.IncludeCount == true)
            {
                res.Count = query.Count();
            }
            if (search.RetriveAll.GetValueOrDefault(false) == true)
            {
                if (search.Page < 0)
                    search.Page = 0;
                query = query.Skip((int)((search.Page - 1) * search.PageSize)).Take((int)(search.PageSize));

            }
            var result = await query.ToListAsync();
            res.Results = _mapper.Map<IReadOnlyList<Models.Category>>(result);
            return res;
        }
        public async  Task<List<Models.Category>> GetCategories()
        {
            var query =  _context.Categories
              .AsQueryable();
            var list = query.ToList();
            return  _mapper.Map<List<Models.Category>>(list);
        }
        public async Task<Models.Category> GetCategoryId(int id)
        {
            var cat= await _context.Categories.FindAsync(id);
            return _mapper.Map<Models.Category>(cat);

        }

        public async Task<Models.Category> GetCategoryByName(string categoryName)
        {
          var cat= await _context.Categories.Where(j => j.Name == categoryName).FirstOrDefaultAsync();

            return _mapper.Map<Models.Category>(cat);

           

        }
    }
}
