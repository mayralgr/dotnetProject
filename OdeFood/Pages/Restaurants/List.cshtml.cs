using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using OdeToFood.Core;
using OdeToFood.Data;

namespace OdeFood.Pages.Restaurants
{
    public class ListModel : PageModel
    {
        private readonly IConfiguration config;
        private readonly IRestaurantData restaurantData;
        
        // properties access by the view
        public string Message { get; set; }
        public IEnumerable<Restaurant> restaurants { get; set; }

        public void OnGet()
        {
            Message = config["Message"];
            restaurants = restaurantData.GetAll();

        }

        public ListModel(IConfiguration config, IRestaurantData restaurantData)
        {
            this.config = config;
            this.restaurantData = restaurantData;
        }
    }
}
