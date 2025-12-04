using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectClassLibrary.Interfaces
{
    public interface IEvent
    {
        string Name { get; set; }
        string Description { get; set; }
        DateTime StartDate { get; set; } //Kan ikke være private set
        DateTime EndDate { get; set; } //Kan ikke være private set
        string ToString();
    }
}
