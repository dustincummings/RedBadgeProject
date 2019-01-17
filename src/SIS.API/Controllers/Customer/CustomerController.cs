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
        [HttpGet]
        //[Authorize(Roles = "User")]
        public async Task<IActionResult> GetCustomerList()
        {
            if (!ModelState.IsValid)
            {
                return StatusCode(400);
            }

            var identityClaimNum = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value);

            var dto = await _manager.GetCustomerList(identityClaimNum);
            var response = _mapper.Map<IEnumerable<CustomerListResponse>>(dto);

            return Ok(response);
        }

        // GET /api/Customer/id
        [HttpGet("{id}")]
        //[Authorize(Roles ="User")]

        public async Task<IActionResult> GetCustomerById(int id)
        {
            if (!ModelState.IsValid)
            {
                return StatusCode(400);
            }

            //var identityClaimNum = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value);

            var dto = await _manager.GetCustomerById(id);
            var response = _mapper.Map<CustomerListResponse>(dto);
            return Ok(response);
        }

        // PUT /api/Customer/id
        [HttpPut]

        public async Task<IActionResult> EditCustomer(CustomerEditRequest request)
        {
            if (!ModelState.IsValid)
            {
                return StatusCode(400);
            }

            //var identityClaimNum = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value);

            var dto = _mapper.Map<CustomerEditDTO>(request);

            if (await _manager.EditCustomer(dto))
                return StatusCode(201);

            throw new Exception();
        }

        // DELETE /api/Customer/id
        [HttpDelete("{id}")]

        public async Task<IActionResult> DeleteCustomer(int id)
        {
            if (!ModelState.IsValid)
            {
                return StatusCode(400);
            }

            if (await _manager.DeleteCustomer(id))
                return StatusCode(200);

            throw new Exception();
        }

    }
}