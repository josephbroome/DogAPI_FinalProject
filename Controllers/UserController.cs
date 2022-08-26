using Microsoft.AspNetCore.Mvc;

namespace DogAPI_FinalProject.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
