using System;

namespace Ders_17_Donguler_BreakContinue
{// Yeni Proje ve dosya olusturmak icin -> dotnet new console -o  Ders_
    class Program
    {
        static void Main(string[] args)
        {//Donguler : break-continue
            string name="Servet AKÇADAĞ";
            for (int i = 0; i < name.Length; i++)
            {
                if(name[i]==' ') //dongu ' ' ile karşılaştığı an duracak
              // break;
                continue; //' ' olduğu yeri atlayıp dongunun kaldığı yerden devam etmesini sağlayacak
                Console.WriteLine(name[i]);
            }
            //------------------------------
            Console.WriteLine("While dongusu ile-----------");
            int x=0;
            while (x<5)
            {
                if(x==3)
                break;//3 ü gördüğü an donguden çıkar
                Console.WriteLine($"X in degeri {x}");
                x++;
            }
            Console.WriteLine("------------------------");
            //Asal sayı uygulaması
            Console.WriteLine("Asal sayı uygulaması");
            bool asalmi=true;
            Console.Write("Bir Sayı Giriniz : ");
            int a=int.Parse(Console.ReadLine());
            if (a==1)
            asalmi=false;
                
                for (int i = 2; i < a; i++)
                {
                    if(a%i==0){
                        asalmi=false;
                        
                        break;
                    }
                    
                }
                if (asalmi)
                    Console.WriteLine(a+" Sayı Asaldır.");
                 else
                    Console.WriteLine(a+" sayı asal değildir.");
        }
    }
}
