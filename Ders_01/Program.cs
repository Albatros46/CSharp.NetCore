using System;

namespace Ders_01
{
    class Program
    {
        static void Main(string[] args)
        {
            String msg=".Net Core ile Web Programlama";

            Console.WriteLine("metnin karakter sayısı : "+msg.Length); //Metinin karakter uzunlugu
            Console.WriteLine(msg.ToLower());//Bütün karakterler küçük harfe çevir
            Console.WriteLine(msg.ToUpper());//Bütün karakterler büyük harfe çevir
            Console.WriteLine(msg.TrimStart());//başındaki Boşluk karakterlerini siler
            Console.WriteLine(msg.Split());// Strng ifade icindeki kelimeleri boşluk karakterinden itibaren ayırarak yazar.
            Console.WriteLine(msg.Split()[0]);//Boşlıklardan itibaren ayırdığı icin her boşluktan sonraki kelime bir dizi elemani gibi davranir o indexteki elemani yazar
            Console.WriteLine(msg[2]);//ikinci karakteri yazar
            Console.WriteLine(msg.StartsWith(".Net"));//msg değişleni .Net ile mi başlıyor true/false deger doner
            Console.WriteLine(msg.EndsWith(".Net"));//msg değişleni .Net ile mi bitiyor true/false deger doner
            Console.WriteLine(msg.Contains(".Net"));//msg içerisinde bu ifade var mı? true/false deger doner
            //Mail adersini kontrol ederken @ var mı yok mu diye kontrol edilip kullaniciya uyari mesaj gonderilebilir.

            Console.WriteLine(msg.IndexOf("Web"));//0 inci indexten baslayarak sayar ve ifadenin konumunu bulur.
            Console.WriteLine(msg.Substring(15,6));//karakterlerin 15. indexten itibaren 3 karakter al
            int index=msg.IndexOf("Web");
            Console.WriteLine(msg.Substring(index));
            Console.WriteLine(msg.Replace(" ","-"));//Boşluk karakterlerini - ile değiştirir
            Console.WriteLine(msg.Replace(" ","+").Replace(".",""));//Boşluk karakterlerini + ile değiş nokta lari da sil
            Console.WriteLine(msg.Insert(0,"..."));//0. indexten itibaren  karakteri ekle
            Console.WriteLine(msg.Insert(msg.Length,"???"));//değişkenin sonundan itibaren ekle
            Console.WriteLine(msg.Remove(15,3));//15 karakterden itibaren 3 karakter sil
        }
    }
}
