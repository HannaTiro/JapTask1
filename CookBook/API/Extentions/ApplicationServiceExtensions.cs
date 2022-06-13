using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using CookBook.Mapper;
using CookBook.Core.Interfaces;
using CookBook.Services;

namespace API.Extentions
{
    public static class ApplicationServiceExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration config)
        {
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<IIngredientService, IngredientService>();
            services.AddScoped<IRecipeService, RecipeService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IRecipeDetailService, RecipeDetailService>();
            services.AddAutoMapper(typeof(CookBookProfile).Assembly);

            return services;
        }
    }
}
