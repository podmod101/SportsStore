using Microsoft.AspNetCore.Mvc;
using SportsStore.Models;
using System.Linq;

namespace SportsStore.Controllers {
    public class HomeController : Controller {
        private DataContext context;

        public HomeController(DataContext ctx) {
            context = ctx;
        }

        public IActionResult Index() {
            ViewBag.Message = "Sports Store App";
            var student = context.Student.Where(m => m.FirstName == "Lana").FirstOrDefault();
            //return View(context.Products.First());
            return View(student);
        }
    }
}