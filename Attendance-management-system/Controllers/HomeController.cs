using Microsoft.AspNetCore.Mvc;

namespace Attendance_management_system.Controllers
{
    public class HomeYuviController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
