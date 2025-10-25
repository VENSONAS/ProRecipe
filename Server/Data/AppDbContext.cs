using Microsoft.EntityFrameworkCore;
using Server.Models;

namespace Server.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Recipe> Recipes => Set<Recipe>();

        protected override void OnModelCreating(ModelBuilder b)
        {
            b.Entity<Recipe>()
             .HasMany(r => r.Ingredients)
             .WithOne()
             .HasForeignKey(i => i.RecipeId)
             .OnDelete(DeleteBehavior.Cascade);

            b.Entity<Ingredient>().Property(i => i.Weight).HasPrecision(10, 2);
            b.Entity<Recipe>().HasIndex(r => r.Name);
            b.Entity<Ingredient>().HasIndex(i => new { i.RecipeId, i.Name });
        }

    }
}