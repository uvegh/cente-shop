using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Builder;
using Shared.Data;




namespace Catalog;

public static class CatalogModule {
    //extension method for abstracting dependency injection
    //register extension, this is like add before build in the program.cs e.g builder.services.....
    public static IServiceCollection AddCatalogModule( this IServiceCollection services, IConfiguration configuration) {
        //add services to container, api endpoints
        //injection for your program.cs
        
        var connectionString = configuration.GetConnectionString("DatabseURL");
        services.AddDbContext<CatalogDBContext>(opt =>
        {
            opt.UseNpgsql(connectionString, o => o.CommandTimeout(180));
        });
        services.AddScoped<IDataSeeder, CatalogDataSeeder>();
        return services;
    }

    //http request pipeline configuration
    public static IApplicationBuilder  UseCatalogModule(this IApplicationBuilder app)
    {
        //configure http request pipeline this is after the builder.build in program.cs
        //api endpoint services


        //"Use"data services
        //call migrationExtension created in shared
        app.UseMigration<CatalogDBContext>();

       
        
        return app;
    }

  
}

    
