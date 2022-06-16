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

            Category cat1 = new Category
            {
                Id = 1,
                Name = "Pancakes",
                CreatedAt = System.DateTime.Now

            };
            modelBuilder.Entity<Category>().HasData(cat1);

            Category cat2 = new Category
            {
                Id = 2,
                Name = "Waffles",
                CreatedAt = System.DateTime.Now

            };
            modelBuilder.Entity<Category>().HasData(cat2);

            Category cat3 = new Category
            {
                Id = 3,
                Name = "Pizzas",
                CreatedAt = System.DateTime.Now

            };
            modelBuilder.Entity<Category>().HasData(cat3);


            Category cat4 = new Category
            {
                Id = 4,
                Name = "Fish",
                CreatedAt = System.DateTime.Now

            };
            modelBuilder.Entity<Category>().HasData(cat4);

            Category cat5 = new Category
            {
                Id = 5,
                Name = "Sushi",
                CreatedAt = System.DateTime.Now

            };
            modelBuilder.Entity<Category>().HasData(cat5);

            Category cat6 = new Category
            {
                Id = 6,
                Name = "Sandwiches",
                CreatedAt = System.DateTime.Now

            };
            modelBuilder.Entity<Category>().HasData(cat6);

            Category cat7 = new Category
            {
                Id = 7,
                Name = "Meat",
                CreatedAt = System.DateTime.Now

            };
            modelBuilder.Entity<Category>().HasData(cat7);

            Category cat8 = new Category
            {
                Id = 8,
                Name = "Pasta",
                CreatedAt = System.DateTime.Now

            };
            modelBuilder.Entity<Category>().HasData(cat8);

            Category cat9 = new Category
            {
                Id = 9,
                Name = "Asian food",
                CreatedAt = System.DateTime.Now

            };
            modelBuilder.Entity<Category>().HasData(cat9);

            Category cat10 = new Category
            {
                Id = 10,
                Name = "Taccos",
                CreatedAt = System.DateTime.Now

            };
            modelBuilder.Entity<Category>().HasData(cat10);

            Category cat11 = new Category
            {
                Id = 11,
                Name = "Barbeque",
                CreatedAt = System.DateTime.Now

            };
            modelBuilder.Entity<Category>().HasData(cat11);

            Category cat12 = new Category
            {
                Id = 12,
                Name = "Rice",
                CreatedAt = System.DateTime.Now

            };
            modelBuilder.Entity<Category>().HasData(cat12);

            Category cat13 = new Category
            {
                Id = 13,
                Name = "Tortilas",
                CreatedAt = System.DateTime.Now
            };
            modelBuilder.Entity<Category>().HasData(cat13);

            Category cat14 = new Category
            {
                Id = 14,
                Name = "Nachos",
                CreatedAt = System.DateTime.Now
            };
            modelBuilder.Entity<Category>().HasData(cat14);

            Category cat15 = new Category
            {
                Id = 15,
                Name = "Cakes",
                CreatedAt = System.DateTime.Now
            };
            modelBuilder.Entity<Category>().HasData(cat15);

            Category cat16 = new Category
            {
                Id = 16,
                Name = "Jams",
                CreatedAt = System.DateTime.Now
            };
            modelBuilder.Entity<Category>().HasData(cat16);

            Category cat17 = new Category
            {
                Id = 17,
                Name = "Omlets",
                CreatedAt = System.DateTime.Now
            };
            modelBuilder.Entity<Category>().HasData(cat17);

            Category cat18 = new Category
            {
                Id = 18,
                Name = "Beans",
                CreatedAt = System.DateTime.Now
            };
            modelBuilder.Entity<Category>().HasData(cat18);

            Category cat19 = new Category
            {
                Id = 19,
                Name = "Cereal",
                CreatedAt = System.DateTime.Now
            };
            modelBuilder.Entity<Category>().HasData(cat19);

            Category cat20 = new Category
            {
                Id = 20,
                Name = "Beef",
                CreatedAt = System.DateTime.Now
            };
            modelBuilder.Entity<Category>().HasData(cat20);

            Category cat21 = new Category
            {
                Id = 21,
                Name = "Bread",
                CreatedAt = System.DateTime.Now
            };
            modelBuilder.Entity<Category>().HasData(cat21);

            Category cat22 = new Category
            {
                Id = 22,
                Name = "Garlic bread",
                CreatedAt = System.DateTime.Now
            };
            modelBuilder.Entity<Category>().HasData(cat22);

            Category cat23 = new Category
            {
                Id = 23,
                Name = "Cabbage",
                CreatedAt = System.DateTime.Now
            };
            modelBuilder.Entity<Category>().HasData(cat23);

            Category cat24 = new Category
            {
                Id = 24,
                Name = "Mushrooms",
                CreatedAt = System.DateTime.Now
            };
            modelBuilder.Entity<Category>().HasData(cat24);

            Category cat25 = new Category
            {
                Id = 25,
                Name = "Schnitzel",
                CreatedAt = System.DateTime.Now
            };
            modelBuilder.Entity<Category>().HasData(cat25);

            Category cat26 = new Category
            {
                Id = 26,
                Name = "Appetiser platter",
                CreatedAt = System.DateTime.Now
            };
            modelBuilder.Entity<Category>().HasData(cat26);

            Category cat27 = new Category
            {
                Id = 27,
                Name = "Vegetarian rice",
                CreatedAt = System.DateTime.Now
            };
            modelBuilder.Entity<Category>().HasData(cat27);

            Category cat28 = new Category
            {
                Id = 28,
                Name = "Vegetarian tortilas",
                CreatedAt = System.DateTime.Now
            };
            modelBuilder.Entity<Category>().HasData(cat28);

            Category cat29 = new Category
            {
                Id = 29,
                Name = "Vegetarian sushi",
                CreatedAt = System.DateTime.Now
            };
            modelBuilder.Entity<Category>().HasData(cat29);

            Category cat30 = new Category
            {
                Id = 30,
                Name = "Vegan sushi",
                CreatedAt = System.DateTime.Now
            };
            modelBuilder.Entity<Category>().HasData(cat30);

            Category cat31 = new Category
            {
                Id = 31,
                Name = "Vegan platter",
                CreatedAt = System.DateTime.Now
            };
            modelBuilder.Entity<Category>().HasData(cat31);

            Category cat32 = new Category
            {
                Id = 32,
                Name = "Vegan pasta",
                CreatedAt = System.DateTime.Now
            };
            modelBuilder.Entity<Category>().HasData(cat32);

            Category cat33 = new Category
            {
                Id = 33,
                Name = "Vegan sandwiches",
                CreatedAt = System.DateTime.Now
            };
            modelBuilder.Entity<Category>().HasData(cat33);

            Category cat34 = new Category
            {
                Id = 34,
                Name = "Vegan cakes",
                CreatedAt = System.DateTime.Now
            };
            modelBuilder.Entity<Category>().HasData(cat34);

            // Ingredient
            modelBuilder.Entity<Ingredient>().HasData(
                new Ingredient()
                {
                    Id = 1,
                    Name = "Eggs",
                    PurchasePrice = 5,
                    PurchaseAmount = 9,
                    PurchaseMeasure = UnitsEnum.kom,
                    CreatedAt = System.DateTime.Now
                },
                new Ingredient()
                {
                    Id = 2,
                    Name = "Milk",
                    PurchasePrice = 200,
                    PurchaseAmount = 170,
                    PurchaseMeasure = UnitsEnum.l,
                    CreatedAt = System.DateTime.Now
                },
                new Ingredient()
                {
                    Id = 3,
                    Name = "Flour",
                    PurchasePrice = 70,
                    PurchaseAmount = 50,
                    PurchaseMeasure = UnitsEnum.kg,
                    CreatedAt = System.DateTime.Now
                },
                new Ingredient()
                {
                    Id = 4,
                    Name = "Chicken",
                    PurchasePrice = 16,
                    PurchaseAmount = 2,
                    PurchaseMeasure = UnitsEnum.kom,
                    CreatedAt = System.DateTime.Now
                },
                new Ingredient()
                {
                    Id = 5,
                    Name = "Beef",
                    PurchasePrice = 20,
                    PurchaseAmount = 2,
                    PurchaseMeasure = UnitsEnum.kg,
                    CreatedAt = System.DateTime.Now
                },
                new Ingredient()
                {
                    Id = 6,
                    Name = "Cheese",
                    PurchasePrice = 20,
                    PurchaseAmount = 5,
                    PurchaseMeasure = UnitsEnum.kg,
                    CreatedAt = System.DateTime.Now
                },
                new Ingredient()
                {
                    Id = 7,
                    Name = "Yogurt",
                    PurchasePrice = 7,
                    PurchaseAmount = 3,
                    PurchaseMeasure = UnitsEnum.l,
                    CreatedAt = System.DateTime.Now
                },
                new Ingredient()
                {
                    Id = 8,
                    Name = "Patatoes",
                    PurchasePrice = 30,
                    PurchaseAmount = 10,
                    PurchaseMeasure = UnitsEnum.kg,
                    CreatedAt = System.DateTime.Now
                },
                new Ingredient()
                {
                    Id = 9,
                    Name = "Spinach",
                    PurchasePrice = 10,
                    PurchaseAmount = 10,
                    PurchaseMeasure = UnitsEnum.kg,
                    CreatedAt = System.DateTime.Now
                },
                new Ingredient()
                {
                    Id = 10,
                    Name = "Salt",
                    PurchasePrice = 10,
                    PurchaseAmount = 17,
                    PurchaseMeasure = UnitsEnum.kg,
                    CreatedAt = System.DateTime.Now
                },
                new Ingredient()
                {
                    Id = 11,
                    Name = "Peper",
                    PurchasePrice = 10,
                    PurchaseAmount = 20,
                    PurchaseMeasure = UnitsEnum.kg,
                    CreatedAt = System.DateTime.Now
                },
                new Ingredient()
                {
                    Id = 12,
                    Name = "Snake beans",
                    PurchasePrice = 10,
                    PurchaseAmount = 20,
                    PurchaseMeasure = UnitsEnum.kg,
                    CreatedAt = System.DateTime.Now
                },
                new Ingredient()
                {
                    Id = 13,
                    Name = "Cherry tomatoes",
                    PurchasePrice = 10,
                    PurchaseAmount = 20,
                    PurchaseMeasure = UnitsEnum.kg,
                    CreatedAt = System.DateTime.Now
                },
               new Ingredient()
               {
                   Id = 14,
                   Name = "Lime",
                   PurchasePrice = 10,
                   PurchaseAmount = 20,
                   PurchaseMeasure = UnitsEnum.kg,
                   CreatedAt = System.DateTime.Now
               },
               new Ingredient()
               {
                   Id = 15,
                   Name = "Turnip",
                   PurchasePrice = 10,
                   PurchaseAmount = 20,
                   PurchaseMeasure = UnitsEnum.kg,
                   CreatedAt = System.DateTime.Now
               },
               new Ingredient()
               {
                   Id = 16,
                   Name = "Sweet patatoes",
                   PurchasePrice = 10,
                   PurchaseAmount = 20,
                   PurchaseMeasure = UnitsEnum.kg,
                   CreatedAt = System.DateTime.Now
               },
               new Ingredient()
               {
                   Id = 17,
                   Name = "Onion",
                   PurchasePrice = 10,
                   PurchaseAmount = 20,
                   PurchaseMeasure = UnitsEnum.kg,
                   CreatedAt = System.DateTime.Now
               },
               new Ingredient()
               {
                   Id = 18,
                   Name = "Mushroom",
                   PurchasePrice = 10,
                   PurchaseAmount = 20,
                   PurchaseMeasure = UnitsEnum.kg,
                   CreatedAt = System.DateTime.Now
               },
               new Ingredient()
               {
                   Id = 19,
                   Name = "Oregano",
                   PurchasePrice = 10,
                   PurchaseAmount = 20,
                   PurchaseMeasure = UnitsEnum.kg,
                   CreatedAt = System.DateTime.Now
               },
               new Ingredient()
               {
                   Id = 20,
                   Name = "Red chilli",
                   PurchasePrice = 10,
                   PurchaseAmount = 20,
                   PurchaseMeasure = UnitsEnum.kg,
                   CreatedAt = System.DateTime.Now
               },
               new Ingredient()
               {
                   Id = 21,
                   Name = "Turmeric",
                   PurchasePrice = 10,
                   PurchaseAmount = 20,
                   PurchaseMeasure = UnitsEnum.kg,
                   CreatedAt = System.DateTime.Now
               },
               new Ingredient()
               {
                   Id = 22,
                   Name = "Dill",
                   PurchasePrice = 10,
                   PurchaseAmount = 20,
                   PurchaseMeasure = UnitsEnum.kg,
                   CreatedAt = System.DateTime.Now
               },
               new Ingredient()
               {
                   Id = 23,
                   Name = "Keema",
                   PurchasePrice = 10,
                   PurchaseAmount = 20,
                   PurchaseMeasure = UnitsEnum.kg,
                   CreatedAt = System.DateTime.Now
               },
               new Ingredient()
               {
                   Id = 24,
                   Name = "Crab",
                   PurchasePrice = 10,
                   PurchaseAmount = 20,
                   PurchaseMeasure = UnitsEnum.kg,
                   CreatedAt = System.DateTime.Now
               },
               new Ingredient()
               {
                   Id = 25,
                   Name = "Chops",
                   PurchasePrice = 10,
                   PurchaseAmount = 20,
                   PurchaseMeasure = UnitsEnum.kg,
                   CreatedAt = System.DateTime.Now
               },
               new Ingredient()
               {
                   Id = 26,
                   Name = "Cranberry",
                   PurchasePrice = 10,
                   PurchaseAmount = 20,
                   PurchaseMeasure = UnitsEnum.kg,
                   CreatedAt = System.DateTime.Now
               },
               new Ingredient()
               {
                   Id = 27,
                   Name = "Kiwi",
                   PurchasePrice = 10,
                   PurchaseAmount = 20,
                   PurchaseMeasure = UnitsEnum.kg,
                   CreatedAt = System.DateTime.Now
               },
               new Ingredient()
               {
                   Id = 28,
                   Name = "Mango",
                   PurchasePrice = 10,
                   PurchaseAmount = 20,
                   PurchaseMeasure = UnitsEnum.kg,
                   CreatedAt = System.DateTime.Now
               },
               new Ingredient()
               {
                   Id = 29,
                   Name = "Watermelon",
                   PurchasePrice = 10,
                   PurchaseAmount = 20,
                   PurchaseMeasure = UnitsEnum.kg,
                   CreatedAt = System.DateTime.Now
               },
               new Ingredient()
               {
                   Id = 30,
                   Name = "Olives",
                   PurchasePrice = 10,
                   PurchaseAmount = 20,
                   PurchaseMeasure = UnitsEnum.kg,
                   CreatedAt = System.DateTime.Now
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
                   CategoryId = 1,
                   CreatedAt = System.DateTime.Now
               },
               new Recipe()
               {
                   Id = 2,
                   Name = "Protein pancakes",
                   Description = "The process is simple! ...",
                   TotalPrice = 6,
                   CategoryId = 1,
                   CreatedAt = System.DateTime.Now

               },
               new Recipe()
               {
                   Id = 3,
                   Name = "Rafaelo pancakes",
                   Description = "The process is simple!.....",
                   TotalPrice = 7,
                   CategoryId = 1,
                   CreatedAt = System.DateTime.Now

               },
                new Recipe()
                {
                    Id = 4,
                    Name = "Neapolitan Pizza",
                    Description = "The process is simple!....",
                    TotalPrice = 5,
                    CategoryId = 3,
                    CreatedAt = System.DateTime.Now
                },
                new Recipe()
                {
                    Id = 5,
                    Name = "Sicilian pizza",
                    Description = "The process is simple!....",
                    TotalPrice = 6,
                    CategoryId = 3,
                    CreatedAt = System.DateTime.Now
                },
                 new Recipe()
                 {
                     Id = 6,
                     Name = "Chicago pizza",
                     Description = "The process is simple!....",
                     TotalPrice = 6,
                     CategoryId = 3,
                     CreatedAt = System.DateTime.Now
                 },
                 new Recipe()
                 {
                     Id = 7,
                     Name = "California pizza",
                     Description = "The process is simple!....",
                     TotalPrice = 6,
                     CategoryId = 3,
                     CreatedAt = System.DateTime.Now
                 },
                new Recipe()
                {
                    Id = 8,
                    Name = "Detroit pizza ",
                    Description = "The process is simple!....",
                    TotalPrice = 16,
                    CategoryId = 3,
                    CreatedAt = System.DateTime.Now
                },
                new Recipe()
                {
                    Id = 9,
                    Name = "Cheese pasta",
                    Description = "The process is simple!....",
                    TotalPrice = 6,
                    CategoryId = 8,
                    CreatedAt = System.DateTime.Now
                },
                new Recipe()
                {
                    Id = 10,
                    Name = "Patato gnocchi",
                    Description = "The process is simple!....",
                    TotalPrice = 6,
                    CategoryId = 8,
                    CreatedAt = System.DateTime.Now
                },
                new Recipe()
                {
                    Id = 11,
                    Name = "Linguine",
                    Description = "The process is simple!....",
                    TotalPrice = 6,
                    CategoryId = 8,
                    CreatedAt = System.DateTime.Now
                },
                 new Recipe()
                 {
                     Id = 12,
                     Name = "Bucatini",
                     Description = "The process is simple!....",
                     TotalPrice = 6,
                     CategoryId = 8,
                     CreatedAt = System.DateTime.Now
                 },
                 new Recipe()
                 {
                     Id = 13,
                     Name = "Tagliatelle",
                     Description = "The process is simple!....",
                     TotalPrice = 6,
                     CategoryId = 8,
                     CreatedAt = System.DateTime.Now
                 },
                 new Recipe()
                 {
                     Id = 14,
                     Name = "Belgian waffles",
                     Description = "The process is simple!....",
                     TotalPrice = 6,
                     CategoryId = 8,
                     CreatedAt = System.DateTime.Now
                 },
                  new Recipe()
                  {
                      Id = 15,
                      Name = "Chocolate waffles",
                      Description = "The process is simple!....",
                      TotalPrice = 6,
                      CategoryId = 8,
                      CreatedAt = System.DateTime.Now
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
                    Price = 1,
                    CreatedAt = System.DateTime.Now
                },
                  new RecipeDetail()
                  {
                      Id = 2,
                      RecipeId = 1,
                      IngredientId = 2,
                      Amount = 3,
                      Measure = UnitsEnum.l,
                      Price = 1,
                      CreatedAt = System.DateTime.Now

                  },
                  new RecipeDetail()
                  {
                      Id = 3,
                      RecipeId = 1,
                      IngredientId = 3,
                      Amount = 20,
                      Measure = UnitsEnum.g,
                      Price = 1,
                      CreatedAt = System.DateTime.Now

                  },

                  //rec2
                  new RecipeDetail()
                  {
                      Id = 4,
                      RecipeId = 2,
                      IngredientId = 1,
                      Amount = 3,
                      Measure = UnitsEnum.kom,
                      Price = 1,
                      CreatedAt = System.DateTime.Now

                  },
                  new RecipeDetail()
                  {
                      Id = 5,
                      RecipeId = 2,
                      IngredientId = 2,
                      Amount = 3,
                      Measure = UnitsEnum.l,
                      Price = 1,
                      CreatedAt = System.DateTime.Now

                  },
                  new RecipeDetail()
                  {
                      Id = 6,
                      RecipeId = 2,
                      IngredientId = 3,
                      Amount = 20,
                      Measure = UnitsEnum.g,
                      Price = 1,
                      CreatedAt = System.DateTime.Now

                  },


                  new RecipeDetail()
                  {
                      Id = 7,
                      RecipeId = 1,
                      IngredientId = 1,
                      Amount = 20,
                      Measure = UnitsEnum.g,
                      Price = 1,
                      CreatedAt = System.DateTime.Now

                  },
                  new RecipeDetail()
                  {
                      Id = 8,
                      RecipeId = 1,
                      IngredientId = 4,
                      Amount = 10,
                      Measure = UnitsEnum.g,
                      Price = 1,
                      CreatedAt = System.DateTime.Now

                  },
                  new RecipeDetail()
                  {
                      Id = 9,
                      RecipeId = 2,
                      IngredientId = 4,
                      Amount = 10,
                      Measure = UnitsEnum.g,
                      Price = 1,
                      CreatedAt = System.DateTime.Now

                  },
                  new RecipeDetail()
                  {
                      Id = 10,
                      RecipeId = 2,
                      IngredientId = 5,
                      Amount = 10,
                      Measure = UnitsEnum.g,
                      Price = 1,
                      CreatedAt = System.DateTime.Now

                  },
                  new RecipeDetail()
                  {
                      Id = 11,
                      RecipeId = 1,
                      IngredientId = 6,
                      Amount = 10,
                      Measure = UnitsEnum.g,
                      Price = 1,
                      CreatedAt = System.DateTime.Now

                  },
                  new RecipeDetail()
                  {
                      Id = 12,
                      RecipeId = 5,
                      IngredientId = 2,
                      Amount = 10,
                      Measure = UnitsEnum.g,
                      Price = 1,
                      CreatedAt = System.DateTime.Now

                  },
                  new RecipeDetail()
                  {
                      Id = 13,
                      RecipeId = 6,
                      IngredientId = 6,
                      Amount = 10,
                      Measure = UnitsEnum.g,
                      Price = 1,
                      CreatedAt = System.DateTime.Now

                  },
                  new RecipeDetail()
                  {
                      Id = 14,
                      RecipeId = 7,
                      IngredientId = 3,
                      Amount = 10,
                      Measure = UnitsEnum.g,
                      Price = 1,
                      CreatedAt = System.DateTime.Now

                  },
                   new RecipeDetail()
                   {
                       Id = 15,
                       RecipeId = 8,
                       IngredientId = 4,
                       Amount = 3,
                       Measure = UnitsEnum.g,
                       Price = 1,
                       CreatedAt = System.DateTime.Now

                   },
                    new RecipeDetail()
                    {
                        Id = 16,
                        RecipeId = 8,
                        IngredientId = 7,
                        Amount = 10,
                        Measure = UnitsEnum.g,
                        Price = 1,
                        CreatedAt = System.DateTime.Now

                    },
                     new RecipeDetail()
                     {
                         Id = 17,
                         RecipeId = 8,
                         IngredientId = 5,
                         Amount = 10,
                         Measure = UnitsEnum.g,
                         Price = 1,
                         CreatedAt = System.DateTime.Now

                     },
                      new RecipeDetail()
                      {
                          Id = 18,
                          RecipeId = 8,
                          IngredientId = 8,
                          Amount = 10,
                          Measure = UnitsEnum.g,
                          Price = 1,
                          CreatedAt = System.DateTime.Now

                      },
                       new RecipeDetail()
                       {
                           Id = 19,
                           RecipeId = 8,
                           IngredientId = 9,
                           Amount = 10,
                           Measure = UnitsEnum.g,
                           Price = 1,
                           CreatedAt = System.DateTime.Now

                       },
                        new RecipeDetail()
                        {
                            Id = 20,
                            RecipeId = 8,
                            IngredientId = 10,
                            Amount = 10,
                            Measure = UnitsEnum.g,
                            Price = 1,
                            CreatedAt = System.DateTime.Now

                        },
                         new RecipeDetail()
                         {
                             Id = 21,
                             RecipeId = 8,
                             IngredientId = 11,
                             Amount = 10,
                             Measure = UnitsEnum.g,
                             Price = 1,
                             CreatedAt = System.DateTime.Now

                         },
                          new RecipeDetail()
                          {
                              Id = 22,
                              RecipeId = 8,
                              IngredientId = 15,
                              Amount = 10,
                              Measure = UnitsEnum.g,
                              Price = 1,
                              CreatedAt = System.DateTime.Now

                          },
                           new RecipeDetail()
                           {
                               Id = 23,
                               RecipeId = 8,
                               IngredientId = 17,
                               Amount = 10,
                               Measure = UnitsEnum.g,
                               Price = 1,
                               CreatedAt = System.DateTime.Now

                           },
                            new RecipeDetail()
                            {
                                Id = 24,
                                RecipeId = 8,
                                IngredientId = 18,
                                Amount = 10,
                                Measure = UnitsEnum.g,
                                Price = 1,
                                CreatedAt = System.DateTime.Now

                            },
                             new RecipeDetail()
                             {
                                 Id = 25,
                                 RecipeId = 8,
                                 IngredientId = 19,
                                 Amount = 10,
                                 Measure = UnitsEnum.g,
                                 Price = 1,
                                 CreatedAt = System.DateTime.Now

                             }
           );

        }
    }
}

