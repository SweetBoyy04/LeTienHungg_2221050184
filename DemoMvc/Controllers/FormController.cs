namespace FormController.Controllers
{

    using Microsoft.AspNetCore.Mvc;

    public class FormController : Controller
    {
          [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(string hoTen)
        {
            ViewBag.ThongBao = "Xin chào " + hoTen;
            return View();
        }
    }
}