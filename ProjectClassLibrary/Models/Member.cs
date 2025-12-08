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
    /// Member klassen implementere alle properties fra interfacet IMember
    /// </summary>
    public class Member : IMember
    {
        #region Instance Fields
        private static int _counter = 0;
        private List<IBooking> _bookings;
        private List<IEvent> _events;
        #endregion
     
        #region Properties
        public string Name { get; set; }
        public string SurName { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Mail { get; set; }
        public MemberType TheMemberType { get; set; }
        public MemberRole TheMemberRole { get; set; }
        public int Id { get; set; }
        #endregion
        
        #region Constructor
        /// <summary>
        /// Konstruktøren bruges til at oprette nye objekter af Memberklassen
        /// </summary>
        /// <param name="name"></param>
        /// <param name="surName"></param>
        /// <param name="phoneNumber"></param>
        /// <param name="address"></param>
        /// <param name="city"></param>
        /// <param name="mail"></param>
        /// <param name="theMemberType"></param>
        /// <param name="theMemberRole"></param>
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
        /// <summary>
        /// Metoden printer et instance af typen member 
        /// </summary>
        public override string ToString()
        {
            return $"Medlem nummer: {Id}\nFornavn: {Name}\nEfternavn: {SurName}\nTelefonnummer: {PhoneNumber}\n" +
                $"Adresse: {Address}\nBy: {City}\nEmail: {Mail}\nType: {TheMemberType}\n" +
                $"Rolle: {TheMemberRole}\n {_bookings}\n {_events}";
        }
        #endregion 
    }
}
