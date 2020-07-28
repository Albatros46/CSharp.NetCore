using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ShopApp.WebUI.Controllers
{
    public class ProductController : Controller
    {
        public string Index()
        {//https://localhost:44328/home/index
            return "Product/Index";
        }
        public string List()
        {// https://localhost:44328/product/list
            return "Product/List";
        }
        public string Details()
        {// https://localhost:44328/product/Details
            return "Product/Detailst";
        }
    }
}
