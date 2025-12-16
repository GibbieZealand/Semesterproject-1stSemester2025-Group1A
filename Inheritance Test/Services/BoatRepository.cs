using ProjectClassLibrary.Exceptions;
using ProjectClassLibrary.Interfaces;
using ProjectClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

// -- Lavet af: Gibbie --
namespace ProjectClassLibrary.Services
{
    /// <summary>
    /// Class for Constructing and calling Boat Repository Objects using the interface
    /// </summary>
    public class BoatRepository : IBoatRepository
    {
        #region Instance Field
        private Dictionary<string, IBoat> _boats;
        #endregion

        #region Properties
        public int Count { get { return _boats.Count; } }
        #endregion  

        #region Constructor
        public BoatRepository()
        {
            _boats = [];
        }
        #endregion

        #region Methods
        /// <summary>
        /// Adds a Boat Object to the Dictionary. 
        /// </summary>
        public void AddBoat(IBoat boat)
        {
            if (!_boats.ContainsKey(boat.SailNumber))
            {
                _boats[boat.SailNumber] = boat;
                Console.WriteLine($"Båden med sejlnummeret {boat.SailNumber} er blevet tilføjet til listen");
                return;
            }
            throw new BoatSailnumberExistsException($"Båden med sejlnummeret {boat.SailNumber} findes allerede.");
        }

        public void AddSailBoat(IBoat sailBoat)
        {

        }

        public void AddMotorBoat(IBoat motorBoat)
        {

        }

        /// <summary>
        /// Collects all the Boats Objects in the Dictionary and files them into a list
        /// </summary>
        public List<IBoat> GetAllBoats()
        {
            return _boats.Values.ToList();
        }

        /// <summary>
        /// Removes a Boat Object from the Dictionary
        /// </summary>
        public void RemoveBoat(string sailNumber)
        {
            _boats.Remove(sailNumber);
            Console.WriteLine($"Båden med sejlnummer {sailNumber} er blevet fjernet.");
        }

        /// <summary>
        /// Updates the info of a Boat Object found by parameter with input info
        /// </summary>
        public void UpdateBoat(IBoat updatedBoat)
        {
            if(_boats.ContainsKey(updatedBoat.SailNumber))
            {
                IBoat existingBoat = _boats[updatedBoat.SailNumber];

                existingBoat.TheBoatType = updatedBoat.TheBoatType;
                existingBoat.Model = updatedBoat.Model;
                existingBoat.EngineInfo = updatedBoat.EngineInfo;
                existingBoat.Draft = updatedBoat.Draft;
                existingBoat.Width = updatedBoat.Width;
                existingBoat.Length = updatedBoat.Length;
                existingBoat.YearOfConstruction = updatedBoat.YearOfConstruction;
            }
        }

        /// <summary>
        /// Searches through the boat dictionary and returns the boat with the given sailnumber. 
        /// </summary>
        public IBoat? SearchBoat(string sailNumber) 
        {
            if (_boats.ContainsKey(sailNumber))
            {
                return _boats[sailNumber];
            }
            return null;
        }

        /// <summary>
        /// Runs through the list and calls the toString() method of every index
        /// </summary>
        public void PrintAllBoats()
        {
            foreach (var boat in _boats)
            {
                Console.WriteLine(boat.ToString());
            }
            Console.WriteLine();
        }
        #endregion
    }
}
