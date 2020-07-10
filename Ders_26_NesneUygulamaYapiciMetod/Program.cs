using System.Linq;
using System;

namespace Ders_26_NesneUygulamaYapiciMetod
{// Yeni Proje ve dosya olusturmak icin -> dotnet new console -o  Ders_
    class Comment//Urunlere yapılan yorum için
    {
        public int CommentId { get; set; }
        public string Text { get; set; }
    }
    class Product{
        public Product()
        {
            var rnd=new Random();//random objesi olusturduk
            this.ProductId=rnd.Next(11111,99999);//5 haneli random sayı turetecek
            this.Comments=new Comment[3];
         //   this.ProductId=(new Random()).Next(11111,99999); //Şeklinde tek satırda da yazabiliriz.
        }
        // :this()  kullanılmasnın amaci bu constructor dan once bir üstteki const calistirilsin.
        public Product(int productId):this()
        {//1.Aşırı yüklenmiş metodu
            this.ProductId=productId;
            
            
        }
         public Product(int productId,string name,double fiyat,bool isapproved):this(productId)
        {// :this(productId) sebebi bir üst const cagirilacak orasi calisacak ordan comment i alacak ve 
        //burada tanımlı olan productidsini de üst teki consttan alacak
           //2.Aşırı yüklenmiş metodu
            this.Name=name;
            this.Price=fiyat;
            this.IsApproved=isapproved;
        }
        public int ProductId { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public bool IsApproved { get; set; }
        public Comment[] Comments { get; set; } //yorum class i dizi olarak atamamızın sebebi bir ürün birden fazla yorum alabilir.

    }
    class Program
    {
        static void Main(string[] args)
        {
            var c1=new Comment{CommentId=101,Text="Çok güzel ürün"};
            Console.WriteLine("***|1.URUN.|***");
            var p1=new Product();
            // p1.Comments[0]=c1; // Hata verecektir.
            p1.Comments=new Comment[3];
            p1.Comments[0]=c1;
            Console.WriteLine(p1.ProductId);
            Console.WriteLine(p1.Name);
            Console.WriteLine(p1.Price);
            Console.WriteLine(p1.IsApproved);//Ürün Onaylı mı? kontrol için
            Console.WriteLine(p1.Comments[0].Text);
            Console.WriteLine(p1.ProductId+" "+p1.Name+" "+p1.Price+" "+p1.IsApproved);
            Console.WriteLine("***|..............|***");
            
            Console.WriteLine("***|2.URUN.|***");
            var p2=new Product(46344);
            var c2=new Comment{CommentId=101,Text="Süper Ürün"};
            p2.Comments[0]=c2;
            Console.WriteLine(p2.ProductId);
            Console.WriteLine(p2.Name);
            Console.WriteLine(p2.Price);
            Console.WriteLine(p2.IsApproved);//Ürün Onaylı mı? kontrol için
            Console.WriteLine(p2.Comments[0].Text);
            Console.WriteLine(p2.ProductId+" "+p2.Name+" "+p2.Price+" "+p2.IsApproved);
            Console.WriteLine("***|..............|***");
            Console.WriteLine("***|3.URUN.|***");
            var c3=new Comment{CommentId=101,Text="Maaşallah Harika Ürün"};
            p2.Comments[0]=c3;
            var p3=new Product(1001,"Televizyon Ünitesi",3750,true);
            Console.WriteLine(p3.ProductId+" "+p3.Name+" "+p3.Price+" "+p3.IsApproved);
            Console.WriteLine("***|..............|***");
        }
    }
}
