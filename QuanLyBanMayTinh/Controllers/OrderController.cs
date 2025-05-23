using Microsoft.AspNetCore.Mvc;
using QuanLyBanMayTinh.Controllers;
using QuanLyBanMayTinh.Models;
using System.Collections.Generic;
using System.Linq;

public class OrderController : Controller
{

    public IActionResult Index()
    {
        var products = new List<Product>(); // Replace with actual data retrieval logic  
        return View(products);
    }
    // admin xem toàn bộ đơn
    public IActionResult AllOrders() => View();
}

