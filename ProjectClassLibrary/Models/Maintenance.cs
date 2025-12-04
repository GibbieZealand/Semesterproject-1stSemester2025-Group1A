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
        #endregion

        #region Properties
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime TimeOfMaintenance { get; set; }
        public bool IsFixed { get; private set; }
        #endregion

        #region Constructor
        public Maintenance(string description, DateTime time)
        {
            Description = description;
            TimeOfMaintenance = time;
            IsFixed = false;
            _count++;
            _id = _nextId;
            Id = _id;
            _nextId++;
        }
        #endregion

        #region Methods

        //Sets IsFixed to true
        public void Fixed()
        {
            IsFixed = true;
        }
        public override string ToString()
        {
            return "ID: " + Id +
                "\nDescription: " + Description +
                "\nTime: " + TimeOfMaintenance +
                "\nIsFixed: " + (IsFixed ? "Completed" : "Pending");
        }

        #endregion
    }
}
