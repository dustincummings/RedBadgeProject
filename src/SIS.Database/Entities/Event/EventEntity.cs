using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RedStarter.Database.Entities.Event
{
   public class EventEntity
    {
        [Key]
        public int EventEntityId { get; set; }

        [Required]
        public string Location { get; set; }

        public int NumberOfPeople { get; set; }

        public string AdditionalNotes { get; set; }

        [Required]
        public DateTimeOffset DateCreated { get; set; }
    }
}
