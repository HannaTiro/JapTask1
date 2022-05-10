using API.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API
{
    public  class SetupService
    {
       public static void Seed(CookBookContext context)
        {
            context.Database.Migrate();
        }
    }
}
