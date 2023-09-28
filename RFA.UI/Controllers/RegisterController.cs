using Microsoft.AspNetCore.Mvc;

namespace RFA.UI.Controllers
{
    public class RegisterController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}
