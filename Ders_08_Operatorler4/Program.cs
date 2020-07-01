using System;

namespace Ders_08_Operatorler4
{
    class Program
    {//yeni proje ve dosya açmak için --> dotnet new console -o  Ders_0
        static void Main(string[] args)
        {
            /*
            1-Girilen iki sayidan büyük olanı bul
            2-Parola ve Email bilgisini isteyip doğruluğunu kontrol et
            3-Girilen bir sayinin pozitif mi olup olmadigini kontrol et
            4-Girilen 3 sayiyinin büyüklüğünü kıyasla
            5-Kullanıcıdan 2 vize (%60) bir final(%40) notlarını alip ortalmayı hesapla
                eger orltalama 50 den büyükse geçti değilse kaldı
                a-Ortalama 50 olsa ile final notu 50 den fazla olmalıdır.
                b-Final 70 ve üzeri ise ortalamanın önemi yok her halükarda geçsin.
            6-Kişinin ad, kilo, ve boy bilgilerini isteyip beden index lerini hesapla
            
            */
            //1-Girilen iki sayidan büyük olanı bul
            /*
            Console.Write("1. Sayıyı giriniz :");
            int sayi1=int.Parse(Console.ReadLine());
            Console.Write("2. Sayıyı giriniz :");
            int sayi2=int.Parse(Console.ReadLine());
            var result=(sayi1>sayi2)?"Sayı1>Sayı2":"Sayı2>Sayı1";
            Console.WriteLine(result);
            */
            //  2-Parola ve Email bilgisini isteyip doğruluğunu kontrol et
            /*
            string _eposta="info@hotmail.com";
            string _parola="12345";
            Console.Write("E-Posta : ");
            string eposta=Console.ReadLine();
            Console.Write("Parola : ");
            string parola=Console.ReadLine();

            var result1=(_eposta==eposta) && (_parola==parola);
            Console.WriteLine("Giriş ->"+result1);
            */
            //3-Girilen bir sayinin pozitif mi olup olmadigini kontrol et
            /*
            Console.WriteLine("Sayı Girin : ");
            int sayi=int.Parse(Console.ReadLine());
            var result=((sayi>0) && (sayi%2==0))?"pozitif çift sayi":"pozitif çift sayi DEĞİL";
            Console.WriteLine(sayi+" "+result);
            */
            //4-Girilen 3 sayiyinin büyüklüğünü kıyasla
            /*
            Console.Write("1.Sayı :");
            int a=int.Parse(Console.ReadLine());
            Console.Write("2.Sayı :");
            int b=int.Parse(Console.ReadLine());
            Console.Write("3.Sayı :");
            int c=int.Parse(Console.ReadLine());
            var result=((a>b) && (a>c))?"Büyük sayı A":((b>a) && (b>c))?"Büyük sayı B":
                                        ((c>b) && (c>a))?"Büyük sayı C":"Hatalı Bilgi";
             //  result=((b>a) && (b>c))?"Büyük sayı B":"B büyük sayı DEĞİL";
             // result=((c>b) && (c>a))?"Büyük sayı C":"C büyük sayı DEĞİL";
            Console.WriteLine(result);
            */
            //5-Kullanıcıdan 2 vize (%60) bir final(%40) notlarını alip ortalmayı hesapla
            // eger orltalama 50 den büyükse geçti değilse kaldı
            //    a-Ortalama 50 olsa ile final notu 50 den fazla olmalıdır.
            //    b-Final 70 ve üzeri ise ortalamanın önemi yok her halükarda geçsin.
            Console.Write("1.Vize Notu : ");
            int v1=int.Parse(Console.ReadLine());
            Console.Write("2.Vize Notu : ");
            int v2=int.Parse(Console.ReadLine());
            Console.Write("Final Notu  : ");
            int fn=int.Parse(Console.ReadLine());
            var ort=((v1+v2)/2)*0.6+(fn*0.4);
            // var durum=ort>=50?"GEÇTİ":"KALDI"; //a ve b şıklarına gore yazacagiz
            var durum=((ort>=50) || (fn>=70));

            Console.WriteLine("Ortalama :"+ort);
            Console.WriteLine(durum?"GEÇTİ":"KALDI");
        }
    }
}
