using Microsoft.EntityFrameworkCore;

namespace CompulsoryAssignment01;
public class ShoppingContext : DbContext
{
    public DbSet<Product> Products { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder options) =>
        options.UseSqlServer("Server=localhost;Database=master;User Id=sa;Password=Henning@Pressening;;Encrypt=True;TrustServerCertificate=True");
}
public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int CategoryId { get; set; }
    public Category Category { get; set; }
}

public class Category
{
    public int Id { get; set; }
    public string Name { get; set; }
}