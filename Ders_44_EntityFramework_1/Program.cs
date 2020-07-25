using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Ders_44_EntityFramework_1
{// Yeni Proje ve dosya olusturmak icin -> dotnet new console -o  Ders_
    //Entity Classes
    //Product(Id, Name, Price)=> Product(Id,Name,Price)
     public class ShopContext : DbContext
    {//EntityFramework içinden gelen bir contexti miras alacak linkte örnek verilmiş
        //https://docs.microsoft.com/tr-tr/ef/core/ 
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

          //ShopContext calistiğinda hangi veritabanın çalışacağınız belirtmek için;
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=shop.db");
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

            Console.WriteLine("Hello World!"); 
        }
    }
}
