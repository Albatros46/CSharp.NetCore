using System;

namespace Ders_07_Operatorler3
{
    class Program
    {
        static void Main(string[] args)
        {//yeni proje ve dosya açmak için --> dotnet new console -o  Ders_0
         // 3-Karşılaştırma Operatorleri (==,!=,<,>,<=,>=,?:)
            //Parola, KullaniciAdi ->Database
            // 12345, MarasliAslan
            int a=5,b=5,c=10,d=4;
            var result=(a==b);//True deger donecek
            Console.WriteLine("result :"+result);
            var result2=(a==c);//false deger doner
            Console.WriteLine("result :"+result2);
            Console.WriteLine("++++++++++++++++");
            String kullaniciAdi="MarasliAslan46";
            String parola="460112";
            var result3=(kullaniciAdi=="servet");
            result3= (parola=="sdsfsdf");
            Console.WriteLine("Kullanıcı adı ve parola :"+result3);
            Console.WriteLine("--------------");
            bool result4=(a!=c);
            Console.WriteLine("a b ye eşit mi? : "+result4);
            result4=(a>c);
            Console.WriteLine(result4);
            result4=(a>=c);
            Console.WriteLine(result4);
            string result5=(a==d)?"eşit":"eşit değil"; //true ise ilk "true" false ise ikinci "false" çalışır.
            Console.WriteLine(result5);

            //----Mantıksal Operatorler
            
        }
    }
}
