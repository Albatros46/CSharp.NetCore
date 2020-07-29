using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ShopApp2.WebUI.Models;
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
            return View();
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