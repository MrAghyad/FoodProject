using FoodProject.Core;
using Microsoft.EntityFrameworkCore;

namespace FoodProject.Data
{
    public class FoodDbContext : DbContext
    {
        public DbSet<Restaurant> Restaurants { get; set; }
    }
}