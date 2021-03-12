using FoodProject.Core;
using Microsoft.EntityFrameworkCore;

namespace FoodProject.Data
{
    public class FoodDbContext : DbContext
    {
        public FoodDbContext(DbContextOptions<FoodDbContext> options) 
            : base(options)
        {
            
        }
        public DbSet<Restaurant> Restaurants { get; set; }
    }
}