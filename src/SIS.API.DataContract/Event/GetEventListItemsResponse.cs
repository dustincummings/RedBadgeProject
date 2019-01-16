using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RedStarter.API.DataContract.Event
{
    public class GetEventListItemsResponse
    {
        public int OwnerID { get; set; }
        public int EventEntityID { get; set; }
        public string Location { get; set; }
        public int NumberOfPeople { get; set; }
        public string AdditionalNotes { get; set; }
        public int FoodID { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [Display(Name = "Date of Event")]
        public DateTime? DateOfEvent { get; set; }
        public int CustID { get; set; }
    }
}
