using ProjectClassLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectClassLibrary.Models
{
    /// <summary>
    /// Class for creating new event objects
    /// </summary>
    public class Event : IEvent
    {
        #region instance fields

        private static int _counter = 0;

        #endregion

        #region properties
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        #endregion

        #region constructor

        public Event(string name, string description, DateTime startDate, DateTime endDate)
        {
            Id = _counter++;
            Name = name;
            Description = description;
            StartDate = startDate;
            EndDate = endDate;
        }

        #endregion

        #region methods
        public override string ToString()
        {
            return $"Event ID: {Id}\nNavn: {Name}\nBeskrivelse: {Description}\nStarttidspunkt: {StartDate}\nSluttidspunkt: {EndDate}";
        }
        #endregion
    }
}
