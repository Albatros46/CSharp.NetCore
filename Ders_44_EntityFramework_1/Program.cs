using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Microsoft.Extensions.Logging;
using System.Linq;

namespace Ders_44_EntityFramework_1
{// Yeni Proje ve dosya olusturmak icin -> dotnet new console -o  Ders_
    //Entity Classes
    //Product(Id, Name, Price)=> Product(Id,Name,Price)
     public class ShopContext : DbContext
    {//EntityFramework içinden gelen bir contexti miras alacak linkte örnek verilmiş
        //https://docs.microsoft.com/tr-tr/ef/core/ 
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public static readonly ILoggerFactory MyLoggerFactory = LoggerFactory.Create(builder => { builder.AddConsole(); });
         //LinQ ile olusturulan SQL sorgusunu LOG tutularak gormek için.
         
         
          //ShopContext calistiğinda hangi veritabanın çalışacağınız belirtmek için;
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder 
                           .UseLoggerFactory(MyLoggerFactory)
                           .UseSqlite("Data Source=shop.db");
            //Hangi database provideri/driver kullanmak istiyorsak ve olumasini istediğimiz db ismini belirttik.
        }

    }
    public class Product{
        //primary key (Id, <type_name>Id)
        
        public int Id { get; set; }

        [MaxLength(100)] //Maximum 100 karakter olacak
        [Required] //zorunlu alan, boş geçilmeyecek
        public string Name { get; set; } //varchar tipinde olacak
        public decimal Price { get; set; } //decimal? yazarsak null olarak da yazilabilir. varsayılan olarak Required yapılmıştır.
    }
    public class Category{
        public int Id { get; set; }
        public string Name { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            /* proje esnasında bir takım kodları kullanmak için
                dotnet tool install --global dotnet-ef
                consol ekranında yazip indireceğiz
                
                Veritabanı ve migration olustmak için ornek;
                https://docs.microsoft.com/en-us/ef/core/get-started/?tabs=netcore-cli
            */
           // AddProduct();
            Console.WriteLine("-------------------");
           // AddProducts();
            Console.WriteLine("-------------------");
            GetAllProducts();
            Console.WriteLine("---id ile sorgulama----");
            GetProductById(5);
            Console.WriteLine("---Name ile sorgu----");
            GetProductByName("iPhone");
        }
        static void AddProducts(){
            using(var db=new ShopContext())
            {
               //Liste halinde ekleme yapma
                var products=new List<Product>{
                    new Product { Name = "iPhone 7 128 gb", Price = 3750 },
                    new Product { Name = "Samsung S8 ", Price = 3110 },
                    new Product { Name = "Huawei P 9 Lite", Price = 2989 },
                    new Product { Name = "Samsung Galaxy S 10", Price = 4000 },
                    new Product { Name = "iPhone X Max", Price = 8000 },
                };
                foreach (var pr in products)
                {
                    db.Products.Add(pr);
                }
                //Foreach yerine:
                // db.Products.AddRange(products);
                db.SaveChanges();
                Console.WriteLine("Veriler Eklendi.");
            };
        }
        static void AddProduct(){
            using(var db=new ShopContext())
            {
                //bir tane ekleme yapma
                var p = new Product { Name = "iPhone 7 128 gb", Price = 3750 };
                db.Products.Add(p);
                db.SaveChanges();//Yapılan Değişiklikleri db ye kaydet          
                // db.Products.AddRange(products);
                
                Console.WriteLine("Veriler Eklendi.");
            };
        }
        static void GetAllProducts(){
            using (var context=new ShopContext())
            {
                var products =context
                .Products
                .Select(p=>new{p.Name, p.Price }) //Şeklinde istediğimiz kolonları listeleyebiliriz.
                .ToList();
                foreach (var p in products)
                {
                    Console.WriteLine($"Adı :{p.Name} Fiyat :{p.Price}");
                }
            }
        }
         static void GetProductById(int id)
        {
            using (var context = new ShopContext())
            {
                var result = context
                                    .Products
                                    .Where(p => p.Id == id)
                                    .FirstOrDefault();//Eger istenilen id de kayit yoksa null deger donecektir.
                
                Console.WriteLine($"Adı :{result.Name} Fiyat :{result.Price}");
                
            }
        }
        static void GetProductByName(string name)
        {
            using (var context = new ShopContext())
            {
                var products = context
                                    .Products
                                    .Where(p => p.Name.ToLower().Contains(name))//.Select ile de kullanılabilir.
                                    .Select(p=>
                                            new { p.Name,p.Price})
                                    .ToList();//Eger istenilen id de kayit yoksa null deger donecektir.
                foreach (var pr in products)
                {
                    Console.WriteLine($"Adı :{pr.Name} Fiyat :{pr.Price}");
                }
            }
        }
    }
}

