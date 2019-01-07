using System;
using System.Collections.Generic;
using System.Text;

namespace RedStarter.Database.DataContract.Customer
{
    public class CustomerCreateRAO
    {
        public string CustFirstName { get; set; }
        public string CustLastName { get; set; }
        public string CustEmail { get; set; }
        public string CustPhone { get; set; }
        public string CustAddress { get; set; }
        public string CustCityStZip { get; set; }
    }
}
