using System;
using System.Linq;
using System.Collections.Generic;
using OdeToFood.Core;
namespace OdeToFood.Data
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll();
    }

    public class InMemoryRestaurantData : IRestaurantData
    {
        List<Restaurant> restaurants;
        public InMemoryRestaurantData()
        {
            restaurants = new List<Restaurant>()
            {
                new Restaurant{ Id = 1, Name= "Scott's Pizza", Location= "Maryland", Cuisine=CuisineType.Italian},
                new Restaurant{ Id = 2, Name= "Cinamon Club", Location= "London", Cuisine=CuisineType.None},
                new Restaurant{ Id = 3, Name= "La costa", Location= "California", Cuisine=CuisineType.Mexican}
            };
        }
        IEnumerable<Restaurant> IRestaurantData.GetAll()
        {
            return from r in restaurants
                   orderby r.Name
                   select r;
        }
    }
}
