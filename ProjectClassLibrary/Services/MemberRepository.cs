using ProjectClassLibrary.Interfaces;
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
        // Tilføje Member
        // if-statement:
        // 
        public void AddMember(IMember member)
        {
            if (!_members.ContainsKey(member.PhoneNumber))
            {
                _members.Add(member.PhoneNumber, member);
            }
            return;
        }

        public List<IMember> GetAllMembers()
        {
            return _members.Values.ToList();
        }

        public void RemoveMember(IMember member)
        {
            _members.Remove(member.PhoneNumber);
        }

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
        #endregion
    }
}
