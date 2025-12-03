using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectClassLibrary.Interfaces
{
    public interface IMemberRepository
    {
        #region Properties
        int Count { get; }
        #endregion
      
        #region Methods
        void AddMember(IMember member);
        void RemoveMember(IMember member);
        void UpdateMember(IMember member);
        List<IMember> GetAllMembers();
        #endregion
    }
}
