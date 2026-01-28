namespace DemoController.Controllers
{

    using Microsoft.AspNetCore.Mvc;

    public class DemoController : Controller
    {
        public IActionResult Index(string hoTen)
        {
            ViewBag.ThongBao = "Xin chào các bạn đến với Demo MVC " + hoTen;
            return View();
        }
    }
}