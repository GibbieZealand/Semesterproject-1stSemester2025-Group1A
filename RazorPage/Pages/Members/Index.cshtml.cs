using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjectClassLibrary.Interfaces;
using ProjectClassLibrary.Models;

namespace RazorPage.Pages.Members
{
    public class IndexModel : PageModel
    {
        private IMemberRepository _repo;


        public List<IMember> Members { get; set; }
        public IndexModel(IMemberRepository memberRepository)
        {
            _repo = memberRepository;
        }
        public void OnGet()
        {
            Members = _repo.GetAllMembers();
        }
       
    }
}
