using Microsoft.AspNetCore.Mvc;
using QuanLyBanMayTinh.Models;

namespace QuanLyBanMayTinh.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login() => View();
        [HttpPost]
        public IActionResult Login(User model) => RedirectToAction("Index", "Home");

        public IActionResult Register() => View();
        [HttpPost]
        public IActionResult Register(User model) => RedirectToAction("Login");

        public IActionResult Logout() => RedirectToAction("Index", "Home");

        public IActionResult Profile() => View();
    }

}
