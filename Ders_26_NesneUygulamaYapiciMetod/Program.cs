using System;

namespace Ders_26_NesneUygulamaYapiciMetod
{// Yeni Proje ve dosya olusturmak icin -> dotnet new console -o  Ders_
    class Product{
        public int ProductId { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public bool IsApproved { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var p1=new Product();
            Console.WriteLine(p1.ProductId);
            Console.WriteLine(p1.Name);
            Console.WriteLine(p1.Price);
            Console.WriteLine(p1.IsApproved);//Ürün Onaylı mı? kontrol için
        }
    }
}
