using Microsoft.Extensions.DependencyInjection;
using MyAPI.Infrastructure.Persistency;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using MyAPI.Core.Options;
using Microsoft.Extensions.Options;

namespace MyAPI.Infrastructure
{
    public static class DependencyInjections
    {
        public static IServiceCollection AddInfrastructureDI(this IServiceCollection services)
        {
            services.AddDbContext<AppDbContext>((serviceprovider , options) => options.
                UseSqlServer(serviceprovider.GetRequiredService<OptionsMonitor<ConnectionStringOption>>().CurrentValue.DefaultConnection));
            return services;
        }
    }
}
