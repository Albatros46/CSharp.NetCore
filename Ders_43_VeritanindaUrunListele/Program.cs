using System;
using System.Data;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace Ders_43_VeritanindaUrunListele
{// Yeni Proje ve dosya olusturmak icin -> dotnet new console -o  Ders_
    class Program
    {
        static void Main(string[] args)
        {
            GetAllProducts();
        }
        static void GetAllProducts()
        {
            using (var connection=GetMySqlConnection())
            {
                try
                {
                    connection.Open();
                    Console.WriteLine("MySQL Server Bağlantı Sağlandı...");
                    string sql="SELECT * FROM northwind.products;";
                    MySqlCommand command= new MySqlCommand(sql,connection);
                    MySqlDataReader reader=command.ExecuteReader();
                    while (reader.Read())
                    {
                        Console.WriteLine($"Ürün Adı:{reader[3]} Ürün Fiyatı:{reader[6]}");
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
         static MySqlConnection GetMySqlConnection()
        {
            //MySql Server e bağlantı işlemi
            //consol ekranına dotnet add package MySql.Data yazıp driveri projemize ekliyoruz.
            string connectionString=@"server=127.0.0.1;port=3306;database=northwind;user=root;password=12345;";
            return new MySqlConnection(connectionString);
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
