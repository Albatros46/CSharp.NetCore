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
            return View(); //view donecek ise IActionResult dan türetilen respons olmalı
            //return "Home/Index"; //string ifade dondururken
        }
         public IActionResult About()
        {// http://localhost:5000/home/about
            return View();
        }
    }
}