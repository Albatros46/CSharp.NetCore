using System.Xml.Linq;
using System;
using System.Collections.Generic;

namespace Ders_36_CollectionsGeneric
{// Yeni Proje ve dosya olusturmak icin -> dotnet new console -o  Ders_
    class Product{
        public string Name { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {   //Generic List
            List<int> plakalar=new List<int>();
            plakalar.Add(10);
            plakalar.Add(34);
            plakalar.Add(35);
            plakalar.Add(46);
            Console.WriteLine("Plakalar--------");
            foreach (var item in plakalar)
            {
                Console.WriteLine(item);
            }
            List<string> sehirler=new List<string>();
            sehirler.Add("Balıkesir");
            sehirler.Add("İstanbul");
            sehirler.Add("İzmir");
            sehirler.Add("Kahramanmaraş");
            sehirler.Add(null);//String ifadelerde null da olabilir
            Console.WriteLine("Şehirler------");
            foreach (var sehir in sehirler)
            {
                Console.WriteLine(sehir);
            }
            List<Product> urunler1=new List<Product>()
            {
                new Product(){Name="iPhone 7 128 gb"},
                new Product(){Name="iPhone 7 Plus 128 gb"},
                new Product(){Name="Samsung Galaxy S 8"},
                new Product(){Name="iPhone 7 128 gb"}                  
            };
             List<Product> urunler2=new List<Product>()
            {
                new Product(){Name="Huavei"},
                new Product(){Name="iPhone 11 Max"},
                new Product(){Name="Samsung S 9"},
                new Product(){Name="iPhone 8 128 gb"}                  
            };
            urunler1.AddRange(urunler2);//urunler2 listesini urunler1 listesine ekliyoruz.
            Console.WriteLine("Ürünler------");
            foreach (var urun in urunler1)
            {
                Console.WriteLine(urun.Name);
            }
            //Lampda expression araciligi ile foreach kullanimi
            urunler1.ForEach(plakalar=>{
                Console.WriteLine(plakalar.Name); //Lampda expression ile kullanim şekli. birden fazla satir olacaksa {} içine yazilabilir.
                });//
            int count=urunler1.Count;
            Console.WriteLine($"Ürünlerin Sayısı :{count}");

            //---------For ile listeleme şekli
            for (int i = 0; i < urunler1.Count; i++)
            {
                Console.WriteLine($"Ürünler :{urunler1[i].Name}");
            }

            //insert items kullanimi bellli bir indexten sonra ekleme yapma
            plakalar.Insert(plakalar.Count,81);//son index ten sonra
            foreach (var x in plakalar)
            {
                Console.WriteLine(x);
            }
            plakalar.Remove(46);//46 degerini silecektir
            //insertrange kullanimi
            urunler1.InsertRange(2,urunler2);//2.indexten itibaren  urunler 2 eklensin
            for (int i = 0; i < urunler1.Count; i++)
            {
                Console.WriteLine($"Ürünler :{urunler1[i].Name}");
            }
        }
    }
}
