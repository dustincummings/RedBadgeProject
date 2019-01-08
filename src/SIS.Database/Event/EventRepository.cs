using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using RedStarter.Database.Contexts;
using RedStarter.Database.DataContract.Event;
using RedStarter.Database.Entities.Event;

namespace RedStarter.Database.Event
{
    public class EventRepository : IEventRepository
    {
        private readonly SISContext _context;
        private readonly IMapper _mapper;

        public EventRepository(SISContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;

        }




        public async Task<bool> CreateEvent(EventCreateRAO rao)
        {
            var entity = _mapper.Map<EventEntity>(rao);

            _context.EventTableAccess.AddAsync(entity);

            return await _context.SaveChangesAsync() == 1;

          
        }
    }
}
