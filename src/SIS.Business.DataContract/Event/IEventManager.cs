using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RedStarter.Business.DataContract.Event
{
   public interface IEventManager
    {
        Task<bool> CreateEvent(EventCreateDTO dto);
        Task<IEnumerable<EventGetListItemsDTO>> GetEvents(int identityClaimNum);
        Task<EventGetListItemsDTO> GetEventById(int id);
        Task<bool> EditEvent(EventUpdateDTO dto);
        Task<bool> DeleteEvent(int id);
    }
}
