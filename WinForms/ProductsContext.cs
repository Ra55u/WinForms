using Microsoft.EntityFrameworkCore;

namespace WinForms;

public class ProductsContext : DbContext
{
    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlite("Data Source=products.db");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>().HasData(
            new Category { CategoryId = 1, Name = "Drinks" },
            new Category { CategoryId = 2, Name = "Vegetables" },
            new Category { CategoryId = 3, Name = "Fruits" },
            new Category { CategoryId = 4, Name = "Seafood" });

        modelBuilder.Entity<Product>().HasData(
            new Product { ProductId = 1, CategoryId = 1, Name = "Apple Juice" },
            new Product { ProductId = 2, CategoryId = 1, Name = "Sprite" },
            new Product { ProductId = 3, CategoryId = 1, Name = "Water" },
            new Product { ProductId = 4, CategoryId = 1, Name = "Redbull" },
            new Product { ProductId = 5, CategoryId = 1, Name = "Tea" },
            new Product { ProductId = 6, CategoryId = 1, Name = "Beer" },
            new Product { ProductId = 7, CategoryId = 1, Name = "Pineapple Juice" },
            new Product { ProductId = 8, CategoryId = 1, Name = "Coffee" },
            new Product { ProductId = 9, CategoryId = 2, Name = "Tomato" },
            new Product { ProductId = 10, CategoryId = 2, Name = "Cucumber" },
            new Product { ProductId = 11, CategoryId = 2, Name = "Carrot" },
            new Product { ProductId = 12, CategoryId = 2, Name = "Potato" },
            new Product { ProductId = 13, CategoryId = 2, Name = "Onion" },
            new Product { ProductId = 14, CategoryId = 2, Name = "Cauliflower" },
            new Product { ProductId = 15, CategoryId = 2, Name = "Eggplant" },
            new Product { ProductId = 16, CategoryId = 2, Name = "Asparagus" },
            new Product { ProductId = 17, CategoryId = 3, Name = "Apple" },
            new Product { ProductId = 18, CategoryId = 3, Name = "Strawberry" },
            new Product { ProductId = 19, CategoryId = 3, Name = "Banana" },
            new Product { ProductId = 20, CategoryId = 3, Name = "Blueberry" },
            new Product { ProductId = 21, CategoryId = 3, Name = "Pineapple" },
            new Product { ProductId = 22, CategoryId = 3, Name = "Mango" },
            new Product { ProductId = 23, CategoryId = 4, Name = "Salmon" },
            new Product { ProductId = 24, CategoryId = 4, Name = "Shrimp" },
            new Product { ProductId = 25, CategoryId = 4, Name = "Tuna" },
            new Product { ProductId = 26, CategoryId = 4, Name = "Crab" },
            new Product { ProductId = 27, CategoryId = 4, Name = "Lobster" },
            new Product { ProductId = 28, CategoryId = 4, Name = "Oyster" },
            new Product { ProductId = 29, CategoryId = 4, Name = "Scallop" });
    }
}
