using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectClassLibrary.Exceptions
{
    public class BoatAlreadyFixedException : Exception
    {
        public BoatAlreadyFixedException(string message)
            : base(message)
        {

        }
    }
}
