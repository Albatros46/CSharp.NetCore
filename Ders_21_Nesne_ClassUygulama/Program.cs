using System;

namespace Ders_21_Nesne_ClassUygulama
{// Yeni Proje ve dosya olusturmak icin -> dotnet new console -o  Ders_
   
    class Product{
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Product class-> name, price, description
                Sınırsız sayıda ürün bilgisini alıp bir dizi icinde saklayacağız
                Ürün adetini Kullanıcı belirtecek
                Eklenen ürünleri listeleyecek
            */
            Console.Write("Adet :");
            int adet=int.Parse(Console.ReadLine());

            Product[] products=new Product[adet];
            int i=0;
            Product prd;//dongu de istenecek veriler prd class a aktarilacak dongu her calistiğinda eski ürünler silinmeden devam edecek
            do
            {
                prd=new Product();
                Console.Write("Ürün Adı :");
                prd.Name=Console.ReadLine();

                Console.Write("Ürün Fiyatı :");
                prd.Price=double.Parse(Console.ReadLine());

                Console.Write("Ürün Hakkında :");
                prd.Description=Console.ReadLine();

                products[i]=prd;
                i++;//Dongu her dondugunde i index artırılacak

            } while (adet!=i); //veya adet>i
            Console.WriteLine("--------Ürün Listesi-----");
            for (int a = 0; a< products.Length; a++)
            {
                Console.WriteLine($"Ürün Adı:{products[a].Name} Fiyatı:{products[a].Price} Hakkında:{products[a].Description}");
            }

            //******************************
            Console.WriteLine("******************************");
            Console.WriteLine("foreach dongusu ile listeleme");
            foreach (var item in products) //products class daki veriler item e aktariliyor
            {
                Console.WriteLine($"Ürün Adı:{item.Name} Fiyatı:{item.Price} Hakkında:{item.Description}");
            }
        }
    }
}
