using System;

namespace Ders_25_NesneYapiciMetodlar
{// Yeni Proje ve dosya olusturmak icin -> dotnet new console -o  Ders_
 
class Araba{
    // ctor yazıp -> Enter ->
    public Araba()
    {
        this.MaxHiz=210;
        Console.WriteLine("Yapıcı Metod Çalıştırıldı...");
    }
    public Araba(int maxhiz)
    {
        this.MaxHiz=maxhiz;
    }
 
     public Araba(string marka,string model,string renk,bool otomatik,int maxhiz)
    {
        this.Marka=marka;
        this.Model=model;
        this.Renk=renk;
        this.Otomatik=otomatik;
        this.MaxHiz=maxhiz;
    }
    public string Marka { get; set; }
        public string Model { get; set; }
        public string Renk { get; set; }
        public bool Otomatik { get; set; }
        public int MaxHiz{get;set;}
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
}
    class Program
    {
        static void Main(string[] args)
        {
            var a1=new Araba(){Marka="Opel",Model="Astra",Renk="Kırmızı",Otomatik=false};
            var a2=new Araba(230){Marka="Ford",Model="Mustang",Renk="Metalik Gri",Otomatik=true};
            var a3=new Araba("Mazda","Samara","Mavi",true,280);

            Console.WriteLine(a3.Marka+" "+a3.Model+" "+a3.Renk+" "+a3.Otomatik+" "+a3.MaxHiz);
            var toyota=new Araba(260);
                toyota.Marka="Toyota";
                toyota.Model="Avensis";
                toyota.Renk="Beyaz";
                toyota.Otomatik=true;
            Console.WriteLine($"{toyota.Marka} marka ve {toyota.Model} model araba, renkte {toyota.Renk} renk ile olarak teslim alındı.");

        }
    }
}
