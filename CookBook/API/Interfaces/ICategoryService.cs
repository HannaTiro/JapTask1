﻿using API.Helper;
using API.Models;
using API.Requests.Category;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Interfaces
{
   public  interface ICategoryService
    {
       Task< PagedList<Models.Category>> GetCategoriesPag(PaginationParams paginationP);
        List<Models.Category> GetCategories();

        Task<Category> GetCategoryId(int id);
        Models.Category GetCategoryByName(string categoryName);

    }
}
