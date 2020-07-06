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
        }
    }
}
