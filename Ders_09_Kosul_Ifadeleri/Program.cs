using System.Runtime.InteropServices.ComTypes;
using System.Runtime.CompilerServices;
using System;

namespace Ders_09_Kosul_Ifadeleri
{
    class Program
    {// yeni dosya ve proje açmak için -> dotnet new console -o  Ders_0
        static void Main(string[] args)
        {
            string username="ServetAKCADAG";
            string password="12345";
            string _username;
            string _passsword;
            Console.Write("Kullancı Adı :");
            _username=Console.ReadLine();
            
             Console.Write("Parola :");
            _passsword=Console.ReadLine();
           
            var IsLonggedin=(username==_username);

            if(username==_username){
                if(password==_passsword)
                Console.WriteLine("Bilgileriniz doğru hoşgeldiniz.");
            }else{
                Console.WriteLine("Parola veya kullanıcı adi yanlış");
            }
            
        }
    }
}
