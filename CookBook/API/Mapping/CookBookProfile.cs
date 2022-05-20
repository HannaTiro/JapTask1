using API.Requests.Recipe;
using AutoMapper;

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
            CreateMap<Entities.User, Models.User>();
            CreateMap<Models.Recipe, RecipePostRequest>().ReverseMap();

        }
    }
}
