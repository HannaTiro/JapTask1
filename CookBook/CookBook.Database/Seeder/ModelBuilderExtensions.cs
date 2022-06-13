using CookBook.Core.Entities;
using CookBook.Common.Enums;
using Microsoft.EntityFrameworkCore;

namespace CookBook.Database.Seeder
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            //List<string> Salt = new List<string>();
            //for (int i = 0; i < 5; i++)
            //{
            //    Salt.Add(HashGenerator.GenerateSalt());
            //}
          

            //User a = new User
            //{
            //    Id=1,
            //    FirstName = "Hanna",
            //    LastName = "Tiro",
            //    UserName = "hanna"

            //};
            //a.PasswordSalt = HashGenerator.GenerateSalt();
            //a.PasswordHash = HashGenerator.GenerateHash(a.PasswordSalt, "hanna");
            //modelBuilder.Entity<User>().HasData(a);

            
            //User b = new User
            //{
            //    Id = 2,
            //    FirstName = "Belma",
            //    LastName = "Nukic",
            //    UserName = "belma"

            //};
            //b.PasswordSalt = HashGenerator.GenerateSalt();
            //b.PasswordHash = HashGenerator.GenerateHash(b.PasswordSalt, "belma");
            //modelBuilder.Entity<User>().HasData(b);

            //Category

            Category cat1= new Category
            {
               Id=1,
                Name = "Pancakes"
            };
            modelBuilder.Entity<Category>().HasData(cat1);

            Category cat2 = new Category
            {
                Id = 2,
                Name = "Waffles"
            };
            modelBuilder.Entity<Category>().HasData(cat2);

            Category cat3 = new Category
            {
                Id = 3,
                Name = "Pizzas"
            };
            modelBuilder.Entity<Category>().HasData(cat3);


            Category cat4 = new Category
            {
                Id = 4,
                Name = "Fish"
            };
            modelBuilder.Entity<Category>().HasData(cat4);

            Category cat5 = new Category
            {
                Id = 5,
                Name = "Sushi"
            };
            modelBuilder.Entity<Category>().HasData(cat5);

            Category cat6 = new Category
            {
                Id = 6,
                Name = "Sandwiches"
            };
            modelBuilder.Entity<Category>().HasData(cat6);

            Category cat7 = new Category
            {
               Id=7,
                Name = "Meat"
            };
            modelBuilder.Entity<Category>().HasData(cat7);

            Category cat8 = new Category
            {
                Id = 8,
                Name = "Pasta"
            };
            modelBuilder.Entity<Category>().HasData(cat8);

            Category cat9 = new Category
            {
                Id = 9,
                Name = "Asian food"
            };
            modelBuilder.Entity<Category>().HasData(cat9);

            Category cat10 = new Category
            {
                Id = 10,
                Name = "Taccos"
            };
            modelBuilder.Entity<Category>().HasData(cat10);

            Category cat11 = new Category
            {
                Id =11,
                Name = "Barbeque"
            };
            modelBuilder.Entity<Category>().HasData(cat11);


            // Ingredient
            modelBuilder.Entity<Ingredient>().HasData(
                new Ingredient()
                {
                    Id = 1,
                    Name = "Eggs",
                    PurchasePrice = 5,
                    PurchaseAmount = 9,
                    PurchaseMeasure = UnitsEnum.kom
                },
                new Ingredient()
                {
                    Id = 2,
                    Name = "Milk",
                    PurchasePrice = 200,
                    PurchaseAmount = 170,
                    PurchaseMeasure = UnitsEnum.l
                },
                new Ingredient()
                  {
                      Id = 3,
                      Name = "Flour",
                      PurchasePrice = 70,
                      PurchaseAmount = 50,
                      PurchaseMeasure = UnitsEnum.kg
                },
                new Ingredient()
                    {
                        Id = 4,
                        Name = "Chicken",
                        PurchasePrice = 16,
                        PurchaseAmount = 2,
                        PurchaseMeasure = UnitsEnum.kom
                },
                new Ingredient()
                      {
                          Id = 5,
                          Name = "Beef",
                          PurchasePrice = 20,
                          PurchaseAmount = 2,
                          PurchaseMeasure = UnitsEnum.kg
                },
                new Ingredient()
                {
                  Id = 6,
                  Name = "Cheese",
                  PurchasePrice = 20,
                  PurchaseAmount = 5,
                  PurchaseMeasure = UnitsEnum.kg
                },
                new Ingredient()
                {
                  Id = 7,
                  Name = "Yogurt",
                  PurchasePrice = 7,
                  PurchaseAmount = 3,
                  PurchaseMeasure = UnitsEnum.l
                },
                new Ingredient()
                {
                  Id = 8,
                  Name = "Patatoes",
                  PurchasePrice = 30,
                  PurchaseAmount = 10,
                  PurchaseMeasure = UnitsEnum.kg
                },
                new Ingredient()
                {
                   Id = 9,
                   Name = "Spinach",
                   PurchasePrice = 10,
                   PurchaseAmount = 10,
                   PurchaseMeasure = UnitsEnum.kg
                },
                new Ingredient()
                {
                  Id = 10,
                  Name = "Salt",
                  PurchasePrice = 10,
                  PurchaseAmount = 17,
                  PurchaseMeasure = UnitsEnum.kg
                },
                new Ingredient()
                {
                  Id = 11,
                  Name = "Peper",
                  PurchasePrice = 10,
                  PurchaseAmount = 20,
                  PurchaseMeasure = UnitsEnum.kg
                }
  );

            //Recipes
            modelBuilder.Entity<Recipe>().HasData(
               new Recipe()
               {
                   Id = 1,
                   Name = "Nutella pancakes",
                   Description = "The process is simple!....",
                   TotalPrice = 5,
                   CategoryId = 1
               },
               new Recipe()
               {
                   Id = 2,
                   Name = "Protein pancakes",
                   Description = "The process is simple! ...",
                   TotalPrice = 6,
                   CategoryId = 1
               },
               new Recipe()
                 {
                     Id = 3,
                     Name = "Rafaelo pancakes",
                     Description = "The process is simple!.....",
                     TotalPrice = 7,
                     CategoryId = 1
                 }
            );


            //recipeDetail
            modelBuilder.Entity<RecipeDetail>().HasData(
                new RecipeDetail()
                {
                    Id = 1,
                    RecipeId = 1,
                    IngredientId = 1,
                    Amount = 3,
                    Measure = UnitsEnum.kom,
                    Price = 1
                },
                  new RecipeDetail()
                  {
                      Id = 2,
                      RecipeId = 1,
                      IngredientId = 2,
                      Amount = 3,
                      Measure = UnitsEnum.l,
                      Price = 1
                  },
                  new RecipeDetail()
                  {
                      Id = 3,
                      RecipeId = 1,
                      IngredientId = 3,
                      Amount = 20,
                      Measure = UnitsEnum.g,
                      Price = 1
                  },

                  //rec2
                  new RecipeDetail()
                  {
                      Id = 4,
                      RecipeId = 2,
                      IngredientId = 1,
                      Amount = 3,
                      Measure = UnitsEnum.kom,
                      Price = 1
                  },
                  new RecipeDetail()
                  {
                      Id = 5,
                      RecipeId = 2,
                      IngredientId = 2,
                      Amount = 3,
                      Measure = UnitsEnum.l,
                      Price = 1
                  },
                  new RecipeDetail()
                  {
                      Id = 6,
                      RecipeId = 2,
                      IngredientId = 3,
                      Amount = 20,
                      Measure = UnitsEnum.g,
                      Price = 1
                  }

                  

                );

        }
    }
}

