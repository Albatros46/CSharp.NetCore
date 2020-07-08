using System;

namespace Ders_22_NesneClassMetodlar
{// Yeni Proje ve dosya olusturmak icin -> dotnet new console -o  Ders_
    class Person{
        public string Name { get; set; }
        public int Year { get; set; }

        public string Intro(){//metod  void olarak da kullanırsak console.writeline olarak yazdıracaktık
           // Console.WriteLine($"Adı :{this.Name} Yaş :{2020-this.Year}"); //void metod olmadğı için
           return $"Adı :{this.Name} Yaş :{2020-this.YasHesapla()}"; //string ifade gonderdiği için
        }
        public int YasHesapla(){
            return DateTime.Now.Year-this.Year;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //class->Object(new)
            //ogrenci->ogr1,ogr2
            Person p1=new Person(){
                Name="Servet",
                Year=1988
            };
            var p2=new Person();
            p2.Name="Akif";
            p2.Year=1991;

            var p3=new Person(){Name="Rukiye", Year=1998};
            var str1=p1.Intro();//string turunde intro metodu kullanılarak yazdiriyoruz.
            var str2=p2.Intro();
            var str3=p3.Intro();
            Console.WriteLine(str1);//string turunde metod tanımlandiği için yazdirma işlemi bu şekilde
            Console.WriteLine(str2);
            Console.WriteLine(str3);
            //Console.WriteLine($"Adı :{p1.Name} Yaş :{2020-p1.Year}");
            //Console.WriteLine($"Adı :{p2.Name} Yaş :{2020-p2.Year}");
            //Console.WriteLine($"Adı :{p3.Name} Yaş :{2020-p3.Year}");
          
        }
    }
}
