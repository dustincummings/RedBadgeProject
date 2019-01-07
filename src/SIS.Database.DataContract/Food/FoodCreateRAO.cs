﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RedStarter.Database.DataContract.Food
{
    public enum AllergenType { Egg = 1, Fish, Shellfish, CowMilk, TreeNuts, Peanuts, Wheat, Soy }

    public class FoodCreateRAO
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Ingredient { get; set; }
        public AllergenType Allergen { get; set; }

    }
}