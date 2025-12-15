using ProjectClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//-- Lavet af Maria --//

namespace ProjectClassLibrary.Interfaces
{
    /// <summary>
    /// Interface for the EventRepository class
    /// </summary>
    public interface IEventRepository
    {
        List<IEvent> GetAllEvents();
        void AddEvent(IEvent theEvent);
        void UpdateEvent(int Id, IEvent upDatedEvent);
        void RemoveEvent(IEvent theEvent);
        void PrintAll();
    }
}
