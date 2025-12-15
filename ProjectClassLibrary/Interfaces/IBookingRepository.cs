using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectClassLibrary.Interfaces
{
    /// <summary>
    /// Interface for the BookingRepository class
    /// </summary>
    public interface IBookingRepository
    {
        void AddBooking(IBooking b);
        void RemoveBooking(IBooking b);
        List<IBooking> GetAllBookings();
        void UpdateBooking(int id, IBooking newBooking);
        void PrintAll();
        //void BookBoat(IBoat boat, IMember member, DateTime startDate, DateTime endDate, string destination);
        void BookBoat(IBooking booking);
        int GetBookingCountForMember(IMember member);
        Dictionary<string, int> GetAllBookingsForMembers();
        //List<int> GetAllBookingsForMembers();
    }
}
