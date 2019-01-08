using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RedStarter.Business.DataContract.Event
{
   public interface IEventManager
    {
        Task<bool> CreateEvent(EventCreateDTO dto);
    }
}
