using System;

namespace Ders_18_Donguler_SayiTahmin
{// Yeni Proje ve dosya olusturmak icin -> dotnet new console -o  Ders_
    class Program
    {
        static void Main(string[] args)
        {
            //Sayı tahmini
            //1-100 arasında bir sayı tutacak ve her tahminde puan azalarak puanlama verecek.
            // var rnd=new Random();//Random sınıfından karakter türet
            //Console.WriteLine(rnd.Next(1,100));//rnd değişkeni ile randam sınıfından 1-100 arasında sayı türet
            int tutulan=(new Random()).Next(1,100);
            int hak=5;
            int tur=0;
            int sayi;
            int puan=100;
            while (hak>0) //şartlar sağlanıp döngüden çıkıncaya akdar while dongusu çalışacak
            {
               Console.Write("Tahmin Sayınızı Giriniz :");
               sayi=int.Parse(Console.ReadLine());
               tur++;
               hak--;//dongu basa her calistiginda hak 1 azalacak
               puan-=10; //her yanlış tahminde 10 ar puan azalacak
               
               if (sayi==tutulan)
               {
                   Console.WriteLine($"{tur}. tur {hak} defada Bildiniz Tebrik Ederim {puan} aldınız.");
                   break;
               }
               else if(sayi>tutulan)
               {
                   if(hak==0)
                   break;
                   Console.WriteLine($"{tur}. tur Tahmininiz Küçültün.");
               }else
               {
                   Console.WriteLine($"{tur}. tur Tahminizi Büyütün.");
               }
               
            }
            Console.WriteLine("OYUN BİTTİ");
        }
    }
}
