using System;
using System.Collections.Generic;
using System.Text;

namespace RedStarter.API.DataContract.Customer
{
    public class CustomerCreateRequest
    {
        public string CustFirstName { get; set; }
        public string CustLastName { get; set; }
        public string CustEmail { get; set; }
        public string CustPhone { get; set; }
        public string CustAddress { get; set; }
        public string CustCityStZip { get; set; }
    }
}
