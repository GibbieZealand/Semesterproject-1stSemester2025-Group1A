using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// - Lavet af Kasper - 
namespace ProjectClassLibrary.Models
{
    public class Admin : Member
    {
        
        public Admin(string name, string surName, string phoneNumber, string address, string city, string mail, MemberType theMemberType) : base(name, surName, phoneNumber, address, city, mail, theMemberType)
        {
        }
    }
}
