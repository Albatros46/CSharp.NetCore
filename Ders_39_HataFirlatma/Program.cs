using System.Linq;
using System;

namespace Ders_39_HataFirlatma
{// Yeni Proje ve dosya olusturmak icin -> dotnet new console -o  Ders_
    class Person{
        public string _name;
        public string Name{
            get{
                return _name;
            }
            set{
                if (value.Length>15)
                {
                    throw new Exception("Ad alanı için en fazla 15 karakter girebilirsiniz!");
                }
                _name=value;
            }
        }

    }
    class Program
    {
        static void checked_password(string password){
            if (password.Length<8 || password.Length>15){
                throw new Exception("Parola 8 karakterden az ve 15 karakterden fazla olamaz!");
                if (!password.Any(char.IsDigit))//Any ile her karakter kontorl edilecek bir karakterin rakam olmasını kontrol edeceğiz.
                {
                    throw new Exception("Parola en az bir tane rakam içermelidir!");
                }
                if (!password.Any(char.IsLetter))//Any ile her karakter kontorl edilecek bir karakterin harf olmasını kontrol edeceğiz.
                {
                    throw new Exception("Parola en az bir tane harf içermelidir!");
                }
            }
        }
        static void Main(string[] args)
        {//Exception Handling: kendi hata kodlarımızı yazalim.
            // int sayi=10;
            // if (sayi>5)
            //     throw new Exception("Sayi 5 den buyuk olamaz");
             Console.Write("Parolanızı Girin :");
             string parola=Console.ReadLine();
            try
            {
                checked_password(parola);
                Console.WriteLine("Parola Geçerli");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);   
            }

            try
            {
                 var p=new Person();
                 p.Name="Servet                                          ";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
