using RedStarter.Database.Entities.Customer;
using RedStarter.Database.Entities.Food;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RedStarter.Database.Entities.Event
{
   public class EventEntity
    {
        [Key]
        public int EventEntityID { get; set; }
        [Required]
        public int OwnerID { get; set; }
        [Required]
        public string Location { get; set; }
        public int NumberOfPeople { get; set; }
        public string AdditionalNotes { get; set; }
        [Required]
        public int FoodID { get; set; }
        public int CustID { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [Display(Name = "Date of Event")]
        public DateTime DateOfEvent { get; set; }

        public virtual FoodEntity Food { get; set; }
        public virtual CustomerEntity Customer { get; set; }

    }
}
