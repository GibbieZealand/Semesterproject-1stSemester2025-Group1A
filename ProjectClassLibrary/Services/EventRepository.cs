using ProjectClassLibrary.Exceptions;
using ProjectClassLibrary.Interfaces;
using ProjectClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//---Lavet af Maria---//

namespace ProjectClassLibrary.Services
{
    public class EventRepository : IEventRepository
    {
        #region Instance field
        /// <summary>
        /// New instance field _events
        /// </summary>
        private List<IEvent> _events; //Vi laver et nyt instansfelt _events, som skal være en List af typen Event

        #endregion

        #region Constructor
        /// <summary>
        /// Constructor for making a new list of events
        /// </summary>
        public EventRepository() //Vi laver en konstruktor til at lave en ny liste af events, som kaldes _events
        {
            _events = new List<IEvent>();
        }

        #endregion

        #region Methods

        /// <summary>
        /// Method for adding new events
        /// </summary>
        public void AddEvent(IEvent theEvent)
        {
            for (int i = 0; i < _events.Count; i++) //Løber igennem listen fra index 0 og plusser 1 op, indtil den når slutningen/det maksimale antal objekter
            {
                if (_events[i].Id == theEvent.Id) //Hvis den allerede findes i systemet / hvis dens ID er det samme som det argument den får
                {
                    throw new EventIdExistsException($"Event med ID'et {theEvent.Id} findes allerede.");
                }
            }
            _events.Add(theEvent); //Hvis eventet IKKE findes, tilføjes den.
        }

        /// <summary>
        /// GetAll method for retrieving all events
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

        /// <summary>
        /// Method for updating events by replacing the current event with a new event
        /// </summary>
 
        public void UpdateEvent(int Id, IEvent upDatedEvent)
        {
            for (int i = 0; i < _events.Count; i++) //Vi løber vores liste igennem
            {
                if (_events[i].Id == Id) //Vi går ind og tjekker, om eventet er på listen ved at tjekke, om eventet er identisk. Hvis Id på en given index plads er lig med Id, fjernes eventet
                {
                    _events[i] = upDatedEvent; //UpDatedEvent ændres nu til det argument, vi indsætter ude i program.cs
                    return;
                }
            }
            Console.WriteLine("Fejl. Eventet findes ikke."); //Hvis eventet ikke findes gives en fejlmeddelelse - jeg laver en console.writeline for nemmere at kunne teste det ude i min program.cs
        }

        /// <summary>
        /// Method for removing events
        /// </summary>

        public void RemoveEvent(IEvent theEvent)
        {
            for (int i = 0; i < _events.Count; i++) //Vi løber vores liste igennem
            {
                if (_events[i].Id == theEvent.Id) //Vi går ind og tjekker, om eventet er på listen ved at tjekke, om eventet er identisk. Hvis eventets Id på en given index plads er lig med theEvent.Id, fjernes eventet, altså hvis de er identiske
                {
                    _events.Remove(_events[i]);
                    return;
                }
            }
            Console.WriteLine("Fejl. Eventet findes ikke."); //Hvis eventet ikke findes gives en fejlmeddelelse - jeg laver en console.writeline for nemmere at kunne teste det ude i min program.cs
        }

        /// <summary>
        /// Method for printing all events
        /// </summary>

        public void PrintAll()
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
