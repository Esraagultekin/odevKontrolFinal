using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Internet_1.Models;

namespace Internet_1.Models
{
    public class AppDbContext : IdentityDbContext<AppUser, AppRole, string>
    {
        public DbSet<Category> Categories { get; set; }
     

        public DbSet<Homework> Homeworks { get; set; }
      //  public DbSet<Student> Students { get; set; }
        public DbSet<Tosubmit> Tosubmits { get; set; }

        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();
            base.OnModelCreating(modelBuilder);
        }
    }
}
