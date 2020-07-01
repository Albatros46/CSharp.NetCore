using System.Xml.Linq;
using System.Transactions;
using System.Linq;
using System.Collections.Specialized;
using System.Collections;
using System;

namespace Ders_03_ArrayMetodlari
{
    class Program
    {
        static void Main(string[] args)
        {// Yeni proje ve klasör için --> dotnet new console -o  Ders_03_ArrayMetodlari
         // Array Metodları
         string[] sehirler={"Kahramanmaras","Ankara","Antalya","İstanbul","Gaziantep","Zonguldak","Eskişehir","Erzincan"};
        Console.WriteLine(sehirler[0]);
        sehirler.SetValue("Kahramanmaraş",0);
        Console.WriteLine(sehirler[0]);
        Console.WriteLine(Array.IndexOf(sehirler,"Ankara"));
        Console.WriteLine(sehirler.Length);
        Array.Sort(sehirler);//alfabeye gore siralama yapacak
        int[] plakalar={34,35,45,46,47,23,70,80,1,6};
        Array.Sort(plakalar);
        Console.WriteLine(sehirler.GetValue(0));
        Console.WriteLine(plakalar.GetValue(0));

        Array.Reverse(sehirler); //Sıralamayı terse cevirir
        Array.Reverse(plakalar); //Sıralamayı terse cevirir
        Console.WriteLine(sehirler.GetValue(0));
        Console.WriteLine(plakalar.GetValue(0));

        Array.Clear(sehirler,0,2);
        Array.Clear(plakalar,3,2);
        Console.WriteLine(sehirler.GetValue(0));
        Console.WriteLine(plakalar.GetValue(0));

        Console.WriteLine(sehirler[^1]);//dizide sondaki elemani yazdiracak
        Console.WriteLine(sehirler[^2]);//dizide sondan ikinci elemani yazdiracak
        var result = sehirler[1..4]; //sehirler dizisinden 1 ile 3. elenlari result degiskenine atadik
            foreach(var sehir in result){
                Console.WriteLine(sehir); //result degiskenindeki degerlin hepsini burda yazdiriyoruz
            }
        var result2=sehirler[1..]; //1 den baslayip sona doğru gider
         foreach(var sehir in result2){
                Console.WriteLine("result2 1. indexten sona kadar :"+sehir); //result degiskenindeki degerlin hepsini burda yazdiriyoruz
            }
        var result3=sehirler[..5]; //5. index e kadar olanlari yazar
         foreach(var sehir in result3){
                Console.WriteLine("result3, 5. index e kadar olanlar :"+sehir); //result degiskenindeki degerlin hepsini burda yazdiriyoruz
            }
        }
    }
}
