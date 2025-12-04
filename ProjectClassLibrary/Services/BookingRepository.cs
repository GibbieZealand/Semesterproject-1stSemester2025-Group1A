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
        private List<IBooking> _bookings = [];

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

        public void PrintAll()
        {
            foreach(IBooking b in _bookings)
            {
                Console.WriteLine(b);
            }
        }
    }
}
