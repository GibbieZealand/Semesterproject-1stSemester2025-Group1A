using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjectClassLibrary.Interfaces;
using ProjectClassLibrary.Models;
using System.Dynamic;

namespace RazorPage.Pages.Members
{
    public class CreateMemberModel : PageModel
    {
        private IMemberRepository _repo;
        [BindProperty]
        public Member NewMember { get; set; }
        public CreateMemberModel(IMemberRepository memberRepository)
        {
            _repo = memberRepository;
        }
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            _repo.AddMember(NewMember);
            return RedirectToPage("Index");
        }
    }
}
