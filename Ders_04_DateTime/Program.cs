using System.Globalization;
using System;

namespace Ders_04_DateTime
{
    class Program
    {
        static void Main(string[] args)
        {// Yeni proje ve klasör için --> dotnet new console -o  Ders_04_DateTime
            DateTime simdi=DateTime.Now;
            string[]  aylar={"Ocak","Şubat","Mart","Nisan","Mayıs","Haziran","Temmuz"
            ,"Ağustos","Eylül","Ekim","Kasım","Aralık"};
            string[] gunler={"Pazartesi","Salı","Çarşamba","Perşembe","Cuma","Cumartesi","Pazar"};
            Console.WriteLine(simdi);
            Console.WriteLine(simdi.Year);
            Console.WriteLine(simdi.Month);
            Console.WriteLine(aylar[simdi.Month-1]);
            Console.WriteLine(simdi.Day);
           // Console.WriteLine(gunler[simdi.Day-1]);
            Console.WriteLine(simdi.DayOfWeek);
            Console.WriteLine("Şimdi Saat  : "+simdi.Hour);
            Console.WriteLine("Şimdi Dakia : "+simdi.Minute);
            Console.WriteLine("Şimdi Saniye: "+simdi.Second);
            Console.WriteLine("----------------------");
            DateTime dateTime=new DateTime(2020,6,2,7,25,36);
            Console.WriteLine(dateTime);
            DateTime dt1=dateTime.AddDays(2);//2 gün daha eklendi
            DateTime dt2=dateTime.AddMonths(2);//2 ay eklendi
            DateTime dt3=dateTime.AddHours(2);//2 saat eklendi
            Console.WriteLine(dt1);
            Console.WriteLine(dt2);
            Console.WriteLine(dt3);
            var fark=simdi-dt1;
            Console.WriteLine(fark.TotalDays);
            Console.WriteLine("*****************");
            Console.WriteLine(simdi.ToString("hh:mm:ss:ml"));//saat dakika saniye milisaniye
            Console.WriteLine(simdi.ToString("ddd MMM %d, yyyy"));
            CultureInfo culture=new CultureInfo("en"); //Tarih formatini değiştirmek için
            Console.WriteLine(simdi.ToString("F",culture));//Tarih formatini değiştirme
        
        }
    }
}
