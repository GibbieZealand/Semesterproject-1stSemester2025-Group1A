using ProjectClassLibrary.Exceptions;
using ProjectClassLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//--Lavet af Necati--
namespace ProjectClassLibrary.Models
{
    public class Maintenance : IMaintenance
    {
        #region Instance fields
        private int _count = 0;
        private int _id;
        private static int _nextId = 1;
        private IBoat _boat;
        private IMember _member;
        #endregion

        #region Properties
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime TimeOfMaintenance { get; set; }
        public bool IsFixed { get; private set; }
        #endregion

        #region Constructor
        public Maintenance(string description, DateTime time, IBoat boat, IMember member)
        {
            Description = description;
            TimeOfMaintenance = time;
            IsFixed = false;
            _count++;
            _id = _nextId;
            Id = _id;
            _nextId++;
            _boat = boat;
            _member = member;
        }
        #endregion

        #region Methods

        /// <summary>
        /// Sets IsFixed to true
        /// </summary>
        public void Fixed()
        {
            if (!IsFixed)
            {
                IsFixed = true;
                return;
            }
            throw new BoatAlreadyFixedException("Båden er Allerede fikset");
        }

        public override string ToString()
        {
            return "ID: " + Id +
                "\nBeskrivelse: " + Description +
                "\nTid: " + TimeOfMaintenance +
                "\nStatus: " + (IsFixed ? "Er Repareret" : "Afventer Reparation")+
                "\nBåd: " + _boat.SailNumber + 
                "\nMedlem: " + _member.Name + " " + _member.SurName + " " + _member.PhoneNumber ;
        }

        #endregion
    }
}
