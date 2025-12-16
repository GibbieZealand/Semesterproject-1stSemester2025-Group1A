using Inheritance_Test.Models;
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
        public SailType SailType { get; set; }
        #endregion

        #region Constructor
        public SailBoat(BoatType boatType, string model, string sailNumber, string engineInfo, double draft, double width, double length, string yearOfConstruction, SailType sailType) : base(boatType, model, sailNumber, engineInfo, draft, width, length, yearOfConstruction)
        {
            SailType = sailType;
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return base.ToString() + $"Sejltype: {SailType}";
        }
        #endregion
    }
}
