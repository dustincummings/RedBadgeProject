using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RedStarter.API.DataContract.Food;
using RedStarter.Business.DataContract.Food;

namespace RedStarter.API.Controllers.Food
{
    [ApiController]
    [AllowAnonymous]
    [Route("api/[controller]")]
    public class FoodController : Controller
    {
        private readonly IMapper _mapper;

        public FoodController(IMapper mapper)
        {
            _mapper = mapper;
        }
       [HttpPost]
       public async Task<IActionResult> PostFood(FoodCreateRequest request)
        {
            var dto = _mapper.Map<FoodCreateDTO>(request);


            return Ok();
        }

    }
}