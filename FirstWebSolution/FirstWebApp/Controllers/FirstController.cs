using Microsoft.AspNetCore.Mvc;

namespace FirstWebApp.Controllers
{
    public class FirstController : Controller
    {
        public string Greet()
        {
            return "Hello you!";
        }
        public ActionResult BasicPage()
        {
            return View();
        }
        public ActionResult AnotherPage()
        {
            return View();
        }
    }
}
