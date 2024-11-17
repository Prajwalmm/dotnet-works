using CouponAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CouponAPI.Data
{
    public class AppDbContext :DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Coupon> Cupons { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Coupon>().HasData(
            new Coupon { CouponId = 1, CouponCode = "10OFF", DiscountAmount = 10, MinAmount = 20 },
            new Coupon { MinAmount = 20, CouponId = 2, CouponCode = "10DJJ", DiscountAmount = 20 }
            );
           
        }
    }
}
