

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Builder;


namespace Order;

public static class OrderModule {

    public static IServiceCollection AddOrderModule( this IServiceCollection services, IConfiguration configuration ) {
        return services;
    }

    public static IApplicationBuilder UseOrderModule(this IApplicationBuilder app)
    {
        return app;
    }
}

