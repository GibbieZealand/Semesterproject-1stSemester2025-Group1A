using ProjectClassLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectClassLibrary.Models
{
    public class Member : IMember
    {
        /// <summary>
        /// Represents a static counter used to track the number of instances or operations.
        /// </summary>
        #region Instance Fields
        private static int _counter = 0;
        #endregion
        /// <summary>
        /// Gets or sets the name associated with the object.
        /// </summary>
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
        /// <summary>
        /// Initializes a new instance of the <see cref="Member"/> class with the specified details.
        /// </summary>
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
           
        }
        #endregion
        /// <summary>
        /// Returns a string representation of the member, including key details such as ID, name, contact information,
        /// and role.
        /// </summary>
        #region Methods
        public override string ToString()
        {
            return $"Medlem nummer: {Id}\nFornavn: {Name}\nEfternavn: {SurName}\nTelefonnummer: {PhoneNumber}\n" +
                $"Adresse: {Address}\nBy: {City}\nEmail: {Mail}\nType: {TheMemberType}\n" +
                $"Rolle: {TheMemberRole}";
        }
        #endregion 
    }
}
