namespace CookBook.Core.Models.Requests.Recipe
{
    public class RecipePostRequest
    {
        public string RecipeName { get; set; }
        public string Description { get; set; }
       
     
        public int CategoryId { get; set; }
    }
}
