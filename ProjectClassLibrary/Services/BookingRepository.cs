using ProjectClassLibrary.Interfaces;
using ProjectClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectClassLibrary.Services
{
    public class BookingRepository : IBookingRepository
    {
        #region Fields
        private List<IBooking> _bookings;
        #endregion

        #region Constructors
        public BookingRepository()
        {
            _bookings = [];
        }
        #endregion

        #region Methods
        public void AddBooking(IBooking booking)
        {
            foreach (IBooking b in _bookings)
            {
                if (b.Id == booking.Id)
                { 
                    return;
                }
            }
            _bookings.Add(booking);
        }

        public void RemoveBooking(IBooking booking)
        {
            _bookings.Remove(booking);
        }

        public List<IBooking> GetAllBookings()
        {
            return _bookings;
        }

        public void UpdateBooking(int id, IBooking newBooking)
        {
            for (int i = 0; i < _bookings.Count; i++)
            {
                if (_bookings[i].Id == id)
                {
                    newBooking.Id = _bookings[i].Id;
                    _bookings[i] = newBooking;
                    return;
                }
            }
        }

        public void BookBoat(IBoat boat, IMember member, DateTime startDate, DateTime endDate)
        {
            if (boat == null || member == null)
            {
                return;
            }
            if (startDate >= endDate)
            {
                Console.WriteLine("Startdato skal være før slutdato.");
                return;
            }
            foreach (IBooking existingBooking in _bookings)
            {
                IBoat existingBoat = existingBooking.TheBoat;
                bool matchingSailNum = existingBoat.SailNumber == boat.SailNumber;
                if (matchingSailNum)
                {
                    bool overlaps = startDate < existingBooking.EndDate && existingBooking.StartDate < endDate;
                    if (overlaps)
                    {
                        Console.WriteLine("Booking dato er ugyldig");
                        return;
                    }
                }
            }
            IBooking booking = new Booking(startDate, endDate, isBooked: true, "", member, boat);
            AddBooking(booking);
            Console.WriteLine("Båden er hermed blevet booket");
        }

        public void PrintAll()
        {
            foreach (IBooking b in _bookings)
            {
                Console.WriteLine(b);
            }
        }

        #endregion
    }
}
