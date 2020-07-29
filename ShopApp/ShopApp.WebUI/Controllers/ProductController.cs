using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ShopApp.WebUI.Models;

namespace ShopApp.WebUI.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {//https://localhost:44328/home/index
            return View();
        }
        public IActionResult List()
        {// https://localhost:44328/product/list
            return View();
        }
        public IActionResult Details(int id)
        {// https://localhost:44328/product/Details
            // Name = "iPhone 7"
            // Price= "4250"
            // Description="Müthiş Telefon"  gibi bilgiler göstermek istiyoruz
            ViewBag.Name = "iPhone 7";
            ViewBag.Price = 4250;
            ViewBag.Description = "Müthiş Telefon";
            var p = new Product();
            p.Name = "Xaimo Red Me 9";
            p.Price = 4000;
            p.Description = "Harika Telefon";

            return View(p);
        }
    }
}
