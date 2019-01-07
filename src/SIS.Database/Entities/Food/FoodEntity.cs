using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RedStarter.Database.Entities.Food
{
    public enum AllergenType { Egg = 1, Fish, Shellfish, CowMilk, TreeNuts, Peanuts, Wheat, Soy }

    public class FoodEntity
    {
        [Key]
        public int FoodID { get; set; }

        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Ingredient { get; set; }
        [Required]
        public AllergenType Allergen { get; set; }

    }
}
