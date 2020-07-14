using System;

namespace Ders_39_HataFirlatma
{// Yeni Proje ve dosya olusturmak icin -> dotnet new console -o  Ders_
    class Program
    {
        static void checked_password(string pasword){
            if (pasword.Length<8 && pasword.Length>15){
                throw new Exception("Parola 8 karakterden az ve 15 karakterden fazla olamaz!");
            }
        }
        static void Main(string[] args)
        {//Exception Handling: kendi hata kodlarımızı yazalim.
            int sayi=10;
            if (sayi>5)
                throw new Exception("Sayi 5 den buyuk olamaz");
        }
    }
}
