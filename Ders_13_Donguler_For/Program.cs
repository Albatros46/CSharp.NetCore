using System;

namespace Ders_13_Donguler_For
{
    class Program
    {// Yeni Proje ve dosya olusturmak icin -> dotnet new console -o  Ders_
        static void Main(string[] args)
        { //for dongusu
           /* for(int i=0; i<100; i++){
                Console.WriteLine(i);
            }
            */
           /*  for(int x=0; x<10; x++){
                Console.WriteLine("For dongüsü kullanımı");
            }
            */
            //for dongusu ile mod alma
            Console.WriteLine("----Mod alma---");
            int toplam=0;
             for(int i=0; i<100; i++){
                 if(i%2==0)
                    {
                        toplam+=i;
                    }
                    
                }
                Console.WriteLine(toplam);
            Console.WriteLine("For dungusu ile Dizi ler kullanımı");
            string[] isimler={"Servet","Ahmet","Akif","Oğuz","Rukiye"};
            for(int i=0; i<isimler.Length; i++){
                Console.WriteLine(isimler[i]);
            }
        }
    }
}
