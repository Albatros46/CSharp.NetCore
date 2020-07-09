using System;

namespace Ders_23_NesneClassMetodUygulama
{// Yeni Proje ve dosya olusturmak icin -> dotnet new console -o  Ders_
    class Islem{
        //Parametreli Metodlar
       
        public int Toplama(int x, int y){
            return x+y;
        }
        public int Top(params int [] sayilar){
            int top=0;//params ile parametreleri dizi halinde gonderebiliriz.
            foreach (var item in sayilar)
            {
                top+=item;
            }
            return top;
        }

    }
    class Araba{
        public string Marka { get; set; }
        public string Model { get; set; }
        public string Renk { get; set; }
        public bool Otomatik { get; set; }

        public void Start(){
            Console.WriteLine($"{this.Marka} {this.Model} Araba Çalıştırıldı...");
        }
         public void Stop(){
            Console.WriteLine($"{this.Marka} {this.Model}Araba Durdu...");
        }
         public void Yavasla(){
            Console.WriteLine($"{this.Marka} {this.Model}Araba Yavasliyor...");
        }
         public void Hizlan(){
            Console.WriteLine($"{this.Marka} {this.Model}Araba Hızlanıyor...");
        }
        public void Menu(){
            string komut="";
            do
            {
                Console.WriteLine("1-Start\n2-Stop\n3-Hızlan\n4-Yavasla\nÇ-Çıkış");
                Console.Write("Seçiminiz: ");
                komut=Console.ReadLine();
                switch (komut)
                {
                    case "1":
                        this.Start();
                        break;
                    case "2":
                        this.Stop();
                        break;
                    case "3":
                        this.Hizlan();
                        break;
                    case "4":
                        this.Yavasla();
                        break;
                    default:
                    
                        Console.WriteLine("Yanlış Seçim!");
                        break;
                }
            } while (komut!="Ç");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var islem=new Islem();
            Console.Write("params ile diziyi parametre olarak gonderme...");
            Console.WriteLine("Params kullanımı :"+islem.Top(50));
            Console.WriteLine("Params kullanımı :"+islem.Top(50,45));
            Console.WriteLine("Params kullanımı :"+islem.Top(50,45,67));
            Console.WriteLine("Params kullanımı :"+islem.Top(50,45,67,78));
            Console.WriteLine("Params kullanımı :"+islem.Top(50,45,67,78,90));
            //----------------------------------
            Console.WriteLine("PAramatreli değişken---------------");
            Console.WriteLine(islem.Toplama(20,30));
            Console.WriteLine(islem.Toplama(x:50,y:80));//named parametr
            var a1=new Araba(){Marka="Opel",Model="Astra",Renk="Kırmızı",Otomatik=false};
            var a2=new Araba(){Marka="Ford",Model="Mustang",Renk="Metalik Gri",Otomatik=true};
            a2.Menu();
           // a1.Start();
          //  a1.Stop();
           // a1.Hizlan();
            //a1.Yavasla();
        }
    }
}
