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
        public string Index()
        {//https://localhost:44328/home/index
            return "Home/Index";
        }
        public string About()
        {// https://localhost:44328/home/about
            return "Home/About";
        }
    }
}
