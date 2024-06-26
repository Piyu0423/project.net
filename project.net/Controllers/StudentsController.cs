using Microsoft.AspNetCore.Mvc;

namespace project.net.Controllers
{
    public class StudentsController : Controller
    {
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
    }
}
