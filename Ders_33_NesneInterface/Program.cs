using System;

namespace Ders_33_NesneInterface //Interface Kullanımı
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
        public Yonetici(string _adsoyad, string _adres, string _departman)
        {
            this.adsoyad=_adsoyad;
            this.adres=_adres;
            this.departman=_departman;
            
        }
        public string adsoyad{get;set; }
        public string adres{get;set; }
        public string departman{get;set; }
        public void bilgi(){
           //Console.WriteLine($"{this.adsoyad} isimli personnel {this.departman} departmanında yöneticidir.");
            Console.WriteLine($"Adı Soyadı:{this.adsoyad} Departmanı:{this.departman} Adresi:{this.adres}");
        }
    }
    class Calisan:IPersonel
    {
            public Calisan(string _adsoyad, string _adres, string _departman)
        {
            this.adsoyad=_adsoyad;
            this.adres=_adres;
            this.departman=_departman;
        }
        public string adsoyad{get;set; }
        public string adres{get;set; }
        public string departman{get;set; }
        public void bilgi(){
            //Console.WriteLine($"{this.adsoyad} isimli personnel {this.departman} departmanında çalışandır.");
            Console.WriteLine($"Adı Soyadı:{this.adsoyad} Departmanı:{this.departman} Adresi:{this.adres}");
        }
    }
  
    class Program//Interface
    {
        static void Main(string[] args)
        {
            // Yonetici yonetici1= new Yonetici();//Şeklinde de obje uretilebilir.
            // Calisan calisan1=new Calisan();
            // //--------------vaya------------
            // IPersonel yonetici2=new Yonetici();//Şeklinde de obje uretilebilir.
            // IPersonel calisan2=new Yonetici();

            var personeller=new IPersonel[4];
            personeller[0]=new Yonetici("Servet AKÇADAĞ","Kahramanmaraş","Bilgi İşlem");
            personeller[1]=new Yonetici("Akif AKÇADAĞ","Kahramanmaraş","Sniper");
            personeller[2]=new Calisan("Ahmet KOZAK","GAZİANTEP","Kalite Kontrol");
            personeller[3]=new Calisan("Celal BİNGÖL","ANKARA","Güvenlik Şefi");
            foreach (var p in personeller)
            {
                //Console.WriteLine($"Adı Soyadı:{p.adsoyad} Departmanı:{p.departman} Adresi:{p.adres}");
                p.bilgi();
            }
        }
    }
}
