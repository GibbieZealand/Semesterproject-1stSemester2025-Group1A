using ProjectClassLibrary.Interfaces;
using ProjectClassLibrary.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// - Lavet af Kasper - 
namespace ProjectClassLibrary.Models
{
    /// <summary>
    /// Generic Class for Constructing Member Objects using the interface
    /// </summary>
    public class Member : IMember
    {
        #region Instance Fields
        private static int _counter = 0;
        #endregion
     
        #region Properties
        public string FirstName { get; set; }
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
        /// Constructor used for creating new member objects
        /// </summary>
        public Member(string name, string surName, string phoneNumber, string address, string city, string mail, MemberType theMemberType, MemberRole theMemberRole)
        {
            FirstName = name;
            SurName = surName;
            PhoneNumber = phoneNumber;
            Address = address;
            City = city;
            Mail = mail;
            TheMemberType = theMemberType;
            TheMemberRole = theMemberRole;
            Id = _counter++;
        }
        public Member()
        {

        }
        #endregion
        #region Methods
        /// <summary>
        /// ToString method used for printing out member information
        /// </summary>
        public override string ToString()
        {
            return $"Medlemsnummer: {Id}\nFornavn: {FirstName}\nEfternavn: {SurName}\nTelefonnummer: {PhoneNumber}\n" +
                $"Adresse: {Address}\nBy: {City}\nEmail: {Mail}\nType: {TheMemberType}\n" +
                $"Rolle: {TheMemberRole}";
        }
        #endregion 
    }
}
