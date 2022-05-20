using System.Collections.Generic;

#nullable disable

namespace API.Entities
{
    public  class Category: BaseEntity
    {
        public Category()
        {
            Recipes = new HashSet<Recipe>();
        }
       
        public string Name { get; set; }
        public virtual ICollection<Recipe> Recipes { get; set; }

    }
}
