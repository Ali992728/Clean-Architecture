using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyAPI.Infrastructure
{
    public static class DependencyInjections
    {
        public static IServiceCollection AddInfrastructureDI(this IServiceCollection services)
        {
            return services;
        }
    }
}
