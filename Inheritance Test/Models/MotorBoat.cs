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
    /// ExampleClass for inheritance
    /// </summary>
    public class MotorBoat : Boat
    {
        #region Properties
        public EngineType EngineType { get; set; }
        #endregion

        #region Constructor
        public MotorBoat(BoatType boatType, string model, string sailNumber, string engineInfo, double draft, double width, double length, string yearOfConstruction, EngineType engineType) : base(boatType, model, sailNumber, engineInfo, draft, width, length, yearOfConstruction)
        {
            EngineType = engineType;
        }
        #endregion
        #region Methods
        public override string ToString()
        {
            return base.ToString() + $"Motortype: {EngineType}";
        }
        #endregion
    }
}
