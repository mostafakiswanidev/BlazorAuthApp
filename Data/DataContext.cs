using Microsoft.EntityFrameworkCore;

namespace BlazorAuthApp.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(new User { Id = 1, Username = "Sarah", Password = "sarah_muthana" });
        }
    }
}
