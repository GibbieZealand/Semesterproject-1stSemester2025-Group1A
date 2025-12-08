using ProjectClassLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// - Lavet af Kasper - 
namespace ProjectClassLibrary.Models
{ 
    /// <summary>
    /// Represents a member with personal details, contact information, and associated roles and types.
    /// </summary>
    public class Member : IMember
    {
        #region Instance Fields
        /// <summary>
        /// A static field that tracks the current counter value.
        /// </summary>
        private static int _counter = 0;
        /// <summary>
        /// Represents a collection of bookings.
        /// </summary>
        private List<IBooking> _bookings;
        /// <summary>
        /// Represents a collection of events.
        /// </summary>
        private List<IEvent> _events;
        #endregion
     
        #region Properties
        /// <summary>
        /// Gets or sets the name associated with the object.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Gets or sets the surname of the individual.
        /// </summary>
        public string SurName { get; set; }
        /// <summary>
        /// Gets or sets the phone number associated with the entity.
        /// </summary>
        public string PhoneNumber { get; set; }
        /// <summary>
        /// Gets or sets the address associated with the entity.
        /// </summary>
        public string Address { get; set; }
        /// <summary>
        /// Gets or sets the name of the city.
        /// </summary>
        public string City { get; set; }
        /// <summary>
        /// Gets or sets the email address associated with the user.
        /// </summary>
        public string Mail { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public MemberType TheMemberType { get; set; }
        public MemberRole TheMemberRole { get; set; }
        public int Id { get; set; }
        #endregion
        
        #region Constructor
        public Member(string name, string surName, string phoneNumber, string address, string city, string mail, MemberType theMemberType, MemberRole theMemberRole)
        {
            
            Name = name;
            SurName = surName;
            PhoneNumber = phoneNumber;
            Address = address;
            City = city;
            Mail = mail;
            TheMemberType = theMemberType;
            TheMemberRole = theMemberRole;
            Id = _counter++;
            _bookings = new List<IBooking>();
            _events = new List<IEvent>();
            
           
        }
        #endregion
       
        #region Methods
        public override string ToString()
        {
            return $"Medlem nummer: {Id}\nFornavn: {Name}\nEfternavn: {SurName}\nTelefonnummer: {PhoneNumber}\n" +
                $"Adresse: {Address}\nBy: {City}\nEmail: {Mail}\nType: {TheMemberType}\n" +
                $"Rolle: {TheMemberRole}\n {_bookings}\n {_events}";
        }
        #endregion 
    }
}
