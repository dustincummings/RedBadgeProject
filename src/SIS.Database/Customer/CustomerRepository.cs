using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using RedStarter.Database.Contexts;
using RedStarter.Database.DataContract.Customer;
using RedStarter.Database.Entities.Customer;

namespace RedStarter.Database.Customer
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly SISContext _context;
        private readonly IMapper _mapper;

        public CustomerRepository(SISContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<bool> CreateCustomer(CustomerCreateRAO rao)
        {
            var entity = _mapper.Map<CustomerEntity>(rao);

            _context.CustomerTableAccess.AddAsync(entity);

            return await _context.SaveChangesAsync() == 1;

            throw new NotImplementedException();
        }

        public async Task<IEnumerable<CustomerListRAO>> GetCustomerList()
        {
            var query = await _context.CustomerTableAccess.ToArrayAsync();     //SingleAsync e=> CustID == id
            var rao = _mapper.Map<IEnumerable<CustomerListRAO>>(query);

            return rao;
        }
    }
}
