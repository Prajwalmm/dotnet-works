using Microsoft.EntityFrameworkCore;
using webApiOfOurHero.Models;

namespace webApiOfOurHero.Entity
{
    public class OurHeroDBContext : DbContext
    {
        public OurHeroDBContext(DbContextOptions<OurHeroDBContext> options) : base(options)
        {
        }
        public DbSet<OurHero> OurHeros { get; set; }

        /*
         OnModelCreating mainly used to configured our EF model
         And insert master data if required
        */
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Setting a primary key in OurHero model
            modelBuilder.Entity<OurHero>().HasKey(x => x.Id);

            // Inserting record in OurHero table
            modelBuilder.Entity<OurHero>().HasData(
                new OurHero
                {
                    Id = 1,
                    FirstName = "System",
                    LastName = "",
                    isActive = true,
                }
            );
        }
    }
}
