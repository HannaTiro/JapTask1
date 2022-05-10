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


        }
    }
}

