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
    }
}
