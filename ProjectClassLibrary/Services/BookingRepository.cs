using ProjectClassLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectClassLibrary.Services
{
    public class BookingRepository : IBookingRepository
    {
        private List<IBooking> _bookings;

        public void AddBooking(IBooking b)
        {
            _bookings.Add(b);
        }

        public override string ToString()
        {
            return "";
        }
    }
}
