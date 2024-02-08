using BylkyWebRazor_Temp.Models;
using Microsoft.EntityFrameworkCore;

namespace BulkyWebRazor_Temp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
            new Category
            {
                CategoryId = 1,
                DisplayOrder = 1,
                Name = "Action"
            },
            new Category
            {
                CategoryId = 2,
                DisplayOrder = 2,
                Name = "SciFi"
            },
            new Category
            {
                CategoryId = 3,
                DisplayOrder = 3,
                Name = "History"
            }
            );
        }
    }
}
