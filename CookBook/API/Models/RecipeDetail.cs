namespace API.Models
{
    public class RecipeDetail
    {
        public int Id { get; set; }
        public int Amount { get; set; }
        public string Measure { get; set; }
        public decimal Price { get; set; }

        public  Ingredient Ingredient { get; set; }
        public int IngredientId { get; set; }

        public  Recipe Recipe { get; set; }
        public int RecipeId { get; set; }
    }
}
