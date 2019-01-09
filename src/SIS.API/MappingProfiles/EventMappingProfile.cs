using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using RedStarter.API.DataContract.Event;
using RedStarter.Business.DataContract.Event;
using RedStarter.Database.DataContract.Event;
using RedStarter.Database.Entities.Event;

namespace RedStarter.API.MappingProfiles
{
    public class EventMappingProfile : Profile
    {
        public EventMappingProfile()
        {
            CreateMap<EventCreateRequest, EventCreateDTO>();
            CreateMap<EventCreateDTO, EventCreateRAO>();
            CreateMap<EventCreateRAO, EventEntity>();

            CreateMap<EventEntity, EventGetListItemsRAO>();
            CreateMap<EventGetListItemsRAO, EventGetListItemsDTO>();
            CreateMap<EventGetListItemsDTO, GetEventListItemsResponse>();
            
        }
    }
}
