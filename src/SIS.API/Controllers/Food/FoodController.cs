using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RedStarter.API.DataContract.Food;
using RedStarter.Business.DataContract.Food;

namespace RedStarter.API.Controllers.Food
{
    [ApiController]
    [Route("api/[controller]")]
    public class FoodController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IFoodManager _manager;

        public FoodController(IMapper mapper, IFoodManager manager)
        {
            _mapper = mapper;
            _manager = manager;
        }
       [HttpPost]
       public async Task<IActionResult> PostFood(FoodCreateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return StatusCode(400);
            }
            var identityClaimNum = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value);
            var dto = _mapper.Map<FoodCreateDTO>(request);
            dto.OwnerID = identityClaimNum;

            if( await _manager.CreateFood(dto))
                return StatusCode(201);


            throw new Exception();
        }

    }
}