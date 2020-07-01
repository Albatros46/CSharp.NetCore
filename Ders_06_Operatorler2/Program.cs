using System;

namespace Ders_06_Operatorler2
{
    class Program
    {
        static void Main(string[] args)
        {//yeni proje ve dosya açmak için --> dotnet new console -o  Ders_0
            /*
            a- Kullanicidan aldigimiz iki sayinin çarpımı ile x,y,z degerlerinin toplamının farkı
            b- Kullanicidan aldigimiz bir sayinin tek/çift mi?
            c- x+y+z toplamlarinin mod 3 kaçtır
            d- y nin x. kuvveti
            */
            int x=2,y=5,z=10;
            Console.Write("1. Sayi :");
            int sayi1=int.Parse(Console.ReadLine());
             Console.Write("2. Sayi :");
            int sayi2=int.Parse(Console.ReadLine());
            int sonuc=(sayi1*sayi2)-(x+y+z);
            Console.WriteLine("Sonuc :"+sonuc);
            Console.WriteLine("-------------------");
            Console.Write("Sayi :");
            int sayi=int.Parse(Console.ReadLine());
            bool sonuc1=(sayi%2)==0?true:false;
             // String sonuc1=(sayi%2)==0?"çift":"tek";
            Console.WriteLine($"Giriken Sayi Çift Mi? :{sonuc1}");

            int mod=(x+y+z)%3;
            Console.WriteLine("z+y+z mod 3 : "+mod);

            var sonuc2=Math.Pow(y,x);//Kuvvet alma
            Console.WriteLine("X üssü Y :"+sonuc2);
        }
    }
}
