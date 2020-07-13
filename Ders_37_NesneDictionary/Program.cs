using System.Net.Security;
using System.Linq;
using System.Collections.Generic;
using System;

namespace Ders_37_NesneDictionary
{// Yeni Proje ve dosya olusturmak icin -> dotnet new console -o  Ders_
    class Program
    {
        static void Main(string[] args)
        {//dictionary
        // Dictionary<TKey,TValue>
        // plaka=>(34:İstanbul),(46:Kahramanmaraş)
            Dictionary<int,string> plakalar=new Dictionary<int, string>();
            plakalar.Add(46,"Kahramanmaraş");
            plakalar.Add(34,"İstanbul");
            plakalar.Add(35,"İzmir");
            plakalar.Add(6,"Ankara");
            foreach (var plaka in plakalar)
            {
                Console.WriteLine($"Plakalar :{plaka.Key} plakalı şehir {plaka.Value}");
            }
            plakalar.Remove(6);//index 6 plan nesne silinir

            //KeyValuePair kullanimi
            foreach (KeyValuePair<int,string> plaka in plakalar)
            {
                Console.WriteLine($"Plakalar :{plaka.Key} plakalı şehir {plaka.Value}");
            }
            Console.WriteLine(plakalar.Contains(new KeyValuePair<int,string>(6,"Ankara")));//nesnenin varliğini kontrol etme true/false
            //for dongusu ile kullanimi
            Console.WriteLine("for dongusu ile listeleme");
            for (int i = 0; i <plakalar.Count; i++)
            {
                Console.WriteLine($"Plakalar :{plakalar.Keys.ElementAt(i)} plakalı şehir {plakalar[plakalar.Keys.ElementAt(i)]}");
            }
            Console.WriteLine("-------------------");
            Dictionary<int,string> kategori=new Dictionary<int, string>(){
                {1,"Elektronik Ev Aletleri"},
                {2,"Oto Aksesuar"},
                {3,"Bahçe Dekorasyon"},
                {4,"Ev Dekorasyon"},
                {5,"Mobilya"}
            };

            Console.WriteLine($"Kategori :{kategori[1]}");
             foreach (var k in kategori)
            {
                Console.WriteLine($"Kategori Id :{k.Key} Kategori Adı:{k.Value}");
            }
            Console.WriteLine(kategori.ContainsKey(3));//degerin varliğini kontrol etme true/false
            //Generic olmayan kullanım için de
            //genereic dictionary hastable ye gore daha hizlidir
            //generic yapida boxing ve unboxing yapilmamaktadir.
            Hashtable ht= new Hashtable(){
                ht.Add(1,"Servet"),
                ht.Add(2,"Ahmet"),
                ht.Add(3,"Akif"),
                ht.Add(4,"Oğuz"),
                ht.Add(5,"Rukiye")
            };
           
        }
    }
}
