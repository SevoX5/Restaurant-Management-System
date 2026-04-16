using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data; // DataTable gibi veri yapıları için gerekli kütüphane
using System.Data.SqlClient; // SQL Server bağlantısı için gerekli kütüphane

namespace Restaurant_Management_System
{

    internal class kategoriList
    {
        string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\alayi\OneDrive\Desktop\Restaurant Management System\Restaurant Management System\Restaurant Management System\DatabaseRestoran.mdf;Integrated Security=True";
    
        public int ID { set; get; } 
        public string KATEGORİ { set; get; } 
        public string DURUM { set; get; }
        public string TARİH { set; get; }

        public List<kategoriList> kategoriListData() 
        {
            List<kategoriList> listData = new List<kategoriList>(); // kategoriList tipinde bir liste oluşturulur

            using (SqlConnection connect = new SqlConnection(connection))// SQL Server bağlantısı oluşturulur
            {
                connect.Open(); // Veritabanı bağlantısını açar

                string selectData = "SELECT * FROM kategoriler"; // SQL sorgusu, kategoriler tablosundaki tüm verileri seçer

                using (SqlCommand cmd = new SqlCommand(selectData, connect))// SQL sorgusunu çalıştırmak için SqlCommand nesnesi oluşturulur
                {
                    SqlDataReader reader = cmd.ExecuteReader(); // SQL sorgusunu çalıştırır ve sonuçları SqlDataReader ile okur
                    while (reader.Read()) 
                    {
                        kategoriList kdata = new kategoriList() // kategoriList tipinde bir nesne oluşturulur ve veriler atanır
                        {
                            ID = (int)reader["id"],// SQL sorgusundan dönen "id" sütunundaki değeri int türüne dönüştürerek id özelliğine atar
                            KATEGORİ = reader["kategori"].ToString(),
                            DURUM = reader["status"].ToString(),
                            // Tarihi önce DateTime'a çevirip sonra formatlıyoruz
                            TARİH = ((DateTime)reader["date_insert"]).ToString("dd-MM-yyyy")

                            
                        };
                        listData.Add(kdata);
                         // Oluşturulan nesne listeye eklenir
                    }
                }

                return listData;// Veritabanından çekilen verilerle doldurulmuş liste döndürülür
            }
        }

    }
}
