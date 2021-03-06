﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RedStarter.Database.DataContract.Event
{
  public class EventGetListItemsRAO
    {
        
        public int EventEntityID { get; set; }
        public string Location { get; set; }
        public int NumberOfPeople { get; set; }
        public string AdditionalNotes { get; set; }
        public int FoodID { get; set; }
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [Display(Name = "Date of Event")]
        public DateTime? DateOfEvent { get; set; }
        public int OwnerID { get; set; }
        public int CustID { get; set; }
    }
}
