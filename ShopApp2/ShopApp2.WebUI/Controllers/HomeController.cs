using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ShopApp2.WebUI.Controllers
{
    
    public class HomeController:Controller //Microsoft.AspNetCore.Mvc içindeki controller i miras alacak
    {//http://localhost:5002/ artık homecontroller 
        public IActionResult Index()
        {// http://localhost:5000/home/index
            int saat=DateTime.Now.Hour;
            string mesaj=saat > 12 ? "İyi Günler" : "Günaydın";
             ViewBag.Greeting = mesaj;
            ViewBag.UserName = "Servet";
            return View(); //view donecek ise IActionResult dan türetilen respons olmalı
            //return "Home/Index"; //string ifade dondururken
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