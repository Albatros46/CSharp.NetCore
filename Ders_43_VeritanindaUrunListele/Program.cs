using System;
using System.Data;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace Ders_43_VeritanindaUrunListele
{// Yeni Proje ve dosya olusturmak icin -> dotnet new console -o  Ders_
    interface IProductDal
    {
        List<Product> GelAllProducts();
        Product GetProductById(int id);
        void Create(Product p);
        void Update(Product p);
        void Delete(int productId);
    }
    public class MySQLProductDal:IProductDal
    {
        private MySqlConnection GetMySqlConnection(){

            //MySql Server e bağlantı işlemi
            //consol ekranına dotnet add package MySql.Data yazıp driveri projemize ekliyoruz.
            string connectionString=@"server=127.0.0.1;port=3306;database=northwind;user=root;password=12345;";
            return new MySqlConnection(connectionString);
        }
        public void Create(Product p){

        }
        public void Update(Product p){

        }
        public void Delete(int productId){

        }
        public  Product GetProductById(int id){

        }
        public List<Product> GelAllProducts(){
             List<Product> products=null;
             using (var connection=GetMySqlConnection())
             return products;
            {
                try
                {
                    connection.Open();
                    Console.WriteLine("MySQL Server Bağlantı Sağlandı...");
                    string sql="SELECT * FROM northwind.products;";
                    MySqlCommand command= new MySqlCommand(sql,connection);
                    MySqlDataReader reader=command.ExecuteReader();
                    products=new List<Product>();

                    while (reader.Read())
                    {
                        products.Add(new Product{ProductId=int.Parse(reader["id"].ToString()),
                        Name=reader["product_name"].ToString(), Price=double.Parse(reader["list_price"]?.ToString())
                        //Verilerin db den obje isimleri ile çekilme işlemi. 
                            }
                        );
                       // Console.WriteLine($"Ürün Adı:{reader[3]} Ürün Fiyatı:{reader[6]}");
                    }
                    reader.Close();
                }
                 catch (Exception e)
                 {
                Console.WriteLine("Bağlantı Sağlanamadı! Hata : ",e.Message);
                 }
                 finally
                {
                    connection.Close();
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var products = GetAllProducts();
            foreach (var pr in products)
            {
                Console.WriteLine($"Id :{pr.ProductId} Name :{pr.Name} Price :{pr.Price}");
            }
        }
        static List<Product> GetAllProducts()
        {
           
        }
       
        static void GetSqlConnection(){
            //MsSQL Server e bağlanacağiz
            // @ ekleyerek \ in string ifade içinde olduğunu belirtiyoruz.
            string connectionString=@"Data Source=.\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=SSPI;"; 
                                    //Data Source=SERVER ADI ;Initial Catalog=VERİTABANI ADI;Integrated Security=SSPI;";
            //Drive veya provider yüklemek için
            //consol ekranına dotnet add package System.Data.SqlClient yazıp driveri projemize ekliyoruz.
            using (SqlConnection connection=new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    Console.WriteLine("MsSQL Server Bağlantı Sağlandı...");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Bağlantı Sağlanamadı! Hata : ",ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }
    }
}
