using System.Linq.Expressions;

using System;

namespace Ders_02_Arrays
{
    class Program
    {
        private const int V = 2;

        static void Main(string[] args)
        {
            //Yeni proje olusturmak icin consol ekranına -->  dotnet new console -o  Ders_02_Arrays
            //Arrays-Diziler
            String msg="Kahramanmaraş Türkiye'nin 46 plakalı dondurması ile meşhur en güzel şehirlerinden biridir.";
            var result=msg.Split();//msg değişken degerini boşluk karakterlerinden itibaren bölerek her cümleyi dizi elemani olarak varsayiyor

            Console.WriteLine(result); //result değişkenindeki boşlktan sonraki her kelime bir dizi ifade eder
            Console.WriteLine(result[0]);
            Console.WriteLine(result[1]);
            Console.WriteLine(result[2]);
            Console.WriteLine(result[9]);
            Console.WriteLine(result[3]);
            Console.WriteLine("-------------------");
            Console.WriteLine(msg[0]); //msg değişkenindeki her karakter bir dizi ifade eder
            Console.WriteLine(msg[1]);
            Console.WriteLine(msg[2]);
            Console.WriteLine(msg[8]);
            Console.WriteLine(msg[9]);
            Console.WriteLine("----------------------");
        //    string[] isimler=new string[5]; //5 elemanlı  isimler dizisi
         //   isimler[0]="Servet";
         //   isimler[1]="Ahmet";
         //   isimler[2]="Akif";
         //   isimler[3]="Oğuz";
         //   isimler[4]="Rukiye";
            String[] isimler={"Servet","Ahmet","Akif","Oğuz","Rukiye"}; //şeklinde de dizi atanabilir.
            //olmayan index numarasına erişim yapmak istersek index out of range hatası alırız.
            int[] numaralar=new int[5];
            numaralar[0]=101;
            numaralar[1]=102;
            numaralar[2]=103;
            numaralar[3]=104;
            numaralar[4]=105;
            Console.WriteLine($"öğrenci adı : {isimler[0]} ve numarası : {numaralar[0]}");
            Console.WriteLine($"öğrenci adı : {isimler[1]} ve numarası : {numaralar[1]}");
            Console.WriteLine($"öğrenci adı : {isimler[2]} ve numarası : {numaralar[2]}");
            Console.WriteLine($"öğrenci adı : {isimler[3]} ve numarası : {numaralar[3]}");
            Console.WriteLine($"öğrenci adı : {isimler[4]} ve numarası : {numaralar[4]}");
        }
    }
}
