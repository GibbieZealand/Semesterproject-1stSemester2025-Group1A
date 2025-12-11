using ProjectClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// -- Lavet af: Gibbie --
namespace ProjectClassLibrary.Interfaces
{
    /// <summary>
    /// Interface for the Boat class
    /// </summary>
    public interface IBoat
    {
        #region Properties
        BoatType TheBoatType { get; set; }
        int Id { get; set; }
        string Model { get; set; }
        string SailNumber { get; set; }
        string EngineInfo { get; set; }
        double Draft { get; set; }
        double Width { get; set; }
        double Length { get; set; }
        string YearOfConstruction { get; set; }
        int BookedNrOfTimes { get; set; }
        IMaintenance Maintenance { get; set; }
        #endregion

    }
}
