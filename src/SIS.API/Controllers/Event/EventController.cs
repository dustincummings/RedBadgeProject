using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RedStarter.API.DataContract.Event;

namespace RedStarter.API.Controllers.Event
{
    [AllowAnonymous]
    [Route("api/[controller]")]
    [ApiController]
    public class EventController : Controller
    {
        private readonly IMapper _mapper;

        public EventController(IMapper mapper)
        {
            _mapper = mapper;
        }

      [HttpPost]
      public async Task<IActionResult> PostEvent(EventCreateRequest request)
        {
            return Ok();
        }

    }
}