using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Models;

namespace UI.Models
{
    public class FoodSpecialViewModels
    {
        public IEnumerable<Special> Special5 { get; set; }
        public IEnumerable<Food> GetFoodBySId { get; set; }
    }
}