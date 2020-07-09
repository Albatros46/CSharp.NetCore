using System;

namespace Ders_24_NesneClassAsiriYuklenme
{// Yeni Proje ve dosya olusturmak icin -> dotnet new console -o  Ders_
/*
    Bazı durumlarda aynı isimde birden çok metod tanımlanabilir
     bu gibi durumlar aşırı yüklenme(overloading) sebep olabilir. 
*/
class Islem{
    public int Toplam(int a, int b){
        return a+b;
    }
     public int Toplam(int a, int b,int c){
        return a+b+c;
    }
     public int Toplam(int a, int b,int c,int d){
        return a+b+c+d;
    }
}
    class Program
    {
        static void Main(string[] args)

        {
            var islem=new Islem();
            Console.WriteLine(islem.Toplam(20,30));
        }
    }
}
