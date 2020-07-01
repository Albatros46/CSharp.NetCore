using System;

namespace Ders_05_Operatorler
{
    class Program
    {
        static void Main(string[] args)
        {//yeni proje ve dosya açmak için --> dotnet new console -o  Ders_0
        /*
        1-Aritmetik Operatorler (+,-,*,/,%,++,--)
        2-Atama Operatorleri (=,+=,-=,*=,/=,%=)
        3-Karşılaştırma Operatorleri (==,!=,<,>,<=,>=,?:)
        4-Mantıksal Operatorler (&&,||, !)
        */

        //1-Aritmetik Operatorler (+,-,*,/,%,++,--)
        Console.WriteLine("-------Aritmetik Operatorler--------");
            int a=10;
            int b=30;
            int val,val1,val2,val4;
            float val3;
            val=a+b;
            Console.WriteLine("30 + 10 :"+val);

            val1=b-a;
            Console.WriteLine("30 - 10 :"+val1);

            val2=a*b;
            Console.WriteLine("10 * 30 :"+val2); 

            val3=(float)a / (float)b;
            Console.WriteLine("10 / 30 :"+val3); 

            val4=b%4;
            Console.WriteLine("30 Mod 4 :"+val4);
            Console.WriteLine("---Atama Operatorleri------");
            //2-Atama Operatorleri (=,+=,-=,*=,/=,%=)
            int x=10, y=20, z=30;
            double mat;
            Console.WriteLine($"x:{x} y:{y} z:{z}");
            x+=5;// x=x+5;
            Console.WriteLine("10 + 5 :"+x);
            x-=5;// x=x-5;
            Console.WriteLine("10 - 5 :"+x);
            x*=5;// x=x*5;
            Console.WriteLine("10 * 5 :"+x);
            x/=5;// x=x/5;
            Console.WriteLine("10 / 5 :"+x);
            x%=5;// x=x%5;
            Console.WriteLine("10 mod 5 :"+x);
            mat=Math.Pow(2,5);//x taban y üs 
            Console.WriteLine("2 üssü 5 :"+mat);
            mat=Math.Sqrt(169);
            Console.WriteLine("169 un karekök ü :"+mat);
        }
    }
}
