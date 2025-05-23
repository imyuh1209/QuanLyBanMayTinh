using Microsoft.AspNetCore.Mvc;
using QuanLyBanMayTinh.Models;

namespace QuanLyBanMayTinh.Controllers
{
    public class CartController : Controller
    {
        public IActionResult Index()
        {
            var products = new List<Product>(); // Replace with actual data retrieval logic  
            return View(products);
        }
        public IActionResult AddToCart(int id) => RedirectToAction("Index");

        [HttpPost]
        public IActionResult UpdateQuantity(int id, int quantity) => RedirectToAction("Index");

        public IActionResult Remove(int id) => RedirectToAction("Index");
    }

}
