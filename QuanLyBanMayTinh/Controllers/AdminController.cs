using Microsoft.AspNetCore.Mvc;

namespace QuanLyBanMayTinh.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index() => View(); // trang tổng admin

        public IActionResult Users() => View();
        public IActionResult Orders() => RedirectToAction("AllOrders", "Order");
        public IActionResult Products() => RedirectToAction("Index", "Product");
    }

}
