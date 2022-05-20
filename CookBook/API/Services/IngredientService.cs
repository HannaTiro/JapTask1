using API.Entities;
using API.Interfaces;
using AutoMapper;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Services
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

        public async Task<List<Models.Ingredient>> GetAll()
        {
            var ingredients = _context.Ingredients.AsQueryable();
            var i = ingredients.ToList();
            return  _mapper.Map<List<Models.Ingredient>>(i);

        }

        public List<string> GetUnits()
        {
            var list = new List<string> { "kg", "g", "l", "ml", "kom" };
            return list;
        }
    }
}
