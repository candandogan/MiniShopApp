using Microsoft.EntityFrameworkCore;
using MiniShopApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShopApp.Data
{
    public class miniShopDbContext : DbContext
    {
        public DbSet<Product> Product { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Brand> Brands { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                .HasMany(category => category.Product)
                .WithOne(product => product.Category)
                .HasForeignKey(product => product.CategoryId);

            //modelBuilder.Entity<Product>()
            //    .HasOne(product => product.Category)
            //    .WithMany(category => category.Product)
            //    .HasForeignKey(product => product.CategoryId);

            modelBuilder.Entity<Brand>()
                .HasMany(brand => brand.Product)
                .WithOne(product => product.Brands)
                .HasForeignKey(product => product.BrandsId);

            //modelBuilder.Entity<Product>()
            //    .HasOne(product => product.Brands)
            //    .WithMany(brand => brand.Product)
            //    .HasForeignKey(product => product.BrandsId);


            base.OnModelCreating(modelBuilder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=(localdb)\\Mssqllocaldb;Database=MiniShopAppDb;Integrated Security=true");
            }
        }
    }

}
