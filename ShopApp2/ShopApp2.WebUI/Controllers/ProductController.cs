using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ShopApp2.WebUI.Controllers
{
    public class ProductController : Controller
    {
          public string Index()
        {// http://localhost:5000/home/index
            return "Product/Index";
        }
         public string List()
        {// http://localhost:5000/Product/List
            return "Product/List";
        }
         public string Details(int id)
        {// http://localhost:5000/Product/Details
            return "Product/Detailst/"+id;
        }      
    }
}