using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ShopApp.WebUI.Controllers
{
    // https://localhost:44328/
    public class HomeController : Controller
    {
        public IActionResult Index()
        {//https://localhost:44328/home/index
            return View();//view donecek ise IActionResult dan türetilen respons olmalı
        }
        public IActionResult About()
        {// https://localhost:44328/home/about
            return View();
        }
    }
}
