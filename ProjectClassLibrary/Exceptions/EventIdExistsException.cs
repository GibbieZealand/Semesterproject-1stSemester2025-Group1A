using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectClassLibrary.Exceptions
{
    /// <summary>
    /// Exception for when the ID for an event already exists
    /// </summary>
    public class EventIdExistsException : Exception
    {
        public EventIdExistsException(string message) : base(message)
        {

        }
    }
}
