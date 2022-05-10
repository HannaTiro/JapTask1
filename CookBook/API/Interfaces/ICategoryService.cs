using API.Requests.Category;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Interfaces
{
   public  interface ICategoryService
    {
        List<Models.Category> Get();
    }
}
