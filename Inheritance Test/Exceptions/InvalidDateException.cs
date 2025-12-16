using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectClassLibrary.Exceptions
{
    /// <summary>
    /// Exception for if a date cannot exist
    /// </summary>
    public class InvalidDateException : Exception
    {
        public InvalidDateException(string message) : base(message)
        {
            
        }
    }
}
