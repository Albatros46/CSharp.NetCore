using System;

namespace Ders_33_NesneInterface
{// Yeni Proje ve dosya olusturmak icin -> dotnet new console -o  Ders_
    interface IPersonel
    {
        string adsoyad{get; set;} //public vs gibi erişim belirteci kullanilmaz
        string adres{get; set;}
        string departman { get; set; }
        void bilgi();//gövdesiz metod tanımlariz.Interface içinde olduğundan varsayılan olarak abstract class tırlar

    }
    class Yonetici:IPersonel
    {
        public string adsoyad{get;set; }
        public string adres{get;set; }
        public string departman{get;set; }
        public void bilgi(){
            Console.WriteLine($"{this.adsoyad} isimli personnel {this.departman} departmanında görevlidir.");
        }
    }
    class Calisan
    {
        
    }
    class Program//Interface
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
