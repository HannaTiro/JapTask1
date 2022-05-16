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


            // Ingredient
            modelBuilder.Entity<Ingredient>().HasData(
                new Ingredient()
                {
                    IngredientId = 1,
                    IngredientName = "Eggs",
                    IngredientPrice = 5,
                    Amount = 9,
                    Measure = "kom"
                },
                new Ingredient()
                {
                    IngredientId = 2,
                    IngredientName = "Milk",
                    IngredientPrice = 200,
                    Amount = 170,
                    Measure = "l"
                },
                  new Ingredient()
                  {
                      IngredientId = 3,
                      IngredientName = "Flour",
                      IngredientPrice = 70,
                      Amount = 50,
                      Measure = "kg"
                  },
                    new Ingredient()
                    {
                        IngredientId = 4,
                        IngredientName = "Chicken",
                        IngredientPrice = 16,
                        Amount = 2,
                        Measure = "kg"
                    },
                      new Ingredient()
                      {
                          IngredientId = 5,
                          IngredientName = "Beef",
                          IngredientPrice = 20,
                          Amount = 2,
                          Measure = "kg"
                      },
                        new Ingredient()
                        {
                            IngredientId = 6,
                            IngredientName = "Cheese",
                            IngredientPrice = 20,
                            Amount = 5,
                            Measure = "kg"
                        },
                          new Ingredient()
                          {
                              IngredientId = 7,
                              IngredientName = "Yogurt",
                              IngredientPrice = 7,
                              Amount = 3,
                              Measure = "l"
                          },
                            new Ingredient()
                            {
                                IngredientId = 8,
                                IngredientName = "Patatoes",
                                IngredientPrice = 30,
                                Amount = 10,
                                Measure = "kg"
                            },
                              new Ingredient()
                              {
                                  IngredientId = 9,
                                  IngredientName = "Spinach",
                                  IngredientPrice = 10,
                                  Amount = 10,
                                  Measure = "kg"
                              },
                                new Ingredient()
                                {
                                    IngredientId = 10,
                                    IngredientName = "Salt",
                                    IngredientPrice = 10,
                                    Amount = 17,
                                    Measure = "kg"
                                },
                                  new Ingredient()
                                  {
                                      IngredientId = 11,
                                      IngredientName = "Peper",
                                      IngredientPrice = 10,
                                      Amount = 20,
                                      Measure = "kg"
                                  }
  );

            //Recipes
            modelBuilder.Entity<Recipe>().HasData(
               new Recipe()
               {
                   RecipeId = 1,
                   RecipeName = "Nutella pancakes",
                   Description = "The process is simple!....",
                   TotalPrice = 5,
                   CategoryId = 1
               },
               new Recipe()
               {
                   RecipeId = 2,
                   RecipeName = "Protein pancakes",
                   Description = "The process is simple! ...",
                   TotalPrice = 6,
                   CategoryId = 1
               },
                 new Recipe()
                 {
                     RecipeId = 3,
                     RecipeName = "Rafaelo pancakes",
                     Description = "The process is simple!.....",
                     TotalPrice = 7,
                     CategoryId = 1
                 }


               );


            //recipeDetail
            modelBuilder.Entity<RecipeDetail>().HasData(
                new RecipeDetail()
                {
                    RecipeDetailId = 1,
                    RecipeId = 1,
                    IngredientId = 1,
                    Amount = 3,
                    Measure = "kom",
                    Price = 1
                },
                  new RecipeDetail()
                  {
                      RecipeDetailId = 2,
                      RecipeId = 1,
                      IngredientId = 2,
                      Amount = 3,
                      Measure = "l",
                      Price = 1
                  },
                  new RecipeDetail()
                  {
                      RecipeDetailId = 3,
                      RecipeId = 1,
                      IngredientId = 3,
                      Amount = 20,
                      Measure = "g",
                      Price = 1
                  },

                  //rec2
                  new RecipeDetail()
                  {
                      RecipeDetailId = 4,
                      RecipeId = 2,
                      IngredientId = 1,
                      Amount = 3,
                      Measure = "kom",
                      Price = 1
                  },
                  new RecipeDetail()
                  {
                      RecipeDetailId = 5,
                      RecipeId = 2,
                      IngredientId = 2,
                      Amount = 3,
                      Measure = "l",
                      Price = 1
                  },
                  new RecipeDetail()
                  {
                      RecipeDetailId = 6,
                      RecipeId = 2,
                      IngredientId = 3,
                      Amount = 20,
                      Measure = "g",
                      Price = 1
                  }

                  

                );

        }
    }
}

