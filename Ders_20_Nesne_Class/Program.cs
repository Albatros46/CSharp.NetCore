using System;

namespace Ders_20_Nesne_Class
{
    class ogrenci{
        //Ogrenci adinda nesne olusturduk
        public int OgrnNo { get; set; }
        public string AdSoyad { get; set; }
        public string Sube { get; set; }
    }
    class Program
    {// Yeni Proje ve dosya olusturmak icin -> dotnet new console -o  Ders_
        static void Main(string[] args)
        {
            int[] ogrno={100,200,300,400,500};
            string[] adsoyad={"Servet AKÇADAĞ","Ahmet GANDIRALI",
            "Akif AKÇADAĞ","Oğuz AKÇADAĞ","Rukiye AKÇADAĞ"};
            string[] sube={"10A","11B","12A","12B","13A"};
            Console.WriteLine($"No:{ogrno[0]} Ad Soyad:{adsoyad[0]} Şube:{sube[0]}");
            Console.WriteLine($"No:{ogrno[1]} Ad Soyad:{adsoyad[1]} Şube:{sube[1]}");
            Console.WriteLine($"No:{ogrno[2]} Ad Soyad:{adsoyad[2]} Şube:{sube[2]}");
            Console.WriteLine($"No:{ogrno[3]} Ad Soyad:{adsoyad[3]} Şube:{sube[3]}");
            Console.WriteLine($"No:{ogrno[4]} Ad Soyad:{adsoyad[4]} Şube:{sube[4]}");
            //-------------------------------
            Console.WriteLine("-------Class türedilerek yapalım----------");
            ogrenci ogr1=new ogrenci();
            ogr1.OgrnNo=101;
            ogr1.AdSoyad="Servet AKÇADAĞ";
            ogr1.Sube="12B";

            ogrenci ogr2=new ogrenci();
            ogr2.OgrnNo=102;
            ogr2.AdSoyad="Celal Bingöl";
            ogr2.Sube="12B";

            ogrenci ogr3=new ogrenci();
            ogr3.OgrnNo=103;
            ogr3.AdSoyad="Ahmet Koza";
            ogr3.Sube="12B";

            ogrenci ogr4=new ogrenci();
            ogr4.OgrnNo=104;
            ogr4.AdSoyad="Sefa ERGİN";
            ogr4.Sube="12B";

            Console.WriteLine($"No:{ogr1.OgrnNo} Ad Soyad:{ogr1.AdSoyad} Şube:{ogr1.Sube}");
            Console.WriteLine($"No:{ogr2.OgrnNo} Ad Soyad:{ogr2.AdSoyad} Şube:{ogr2.Sube}");
            Console.WriteLine($"No:{ogr3.OgrnNo} Ad Soyad:{ogr3.AdSoyad} Şube:{ogr3.Sube}");
            Console.WriteLine($"No:{ogr4.OgrnNo} Ad Soyad:{ogr4.AdSoyad} Şube:{ogr4.Sube}");
        }
    }
}
