using System;
using System.Collections.Generic;
using System.Text;

namespace RedStarter.Business.DataContract.Food
{
    public class FoodGetListItemsDTO
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Ingredient { get; set; }
        public AllergenType Allergen { get; set; }
    }
}
