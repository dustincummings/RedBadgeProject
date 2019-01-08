using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RedStarter.Database.Entities.Customer
{
    public class CustomerEntity
    {
        [Key]
        public int CustID { get; set; }
        [Required]
        public string CustFirstName { get; set; }
        [Required]
        public string CustLastName { get; set; }
        [Required]
        public string CustEmail { get; set; }
        [Required]
        public string CustPhone { get; set; }
        [Required]
        public string CustAddress { get; set; }
        [Required]
        public string CustCityStZip { get; set; }
        [Required]
        public int OwnerID { get; set; }
    }
}
