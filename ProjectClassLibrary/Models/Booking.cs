using ProjectClassLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectClassLibrary.Models
{
    public class Booking : IBooking
    {
        private static int _counter;

        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsBooked { get; set; }
        public string Destination { get; set; }

        public Booking(DateTime startDate, DateTime endDate, bool isBooked, string destination)
        {
            StartDate = startDate;
            EndDate = endDate;
            IsBooked = isBooked;
            Destination = destination;
            Id = _counter++;
        }

        public override string ToString()
        {
            return $"Id: {Id}, \nStartDate: {StartDate}, \nEndDate: {EndDate}, \nIsBooked: {IsBooked}, \nDestination: {Destination}";
        }
    }
}
