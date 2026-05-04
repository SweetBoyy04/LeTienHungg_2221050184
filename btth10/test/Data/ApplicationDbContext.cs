using Microsoft.EntityFrameworkCore;
using test.Models;
public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
 
    public DbSet<Person> People { get; set; } = default!;
    public DbSet<Product> Products { get; set; } = default!;
  
}