using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectClassLibrary.Exceptions
{
    /// <summary>
    /// Exception for when the isFixed bool returns true 
    /// </summary>
    public class BoatAlreadyFixedException : Exception
    {
        public BoatAlreadyFixedException(string message)
            : base(message)
        {

        }
    }
}
