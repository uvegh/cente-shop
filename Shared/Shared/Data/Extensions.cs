using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Shared.Data.Seed;

namespace Shared.Data;

public static class Extensions
{
    public static IApplicationBuilder UseMigration<TContext>(this IApplicationBuilder app)
        where TContext: DbContext//constraint must be a dbcontext
    {
        //this IApplicationBuilder-extension method on Iapplication builder, inject  in the main program.cs from here

        //so instead of app.useMigration<eachccontext> in program.cs
        //you can do it once here
        MigrateDatabaseAsync<TContext>
//synchronously wait for asynchronous method then gets result
(app.ApplicationServices).GetAwaiter().GetResult();
  SeedDataAsync<TContext>(app.ApplicationServices).GetAwaiter().GetResult();
        return app;
    }

    private static async Task MigrateDatabaseAsync<TContext>
//iservice provider to get the required services
(IServiceProvider serviceProvider)
     where TContext : DbContext
    {
        // scope is a container to get services, use using to dispose of after use,create scope for DI
        using var scope = serviceProvider.CreateScope();


        // Get the specific DbContext (CatalogDBContext, BasketDBContext, etc.)
        var context = scope.ServiceProvider.GetRequiredService<TContext>();
        //run  migrations
        await context.Database.MigrateAsync();
    }
    private static async Task SeedDataAsync<TContext>(IServiceProvider serviceProvider)
      
    {
        using var scope = serviceProvider.CreateScope();
        //create seeder by using generic seederInterface for e.g catalog,order, basket
        var seeders = scope.ServiceProvider.GetServices<IDataSeeder>();
        // Get ALL implementations of IDataSeeder from DI container

        foreach (var seeder in seeders)
        {
            await seeder. SeedAllAsync();
            
        }

    }
}
