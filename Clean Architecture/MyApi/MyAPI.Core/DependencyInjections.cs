using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MyAPI.Core.Options;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyAPI.Core
{
    public static class DependencyInjections
    {
        public static IServiceCollection AddCoreDI(this IServiceCollection services,IConfiguration config)
        {
            services.Configure<IServiceCollection>(config.GetSection(ConnectionStringOption.SectionName));
            return services;
        }
    }
}
