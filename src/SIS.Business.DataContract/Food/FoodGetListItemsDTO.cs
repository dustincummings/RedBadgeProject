using System;
using System.Collections.Generic;
using System.Text;

namespace RedStarter.Business.DataContract.Food
{
    public class FoodGetListItemsDTO
    {
        public int FoodID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Ingredient { get; set; }
        public string Allergen { get; set; }
    }
}
