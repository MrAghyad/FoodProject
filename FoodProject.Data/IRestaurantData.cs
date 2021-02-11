using System.Collections.Generic;
using System.Linq;
using FoodProject.Core;

namespace FoodProject.Data
{
    public interface IRestaurantData 
    {
        IEnumerable<Restaurant> GetRestaurantsByName(string name);
    }

    public class InMemoryRestaurantData : IRestaurantData
    {
        List<Restaurant> restaurants;

        public InMemoryRestaurantData()
        {
            restaurants = new List<Restaurant>()
            {
                new Restaurant{Id = 1, Name = "Pizza Hut", Location = "Jeddah", Cuisine = CuisineType.Italian},
                new Restaurant{Id = 2, Name = "Taco Bell", Location = "Jeddah", Cuisine = CuisineType.Mexican},
                new Restaurant{Id = 3, Name = "Tekka", Location = "Jeddah", Cuisine = CuisineType.Indian},
            };
        }
        public IEnumerable<Restaurant> GetRestaurantsByName(string name)
        {
            return from r in restaurants 
                    where string.IsNullOrEmpty(name) || r.Name.StartsWith(name)
                    orderby r.Name
                    select r; 
        }
    }
}