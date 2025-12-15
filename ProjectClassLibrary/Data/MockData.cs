using ProjectClassLibrary.Interfaces;
using ProjectClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Ikke i brug

namespace ProjectClassLibrary.Data
{
    public class MockData
    {
        #region Instance fields
        private static Dictionary<string, IMember> _memberData =
            new Dictionary<string, IMember>()
            {
            { "12121212", new Member("Poul","Jensen","23456789","Gaden 1","Hillerød","PH@gamil.com",MemberType.Senior,MemberRole.Member) },
            
            };

        private static Dictionary<string, IBoat> _boatData =
              new Dictionary<string, IBoat>()
              {
            { "16-3335", new Boat(BoatType.TERA, "Model", "16-3335", "Is very good :3", 32, 23, 33, "1982")},

              };
        #endregion

        #region Properties
        public static Dictionary<string, IMember> MemberData
        {
            get { return _memberData; }
        }
        public static Dictionary<string, IBoat> BoatData
        {
            get { return _boatData; }
        }

        //public static List<MenuItem> MenuItemData
        //{
        //    get { return _menuItemData; }
        //}
        #endregion
    }
}

