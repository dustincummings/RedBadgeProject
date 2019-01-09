using System;
using System.Collections.Generic;
using System.Text;

namespace RedStarter.Database.DataContract.Food
{
    public class FoodUpdateRAO
    {
        public int FoodID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Ingredient { get; set; }
        public AllergenType Allergen { get; set; }

    }
}
