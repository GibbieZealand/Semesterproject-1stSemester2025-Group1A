using ProjectClassLibrary.Exceptions;
using ProjectClassLibrary.Interfaces;
using ProjectClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// - Lavet af Kasper - 
namespace ProjectClassLibrary.Services
{
    /// <summary>
    /// Class for Constructing and calling Member Repository Objects using the interface
    /// </summary>
    public class MemberRepository : IMemberRepository
    {
        #region Instance Fields
        private Dictionary<string, IMember> _members;
        #endregion
     
        #region Properties
        /// <summary>
        /// Count som bruges til at tælle members i Repository
        /// </summary>
        public int Count { get { return _members.Count; } }
        #endregion

        #region Constructor
        /// <summary>
        /// MemberRepository constructor bruges når vi laver et nyt dictionary af med navnet MemberRepository, med en string som key og en IMember som value
        /// </summary>
        public MemberRepository()
        {
            _members = new Dictionary<string, IMember>();
        }
        #endregion

        #region Methods
        // Formål:
        // Tilføje Medlem
        // if-statement:
        // Hvis Dictionary _members ikke indeholder Telefonnummer på det Medlem man vil tilføje. Tilføjes Medlemmet
        // Else if:
        //Medlem bliver ikke tilføjet

        /// <summary>
        /// Method for adding members to our repository, which runs a check to tell if the phone number is available
        /// </summary>
        public void AddMember(IMember member)
        {
            if (!_members.ContainsKey(member.PhoneNumber))
            {
                _members.Add(member.PhoneNumber, member);
                return;
            }
            throw new MemberPhoneNumberExistsException($"Medlemstelefonnummeret {member.PhoneNumber} findes allerede.");
        }
        // Formål:
        // At få fat på en list med alle medlemmer/objekter
        // Metoden returnere via en indbygget metode som hedder ToList(); som henter liste med _members Values

        /// <summary>
        /// Method for returning a list of members
        /// </summary>
        public List<IMember> GetAllMembers()
        {
            return _members.Values.ToList();
        }
        // Formål:
        // Fjerne Medlem
        // Metoden sletter via metoden Remove, og sletter telefonnummeret fra _members

        /// <summary>
        /// Method for removing a member from the dictionary, using their phone number
        /// </summary>
        public void RemoveMember(IMember member)
        {
            _members.Remove(member.PhoneNumber);
        }
        // Formål:
        // Opdatere Medlem
        // if-statement:
        // Hvis _members indholder Telefonnummeret argumentet, så overskrider de nye værdier de nuværende med samme telefonnummer.

        /// <summary>
        /// Method to update a member's info, using their phone number to distinguish them
        /// </summary>
        public void UpdateMember(IMember updatedMember)
        {
            if (_members.ContainsKey(updatedMember.PhoneNumber))
            {
                IMember existingMember = _members[updatedMember.PhoneNumber];

                existingMember.FirstName = updatedMember.FirstName;
                existingMember.SurName = updatedMember.SurName;
                existingMember.Address = updatedMember.Address;
                existingMember.City = updatedMember.City;
                existingMember.Mail = updatedMember.Mail;
                existingMember.TheMemberType = updatedMember.TheMemberType;
                existingMember.TheMemberRole = updatedMember.TheMemberRole;
            }
        }

        /// <summary>
        /// Searches through the boat dictionary and returns the boat with the given sailnumber. 
        /// </summary>
        public IMember? SearchMember(string phoneNumber) //Vi søger efter en båd. HVIS dictionariet indeholder det angivne sejlnummer, returnerer den båden. Hvis ikke, returneres null
        {
            if (_members.ContainsKey(phoneNumber))
            {
                return _members[phoneNumber];
            }
            return null;
        }

        /// <summary>
        /// Method for printing the info of every member in the dictionary
        /// </summary>
        public void PrintAll() 
        {
            foreach (IMember member in _members.Values)
            {
                Console.WriteLine(member);
                Console.WriteLine();
            }
        }
        #endregion
    }
}
