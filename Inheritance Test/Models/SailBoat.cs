using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// -- ikke i brug - kun til inheritance eksempel

namespace ProjectClassLibrary.Models
{
    /// <summary>
    /// Example class for inheritance
    /// </summary>
    public class SailBoat : Boat
    {
        #region Properties
        public string SailType { get; set; }
        #endregion

        #region Constructor
        public SailBoat(BoatType boatType, string model, string sailNumber, string engineInfo, string sailType, double draft, double width, double length, string yearOfConstruction) : base(boatType, model, sailNumber, engineInfo, draft, width, length, yearOfConstruction)
        {
            SailType = sailType;
        }
        #endregion
    }
}
