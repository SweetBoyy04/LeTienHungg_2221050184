using Microsoft.EntityFrameworkCore;

namespace DemoMvc.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // Ví dụ DbSet
        // public DbSet<User> Users { get; set; }
        // public DbSet<Product> Products { get; set; }
        public DbSet<Models.Entities.Student> Students { get; set; } //      tạo bảng Students trong database
        public DbSet<Models.Entities.Produce> Produces { get; set; } //      tạo bảng Produces trong database
    }
}