using System;
using System.Data;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace Ders_42_MsSQL_Baglanti
{// Yeni Proje ve dosya olusturmak icin -> dotnet new console -o  Ders_
    class Program
    {
        static void Main(string[] args)
        {
            GetSqlConnection();
            GetMySqlConnection();
        }
        static void GetMySqlConnection(){
            //MySql Server e bağlantı işlemi
            string connectionString=@"server=127.0.0.1;port=3306;database=northwind;user=root;password=12345;";
            //consol ekranına dotnet add package MySql.Data yazıp driveri projemize ekliyoruz.
            using (var connection=new MySqlConnection(connectionString))
            {
                try
                {
                connection.Open();
                Console.WriteLine("MySQL Server Bağlantı Sağlandı...");
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
