using System;
using System.Collections.Generic;

namespace Ders_40_HataFirlatmaUygulama
{// Yeni Proje ve dosya olusturmak icin -> dotnet new console -o  Ders_
/*
      "1","2","5a","10b","abc","10","50"
    1-Listeden sayılsal ifadeleri bulunuz.
    2-Kullanıcı q degerini girmedikçe sayısal degeri bulana kadar hata mesajı verecek.
    3-Girilen parola içinde türkçe karakter araması yapacak
*/
    class Program
    {
        static void Main(string[] args)
        {
            //1-Soru....
            // var liste=new List<string>(){
            //     "1","2","5a","10b","abc","10","50"
            // };
            // foreach (var item in liste)
            // {
            //     try
            //     {
            //         int a=int.Parse(item);
            //         Console.WriteLine(a);
            //     }
            //     catch (Exception)
            //     {// 
            //         continue;
            //     }
            // }
            //2-Soru.....
            while (true)
            {
                Console.Write("Sayı :");
                string input=Console.ReadLine();
                if (input=="q")
                    break;
                    
                    try
                    {
                        int sayi=int.Parse(input);   
                        Console.WriteLine("Girilen Değer: {0}",sayi);
                    }
                    catch (System.Exception)
                    {
                        Console.WriteLine("Geçersiz Sayı.");
                        continue;
                    }
                    
            }
            //3-Girilen parola içinden türkçe karakter sorgulaması
            Console.Write("Parola :");
            string parola=Console.ReadLine();
            try
            {
                CheckPassword(parola);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        static void CheckPassword(string parola){
            string turkce_karakter="ş,Ş,ı,İ,ğ,Ğ,ü,Ü,ç,Ç,ö,Ö";
            foreach (var karakter in parola)
            {
                if(turkce_karakter.IndexOf(karakter)>-1){
                    throw new Exception("Parola Tükçe Karakter İçeremez");
                }
            }
            Console.WriteLine("Geçerli Parola...");
        }
    }
}
