using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectClassLibrary.Interfaces
{
    public interface IEventRepository
    {
        void AddEvent(IEvent e);
        List<IEvent> GetAllEvents();
    }
}
