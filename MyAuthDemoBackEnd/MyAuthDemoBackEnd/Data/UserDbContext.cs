using Microsoft.EntityFrameworkCore;
using MyAuthDemoBackEnd.Models;

namespace MyAuthDemoBackEnd.Data
{
    public class UserDbContext :DbContext
    {
        public UserDbContext(DbContextOptions<UserDbContext> options) : base(options) { }
        public DbSet<User> Users { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(new User
            { 
                UserName = "admin",
                Password = "1234",
            });
        }
    }
}
