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
    /// Interface for the BoatRepository Class
    /// </summary>
    public interface IBoatRepository
    {
        #region Properties
        public int Count { get; }
        #endregion

        #region Methods
        List<IBoat> GetAllBoats();
        void AddBoat(IBoat boat);
        void RemoveBoat(string sailNumber);
        void UpdateBoat(IBoat boat);
        IBoat? SearchBoat(string sailNumber);
        #endregion
    }
}
