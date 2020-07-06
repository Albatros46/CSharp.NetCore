using Internal;
using System.Runtime;
using System;

namespace Ders_14_Donguler_Uygulama1
{
    class Program
    {// Yeni Proje ve dosya olusturmak icin -> dotnet new console -o  Ders_
        static void Main(string[] args)
        {//1-Kullanıcıdan başlangıç, bitiş ve artış miktarı isteyerek aralıktaki sayıları ekrana yazdıracak
            
           
            Console.WriteLine("Başlangıç sayısı bitiş sayısından küçük olmalı..");
            Console.Write("Başlangıç sayısını girin :");
            int basla=int.Parse(Console.ReadLine());
            Console.Write("Bitiş sayısını girin :");
            int bitir=int.Parse(Console.ReadLine());
            Console.Write("Artış miktarını girin :");
            int artis=int.Parse(Console.ReadLine());
            int sayac=0;
            for(int i=basla; i<=bitir; i=i+artis){
                sayac++;
                Console.WriteLine($"{sayac}.sayı = "+i);
            }
        //Dizilerle örnek
        int[] sayilar={1,3,6,9,12,7,23,67,90,120};
        //2-Sayılar dizisinden 3 ün katı olanları listele
        for (int i=0; i<sayilar.Length; i++){
            if(sayilar[i]%3==0)
            Console.WriteLine("Sayılar dizisinde 3 ün katı :"+sayilar[i]);
        }
        //3-Sayılar dizisindeki sayıların toplamı kaçtir
        int toplam=0;
        long carp=1;
        for(int i=0; i<sayilar.Length;i++){
            toplam+=sayilar[i];
            carp*=sayilar[i];
        }
        Console.WriteLine("Toplam Sayı :"+toplam);
        Console.WriteLine("Sayıların Çarpımı :"+carp);
        //4-Sayılar dizisindeki tek sayıların karesi kaçtır
        for(int i=0;i<sayilar.Length;i++){
                if(sayilar[i]%2==1)
                    Console.WriteLine("Sayılar dizsindeki tek sayıların karesi :"+sayilar[i]*sayilar[i]);
            }
        }
        //5-Arabalar dizsindeki en az karakterli araç izimlerini yazdır.
        string[] araba={"Mercedes","Audi","Ford","Toyota","Opel","Mitsubishi","Land Rover","Volkswagen","Tata","Mazda","Subaru"}
        for(int i = 0; i < araba.length; i++)
        {
            if(araba[i].Length>=5)
                Console.writeline(araba[i]);
        }
    }
}
