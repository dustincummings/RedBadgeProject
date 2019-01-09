using System;
using System.Collections.Generic;
using System.Text;

namespace RedStarter.API.DataContract.Event
{
    public class GetEventListItemsResponse
    {
        public string Location { get; set; }
        public int NumberOfPeople { get; set; }
        public string AdditionalNotes { get; set; }
        public string Food { get; set; }

    }
}
