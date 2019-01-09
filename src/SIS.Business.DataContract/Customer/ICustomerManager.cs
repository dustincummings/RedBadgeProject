using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RedStarter.Business.DataContract.Customer
{
    public interface ICustomerManager
    {
        Task<bool> CreateCustomer(CustomerCreateDTO dto);
        Task<IEnumerable<CustomerListDTO>> GetCustomerList();
        Task<CustomerListDTO> GetCustomerById(int id);
    }
}
