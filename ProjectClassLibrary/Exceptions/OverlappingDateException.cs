using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectClassLibrary.Exceptions
{
    /// <summary>
    /// Exception for if a booking date is overlapping with another
    /// </summary>
    public class OverlappingDateException : Exception 
    {
        public OverlappingDateException(string message) :base(message)
        {
            
        }
    }
}
