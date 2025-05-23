using Microsoft.AspNetCore.Mvc;
using QuanLyBanMayTinh.Models;

namespace QuanLyBanMayTinh.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var products = new List<Product>(); // Replace with actual data retrieval logic  
            return View(products);
        }

        [HttpPost]
        public IActionResult Search(string keyword) => RedirectToAction("Search", "Product", new { keyword });
    }
}
