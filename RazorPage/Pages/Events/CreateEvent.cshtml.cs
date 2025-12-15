using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjectClassLibrary.Interfaces;
using ProjectClassLibrary.Models;


namespace RazorPage.Pages.Events
{
    public class CreateEventModel : PageModel
    {
        private IEventRepository _repo;

        //Den nye event hentes ind i NewEvent
        [BindProperty] //Nu kan den få noget tilbage
        public Event NewEvent { get; set; }
        public CreateEventModel(IEventRepository eventRepository)
        {
            _repo = eventRepository;
        }

        //Kaldes når der skal hentes/vises noget
        public void OnGet()
        {

        }

        //Kaldes når der skal ændres noget
        public IActionResult OnPost()
        {
            _repo.AddEvent(NewEvent);
            return RedirectToPage("Index");
        }
    }
}
