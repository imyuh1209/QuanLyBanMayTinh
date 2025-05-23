using Microsoft.AspNetCore.Mvc;
using QuanLyBanMayTinh.Models;

namespace QuanLyBanMayTinh.Controllers
{
    public class CheckoutController : Controller
    {
        public IActionResult Index() => View(); // nhập thông tin giao hàng
        [HttpPost]
        public IActionResult Submit(Order model) => RedirectToAction("Success");

        public IActionResult Success() => View();
    }

}
