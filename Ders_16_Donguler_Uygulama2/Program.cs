using System.Runtime.InteropServices;
using System.ComponentModel;
using System;

namespace Ders_16_Donguler_Uygulama2
{// Yeni Proje ve dosya olusturmak icin -> dotnet new console -o  Ders_
    class Program
    {
        static void Main(string[] args)
        {
             //Sınırsız sayıda ürün ismini bir dizi içinde saklamak
             //Ürün Adetini kullanıcı belirlesin
             //Eklenen ürünleri listelensin

             //while, array
             Console.Write("Adet :"); //adet bilgisi istendi
             int adet=int.Parse(Console.ReadLine());
             
             string[] urunler=new string[adet];
             int i=0; //sayac belirledik
             do
             {
                 Console.Write($"{i+1}.Ürün Adı :");
                 urunler[i]=Console.ReadLine();
                 i++;
             } while (adet!=i);//sayac girilen adet sayısı kadar devam edecek
            Console.WriteLine("Ürünler Listeleniyor...");
            for (int a = 0; a < urunler.Length; a++)
            {
                Console.WriteLine($"{a+1}. Ürün Adı : "+urunler[a]);
            }
        }
    }
}
