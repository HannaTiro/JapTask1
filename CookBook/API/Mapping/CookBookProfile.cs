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
            CreateMap<Entities.Ingredient, Models.Ingredient>()
                .ForMember(dest => dest.PurchaseMeasure, opt => opt.MapFrom(src => src.PurchaseMeasure.ToString()));
            CreateMap<Entities.RecipeDetail, Models.RecipeDetail>()
                .ForMember(dest => dest.Measure, opt => opt.MapFrom(src => src.Measure.ToString())).ReverseMap();
            CreateMap<Entities.User, Models.User>();
            CreateMap<Models.Recipe, RecipePostRequest>().ReverseMap();
        

       

        }
    }
}
