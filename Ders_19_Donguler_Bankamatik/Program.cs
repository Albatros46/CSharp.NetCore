using System;

namespace Ders_19_Donguler_Bankamatik
{
    class Program
    {// Yeni Proje ve dosya olusturmak icin -> dotnet new console -o  Ders_
        static void Main(string[] args)
        {
            //Menü : Bakiye
            //Para Yatırma
            //Para Çekme
            //Çıkış
            string secim="";
            double bakiye=0;
            double ekhesap=1000;
            double ekhesaplimit=1000;
            do
            {
            Console.Write("1-Bakiye Görüntüle\n2-Para Yatırma\n3-Para Çekme\n4-Çıkış\nSeçim :");
            secim=Console.ReadLine();
            switch (secim)

            {
                case "1":
                    Console.WriteLine("Bakiyeniz {0}:",bakiye," TL");
                    Console.WriteLine("Ek Hesap Bakiyeniz {0} :",ekhesap," TL");
                    break;
                case "2":
                    Console.Write("Yatıracağınız Miktar :");
                    double yatirilan=double.Parse(Console.ReadLine());
                    bakiye+=yatirilan;
                    break;
                case "3":
                    Console.Write("Çekmek İstediğiniz Miktar :");
                    double cekilen=double.Parse(Console.ReadLine());
                    if(cekilen>bakiye){

                        double toplam=bakiye+ekhesap;
                        if (toplam>=cekilen)
                        {
                            Console.WriteLine("Ek Hesap Kullanilsin mi? (e/h)");
                            string ekhesaptercih=Console.ReadLine();
                            if(ekhesaptercih=="e"){
                                Console.Write("Paranızı Alabilirsiniz.");
                                ekhesap-=(cekilen-bakiye);
                                bakiye=0;
                            }else{
                                Console.Write("Yetersiz Bakiye.");
                            }
                        }
                        Console.WriteLine("Yetersiz Bakiye");
                    }
                        else
                        cekilen-=bakiye;
                    break;
                case "4":
                    Console.WriteLine("Çıkış\n");
                    break;
                default:
                    Console.WriteLine("Hatalı Seçim Yaptınız.\n");
                    break;
            }
            } while (secim!="4"); //secim değişleni 4 olana kadar dongu çalışacak 4 olduğunda dongu sonlanacak
            Console.WriteLine("Uygulamadan Çıkılıyor...");
        }
    }
}
