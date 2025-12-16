using ProjectClassLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//-- Lavet af Frederik --//

namespace ProjectClassLibrary.Models
{
    /// <summary>
    /// /// <summary>
    /// Generic Class for Constructing Booking Objects using the interface
    /// </summary>
    /// </summary>
    public class Booking : IBooking
    {
        #region Instance Fields
        private static int _counter;
        private bool _isActive;
        #endregion
        #region Properties
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsActive
        {
            get
            {
                return StartDate <= DateTime.Now && DateTime.Now <= EndDate;
            }
        }
        public bool SailCompleted { get; set; }
        public string Destination { get; set; }
        public IMember TheMember { get; set; }
        public IBoat TheBoat { get; set; }
        #endregion
        #region Constructor
        public Booking(DateTime startDate, DateTime endDate, string destination,IMember member,IBoat boat)
        {
            StartDate = startDate;
            EndDate = endDate;
            Destination = destination;
            Id = _counter++;
            TheMember = member;
            TheBoat = boat;
            boat.BookedNrOfTimes++;
        }
        #endregion
        #region Methods
        public override string ToString()
        {
            return $"Id: {Id} " +
                $"\nStart Dato: {StartDate} " +
                $"\nSlut Dato: {EndDate} " +
                $"\nDestination: {Destination} " +
                $"\nBåden med sejlnummeret: {TheBoat.SailNumber}" +
                $"\nBooket af: {TheMember.FirstName}" +
                $"\nBåden er kommet i havn: {SailCompleted}";
        }
        #endregion
    }
}
