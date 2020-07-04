using System;

namespace Ders_12_Switch
{
    class Program
    {
        static void Main(string[] args)
        {// Yeni Proje ve dosya olusturmak icin -> dotnet new console -o  Ders_0
            Console.Write("Kaçıncı Aydayız :");
            int ay=int.Parse(Console.ReadLine());
            switch(ay){
                case 12:
                Console.WriteLine("ARALIK Ayı");
                    break;
                case 11:
                Console.WriteLine("KASIM Ayı");
                    break;
                case 10:
                Console.WriteLine("EKİM Ayı");
                    break;
                case 9:
                Console.WriteLine("EYLÜL Ayı");
                    break;
                case 8:
                Console.WriteLine("AĞUSTOS Ayı");
                    break;
                case 7:
                Console.WriteLine("TEMMUZ Ayı");
                    break;
                 case 6:
                Console.WriteLine("HAZİRAN Ayı");
                    break;
                 case 5:
                Console.WriteLine("MAYIS Ayı");
                    break;
                 case 4:
                Console.WriteLine("NİSAN Ayı");
                    break;
                 case 3:
                Console.WriteLine("MART Ayı");
                    break;
                 case 2:
                Console.WriteLine("ŞUBAT Ayı");
                    break;
                 case 1:
                Console.WriteLine("OCAK Ayı");
                    break;
                default:
                 Console.WriteLine("Yanlış Bilgi...");   
                 break;
            }
        }
    }
}
