using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using RedStarter.Business.DataContract.Customer;
using RedStarter.Database.DataContract.Customer;

namespace RedStarter.Business.Managers.Customer
{
    public class CustomerManager : ICustomerManager
    {
        private readonly IMapper _mapper;
        private readonly ICustomerRepository _repository;

        public CustomerManager(IMapper mapper, ICustomerRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public async Task<bool> CreateCustomer(CustomerCreateDTO dto)
        {
            var rao = _mapper.Map<CustomerCreateRAO>(dto);

            if (await _repository.CreateCustomer(rao))
                return true;

            throw new NotImplementedException();
        }

        public async Task<IEnumerable<CustomerListDTO>> GetCustomerList()
        {
            var rao = await _repository.GetCustomerList();
            var dto = _mapper.Map<IEnumerable<CustomerListDTO>>(rao);

            return dto;
        }

        public async Task<CustomerListDTO> GetCustomerById(int id)
        {
                var rao = await _repository.GetCustomerById(id);
                var dto = _mapper.Map<CustomerListDTO>(rao);

                return dto;
        }

        public async Task<bool> EditCustomer(CustomerEditDTO dto)
        {
            var rao = _mapper.Map<CustomerEditRAO>(dto);

            if (await _repository.EditCustomer(rao))
                return true;

            throw new NotImplementedException();
        }

        public async Task<bool> DeleteCustomer(int id)
        {
            if (await _repository.DeleteCustomer(id))
                return true;

            return false;
        }
    }
}
