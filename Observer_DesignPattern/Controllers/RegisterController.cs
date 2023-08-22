using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Observer_DesignPattern.DAL;
using Observer_DesignPattern.Models;
using Observer_DesignPattern.ObserverPattern;

namespace Observer_DesignPattern.Controllers
{
    public class RegisterController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly ObserverObject _observerObject;

        public RegisterController(ObserverObject observerObject, UserManager<AppUser> userManager)
        {
            _observerObject = observerObject;
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(RegisterViewModel model)
        {
            var appUser = new AppUser()
            {
                Name = model.Name,
                Surname = model.Surname,
                City = model.City,
                Email = model.Email,
                District = model.District,
                UserName = model.Username
            };
            var result=await _userManager.CreateAsync(appUser,model.Password);
            if (result.Succeeded)
            {
                _observerObject.NotifyObserver(appUser);
                return View();
            }
            return View();
        }


    }
}
