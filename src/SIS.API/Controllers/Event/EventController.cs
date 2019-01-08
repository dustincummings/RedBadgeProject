using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RedStarter.API.DataContract.Event;
using RedStarter.Business.DataContract.Event;

namespace RedStarter.API.Controllers.Event
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class EventController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IEventManager _manager;

        public EventController(IMapper mapper, IEventManager manager)
        {
            _mapper = mapper;
            _manager = manager;
        }

      [HttpPost]
      [Authorize(Roles ="Admin, User")]
      public async Task<IActionResult> PostEvent(EventCreateRequest request)
        {

            if (!ModelState.IsValid)
            {
                return StatusCode(400);
            }


            var identityClaimNum = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value);


            var dto = _mapper.Map<EventCreateDTO>(request);
            dto.DateCreated = DateTime.Now;
            dto.OwnerId = identityClaimNum;

            if(await _manager.CreateEvent(dto))
                return StatusCode(201);

            throw new Exception();
        }

    }
}