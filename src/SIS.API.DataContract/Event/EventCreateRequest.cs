using System;
using System.Collections.Generic;
using System.Text;

namespace RedStarter.API.DataContract.Event
{
    public class EventCreateRequest
    {
        public string Location { get; set; }
        public int NumberOfPeople { get; set; }
        public string AdditionalNotes { get; set; }
        public string Food { get; set; }
        

        public DateTimeOffset DateCreated { get; set; }
    }
}
