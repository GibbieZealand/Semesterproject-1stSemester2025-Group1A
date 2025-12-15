using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//--Lavet af Necati--
namespace ProjectClassLibrary.Interfaces
{
    /// <summary>
    /// Interface for the Maintenance class
    /// </summary>
    public interface IMaintenance
    {
        string Description { get; set; }
        DateTime TimeOfMaintenance { get; set; }
        bool IsFixed { get; }
        int Id { get; set; }
    }
}
