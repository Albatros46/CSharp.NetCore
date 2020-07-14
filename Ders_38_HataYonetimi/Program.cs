using System;

namespace Ders_38_HataYonetimi
{// Yeni Proje ve dosya olusturmak icin -> dotnet new console -o  Ders_
    class Product{
        public string  Name { get; set; }

    }
    class Program
    {
        static void Main(string[] args)
        {//Exception class dan türetildiği icin exception ile yakalayabiliriz.
         //Exception
         //Unhandled exception. System.FormatException: 
         //Unhandled exception. System.DivideByZeroException: 
         //Unhandled exception. System.NullReferenceException:
         try//Hata olabilecek kodlarimizi try-catch bloklari arasina yazacagiz.
         {
             Console.Write("1.Sayı Giriniz :");
             int sayi1=int.Parse(Console.ReadLine());
             Console.Write("2.Sayı Giriniz :");
             int sayi2=int.Parse(Console.ReadLine());
             var sonuc=sayi1/sayi2;
             Console.WriteLine($"{sayi1}/{sayi2}={sonuc}",sayi1,sayi2,sonuc);
         }
          catch (DivideByZeroException ex)//Exception Handling, bir sayıyı 0 a bölmek istendiğinde
          {
              Console.WriteLine("Hiçbir sayı sıfır(0)'a bölünemez.");
              Console.WriteLine(ex.Message);
          }
          catch(FormatException ex)//sayı yerine harf girildiğinde
          {
              Console.WriteLine("Sayısal karakter dışında deger girdiniz.");
              Console.WriteLine(ex.Message);
          }
         catch(Exception e){
             Console.WriteLine("Bir Hata Oluştu..");
             Console.WriteLine(e.Message);
         }
         finally{
             //Hata olsun veya olmasın kesinlikle calişmasini istegimiz kodlar
             Console.WriteLine("Finally Blogu calisti.");
         }
         //------------------
         // Product p=null;
         // Console.Write(p.Name);//Unhandled exception. System.NullReferenceException: product nesnesi null(boş) oldugu için yazdıracak obje yok hata verir
        }
    }
}
