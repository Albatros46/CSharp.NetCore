using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopApp.WebUI.Models
{
    public class Product
    {
        public string Name { get; set; }//Ürün Adı
        public double Price { get; set; }//Ürün Fiyatı
        public string Description { get; set; }//Ürün Hakkında
    }
}
