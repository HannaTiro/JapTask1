using API.Entities;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace API
{
    public  class Program
    {
        public static void Main(string[] args)
        {
            //var host = CreateHostBuilder(args).Build();
            //using var scope = host.Services.CreateScope();
            //var services = scope.ServiceProvider;
            //try
            //{
            //    var context = services.GetRequiredService<CookBookContext>();
            //    var userManager = services.GetRequiredService<UserManager<AppUser>>();

            //    await context.Database.MigrateAsync();
            //    await Seed.SeedUsers(userManager);
            //}
            //catch (Exception ex)c
            //{

            //    var logger = services.GetRequiredService<ILogger<Program>>();
            //    logger.LogError(ex, "An error occurred during migration");
            //}
            //await host.RunAsync();

            var host = CreateHostBuilder(args).Build();

            using (var scope = host.Services.CreateScope())
            {
                var database = scope.ServiceProvider.GetRequiredService<CookBookContext>();
                SetupService.Seed(database);
              
            }
            host.Run();

        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
