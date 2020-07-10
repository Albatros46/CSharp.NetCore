using System;

namespace Ders_27_NesneProperties
{// Yeni Proje ve dosya olusturmak icin -> dotnet new console -o  Ders_
    class Product
    {
        public string Name;
        private double _price;
        public double Price{
            get{
                return _price;
            }
            set{
                if (value<0)
                {
                    _price=0;
                }else
                    _price=value;
            }
        }
        //  public void SetPrice(double price){
        //     if (price<0)
        //     {
        //         price=0;
        //     }else
        //         this.price=price;
        // }
        public double GetPrice(){
            return this.price();
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
             var p=new Product();
             p.Name="iphone 7 plus";
             p.Price=-4500;
             Console.WriteLine(p.Price());
        }
    }
}
