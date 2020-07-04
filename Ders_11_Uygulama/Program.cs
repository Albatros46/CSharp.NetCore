using System;

namespace Ders_11_Uygulama
{
    class Program
    {
        static void Main(string[] args)
        {// Yeni Proje ve dosya olusturmak icin -> dotnet new console -o  Ders_0
         //Kullanıcıdıdan ad soyad bilgisi isteyip 18 den büyük ve eğitim seviyesine gore Ehliyetdurumunu sorgulasın
            Console.WriteLine("--Ehliyet Durumu Sorgulama----");
            Console.Write("Ad Soyad : ");
            String ad_soyad=Console.ReadLine(); 
            Console.Write("Yaş      :");
            int yas=int.Parse(Console.ReadLine());
            Console.Write("Eğitim Seviyesi :");
            string es=Console.ReadLine();
            if(yas>=18){
                //Eğitim bilgisini kontrol edecegiz.
                if(es=="Lise" || es=="Üniversite"){
                    Console.WriteLine($"{ad_soyad} Ehliyet Alabilirsiniz...");
                }else
                {
                    Console.WriteLine($"{ad_soyad} Ehliyet alamak için eğitim durumunuz yetersiz");
                }
            }else
            {
                Console.WriteLine("Ehliyet almak için en az 18 yaşında olmalısınız!");
            }
            Console.WriteLine("----------------------");
            Console.WriteLine("--Girilen 3 sayıdan büyüğü bulalım----");
            //girilen üç sayıdan en büyüğünü bulalım
            Console.Write("a :");
            int a=int.Parse(Console.ReadLine());
            Console.Write("b :");
            int b=int.Parse(Console.ReadLine());
            Console.Write("c :");
            int c=int.Parse(Console.ReadLine());
            if(a>b && a>c)
                 Console.WriteLine(a+" sayısı "+b+" ve "+c+" sayılarından büyüktür.");
            else if(b>a && b>c)
                 Console.WriteLine(b+" sayısı "+a+" ve "+c+" sayılarından büyüktür.");
            else if(c>a && c>b)
                 Console.WriteLine(c+" sayısı "+a+" ve "+b+" sayılarından büyüktür.");
            else
                 Console.WriteLine("Tanımlanamadı!");
            Console.WriteLine("------------------------------");
        //Trafiğe çıkış tarih bilgisi alınan bir aracın yıllık bakımını hesaplayalım
        //1.Bakım-> 1. yıl    2.Bakım-> 2. yıl    3.Bakım-> 3. yıl   
        // Süre hesabını alınan gün, ay , yıl bilgisine gore yapacagiz.
         Console.WriteLine("-----Araç Bakım Hesaplama----");
         Console.Write("Ad Soyad    :");
         string adsoyad=Console.ReadLine();
         Console.Write("Araç Plakası:");
         string plaka=Console.ReadLine();
         Console.Write("Trafiğe Çıkış Yıl:");
         int yil=int.Parse(Console.ReadLine());
         Console.Write("Trafiğe Çıkış Ay:");
         int ay=int.Parse(Console.ReadLine());
         Console.Write("Trafiğe Çıkış Gun:");
         int gun=int.Parse(Console.ReadLine());
         int toplamGun=(DateTime.Now-new DateTime(yil,ay,gun)).Days; //timeSpan deger int olarak donusturulecek
        if(toplamGun<=365)
            Console.WriteLine($"Sayın {adsoyad} {gun}/{ay}/{yil} çıkış tarihli ve {plaka} plakalı aracınızın 1.Servis Bakımı Geldi...");
        else if(toplamGun<=365 && toplamGun<=365*2)
            Console.WriteLine($"Sayın {adsoyad} {gun}/{ay}/{yil} çıkış tarihli ve {plaka} plakalı aracınızın 2.Servis Bakımı Geldi...");
        else if(toplamGun<=365 && toplamGun<=365*3)
            Console.WriteLine($"Sayın {adsoyad} {gun}/{ay}/{yil} çıkış tarihli ve {plaka} plakalı aracınızın 3.Servis Bakımı Geldi...");
         else
         Console.WriteLine($"Sayın {adsoyad} Yanlış Bilgi Girdiniz..."); 
        }
    }
}
