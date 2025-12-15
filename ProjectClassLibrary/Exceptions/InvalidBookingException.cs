using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectClassLibrary.Exceptions
{
    /// <summary>
    /// Exception for when a booking is invalid
    /// </summary>
    public class InvalidBookingException : Exception
    {
        public InvalidBookingException(string message) : base(message)
        {
            
        }
    }
}
