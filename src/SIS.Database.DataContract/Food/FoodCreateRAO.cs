using System;
using System.Collections.Generic;
using System.Text;

namespace RedStarter.Database.DataContract.Food
{
    

    public class FoodCreateRAO
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Ingredient { get; set; }
        public string Allergen { get; set; }
        public int OwnerID { get; set; }
    }
}
