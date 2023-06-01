using Microsoft.AspNetCore.Mvc;

namespace aspnetmvccrud.Controllers
{
    public class EmployeesController : Controller
    {
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
    }
}
