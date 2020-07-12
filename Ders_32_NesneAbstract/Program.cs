using System;

namespace Ders_32_NesneAbstract
{// Yeni Proje ve dosya olusturmak icin -> dotnet new console -o  Ders_
   class Person{
        public string Name { get; set; }//Ad
        public string  SurName { get; set; }//Soyad
        public Person(string name, string surname) //Yazdırma yapacağımız metod(constructor)
        {//burdaki parametleri student e de yazmalıyız aksi halde hata verir
            this.Name=name;
            this.SurName=surname;
            Console.WriteLine("Person Nesnesi Oluşturuldu.");
        }
        public virtual void Intro(){ //virtual anahtar kelimesi ekleyerek student class da bu metodu override yapabiliriz
            Console.WriteLine($"Adı :{this.Name} Soyadı :{this.SurName}");
            
        }
    }
    class Student:Person{ //Student class i Person class in özelliklerine sahip olacak
        public int StudentNumber { get; set; }
        public Student(string name, string surname,int studentno):base(name,surname) 
        {//gelen parametleri this ile berlitmek yerine base(name,surname) ile de eslestirebiliriz.temel sınıftan çekilecek parametlereler base ile belirtilir.
            this.StudentNumber=studentno;
            Console.WriteLine("Student Nesnesi Oluşturuldu.");
        }
        public override void Intro(){//temel sınıfta virtual kullanildği icin burda override yaparak kullanacağiz.
            Console.WriteLine($"Adı :{this.Name} Soyadı :{this.SurName} Ogrenci Nu:{this.StudentNumber}");
        }
    }
    class Teacher:Person{
        public string Brans { get; set; }
        public Teacher(string name, string surname, string brans):base(name,surname){
            this.Brans=brans;
        }
        public void Teach()
        {
            Console.WriteLine("Bilgisayar Yazılım Öğretmeni:");
        }
        public override void Intro(){//temel sınıfta virtual kullanildği icin burda override yaparak kullanacağiz.
            Console.WriteLine($"Adı :{this.Name} Soyadı :{this.SurName} Bırans:{this.Brans}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Abstract Class: Soyut Class
            var p=new Person("Servet","AKÇADAĞ"); //yorum satırı yapsak ta
            var s=new Student("Akif","AKÇADAĞ",101);   //student nesnesi çalıştığında ilk once person nesnesi olusur
            var t=new Teacher("Ahmet","Akçadağ","3D Tasarım Öğretmeni");
            p.Intro();
            s.Intro();
            t.Intro();
        }
    }
}
