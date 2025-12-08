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
    /// Provides functionality to manage a collection of members, allowing for adding, retrieving, updating, and
    /// removing members.
    /// </summary>
    /// <remarks>The <see cref="MemberRepository"/> class maintains a collection of members, where each member
    /// is uniquely identified by their phone number. This class supports operations such as adding new members,
    /// retrieving all members, updating existing members, and removing members.</remarks>
    public class MemberRepository : IMemberRepository
    {
        #region Instance Fields
        /// <summary>
        /// Represents a collection of members, where each member is identified by a unique string key.
        /// </summary>
     
        private Dictionary<string, IMember> _members;
        #endregion
     
        #region Properties
        /// <summary>
        /// Gets the number of elements contained in the collection.
        /// </summary>
        public int Count { get { return _members.Count; } }
        #endregion

        #region Constructor
        /// <summary>
        /// Initializes a new instance of the <see cref="MemberRepository"/> class.
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
        /// Adds a new member to the collection.
        /// </summary>
        /// <remarks>This method ensures that each member in the collection has a unique phone number. If
        /// the phone number of the provided <paramref name="member"/> already exists, the method will throw an
        /// exception.</remarks>
        /// <param name="member">The member to add. The member's <see cref="IMember.PhoneNumber"/> must be unique within the collection.</param>
        /// <exception cref="MemberPhoneNumberExistsException">Thrown if a member with the same phone number already exists in the collection.</exception>
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
        /// Retrieves a list of all members.
        /// </summary>
        /// <returns>A list of all members as <see cref="IMember"/> objects. The list will be empty if no members are present.</returns>
        public List<IMember> GetAllMembers()
        {
            return _members.Values.ToList();
        }
        // Formål:
        // Fjerne Medlem
        // Metoden sletter via metoden Remove, og sletter telefonnummeret fra _members
        /// <summary>
        /// Removes the specified member from the collection.
        /// </summary>
        /// <remarks>This method removes the member based on their phone number. If the phone number does
        /// not exist in the collection, no action is taken.</remarks>
        /// <param name="member">The member to remove. The member's <see cref="IMember.PhoneNumber"/> is used to identify and remove it from
        /// the collection.</param>
        public void RemoveMember(IMember member)
        {
            _members.Remove(member.PhoneNumber);
        }
        // Formål:
        // Opdatere Medlem
        // if-statement:
        // Hvis _members indholder Telefonnummeret argumentet, så overskrider de nye værdier de nuværende med samme telefonnummer
        /// <summary>
        /// Updates the details of an existing member in the collection.
        /// </summary>
        /// <remarks>If a member with the same phone number as <paramref name="updatedMember"/> exists in
        /// the collection, their details will be replaced with the values from <paramref name="updatedMember"/>. If no
        /// such member exists, the method performs no action.</remarks>
        /// <param name="updatedMember">The member object containing the updated details. The <see cref="IMember.PhoneNumber"/> property is used to
        /// identify the existing member to update.</param>
        
        public void UpdateMember(IMember updatedMember)
        {
            if (_members.ContainsKey(updatedMember.PhoneNumber))
            {
                IMember existingMember = _members[updatedMember.PhoneNumber];

                existingMember.Name = updatedMember.Name;
                existingMember.SurName = updatedMember.SurName;
                existingMember.Address = updatedMember.Address;
                existingMember.City = updatedMember.City;
                existingMember.Mail = updatedMember.Mail;
                existingMember.TheMemberType = updatedMember.TheMemberType;
                existingMember.TheMemberRole = updatedMember.TheMemberRole;
            }

        }
        /// <summary>
        /// Prints all members to the console, each followed by a blank line.
        /// </summary>
        /// <remarks>This method iterates through all members and writes their string representation      
        /// to the console. Each member is followed by an additional blank line for readability.</remarks>
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
