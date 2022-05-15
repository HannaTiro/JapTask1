﻿using API.Entities;
using API.Interfaces;
using API.Models;
using API.Requests.Recipe;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Services
{
    public class RecipeService : IRecipeService
    {
        protected readonly CookBookContext _context;
        protected readonly IMapper _mapper;
        public RecipeService(CookBookContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<Models.Recipe>> GetByCategory(int categoryId)
        {
            var recipe = await _context.Recipes.Where(j => j.CategoryId == categoryId).ToListAsync();

            return _mapper.Map<List<Models.Recipe>>(recipe);
        }

        public List<Models.Recipe> GetRecipeByCategory(string categoryName)
        {
            var recipes = _context.Recipes.Include(x => x.Category).AsQueryable();
            recipes = recipes.Where(y => y.Category.CategoryName.Equals(categoryName));
            var list = recipes.ToList();
            return _mapper.Map<List<Models.Recipe>>(recipes);

        }

        public async Task< Models.Recipe> GetRecipeById(int id)
        {
            var recipe = await _context.Recipes.Include(x=>x.Category).Where(x => x.RecipeId == id).FirstOrDefaultAsync();
            return _mapper.Map<Models.Recipe>(recipe);
        }

        public  Models.Recipe GetRecipeByName(string recipeName)
        {
            var cat = _context.Recipes.Where(j => j.RecipeName == recipeName).FirstOrDefault();

            return _mapper.Map<Models.Recipe>(cat);
        }

        public List<Models.Recipe> GetRecipes()
        {
            var query = _context.Recipes.Include(x=>x.Category)
             .AsQueryable();


            var list = query.ToList();
            return _mapper.Map<List<Models.Recipe>>(list);
        }

        public List<Models.RecipeDetail> GetIngredients(int recipeId)
        {
            var request = _context.RecipeDetails.Include(x => x.Recipe).Include(x => x.Ingredient).Where(x => x.Recipe.RecipeId == recipeId).AsQueryable();
            var list = request.ToList();
            return _mapper.Map<List<Models.RecipeDetail>>(list);


        }

        public  async Task<ActionResult<Entities.Recipe>> InsertRecipe(Models.Recipe request)
        {
            var model = new Entities.Recipe
            {
                RecipeName = request.RecipeName,
                CategoryId = request.CategoryId,
                Description = request.Description,
                TotalPrice=0
               
            };


             _context.Recipes.Add(model);
           await _context.SaveChangesAsync();

            return _mapper.Map<Entities.Recipe>(model);
        }


    }
}
