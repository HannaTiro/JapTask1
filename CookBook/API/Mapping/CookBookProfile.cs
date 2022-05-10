using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Mapping
{
    public class CookBookProfile:Profile
    {
        public CookBookProfile()
        {
            CreateMap<Entities.Category, Models.Category>().ReverseMap();
            CreateMap<Entities.Recipe, Models.Recipe>().ReverseMap();
            CreateMap<Entities.Ingredient, Models.Ingredient>().ReverseMap();
            CreateMap<Entities.RecipeDetail, Models.RecipeDetail>().ReverseMap();
            CreateMap<Entities.AppUser, Models.AppUser>().ReverseMap();




        }
    }
}
