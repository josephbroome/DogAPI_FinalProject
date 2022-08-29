using DogAPI_FinalProject.Data;
using DogAPI_FinalProject.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace DogAPI_FinalProject.Controllers
{
    public class RoleController : Controller
    {
        private readonly ApplicationDbContext _db;
        private readonly UserManager<AppUser> _userManger;
        private readonly RoleManager<IdentityRole> _roleManger;

        public RoleController(ApplicationDbContext db, UserManager<AppUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _db = db;
            _userManger = userManager;
            _roleManger = roleManager;  

        }
        public IActionResult Index()
        {
            var roles = _db.Roles.ToList();
            return View(roles);
        }


    }
}
