using API.Entities;
using API.Helper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace API.Seeder
{
    public static class ModelBuilderExtensions
    {
        //public static async Task SeedUsers(UserManager<AppUser> userManager)
        //{
        //    if (await userManager.Users.AnyAsync()) return;
        //    var userData = await System.IO.File.ReadAllTextAsync("Data/UserSeedData.json");
        //    var users = JsonSerializer.Deserialize<List<AppUser>>(userData);
        //    if (users == null) return;


        //    foreach (var user in users)
        //    {

        //        user.Username = user.Username.ToLower();
        //        await userManager.CreateAsync(user, "Pa$$w0rd");

        //    }

        //    var admin = new AppUser
        //    {
        //        Username = "admin"
        //    };

        //    await userManager.CreateAsync(admin, "Pa$$w0rd");



        //}

        public static void Seed(this ModelBuilder modelBuilder)
        {
            List<string> Salt = new List<string>();
            for (int i = 0; i < 5; i++)
            {
                Salt.Add(HashGenerator.GenerateSalt());
            }
          

            AppUser a = new AppUser
            {
                AppUserId = 1,
                FirstName = "Hanna",
                LastName = "Tiro",
                Username = "hanna"

            };
            a.PasswordSalt = HashGenerator.GenerateSalt();
            a.PasswordHash = HashGenerator.GenerateHash(a.PasswordSalt, "hanna");
            modelBuilder.Entity<AppUser>().HasData(a);

            
            AppUser b = new AppUser
            {
                AppUserId = 2,
                FirstName = "Belma",
                LastName = "Nukic",
                Username = "belma"

            };
            b.PasswordSalt = HashGenerator.GenerateSalt();
            b.PasswordHash = HashGenerator.GenerateHash(b.PasswordSalt, "belma");
            modelBuilder.Entity<AppUser>().HasData(b);

            //Category

            Category cat1= new Category
            {
                CategoryId = 1,
                CategoryName = "Pancakes"
            };
            modelBuilder.Entity<Category>().HasData(cat1);

            Category cat2 = new Category
            {
                CategoryId = 2,
                CategoryName = "Waffles"
            };
            modelBuilder.Entity<Category>().HasData(cat2);

            Category cat3 = new Category
            {
                CategoryId = 3,
                CategoryName = "Pizzas"
            };
            modelBuilder.Entity<Category>().HasData(cat3);


            Category cat4 = new Category
            {
                CategoryId = 4,
                CategoryName = "Fish"
            };
            modelBuilder.Entity<Category>().HasData(cat4);

            Category cat5 = new Category
            {
                CategoryId = 5,
                CategoryName = "Sushi"
            };
            modelBuilder.Entity<Category>().HasData(cat5);

            Category cat6 = new Category
            {
                CategoryId = 6,
                CategoryName = "Sandwiches"
            };
            modelBuilder.Entity<Category>().HasData(cat6);

            Category cat7 = new Category
            {
                CategoryId = 7,
                CategoryName = "Meat"
            };
            modelBuilder.Entity<Category>().HasData(cat7);

            Category cat8 = new Category
            {
                CategoryId = 8,
                CategoryName = "Pasta"
            };
            modelBuilder.Entity<Category>().HasData(cat8);

            Category cat9 = new Category
            {
                CategoryId = 9,
                CategoryName = "Asian food"
            };
            modelBuilder.Entity<Category>().HasData(cat9);

            Category cat10 = new Category
            {
                CategoryId = 10,
                CategoryName = "Taccos"
            };
            modelBuilder.Entity<Category>().HasData(cat10);

            Category cat11 = new Category
            {
                CategoryId =11,
                CategoryName = "Barbeque"
            };
            modelBuilder.Entity<Category>().HasData(cat11);
        }
    }
}

