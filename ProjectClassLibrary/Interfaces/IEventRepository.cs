using ProjectClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectClassLibrary.Interfaces
{
    public interface IEventRepository
    {
        List<IEvent> GetAllEvents();
        void AddEvent(IEvent theEvent);
        void RemoveEvent(IEvent theEvent);
        void PrintAll();
    }
}
