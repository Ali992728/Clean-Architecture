using Microsoft.EntityFrameworkCore;
using MyAPI.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyAPI.Infrastructure.Persistency
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
