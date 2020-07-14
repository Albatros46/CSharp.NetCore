using System;

namespace Ders_38_HataYonetimi
{// Yeni Proje ve dosya olusturmak icin -> dotnet new console -o  Ders_
    class Product{
        public string  Name { get; set; }

    }
    class Program
    {
        static void Main(string[] args)
        {//Exception ve Exception Handling
        //Exception
        //Unhandled exception. System.FormatException: 
        //Unhandled exception. System.DivideByZeroException: 
        //Unhandled exception. System.NullReferenceException:
            Console.Write("1.Sayı Giriniz :");
            int sayi1=int.Parse(Console.ReadLine());
            Console.Write("2.Sayı Giriniz :");
            int sayi2=int.Parse(Console.ReadLine());
            var sonuc=sayi1/sayi2;
            

            //------------------
            Product p=null;
            Console.Write(p.Name);//Unhandled exception. System.NullReferenceException: product nesnesi null(boş) oldugu için yazdıracak obje yok hata verir
        }
    }
}
