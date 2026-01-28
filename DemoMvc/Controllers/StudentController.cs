namespace StudentController.Controllers
{
    using DemoMvc.Models.Entities;
    using Microsoft.AspNetCore.Mvc;

    public class StudentController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
         public IActionResult Index(Student data)
        {
            ViewBag.ThongBao = " MSV :"+ data.StudentCore +" - Ten :"+ data.FullName;
            return View();
        }
        
    }
}