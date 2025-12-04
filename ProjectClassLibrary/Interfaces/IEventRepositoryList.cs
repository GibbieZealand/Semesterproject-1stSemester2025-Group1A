using ProjectClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectClassLibrary.Interfaces
{
    public interface IEventRepositoryList
    {
        List<IEvent> GetAllEvents(); //Vi har skrevet IEvent i vores Klassediagram?
        void AddEvent(IEvent theEvent);

        void RemoveEvent(IEvent theEvent);

        void PrintAll();


    }
}
