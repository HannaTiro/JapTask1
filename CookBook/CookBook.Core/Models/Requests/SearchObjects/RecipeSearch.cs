using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookBook.Core.Models.Requests.SearchObjects
{
    public class RecipeSearch:BaseSearch
    {
        public int CategoryId { get; set; }
    }
}
