namespace CookBook.Core.Models.Requests.Recipe
{
    public class RecipeSearchRequest: BaseSearch
    {
   
        public string RecipeName { get; set; }
        public string Description { get; set; }
        public string IngredientName { get; set; }

    }
}
