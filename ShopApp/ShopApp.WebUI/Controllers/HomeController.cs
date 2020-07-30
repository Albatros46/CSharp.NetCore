using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ShopApp.WebUI.Models;
using ShopApp.WebUI.ViewModels;

namespace ShopApp.WebUI.Controllers
{
    // https://localhost:44328/
    public class HomeController : Controller
    {
        public IActionResult Index()
        {//https://localhost:44328/home/index
            var products = new List<Product>() {
                new Product{Name="iPhone X Max",Price=12000,Description="Çok İyi Telefon"},
                new Product{Name="Samsung Galaxy S 10",Price=6000,Description="İyi Telefon",isApproved=true},
                new Product{Name="iPhone 8 Plus",Price=9000,Description="İyi Telefon",isApproved=true},
                new Product{Name="Huawei Me 10 Pro",Price=5000,Description="Güzel Telefon"},
                new Product{Name="Xiaomi Red Me 10",Price=4500,Description="İyi Telefon",isApproved=true}
            };
            var categories = new List<Category>() {
                new Category { Name="Telefonlar",Description="Telefon Listesi"},
                new Category { Name="Mobilya",Description="Ev ve İş Mobilyaları"},
                new Category { Name="Oto Aksesuar",Description="Otomobil Aksesuarları"},
                new Category { Name="Bahçe ve Dekorasyon",Description="Bahçe dekor malzemeleri"},
                new Category { Name="Beyaz Eşyalar",Description="Beyaz Eşyalar"}
            };
            var category = new Category { Name = "Telefonlar", Description = "Telefon Listesi" };
            // ViewBag.Category = category; //List.cshtml de ulaşabiliriz.
            var productviewModel = new ProductViewModel()
            {
                Categories = categories,
                Products = products
            };
            return View(productviewModel);
        }
        public IActionResult About()
        {// https://localhost:44328/home/about
            return View();
        }
        public IActionResult Contact()
        {// https://localhost:44328/home/contact
            return View("MyView");
        }
    }
}
