using ProjectClassLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// -- Lavet af: Gibbie --
namespace ProjectClassLibrary.Models
{
    /// <summary>
    /// Generic Class for Constructing Boat Objects
    /// </summary>
    public class Boat : IBoat
    {
        #region Instance Fields
        private static int _counter = 0;
        private IMaintenance _maintenance;


        #endregion

        #region Properties
        public int Id { get; set; }
        public BoatType TheBoatType { get; set; }
        public string Model { get; set; }
        public string SailNumber { get; set; }
        public string EngineInfo { get; set; }
        public double Draft { get; set; }
        public double Width { get; set; }
        public double Length { get; set; }
        public string YearOfConstruction { get; set; }
        public IMaintenance Maintenance { get; set; }   
        #endregion

        #region Constructor
        public Boat(BoatType boatType, string model, string sailNumber, string engineInfo, 
            double draft, double width, double length, string yearOfConstruction)
        {
            Id = _counter++;
            TheBoatType = boatType;
            Model = model;
            SailNumber = sailNumber;
            EngineInfo = engineInfo;
            Draft = draft;
            Width = width;
            Length = length;
            YearOfConstruction = yearOfConstruction;
         
        }
       
        #endregion

        #region Methods
        public override string ToString()
        {
            return ($"\nBåd Nr.{Id}: " +
                $"\nBådinfo..." +
                $"\n{YearOfConstruction} {Model} {TheBoatType} {SailNumber} " +
                $"\nMotorinfo: {EngineInfo} " +
                $"\nDimensioner... " +
                $"\nDybgang: {Draft}, Bredde: {Width}, Længde: {Length}," +
                $"\n {Maintenance}");
        }
        #endregion

    }
}
