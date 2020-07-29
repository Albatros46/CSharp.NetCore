using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ShopApp2.WebUI.Models;
using ShopApp2.WebUI.ViewModels;

namespace ShopApp2.WebUI.Controllers
{
    public class ProductController : Controller
    {
          public IActionResult Index()
        {// http://localhost:5000/home/index
            //ViewBag 
            //Model
            //ViewData 
            var product=new Product{Name="Samsung S 8",Price=3000,Description="Güzel Telefon"};
            ViewData["Category"]="Category";
            ViewData["Product"]=product;

            ViewBag.Category = "Telefonlar";
            ViewBag.Product = product;
            return View(product);
        }
         public IActionResult List()
        {// http://localhost:5000/Product/List
        //Burada tanımladığımız list i view de belirtilen List.cshtml de model tanımlarken List olarak tanımlayacağız.
             var products = new List<Product>() { 
                new Product{Name="iPhone X Max",Price=12000,Description="Çok İyi Telefon"},
                new Product{Name="Samsung Galaxy S 10",Price=6000,Description="İyi Telefon"},
                new Product{Name="iPhone 8 Plus",Price=9000,Description="İyi Telefon"},
                new Product{Name="Huawei Me 10 Pro",Price=5000,Description="Güzel Telefon"},
                new Product{Name="Xiaomi Red Me 10",Price=4500,Description="İyi Telefon"}
            };
            var category = new Category { Name="Telefonlar",Description="Telefon Listesi"};
               // ViewBag.Category = category; //List.cshtml de ulaşabiliriz.
            var productviewModel = new ProductViewModel() { 
                Category=category,
                Products=products
            };
            return View(productviewModel);
        }
         public IActionResult Details(int id)
        {// http://localhost:5000/Product/Details
            // Name = "iPhone 7"
            // Price= "4250"
            // Description="Müthiş Telefon"  gibi bilgiler göstermek istiyoruz
            ViewBag.Name = "iPhone 7";
            ViewBag.Price= 4250;
            ViewBag.Description="Müthiş Telefon";
            var p=new Product();
            p.Name="Xaimo Red Me 9";
            p.Price=4000;
            p.Description="Harika Telefon";

            return View(p);
        }      
    }
}