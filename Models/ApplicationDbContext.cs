using Microsoft.EntityFrameworkCore;

namespace ParkyAPI.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<NationalPark> NationalParks { get; set;}
    }
}
