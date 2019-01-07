using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RedStarter.Database.DataContract.Event
{
    public interface IEventRepository
    {
        Task<bool> CreateEvent(EventCreateRAO rao);
    }
}
