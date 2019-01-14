using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RedStarter.API.DataContract.Event
{
    public class EventCreateRequest
    {
        public string Location { get; set; }
        public int NumberOfPeople { get; set; }
        public string AdditionalNotes { get; set; }
        public int FoodID { get; set; }
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Date of Event")]
        public DateTime? DateOfEvent { get; set; }
        public int CustID { get; set; }


    }
}
