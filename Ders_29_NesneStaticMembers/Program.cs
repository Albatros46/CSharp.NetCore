using System;

namespace Ders_29_NesneStaticMembers
{// Yeni Proje ve dosya olusturmak icin -> dotnet new console -o  Ders_
//ilk olarak student class olusturduk
    class Student{//Instance class->orneklenebilir cogaltilabilir class
        public string Name { get; set; }//ogrenci degerleri tanımladik
        public int StudentNumber { get; set; }
        public static string School ="Kahramnmaraş Sütçü İmam Üni.";//static->classs(sınıf) a özel bilgiler
                                    //{ get; set; }
        public static string Adress="Kahramanmaraş"; //static->class a özel bilgiler student class ile cagirilabilir.
                                // { get; set; }
        public Student(string name, string studentnumber)
        {//degerlerin karsilanacagi constrcutor i yazdik
            this.Name=name;
            this.StudentNumber=studentnumber;
        }
        public void DisplayStudentDetails() {//goruntuleyecegimiz metodu yazdik.
            Console.WriteLine($"ADI :{this.Name} NO :{this.StudentNumber}");
        }
        public static void DisplaySchoolDetails(){
            Console.WriteLine($"Okul Adı :{School} Adres :{Adress}");
        }
    }
    static class HelperMetods{//static class (yardımcı metod)
        public static string KarakterDuzelt(string str){
            return str.Replace("ç","o")
                      .Replace("ş","s")
                      .Replace("ğ","g")
                      .Replace("ı","i");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // var s1=new Student("Servet",101);
            // var s2=new Student("Akif",102);
            // var s3=new Student("Ahmet",103);
            // Student.DisplaySchoolDetails();
            // s1.DisplayStudentDetails();
            // s2.DisplayStudentDetails();
            // s3.DisplayStudentDetails();
            string str="ölçme ve değerlendirme";
            var result= HelperMetods.KarakterDuzelt(str);
            Console.WriteLine(result);
        }
    }
}
