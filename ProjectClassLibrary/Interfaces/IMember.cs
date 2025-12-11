using ProjectClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// - Lavet af Kasper -
namespace ProjectClassLibrary.Interfaces
{
    
    public interface IMember
    {
        string Name { get; set; }   
        string SurName { get; set; }
        string PhoneNumber { get; set; }
        string Address { get; set; }
        string City { get; set; }
        string Mail { get; set; }
        MemberType TheMemberType { get; set; }
        MemberRole TheMemberRole { get; set; }
        int Id { get; set; }
    }
}
