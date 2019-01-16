using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RedStarter.Database.Entities.Food
{

    public class FoodEntity
    {
        [Key]
        public int FoodID { get; set; }
        [Required]
        public int OwnerID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Ingredient { get; set; }
        [Required]
        public string Allergen { get; set; }

    }
}
