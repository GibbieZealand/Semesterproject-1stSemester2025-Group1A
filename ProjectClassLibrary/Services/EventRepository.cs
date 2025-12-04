using ProjectClassLibrary.Interfaces;
using ProjectClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectClassLibrary.Services
{
    public class EventRepository : IEventRepository
    {
        #region Instance field
        private List<IEvent> _events; //Vi laver et nyt instansfelt _orders, som skal være en List af typen Event

        #endregion

        #region Constructor
        public EventRepository() //Vi laver en konstruktor til at lave en ny liste af events, som kaldes _events
        {
            _events = new List<IEvent>();
        }

        #endregion

        #region Methods

        /// <summary>
        /// Method for adding new events. 
        /// </summary>
        public void AddEvent(IEvent theEvent)
        {
            for (int i = 0; i < _events.Count; i++) //Løber igennem listen fra index 0 og plusser 1 op, indtil den når slutningen/det maksimale antal objekter
            {
                if (_events[i].Id == theEvent.Id) //Hvis den allerede findes i systemet / hvis dens ID er det samme som det argument den får
                {
                    Console.WriteLine("Fejl. Ordren findes allerede."); //Den bliver ikke tilføjet, hvis den allerede findes, og der udskrives en fejl
                    return;
                    //Kan laves til en exception i stedet?
                }
            }
            _events.Add(theEvent); //Hvis ordren IKKE findes, tilføjes den.
        }

        /// <summary>
        /// GetAll met
        /// </summary>
        /// <returns></returns>

        public List<IEvent> GetAllEvents()
        {
            List<IEvent> returnEventList = new List<IEvent>();
            foreach (IEvent e in _events)
            {
                returnEventList.Add(e);
            }
            return returnEventList;

            //return _events;
        }

        public void RemoveEvent(IEvent theEvent)
        {
            for (int i = 0; i < _events.Count; i++) //Vi løber vores liste igennem
            {
                if (_events[i].Id == theEvent.Id) //Vi går ind og tjekker, om ordren er på listen ved at tjekke, om ordren er identisk. Hvis OrderID på en given index plads er lig med orderNumber, fjernes ordren, altså hvis de er identiske
                {
                    _events.Remove(_events[i]);
                    return;
                }
            }
            Console.WriteLine("Fejl. Ordren findes ikke."); //Hvis ordren ikke findes gives en fejlmeddelelse
        }

        public void PrintAll() //Jeg lavede en PrintAll metode for at teste, at min Add metode virkede (kan det testes uden en print all?)
        {
            foreach (IEvent e in _events)
            {
                Console.WriteLine(e);
                Console.WriteLine();
            }
        }
        #endregion
    }
}
