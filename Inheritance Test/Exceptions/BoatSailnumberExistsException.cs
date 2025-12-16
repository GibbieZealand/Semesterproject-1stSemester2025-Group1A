using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectClassLibrary.Exceptions
{
    /// <summary>
    /// Exception class for when a boat sail number already exists
    /// </summary>
    public class BoatSailnumberExistsException : Exception
    {
        public BoatSailnumberExistsException(string message) :base (message)
        {
            
        }
    }
}
