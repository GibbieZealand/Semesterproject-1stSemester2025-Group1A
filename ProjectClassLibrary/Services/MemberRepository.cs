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
    public class MemberRepository : IMemberRepository
    {
        #region Instance Fields
        private Dictionary<string, IMember> _members;
        #endregion
     
        #region Properties
        public int Count { get { return _members.Count; } }
        #endregion

        #region Constructor
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
        public List<IMember> GetAllMembers()
        {
            return _members.Values.ToList();
        }
        // Formål:
        // Fjerne Medlem
        // Metoden sletter via metoden Remove, og sletter telefonnummeret fra _members
        public void RemoveMember(IMember member)
        {
            _members.Remove(member.PhoneNumber);
        }
        // Formål:
        // Opdatere Medlem
        // if-statement:
        // Hvis _members indholder Telefonnummeret argumentet, så overskrider de nye værdier de nuværende med samme telefonnummer.
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
