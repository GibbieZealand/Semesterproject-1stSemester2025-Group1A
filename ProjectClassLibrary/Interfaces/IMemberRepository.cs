using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// - Lavet af Kasper - 
namespace ProjectClassLibrary.Interfaces
{
    /// <summary>
    /// Interface for the MemberRepository class
    /// </summary>
    public interface IMemberRepository
    {
        int Count { get; }
        void AddMember(IMember member);
        void RemoveMember(IMember member);
        void UpdateMember(IMember member);
        List<IMember> GetAllMembers();
        void PrintAll();
        IMember? SearchMember(string phoneNumber);
    }
}
