using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectClassLibrary.Exceptions
{

    /// <summary>
    /// Exception for when a boat is already booked
    /// </summary>
    public class BoatBookedException : Exception
    {
        public BoatBookedException(string message) :base(message)
        {
            
        }
    }
}
