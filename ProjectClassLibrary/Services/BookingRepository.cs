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
            //TO-DO: Exceptions og try/catch skal flyttes til program.cs
            //Try/Catch Rykket til FrederikTest

            if ((boat == null || member == null))
            {
                throw new NullReferenceException("Mangler input");
            }

            if ((startDate >= endDate))
            {
                throw new InvalidDateException("Startdato skal være før slutdato.");
            }

            if (CheckBookingOverlaps(boat, startDate, endDate))
            {
                throw new OverlappingDateException("Bookingen overlapper med en anden.");
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

        public Dictionary<string, int> GetAllBookingsForMembers()
        {
            Dictionary<IMember, int> memberCounts = [];
            foreach (IBooking existingBooking in _bookings)
            {
                IMember member = existingBooking.TheMember;
                if (member != null)
                {
                    if (!memberCounts.ContainsKey(member))
                    {
                        memberCounts[member] = 0;
                    }
                    memberCounts[member]++;
                }
            }
            Dictionary<string, int> result = [];
            foreach (KeyValuePair<IMember, int> kvp in memberCounts)
            {
                result[kvp.Key.Name] = kvp.Value;
            }
            return result;
        }

        public void PrintAll()
        {
            foreach (IBooking b in _bookings)
            {
                Console.WriteLine(b);
            }
        }

        bool CheckBookingOverlaps(IBoat boat, DateTime startDate, DateTime endDate)
        {
            foreach (IBooking existingBooking in _bookings)
            {
                IBoat existingBoat = existingBooking.TheBoat;
                if (existingBoat == null)
                {
                    continue; //Skip null boats
                }
                bool matchingSailNum = existingBoat.SailNumber == boat.SailNumber;
                if (matchingSailNum)
                {
                    bool startsBeforeExistingEnds = startDate < existingBooking.EndDate;
                    bool endsAfterExistingStarts = endDate > existingBooking.StartDate;
                    bool overlaps = startsBeforeExistingEnds && endsAfterExistingStarts;
                    if (overlaps)
                    {
                        return true;
                    }
                }
            }
            return false;
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
