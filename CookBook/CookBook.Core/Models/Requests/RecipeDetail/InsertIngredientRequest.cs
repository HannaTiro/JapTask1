
using CookBook.Common.Enums;

namespace CookBook.Core.Models.Requests.RecipeDetail
{
    public class InsertIngredientRequest
    {
        public int IngredientId { get; set; }
        public int  RecipeId { get; set; }
        public int Amount { get; set; }
        public UnitsEnum Measure { get; set; }
        
    }
}
