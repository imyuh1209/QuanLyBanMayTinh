using Microsoft.AspNetCore.Mvc;
using QuanLyBanMayTinh.Models;

public class ProductController : Controller
{
    public IActionResult Index()
    {
        var products = new List<Product>(); // Replace with actual data retrieval logic  
        return View(products);
    }
    public IActionResult Details(int id) => View(); // chi tiết sản phẩm

    // Admin
    public IActionResult Create() => View();
    [HttpPost]
    public IActionResult Create(Product model) { return RedirectToAction("Index"); }

    public IActionResult Edit(int id) => View();
    [HttpPost]
    public IActionResult Edit(Product model) { return RedirectToAction("Index"); }

    public IActionResult Delete(int id) => View();
    [HttpPost]
    public IActionResult DeleteConfirmed(int id) { return RedirectToAction("Index"); }

    public IActionResult Search(string keyword) => View(); // kết quả tìm kiếm
}
