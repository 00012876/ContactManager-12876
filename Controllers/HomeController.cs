using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ContactManager12876.Models;
using System.Diagnostics;

namespace ContactManager12876.Controllers
{
    public class HomeController : Controller
    {
        ContactContext _ctx;
        public HomeController(ContactContext ctx)
        {
               _ctx = ctx;
        }
        //00012876
        public IActionResult Index()
        {
            var contacts = _ctx.Contacts.Include(c => c.Category).OrderBy(c => c.LastName).ToList();
            return View(contacts);
        }

       
    }
}
