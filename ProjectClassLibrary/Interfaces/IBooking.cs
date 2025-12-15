using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectClassLibrary.Interfaces
{
    /// <summary>
    /// Interface for the Booking class
    /// </summary>
    public interface IBooking
    {
        int Id { get; set; }
        DateTime StartDate { get; set; }
        DateTime EndDate { get; set; }
        //bool IsBooked { get; set; }
        bool IsActive { get; }
        string Destination { get; set; }
        IBoat TheBoat { get; set; }
        IMember TheMember { get; set; }
        bool SailCompleted { get; set; }
    }
}
