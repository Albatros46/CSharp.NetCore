using System.Collections;
using System;

namespace Ders_35_Collections
{// Yeni Proje ve dosya olusturmak icin -> dotnet new console -o  Ders_
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Array->fixed size(sabit genişlik)
                Collections
                |->non-generic
                |--->Arraylist, SortedList
                |->generic
                |--->int, string,product gibi degerler almaktadir.

            */
            //IList myList=new ArrayList(); //IList özellikleri daha fazla
            //ICollection myList=new ArrayList();//ICollection özellikleri daha fazla
            ArrayList myList=new ArrayList();
            myList.Add(30);
            myList.Add("Kahramanmaraş");
            myList.Add(10.5);

            ArrayList myList2=new ArrayList(){10.5,50,"Ankara"};
            //Liste elemanlarına erişim sağlamak için 
            //Accessing Item
            Console.WriteLine(myList[0]);
            Console.WriteLine(myList2[3]);
            
            myList.Insert(1,20);
            myList.InsertRange(3,myList2);//3. indexten itibaren mylist2 yi ekle
            foreach (var item in myList)
            {
                Console.WriteLine(item);
            }
            //Remove items - listden obje silme
            myList.Remove(30);
            myList.RemoveAt(2);//2.indexteki objeyi sil
            myList.RemoveRange(0,2);//0. indexten balayarak 2 obje sil

            //sıralama işlemi
            ArrayList sayilar=new ArrayList(){1,45,32,31,43,61,16,21,26};
            
            foreach (var i in sayilar)
            {
                Console.WriteLine(i);
            }
            sayilar.Sort();
        }
    }
}
