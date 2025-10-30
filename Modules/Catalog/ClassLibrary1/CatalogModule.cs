using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Builder;
using FluentValidation;

namespace Catalog;

public static class CatalogModule {
    //extension method for abstracting dependency injection
    public static IServiceCollection AddCatalogModule( this IServiceCollection services, IConfiguration configuration) {
        

        return services;
    }

    //http request pipeline configuration
    public static IApplicationBuilder  UseCatalogModule(this IApplicationBuilder app)
    {
        return app;
    }

}

    
