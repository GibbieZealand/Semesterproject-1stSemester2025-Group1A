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
        #region Instance Fields
        //private IMember _member;
        //private IBoat _boat;
        private static int _counter;
        #endregion
        #region Properties
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsBooked { get; set; }
        public string Destination { get; set; }
        public IMember TheMember { get; set; }
        public IBoat TheBoat { get; set; }
        #endregion
        #region Constructor
        public Booking(DateTime startDate, DateTime endDate, bool isBooked, string destination,IMember member,IBoat boat)
        {
            StartDate = startDate;
            EndDate = endDate;
            IsBooked = isBooked;
            Destination = destination;
            Id = _counter++;
            TheMember = member;
            TheBoat = boat;
        }
        #endregion
        #region Methods
        public override string ToString()
        {
            return $"Id: {Id} " +
                $"\nStart Dato: {StartDate} \nSlut Dato: {EndDate} " +
                $"\nEr Booked: {IsBooked} " +
                $"\nDestination: {Destination} " +
                $"\n{TheMember} \n{TheBoat}";
        }
        #endregion
    }
}
