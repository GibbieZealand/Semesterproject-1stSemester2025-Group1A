using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjectClassLibrary.Interfaces;
using ProjectClassLibrary.Models;

namespace RazorPage.Pages.Events
{
    public class IndexModel : PageModel
    {
        private IEventRepository _repo;

        public List<IEvent> Events { get; set; }

        //Constructor
        public IndexModel(IEventRepository eventRepository) //Dependency injection
        {
            _repo = eventRepository;
        }

        //Controller
        public void OnGet() //Hvis vi skal hente noget
        {
            Events = _repo.GetAllEvents();
        }
    }
}
