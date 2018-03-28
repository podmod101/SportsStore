using Microsoft.AspNetCore.Mvc;
using TournamentManagement.Models;
using System.Linq;

namespace TournamentManagement.Controllers {
    public class HomeController : Controller {
        private DataContext context;

        public HomeController(DataContext ctx) {
            context = ctx;
        }

        public IActionResult Index() {
            ViewBag.Message = "AIMS";
            var student = context.Student.Where(m => m.FirstName == "Lana").FirstOrDefault();
            
            return View(student);
        }
    }
}