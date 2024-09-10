using leaveManagementSystem.web.Models;
using Microsoft.AspNetCore.Mvc;

namespace leaveManagementSystem.web.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            var data = new TestViewModel
            {
                Name = "Student",
                DOB = new DateTime(1956,09,27)            };
            return View(data);
        }
    }
}
