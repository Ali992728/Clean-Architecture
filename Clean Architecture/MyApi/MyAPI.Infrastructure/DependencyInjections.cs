using Microsoft.Extensions.DependencyInjection;
using MyAPI.Infrastructure.Persistency;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using MyAPI.Core.Options;
using Microsoft.Extensions.Options;
using MyAPI.Application.Interfaces;
using MyAPI.Infrastructure.Repositories;

namespace MyAPI.Infrastructure
{
    public static class DependencyInjections
    {
        public static IServiceCollection AddInfrastructureDI(this IServiceCollection services)
        {
            services.AddDbContext<AppDbContext>((serviceprovider, options) =>
                options.UseSqlServer(
                    serviceprovider
                        .GetRequiredService<IOptionsMonitor<ConnectionStringOption>>()
                        .CurrentValue
                        .DefaultConnection));


            services.AddScoped<IEmployeeRepository, EmployeeRepository>();

            return services;
        }
    }
}
