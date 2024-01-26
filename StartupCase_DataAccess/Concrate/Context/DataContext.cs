using Microsoft.EntityFrameworkCore;
using StartupCase_Entities.Entities;
using System.Diagnostics;

namespace StartupCase_DataAccess.Concrate.Context
{
    public class DataContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-L558L50\LOCALSQL;Database=StartupCentrumDb;Trusted_Connection=True;TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Products>()
                .HasOne<Categories>(s => s.categories)
                .WithMany(g => g.Products)
                .HasForeignKey(s => s.CategoryId);

            modelBuilder.Entity<ProductFilterValues>()
               .HasOne<ProductFilter>(s => s.ProductFilter)
               .WithMany(g => g.ProductFilterValues)
               .HasForeignKey(s => s.ProductFilterId);

            modelBuilder.Entity<ProductFilterCategory>()
           .HasKey(ba => new { ba.ProductFilterId, ba.CategoryId });

            modelBuilder.Entity<Categories>()
           .HasMany(a => a.ProductFilterCategories)
           .WithOne(ba => ba.Categories)
           .HasForeignKey(ba => ba.CategoryId);

            modelBuilder.Entity<ProductFilter>()
      .HasMany(a => a.productFilterCategories)
      .WithOne(ba => ba.ProductFilter)
      .HasForeignKey(ba => ba.ProductFilterId);



        }

        public DbSet<Products> Products { get; set; }
        public DbSet<Categories> Categories { get; set; }
        public DbSet<ProductFilter> ProductFilters { get; set; }
        public DbSet<ProductFilterValues> productFilterValues { get; set; }
        public DbSet<ProductFilterCategory> ProductFilterCategories { get; set; }

    }
}
