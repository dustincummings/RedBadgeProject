using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using RedStarter.Business.DataContract.Event;
using RedStarter.Database.DataContract.Event;

namespace RedStarter.Business.Managers.Event
{
    public class EventManager : IEventManager
    {
        private readonly IMapper _mapper;
        private readonly IEventRepository _repository;

        public EventManager(IMapper mapper, IEventRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }



        public async Task<bool> CreateEvent(EventCreateDTO dto)
        {
            var rao = _mapper.Map<EventCreateRAO>(dto);

           if(await _repository.CreateEvent(rao))
            return true;

            throw new NotImplementedException();
        }
    }
}
