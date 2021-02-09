using System.Collections.Generic;
using FoodProject.Core;
using System.Linq;

namespace FoodProject.Data
{
    public interface IRestaurantData 
    {
        public IEnumerable<Restaurant> GetAll();
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
        public IEnumerable<Restaurant> GetAll()
        {
            return from r in restaurants 
                    orderby r.Name
                    select r; 
        }
    }
}