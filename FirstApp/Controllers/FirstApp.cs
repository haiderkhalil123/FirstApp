using Microsoft.AspNetCore.Mvc;

namespace FirstApp.Controllers
{
    public class FirstApp : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        //public string App()
        //{
        //    return "HEllo World";
        //}


    }
}
