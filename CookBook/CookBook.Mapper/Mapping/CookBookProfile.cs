using CookBook.Core.Models.Requests.Recipe;
using AutoMapper;

namespace CookBook.Mapper
{
    public class CookBookProfile:Profile
    {
        public CookBookProfile()
        {
            CreateMap<CookBook.Core.Entities.Category, CookBook.Core.Models.Category>().ReverseMap();
            CreateMap<CookBook.Core.Entities.Recipe, CookBook.Core.Models.Recipe>().ReverseMap();
            CreateMap<CookBook.Core.Entities.Ingredient, CookBook.Core.Models.Ingredient>()
                .ForMember(dest => dest.PurchaseMeasure, opt => opt.MapFrom(src => src.PurchaseMeasure.ToString()));
            CreateMap<CookBook.Core.Entities.RecipeDetail, CookBook.Core.Models.RecipeDetail>()
                .ForMember(dest => dest.Measure, opt => opt.MapFrom(src => src.Measure.ToString())).ReverseMap();
            CreateMap<CookBook.Core.Entities.User, CookBook.Core.Models.User>();
            CreateMap<CookBook.Core.Models.Recipe, RecipePostRequest>().ReverseMap();
        

       

        }
    }
}
