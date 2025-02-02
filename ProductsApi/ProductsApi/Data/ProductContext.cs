﻿using Microsoft.EntityFrameworkCore;
using ProductsApi.Models;
namespace ProductsApi.Data
{
    public class ProductContext : DbContext

    {

        public ProductContext(DbContextOptions<ProductContext> options) : base(options)

        {

        }

        public DbSet<Product> Products { get; set; }

        public DbSet<Category> Categories { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 1,
                Name = "gayteoyn",
                Description = "akhoialh",
                Price = 1234,
            },
            new Product
            {
                Id = 2,
                Name = "alhkfa",
                Description = "akhoialh",
                Price = 128734,
            }
                );
        }
        //        protected override void OnModelCreating(ModelBuilder modelBuilder)
        //        {
        //            modelBuilder.Entity<Category>().HasData(new Category

        //            {

        //                Id = 1,

        //                Name = "Electronics",

        //                Description = "Electronic Items",


        //            },

        //new Category

        //{

        //    Id = 2,

        //    Name = "Clothes",

        //    Description = "Dresses",

        //},

        //new Category

        //{

        //    Id = 3,

        //    Name = "Grocery",

        //    Description = "Grocery Items",

        //}

        //);

        //        }

    }
}
