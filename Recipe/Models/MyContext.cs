using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Recipe.Models
{
    public class MyContext : IdentityDbContext<User>
    {
        public MyContext(DbContextOptions options) : base(options) { }
        public DbSet<User> Userz { get; set; }
        public DbSet<Recipes> Recipes { get; set; }
        public DbSet<RecipeIngredients> RecipeIngredients { get; set; }
        public DbSet<Save> Saves { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Follow> Followers { get; set; }
    }
}