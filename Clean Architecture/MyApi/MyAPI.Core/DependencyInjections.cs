using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyAPI.Core
{
    public static class DependencyInjections
    {
        public static IServiceCollection AddCoreDI(this IServiceCollection services)
        {
            return services;
        }
    }
}
