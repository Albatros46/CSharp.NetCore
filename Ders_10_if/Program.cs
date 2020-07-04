using System;

namespace Ders_10_if
{
    class Program
    {// yeni dosya ve proje açmak için -> dotnet new console -o  Ders_0
        static void Main(string[] args)
        {
            Console.Write("1.Sayıyı Girin :");
            int x;
            x=int.Parse(Console.ReadLine());
            Console.Write("2.Sayıyı Girin :");
            int y;
            y=int.Parse(Console.ReadLine());
            if(x>y){
                Console.WriteLine(x+" Sayısı "+y+" sayısından büyüktür.");
            }else if(y>x){
                Console.WriteLine(y+" Sayısı "+x+" sayısından büyüktür.");
            }else if(x==y)
            {
                Console.WriteLine(x+" Sayısı "+y+" eşittir");
            }else
            {
                Console.WriteLine("Tanımlanamadı!");
            }
        }
    }
}
