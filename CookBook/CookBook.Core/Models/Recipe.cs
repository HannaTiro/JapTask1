namespace CookBook.Core.Models
{
    public class Recipe
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal TotalPrice { get; set; }
        public Category Category { get; set; }
        public int CategoryId { get; set; }
        //public  ICollection<RecipeDetail> RecipeDetails { get; set; }
    }
}
