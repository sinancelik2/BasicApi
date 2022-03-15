using System;
using App.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace App.Persistence.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product {Id = Guid.NewGuid(), Name = "Pen", Value = 5, Quantity = 100},
                new Product {Id = Guid.NewGuid(), Name = "Notebook", Value = 10, Quantity = 300},
                new Product {Id = Guid.NewGuid(), Name = "Paper", Value = 1, Quantity = 1000}
            );
            base.OnModelCreating(modelBuilder);
        }
    }
}