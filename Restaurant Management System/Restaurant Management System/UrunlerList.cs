using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Restaurant_Management_System
{
     class UrunlerList//veritabının tüm bilgilerini çekmek için oluşturulan UrunlerList sınıfı
    {
        string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\alayi\OneDrive\Desktop\Restaurant Management System\Restaurant Management System\Restaurant Management System\DatabaseRestoran.mdf;Integrated Security=True";

        public int ID { get; set; }
        public string UrunId { get; set; }
        public string UrunAdi { get; set; }
        public string Kategori { get; set; }
        public string Stok { get; set; }
        public string Fiyat { get; set; }
        public string stokDurumu { get; set; }
        public string image { get; set; }
        public string DateInsert { get; set; }
        public string DateUpdate { get; set; }


        public List<UrunlerList> UrunlerListData()// UrunlerListData metodu, veritabanından ürün bilgilerini okuyarak bir liste halinde döndürür
        {
            List<UrunlerList> listData = new List<UrunlerList>();// UrunlerList tipinde bir liste oluşturulur

            using (SqlConnection connect = new SqlConnection(connection)) 
            { 
                connect.Open();
                string selectData="SELECT * FROM urunler ";
                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();// Veritabanından veri okumak için SqlDataReader kullanılır
                    while (reader.Read())// Veritabanından okunan her bir kayıt için döngü çalışır
                    {
                       UrunlerList uList=new UrunlerList();// Veritabanından okunan her bir kayıt için yeni bir nesne oluşturulur
                        uList.ID = (int)reader["id"];
                        uList.UrunId = reader["urun_id"].ToString();
                        uList.UrunAdi = reader["urun_adi"].ToString();
                        uList.Kategori = reader["kategori"].ToString();
                        uList.Stok = reader["stok"].ToString();
                        uList.Fiyat = reader["fiyat"].ToString();
                        uList.stokDurumu = reader["stok_durumu"].ToString();
                        uList.image = reader["image"].ToString();
                        uList.DateInsert = ((DateTime)reader["date_insert"]).ToString("MM-dd-yyyy");
                        uList.DateUpdate = reader["date_update"] == DBNull.Value ? null : ((DateTime)reader["date_update"]).ToString("MM-dd-yyyy");//error verdiğin için chatten aldım 
                        listData.Add(uList);// Oluşturulan nesne listeye eklenir
                    }
                }

            }
            return listData;// Veritabanından çekilen verilerle doldurulmuş liste döndürülür
        }

    }
}
