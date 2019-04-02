using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace my_pizza.Models
{
    public class CatalogContext : DbContext
    {
        public CatalogContext(DbContextOptions<CatalogContext> options)
            : base(options)
        { }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=my_pizza.db");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Category>().HasData(new Category
            {
                Id = 1,
                Name = "Pizza"
            },
            new Category
            {
                Id = 2,
                Name = "Durum"
            });

            builder.Entity<Product>().HasData(new Product
            {
                Id = 1,
                Name = "Vesuvio",
                Description = "Tomat, ost og skinke",
                Price = 69,
                CategoryId = 1
            },
            new Product
            {
                Id = 2,
                Name = "Vegetariana",
                Description = "Tomat, ost, paprika, champignon, ananas, asparges og løg",
                Price = 74,
                CategoryId = 1
            },
            new Product
            {
                Id = 3,
                Name = "Hawaii",
                Description = "Tomat, ost, skinke og ananas",
                Price = 71,
                CategoryId = 1
            },
            new Product
            {
                Id = 4,
                Name = "Pepperoni",
                Description = "Tomat, ost og pepperoni",
                Price = 69,
                CategoryId = 1
            },
            new Product
            {
                Id = 5,
                Name = "Capricciosa",
                Description = "Tomat, ost, skinke og champignon",
                Price = 73,
                CategoryId = 1
            },
            new Product
            {
                Id = 6,
                Name = "Kylling Durum",
                Description = "Serveres med salat og dressing",
                Price = 59,
                CategoryId = 2
            },
            new Product
            {
                Id = 7,
                Name = "Kebab Durum",
                Description = "Serveres med salat og dressing",
                Price = 59,
                CategoryId = 2
            },
            new Product
            {
                Id = 8,
                Name = "Græsk Bøf Durum",
                Description = "Serveres med salat og dressing",
                Price = 59,
                CategoryId = 2
            },
            new Product
            {
                Id = 9,
                Name = "Falafel Durum",
                Description = "Serveres med salat og dressing",
                Price = 59,
                CategoryId = 2
            },
            new Product
            {
                Id = 10,
                Name = "Skinke Durum",
                Description = "Serveres med salat og dressing",
                Price = 59,
                CategoryId = 2
            });
        }
    }
}