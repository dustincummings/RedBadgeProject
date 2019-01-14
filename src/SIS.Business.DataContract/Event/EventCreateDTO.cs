using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RedStarter.Business.DataContract.Event
{
    public class EventCreateDTO
    {
        public string Location { get; set; }
        public int NumberOfPeople { get; set; }
        public string AdditionalNotes { get; set; }
        public int FoodID { get; set; }
        public DateTime? DateOfEvent { get; set; }
        public int CustID { get; set; }
        public DateTimeOffset DateCreated { get; set; }
        public int OwnerID { get; set; }
    }
}