using API.Helper;

namespace API.Requests.RecipeDetail
{
    public class InsertIngredientRequest
    {
        public int  Id { get; set; }
        public int Amount { get; set; }
        public UnitsEnum Measure { get; set; }
        
    }
}
