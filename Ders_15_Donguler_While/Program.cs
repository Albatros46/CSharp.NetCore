using System;

namespace Ders_15_Donguler_While
{
    class Program
    {// Yeni Proje ve dosya olusturmak icin -> dotnet new console -o  Ders_
    //While dongusu
        static void Main(string[] args)
        {
            //While 
            int i=0;
            while(i<10){
                if (i%2==0)
                {
                    Console.WriteLine($"Çift Sayı : {i}");
                    i++;
                }else{
                     Console.WriteLine($"Tek Sayı : {i}");
                    i++;
                }
                
            }
            string name="";
            while (string.IsNullOrEmpty(name))//name değişlenini boş mu kontrol ediyor.
            {//şartlar olustuktan sonra iç kodlar çalışır
                Console.Write("İsminiz :"+name);
                name=Console.ReadLine();
            }
            Console.WriteLine("Merhaba "+name);
            Console.WriteLine($"Merhaba {name}");
            Console.WriteLine("----do-while dongusu-----");
            //----do-while dongusu
            string isim="";
            do//kodlar calıştıktan sonra şart gerçekleşir
            {
                Console.Write("İsminiz :"+isim);
                isim=Console.ReadLine();
            } while (string.IsNullOrEmpty(isim));
        }
    }
}
