using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//-- Lavet af Frederik --//

namespace ProjectClassLibrary.Interfaces
{
    /// <summary>
    /// Interface for the BookingRepository class
    /// </summary>
    public interface IBookingRepository
    {
        void AddBooking(IBooking booking);
        void RemoveBooking(IBooking b);
        List<IBooking> GetAllBookings();
        void UpdateBooking(int id, IBooking newBooking);
        void PrintAll();
        int GetBookingCountForMember(IMember member);
        Dictionary<string, int> GetAllBookingsForMembers();
    }
}
