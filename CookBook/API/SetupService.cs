using CookBook.Database.Context;
using Microsoft.EntityFrameworkCore;

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
