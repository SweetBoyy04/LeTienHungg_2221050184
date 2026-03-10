namespace DemoMvc.Controllers
{

    using Microsoft.AspNetCore.Mvc;

    public class Student1Controller : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create()
        {
            return View();
        }
    }
}