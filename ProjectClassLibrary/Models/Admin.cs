using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectClassLibrary.Models
{
    public class Admin : Member
    {
        public Admin(string name, string surName, string phoneNumber, string address, string city, string mail, MemberType theMemberType, MemberRole theMemberRole) : base(name, surName, phoneNumber, address, city, mail, theMemberType, theMemberRole)
        {
        }
    }
}
