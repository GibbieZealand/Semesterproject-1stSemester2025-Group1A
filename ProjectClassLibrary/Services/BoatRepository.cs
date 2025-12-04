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
    public class BoatRepository : IBoatRepository
    {
        #region Properties
        private Dictionary<string, IBoat> _boats;

        public BoatRepository()
        {
            _boats = new Dictionary<string, IBoat>();
        }
        public int Count { get { return _boats.Count; } }
        #endregion

        #region Methods
        /// <summary>
        /// Adds a Boat Object to the Dictionary
        /// </summary>
        public void AddBoat(IBoat boat)
        {
            _boats[boat.SailNumber] = boat;
            ;
        }

        //
        public void BookBoat()
        {
            //TODO - Implement Booking Method
            throw new NotImplementedException();
        }

        /// <summary>
        /// Collects all the Boats Objects in the Dictionary and files them into a list
        /// </summary>
        public List<IBoat> GetAll()
        {
            return _boats.Values.ToList();
        }

        /// <summary>
        /// Removes a Boat Object from the Dictionary
        /// </summary>
        public void RemoveBoat(string sailNumber)
        {
            _boats.Remove(sailNumber);
            Console.WriteLine($"Boat Nr.{sailNumber} has been removed");
        }

        /// <summary>
        /// Updates the info of a Boat Object found by parameter
        /// </summary>
        public void UpdateBoat(IBoat boat)
        {
            //TODO - Implement Update Boat
                //Which parameters are needed? Are we changing just a single value or rewriting the whole
                //Object through command line?
            throw new NotImplementedException();
        }
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
