using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectClassLibrary.Interfaces
{
    public interface IBookingRepository
    {
        void AddBooking(IBooking b);
        void RemoveBooking(IBooking b);
        List<IBooking> GetAllBookings();
        void UpdateBooking(int id, IBooking newBooking);
        void PrintAll();
        void BookBoat(IBoat boat, IMember member, DateTime startDate, DateTime endDate);
        int GetBookingCountForMember(IMember member);
    }
}
