﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RedStarter.API.DataContract.Food
{
    public class GetFoodListItemsResponse
    {
        public int OwnerID { get; set; }
        public int FoodID  { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Ingredient { get; set; }
        public string Allergen { get; set; }
    }
}
