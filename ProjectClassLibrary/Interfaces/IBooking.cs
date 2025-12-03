using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectClassLibrary.Interfaces
{
    public interface IBooking
    {
        DateTime StartDate { get; set; }
        DateTime EndDate { get; set; }
        bool IsBooked { get; set; }
        string Destination { get; set; }
    }
}
