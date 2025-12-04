using ProjectClassLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectClassLibrary.Models
{
    public class Event : IEvent
    {
        public int Id { get; set; }
        private static int _counter = 0;
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public Event(string name, string description, DateTime startDate, DateTime endDate)
        {
            Id = _counter++;
            Name = name;
            Description = description;
            StartDate = startDate;
            EndDate = endDate;
        }

        public override string ToString()
        {
            return $"Event ID: {Id}\nNavn: {Name}\nBeskrivelse: {Description}\nStarttidspunkt: {StartDate}\nSluttidspunkt: {EndDate}";
        }
    }
}
