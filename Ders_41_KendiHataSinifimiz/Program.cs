using System;

namespace Ders_41_KendiHataSinifimiz
{// Yeni Proje ve dosya olusturmak icin -> dotnet new console -o  Ders_
   //Exception
    class LoginException:Exception{
        public LoginException(string message):base(message)
        {
            //LoginException Exception türetildiği için Exception tüm özelliklerine sahiptir.
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Login("ServetAKÇADAĞ","12345634");
                Console.WriteLine("Giriş Başarlı...");
            }
            catch (LoginException ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }
        static void Login(string username, string password){
            if (username.Contains(" "))
                throw new LoginException("Username boşluk içeremez.");
            
            if(password.Length<8)
                throw new LoginException("Parola 8 karakterden az olamaz!");
        }
    }
}
