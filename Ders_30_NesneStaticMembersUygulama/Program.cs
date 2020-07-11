using System;

namespace Ders_30_NesneStaticMembersUygulama
{// Yeni Proje ve dosya olusturmak icin -> dotnet new console -o  Ders_
    class Product//Product objesi olusturuldu.
    {
        public int ProductId { get; set; }//UrunId
        public string  ProductName { get; set; }//UrunAdi
        public double Price  { get; set; }//Fiyat
        public bool  IsApproved { get; set; }//Onaylımı
    }
    static class ProductManager //veritabani mantığını burda gosterecegiz.
    {
        static Product[] Products; //public olmadiği icin disaridan erisim olmayacak metod ile erisim olacak
        static ProductManager Program()//constructor ismi public veya static olmayacak
        {
            Products=new Product[5];//product dizini 5 elemanlı olacak
            Products[0]=new Product{ProductId=1,ProductName="Iphone 7",Price=4250,IsApproved=true};
            Products[1]=new Product{ProductId=2,ProductName="Iphone 6",Price=2850,IsApproved=false};
            Products[2]=new Product{ProductId=3,ProductName="Iphone 7 Plus",Price=4250,IsApproved=true};
            Products[3]=new Product{ProductId=4,ProductName="Samsung Galaksi",Price=2500,IsApproved=false};
            Products[4]=new Product{ProductId=5,ProductName="Iphone 8 X Max",Price=7500,IsApproved=true};
        }
        public static Product[] GetProducts(){
            return Products; //ProductManager deki listeye metod araciliği ile erisecegiz
        }
        public static Product GetProductById(int id){
            //disaridan girilen id ye gore ürün getirecek
            Product product=null;
            foreach (var p in Products)
            {
                if(p.ProductId==id)
                    product=p;
            }
            return product;
        }
        public static Product GetProductByName(string name){
            Product product=null;
            foreach (var p in Products)
            {
                if (p.ProductName.Contains(name.ToLower()))
                {
                    product=p;
                    break;//bulduğu ilk kayıtta dursun
                }
            }

            return product;

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var product=ProductManager.GetProductById(2); //id 2 olan urun getirilsin
            Console.WriteLine($"Urun Id:{product.ProductId} Urun Adı :{product.ProductName} Fiyatı :{product.Price} Onalı Mı? {product.IsApproved}");
            Console.WriteLine("----------------------------------");
            var product1=ProductManager.GetProductByName("Iphone 7 Plus");
            Console.WriteLine($"Urun Id:{product1.ProductId} Urun Adı :{product1.ProductName} Fiyatı :{product1.Price} Onalı Mı? {product1.IsApproved}");
            Console.WriteLine("----------------------------------");
            var products=ProductManager.GetProducts();
            foreach (var p1 in products)
            {
               Console.WriteLine($"Urun Id:{p1.ProductId} Urun Adı :{p1.ProductName} Fiyatı :{p1.Price} Onalı Mı? {p1.IsApproved}");
            }
        }
    }
}
