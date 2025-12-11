using ProjectClassLibrary.Exceptions;
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
            try
            {
                CheckMissingInput(boat, member);
                CheckIncorrectDateTime(startDate, endDate);
                if (CheckBookingOverlaps(boat, member, startDate, endDate))
                {
                    Console.WriteLine("Booking tiderne overlapper");
                    return;
                }
            }
            catch (NullReferenceException nRex)
            {
                Console.WriteLine(nRex.Message);
                return;
            }
            catch (InvalidDateException iDex)
            {
                Console.WriteLine(iDex.Message);
                return;
            }
            catch (InvalidBookingException iBex)
            {
                Console.WriteLine(iBex.Message);
                return;
            }
            IBooking booking = new Booking(startDate, endDate, isBooked: true, "", member, boat);
            AddBooking(booking);
            Console.WriteLine("Båden er hermed blevet booket");
        }

        public int GetBookingCountForMember(IMember member)
        {
            int count = 0;
            foreach (IBooking existingBooking in _bookings)
            {
                bool validMember = existingBooking.TheMember != null && existingBooking.TheMember.Id == member.Id;
                if (validMember)
                {
                    count++;
                }
            }
            return count;
        }

        //public List<int> GetAllBookingsForMembers()
        //{
        //    List<IMember> members = [];
        //    foreach (IBooking existingBooking in _bookings)
        //    {
        //        IMember member = existingBooking.TheMember;
        //        if (member != null)
        //        {
        //            members.Add(member);
        //        }
        //    }
        //    List<int> bookingCounts = [];
        //    foreach(IMember m in members)
        //    {
        //        bookingCounts.Add(GetBookingCountForMember(m));
        //    }
        //    return bookingCounts;
        //}

        public void PrintAll()
        {
            foreach (IBooking b in _bookings)
            {
                Console.WriteLine(b);
            }
        }
        void CheckIncorrectDateTime(DateTime startDate, DateTime endDate)
        {
            if (startDate >= endDate)
            {
                throw new InvalidDateException("Startdato skal være før slutdato.");
            }
        }
        bool CheckBookingOverlaps(IBoat boat, IMember member, DateTime startDate, DateTime endDate)
        {
            foreach (IBooking existingBooking in _bookings)
            {
                IBoat existingBoat = existingBooking.TheBoat;
                if(existingBoat == null)
                {
                    continue; // Skip null boats
                }
                bool matchingSailNum = existingBoat.SailNumber == boat.SailNumber;
                if (matchingSailNum)
                {
                    // TODO - Debug: funktion virker ikke ordenligt - tilføjer ikke til booking
                    //bool noOverlaps = (startDate < existingBooking.StartDate && endDate < existingBooking.StartDate) || 
                    //(startDate > existingBooking.EndDate && endDate > existingBooking.EndDate);
                    //bool overlaps = startDate <= existingBooking.EndDate && existingBooking.StartDate <= endDate;
                    bool startsBeforeExistingEnds = startDate < existingBooking.EndDate;
                    bool endsAfterExistingStarts = endDate > existingBooking.StartDate;
                    bool overlaps = startsBeforeExistingEnds && endsAfterExistingStarts;
                    //if (!overlaps)
                    if (overlaps)
                    {
                        // throw new InvalidBookingException("Båden er allerede blevet booket til given tid");
                        //Console.WriteLine("It didn't work, dummy");
                        return true; 
                    }
                }
            }
            return false;
        }
        void CheckMissingInput(IBoat boat, IMember member)
        {
            if (boat == null || member == null)
            {
                throw new NullReferenceException("Mangler input");
            }
        }

        public List<IBooking> GetAllActiveBookings()
        {
            List<IBooking> activeList = [];
            foreach (IBooking b in _bookings)
            {
                if (b.IsActive)
                {
                    activeList.Add(b);
                }
            }
            return activeList;
        }
        #endregion

    }
}
