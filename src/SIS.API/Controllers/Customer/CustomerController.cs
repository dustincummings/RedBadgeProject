using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RedStarter.API.DataContract.Customer;
using RedStarter.Business.DataContract.Customer;
using RedStarter.Database.Contexts;

namespace RedStarter.API.Controllers.Customer
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : Controller
    {
        private readonly IMapper _mapper;
        private readonly ICustomerManager _manager;

        public CustomerController(IMapper mapper, ICustomerManager manager)
        {
            _mapper = mapper;
            _manager = manager;
        }

        [HttpPost]
        public async Task<IActionResult> PostCustomer(CustomerCreateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return StatusCode(400);
            }

            var identityClaimNum = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value);

            var dto = _mapper.Map<CustomerCreateDTO>(request);
            dto.OwnerID = identityClaimNum;

            if (await _manager.CreateCustomer(dto))
                return StatusCode(201);

            throw new Exception();
            //return Ok();
        }

        // GET /api/Customer
       

    }
}