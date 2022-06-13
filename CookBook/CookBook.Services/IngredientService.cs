using AutoMapper;
using CookBook.Core.Interfaces;
using CookBook.Database.Context;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CookBook.Services
{
    public class IngredientService : IIngredientService
    {
        protected readonly CookBookContext _context;
        protected readonly IMapper _mapper;
        public IngredientService(CookBookContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<List<CookBook.Core.Models.Ingredient>> GetAll()
        {
            var ingredients = _context.Ingredients.ToList();
            return  _mapper.Map<List<CookBook.Core.Models.Ingredient>>(ingredients);
        }
       
    }
}
