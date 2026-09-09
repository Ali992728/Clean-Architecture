using MyAPI.Application;
using MyAPI.Core;
using MyAPI.Infrastructure;

namespace MyAPI.API
{
    public static class DependencyInjections
    {
        public static IServiceCollection AddAPIDI(this IServiceCollection services)
        {
            services.AddCoreDI();
            services.AddApplicationDI();
            services.AddInfrastructureDI();
            return services;
        }
    }
}
