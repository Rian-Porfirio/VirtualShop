using EShop.ProductAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace EShop.ProductAPI.Context;

public class AppDbContext : DbContext
{

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Category> Categories { get; set; }
    public DbSet<Product> Products { get; set; }

    //Fluent API

    protected override void OnModelCreating(ModelBuilder md)
    {
        md.Entity<Category>().HasKey(c => c.Id);

        md.Entity<Category>().Property(c => c.Name).HasMaxLength(255).IsRequired();

        md.Entity<Category>().HasMany(c => c.Products).WithOne(p => p.Category).OnDelete(DeleteBehavior.Cascade);


        md.Entity<Product>().Property(p => p.Name).HasMaxLength(255).IsRequired();

        md.Entity<Product>().Property(p => p.Description).HasMaxLength(255).IsRequired();

        md.Entity<Product>().Property(p => p.ImageUrl).HasMaxLength(255).IsRequired();

        md.Entity<Product>().Property(p => p.Price).HasPrecision(6,3).IsRequired();

        md.Entity<Category>().HasData(
            new Category
            {
                Id = 1,
                Name = "Material Escolar",
            },
            new Category
            {
                Id = 2,
                Name = "Acessórios",
            }
        );
    }
}
