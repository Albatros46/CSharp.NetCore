using System;

namespace Ders_32_NesneAbstract
{// Yeni Proje ve dosya olusturmak icin -> dotnet new console -o  Ders_
    abstract class Person{
        public string Name { get; set; }//Ad
        public string  SurName { get; set; }//Soyad
        public Person(string name, string surname) //Yazdırma yapacağımız metod(constructor)
        {//burdaki parametleri student e de yazmalıyız aksi halde hata verir
            this.Name=name;
            this.SurName=surname;
            Console.WriteLine("Person Nesnesi Oluşturuldu.");
        }
        public void Greeting(){
            Console.WriteLine("Ben Öğretmenim.");
        }
        public abstract void Intro(); //abstract metod kullanmak icin class da abstract olmalı
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
    class Shape{
        public int Width { get; set; }//Genişlik
        public int Height { get; set; }//Yükseklik
        public virtual void Draw(){ //temel sınıf içindeki tanimlamaları kullanmak istemirsak virtual yerine abstract yazariz.
            Console.WriteLine("Şekil Çiziliyor.");
        }
    }
    class Square:Shape{
        public override void Draw(){
            Console.WriteLine("KARE Şekili Çiziliyor.");
        }
    }
    class  Rectangle:Shape{
        public override void Draw(){ //override edilmesi için temel class da virtual edilmeli.
            base.Draw();//ile temel siniftaki metodu da çağırabiliriz.
            Console.WriteLine("DAİRE Şekili Çiziliyor.");
            
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Abstract Class: Soyut Class
            //Abstract siniftan obje turetilemez
            var s=new Student("Akif","AKÇADAĞ",101);   //student nesnesi çalıştığında ilk once person nesnesi olusur
            var t=new Teacher("Ahmet","Akçadağ","3D Tasarım Öğretmeni");
            t.Greeting();
            s.Greeting();
            s.Intro();
            t.Intro();
            Console.WriteLine("|------------------------|");
            Console.WriteLine("*********ŞEKİL***********");
            //Abstract soyut sinif
            var shapes=new Shape[3];
            shapes[0]=new Shape();
            shapes[1]=new Square();//shape den turedildi
            shapes[2]=new Rectangle();//shape den turedildi

            foreach (var shape in shapes)
            {
                shape.Draw();
            }
        }
    }
}
