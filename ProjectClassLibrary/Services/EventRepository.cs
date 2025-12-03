using ProjectClassLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectClassLibrary.Services
{
    public class EventRepository : IEventRepository
    {
        private List<IEvent> _events;

        public void AddEvent(IEvent e)
        {
            _events.Add(e);
        }

        public List<IEvent> GetAllEvents()
        {
            return _events;
        }

        public override string ToString()
        {
            return "";
        }
    }
}
