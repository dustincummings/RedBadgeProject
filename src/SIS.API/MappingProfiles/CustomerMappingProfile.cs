using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using RedStarter.API.DataContract.Customer;
using RedStarter.Business.DataContract.Customer;
using RedStarter.Database.DataContract.Customer;
using RedStarter.Database.Entities.Customer;

namespace RedStarter.API.MappingProfiles
{
    public class CustomerMappingProfile : Profile
    {
        public CustomerMappingProfile()
        {
            CreateMap<CustomerCreateRequest, CustomerCreateDTO>();
            CreateMap<CustomerCreateDTO, CustomerCreateRAO>();
            CreateMap<CustomerCreateRAO, CustomerEntity>();
        }
    }
}
