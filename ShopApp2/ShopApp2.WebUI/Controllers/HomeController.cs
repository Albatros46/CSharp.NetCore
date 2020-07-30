using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ShopApp2.WebUI.Models;
using ShopApp2.WebUI.ViewModels;

namespace ShopApp2.WebUI.Controllers
{
    
    public class HomeController:Controller //Microsoft.AspNetCore.Mvc içindeki controller i miras alacak
    {//http://localhost:5002/ artık homecontroller 
        public IActionResult Index()
        {// http://localhost:5000/home/index
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
        {// http://localhost:5000/home/about
            return View();
        }
         public IActionResult Contact()
        {// http://localhost:5000/home/contact
            return View("MyView");// MyView donecek istek olarak MyView arayacaktir.
        }
    }
}