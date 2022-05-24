using API.Helper;

namespace API.Models
{
    public class Ingredient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal PurchasePrice { get; set; }
        public int PurchaseAmount { get; set; }
        public string PurchaseMeasure { get; set; }


    }
}
