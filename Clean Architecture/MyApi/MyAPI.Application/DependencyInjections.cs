using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyAPI.Application
{
    public static class DependencyInjections
    {
        public static IServiceCollection AddApplicationDI(this IServiceCollection services)
        {
            return services;
        }
    }
}
