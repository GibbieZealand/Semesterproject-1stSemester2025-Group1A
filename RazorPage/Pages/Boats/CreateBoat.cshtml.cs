using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjectClassLibrary.Interfaces;
using ProjectClassLibrary.Models;
using ProjectClassLibrary.Services;
using ProjectClassLibrary.Exceptions;
using ProjectClassLibrary.Helpers;

namespace RazorPage.Pages.Boats
{
    public class CreateModel : PageModel
    {
        private IBoatRepository _repo;
    }
}
