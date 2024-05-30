using LeaveManagementSystem.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace LeaveManagementSystem.Web.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            var data = new TestViewModel
            {
                Name = "Akhand Jyoti: Student of MVC Mastery",
                DateOfBirth = new DateTime(1995,03,22)
            };
            return View(data);
        }
    }
}
