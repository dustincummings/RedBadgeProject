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
      //[Authorize(Roles ="Admin, User")]
      public async Task<IActionResult> PostEvent(EventCreateRequest request)
        {

            if (!ModelState.IsValid)
            {
                return StatusCode(400);
            }


            var identityClaimNum = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value);


            var dto = _mapper.Map<EventCreateDTO>(request);
            dto.OwnerID = identityClaimNum;

            if(await _manager.CreateEvent(dto))
                return StatusCode(201);

            throw new Exception();
        }
        [HttpGet]
        //[Authorize(Roles = "User")/*]*/
        public async Task<IActionResult> GetEvents()
        {
            if (!ModelState.IsValid) //want this to check 
            {
                return StatusCode(400);
            }

            var identityClaimNum = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value);

            var dto = await _manager.GetEvents(identityClaimNum);
            var response = _mapper.Map<IEnumerable<GetEventListItemsResponse>>(dto);

            return Ok(response); //TODO : Handle exceptions

        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetEventById(int id)
        {
             if (!ModelState.IsValid) //want this to check 
                {
                    return StatusCode(400);
                }

            var identityClaimNum = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value);

            var dto = await _manager.GetEventById(id);
            var response = _mapper.Map<GetEventListItemsResponse>(dto);

            return Ok(response); //TODO : Handle exception
        }
        [HttpPut]
        public async Task<IActionResult> EditEvent(PatchEventListItemRequest request)
        {
            if (!ModelState.IsValid)
            {
                return StatusCode(400);
            }
            var dto = _mapper.Map<EventUpdateDTO>(request);
            if (await _manager.EditEvent(dto))
                return StatusCode(201);
            return Ok();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEvent(int id)
        {
            if (await _manager.DeleteEvent(id))
                return StatusCode(201);
            throw new Exception();

        }





    }
}