using FirstApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstApp.Controllers
{
    public class FirstController : Controller
    {
        public string Index()
        {
            return "Hello World";
        }

        public IActionResult Hello()
        {
            ViewBag.Message = "Hello World";
            return View();
        }

        public IActionResult Info()
        {
            Person person = new Person();
            person.Name = "Haider Khalil";
            person.Age = 17;
            person.Location = "Pakistan";
            return View(person);
        }
    }
}
