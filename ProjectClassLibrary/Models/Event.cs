using ProjectClassLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//-- Lavet af Maria -- //

namespace ProjectClassLibrary.Models
{
    /// <summary>
    /// Generic Class for Constructing Event Objects using the interface
    /// </summary>
    public class Event : IEvent
    {
        #region instance fields
        /// <summary>
        /// Static counter set to 0
        /// New instance field list called _members
        /// </summary>

        private static int _counter = 0;
        private List<IMember> _members;

        #endregion

        #region properties
        /// <summary>
        /// Properties for the event class
        /// </summary>

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public IMember Author { get; set; }

        #endregion

        #region constructor
        /// <summary>
        /// Constructor for making a new event with parameters name, description, startDate and endDate
        /// </summary>

        public Event(string name, string description, DateTime startDate, DateTime endDate, IMember member)
        {
            Id = _counter++;
            Name = name;
            Description = description;
            StartDate = startDate;
            EndDate = endDate;
            Author = member;
            _members = [];
        }
        
        // For razorpages
        public Event()
        {

        }
        #endregion

        #region methods
        /// <summary>
        /// Assigns a member to an Event
        /// </summary>
        public void AssignMember(IMember member)
        {
            foreach (IMember m in _members)
            {
                if (m.Id == member.Id)
                {
                    return;
                }
            }
            _members.Add(member);
        }
        /// <summary>
        /// Retrieves all members registered to an event
        /// </summary>
        public string GetAllEventMemberNames()
        {
            string s = "";
            foreach (IMember m in _members)
            {
                s += "\n" + m.FirstName + " " + m.SurName;
            }
            return s;
        }
        /// <summary>
        /// Prints out all the information about an event
        /// </summary>
        public override string ToString()
        {
            return $"Begivenheds ID: {Id}" +
                $"\nNavn: {Name}" +
                $"\nBeskrivelse: {Description}" +
                $"\nStarttidspunkt: {StartDate}" +
                $"\nSluttidspunkt: {EndDate}" +
                $"\nOprettet af: {Author.FirstName + " " + Author.SurName}" +
                $"\nMedlemsnavne: {GetAllEventMemberNames()}";
        }
        #endregion
    }
}
