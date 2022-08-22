using DogAPI_FinalProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace DogAPI_FinalProject.Controllers
{
    public class RegisterController : Controller
    {
        private readonly IRegisterRepository _repo;

        public RegisterController(IRegisterRepository repo)
        {
            _repo = repo;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Email()
        {
            return View();
        }
        public IActionResult TermsOfService()
        {
            return View();
        }
        public IActionResult WhyRegister()
        {
            return View();
        }
        public IActionResult RegisterUser() 
        {
            var user = _repo.AssignUser();
            return View(user);
        }
        public IActionResult RegisterUserToDatabase(RegisterModel registerUser)
        {
            _repo.RegisterUser(registerUser);

            return RedirectToAction("Email");
        }



    }
}
