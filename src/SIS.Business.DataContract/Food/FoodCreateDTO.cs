using System;
using System.Collections.Generic;
using System.Text;

namespace RedStarter.Business.DataContract.Food
{
    public enum AllergenType { Egg = 1, Fish, Shellfish, CowMilk, TreeNuts, Peanuts, Wheat, Soy }

    public class FoodCreateDTO
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Ingredient { get; set; }
        public AllergenType Allergen { get; set; }
        public int OwnerID { get; set; }
    }
}
