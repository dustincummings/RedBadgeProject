using System;
using System.Collections.Generic;
using System.Text;

namespace RedStarter.Database.Entities.Customer
{
    public class CustomerEntity
    {
        public int CustEntityID { get; set; }
        public string CustFirstName { get; set; }
        public string CustLastName { get; set; }
        public string CustEmail { get; set; }
        public string CustPhone { get; set; }
        public string CustAddress { get; set; }
        public string CustCityStZip { get; set; }
        public int CustID { get; set; }
    }
}
