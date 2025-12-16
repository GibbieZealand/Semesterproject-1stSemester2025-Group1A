using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectClassLibrary.Models
{
    /// <summary>
    /// ExampleClass for inheritance
    /// </summary>
    public class MotorBoat : Boat
    {
        #region Properties
        public string EngineType { get; set; }
        #endregion

        #region Constructor
        public MotorBoat(BoatType boatType, string model, string sailNumber, string engineInfo, double draft, double width, double length, string yearOfConstruction, string engineType) : base(boatType, model, sailNumber, engineInfo, draft, width, length, yearOfConstruction)
        {
            EngineType = engineType;
        }
        #endregion
    }
}
