using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectClassLibrary.Interfaces
{
    /// <summary>
    /// Interface for the Event Class
    /// </summary>
    public interface IEvent
    {
        int Id { get; set; }
        string Name { get; set; }
        string Description { get; set; }
        DateTime StartDate { get; set; }
        DateTime EndDate { get; set; }

        void AssignMember(IMember member);
    }
}
