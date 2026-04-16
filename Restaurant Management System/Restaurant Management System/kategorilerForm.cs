using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; // SQL Server bağlantısı için gerekli kütüphane

namespace Restaurant_Management_System
{
    public partial class kategorilerForm : UserControl
    {
        string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\alayi\OneDrive\Desktop\Restaurant Management System\Restaurant Management System\Restaurant Management System\DatabaseRestoran.mdf;Integrated Security=True";

        public kategorilerForm()
        {
            InitializeComponent();//bu metodu ben eklemedim, formun tasarımını oluşturduğumda otomatik olarak oluştu.  
            kategoriGoster(); // Kategorileri göstermek için kategoriGoster() metodunu çağırır. en aşağıda 
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)//update butonu (güncelle)
        {
            if (getID == 0)// getID değişkeni, DataGridView'deki tıklanan satırın "id" değerini tutmak için kullanılır. Eğer getID 0 ise, kullanıcı herhangi bir kategori seçmemiş demektir.
            { 
                MessageBox.Show("Lütfen güncellemek istediğiniz kategoriyi seçiniz!", "Hata Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Error); // Eğer getID 0 ise, kullanıcıya hata mesajı gösterir
            }
            else
            {
                if (MessageBox.Show("Bunu güncellemek istediğine emin misin?", "Onay Mesajı", MessageBoxButtons.YesNo, MessageBoxIcon.Question )== DialogResult.Yes)
                {
                    using (SqlConnection connect = new SqlConnection(connection)) // Veritabanı bağlantısı için SqlConnection nesnesi oluşturulur ve bağlantı dizesi sağlanır
                    { 
                        connect.Open(); // Veritabanı bağlantısını açar
                        string updateData = "UPDATE kategoriler SET kategori = @kat, status = @status WHERE id = @id"; // SQL sorgusu, seçilen kategoriyi güncellemek için kullanılır

                        using (SqlCommand cmd = new SqlCommand(updateData, connect)) // SQL sorgusunu çalıştırmak için SqlCommand nesnesi oluşturulur
                        {
                            cmd.Parameters.AddWithValue("@id", getID); // Kullanıcının girdiği kategori adını parametre olarak ekler
                            cmd.Parameters.AddWithValue("@kat", kategori_kategori.Text.Trim()); // Kullanıcının girdiği kategori adını parametre olarak ekler
                            cmd.Parameters.AddWithValue("@status", kategori_stokdurumu.SelectedItem.ToString()); // Kullanıcının seçtiği stok durumunu parametre olarak ekler

                            cmd.ExecuteNonQuery(); // SQL sorgusunu çalıştırır ve kategoriyi veritabanında günceller
                            alaniTemizle();// Güncelleme işlemi tamamlandıktan sonra alanları temizler

                            MessageBox.Show("Kategori başarıyla güncellendi!", "Bilgi Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Information); // Kategori başarıyla güncellendiğinde kullanıcıya bilgi mesajı gösterir


                        }
                        connect.Close(); // Veritabanı bağlantısını kapatır
                    }
                }

            }
            kategoriGoster(); // Kategorileri göstermek için kategoriGoster() metodunu çağırır. en aşağıda
        }

        private void button1_Click(object sender, EventArgs e)//add butonu (ekle)
        {
            if(kategori_kategori.Text==""|| kategori_stokdurumu.SelectedIndex == -1) //burası ,seçim yapılmadığında hata versin
            {
                MessageBox.Show("Kotegori boş! Lütfen kategori adını giriniz.", "Hata Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Error); // Eğer kategori adı boşsa veya seçilmemişse, kullanıcıya hata mesajı gösterir
            }
            else
            {
                using (SqlConnection connect = new SqlConnection(connection)) // Veritabanı bağlantısı için SqlConnection nesnesi oluşturulur ve bağlantı dizesi sağlanır
                {
                    connect.Open(); // Veritabanı bağlantısını açar

                    string selectKategori = "SELECT * FROM kategoriler WHERE kategori = @kat"; // SQL sorgusu, kategori adını parametre olarak alır

                    using (SqlCommand checkKat = new SqlCommand(selectKategori, connect))// SQL sorgusunu çalıştırmak ve sonuçları almak için SqlCommand kullanılır
                    {
                        checkKat.Parameters.AddWithValue("@kat", kategori_kategori.Text.Trim()); // Kullanıcının girdiği kategori adını parametre olarak ekler

                        SqlDataAdapter adapter = new SqlDataAdapter(checkKat); // SQL sorgusunu çalıştırmak ve sonuçları almak için SqlDataAdapter kullanılır
                        DataTable table = new DataTable(); // Sonuçları tutmak için bir DataTable oluşturulur
                        adapter.Fill(table); // SQL sorgusunun sonuçları DataTable'a doldurulur

                        if (table.Rows.Count > 0)
                        {
                            MessageBox.Show(kategori_kategori.Text.Trim() + " Bu kategori zaten mevcut!", "Hata Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Error); // Eğer DataTable'da en az bir satır varsa, kategori zaten mevcut demektir
                        }
                        else
                        {
                            string insertKategori = "INSERT INTO kategoriler (kategori,status,date_insert) VALUES (@kat, @status, @date)"; // SQL sorgusu, yeni kategori eklemek için kullanılır

                            using (SqlCommand cmd = new SqlCommand(insertKategori, connect))
                            {
                                cmd.Parameters.AddWithValue("@kat", kategori_kategori.Text.Trim()); // Kullanıcının girdiği kategori adını parametre olarak ekler
                                cmd.Parameters.AddWithValue("@status", kategori_stokdurumu.SelectedItem.ToString()); // Kullanıcının seçtiği stok durumunu parametre olarak ekler

                                DateTime today = DateTime.Today; // Bugünün tarihini alır
                                cmd.Parameters.AddWithValue("@date", today); // Yeni kategori için geçerli tarihi ekler

                                cmd.ExecuteNonQuery(); // SQL sorgusunu çalıştırır ve yeni kategoriyi veritabanına ekler
                                MessageBox.Show("Kategori başarıyla eklendi!", "Bilgi Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Information); // Kategori başarıyla eklendiğinde kullanıcıya bilgi mesajı gösterir

                                alaniTemizle();
                            }
                        }
                    }
                }
            }
                kategoriGoster(); // Kategorileri göstermek için kategoriGoster() metodunu çağırır. en aşağıda
        }
        void alaniTemizle() 
        {
            kategori_kategori.Clear(); // Kategori adını temizler
            kategori_stokdurumu.SelectedIndex = -1; // Stok durumunu varsayılan olarak seçilmemiş hale getirir
            getID = 0; // getID değişkenini sıfırlar, böylece herhangi bir kategori seçilmemiş olur
        }

        private void kategori_temizlebtn_Click(object sender, EventArgs e)
        {
           alaniTemizle();
        }

        public void kategoriGoster() 
        {
            kategoriList kdata = new kategoriList(); // kategoriList tipinde bir nesne oluşturulur
            List<kategoriList> listdata = kdata.kategoriListData(); // kategoriListData() metodunu çağırarak kategorileri alır //class da oluşturdum // kategoriListData() metodu, veritabanından kategorileri alır ve bir liste olarak döndürür. daha hızlı olsun diye 

            dataGridView1.DataSource = listdata; // Alınan kategorileri DataGridView'e bağlar ve görüntüler
        }

        private int getID = 0;// getID değişkeni, DataGridView'deki tıklanan satırın "id" değerini tutmak için kullanılır
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)// DataGridView'deki bir hücreye tıklandığında çalışacak olay işleyicisidir
        {

            if (e.RowIndex >= 0) // Eğer tıklanan hücre geçerli bir satırda ise
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex]; // Tıklanan satırı alır
                getID = (int)row.Cells["id"].Value; // Satırdaki "id" hücresinin değerini getID değişkenine atar
                kategori_kategori.Text = row.Cells[1].Value.ToString(); // Satırdaki "kategori" hücresinin değerini kategori_kategori TextBox'ına atar
                kategori_stokdurumu.SelectedItem = row.Cells[2].Value.ToString(); // Satırdaki "status" hücresinin değerini kategori_stokdurumu ComboBox'ına atar
            }
        }

        private void kategori_silbtn_Click(object sender, EventArgs e)
        {
            if (getID == 0)// getID değişkeni, DataGridView'deki tıklanan satırın "id" değerini tutmak için kullanılır. Eğer getID 0 ise, kullanıcı herhangi bir kategori seçmemiş demektir.
            {
                MessageBox.Show("Lütfen silmek istediğiniz kategoriyi seçiniz!", "Hata Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Error); // Eğer getID 0 ise, kullanıcıya hata mesajı gösterir
            }
            else
            {
                if (MessageBox.Show("Bunu güncellemek istediğine emin misin?", "Onay Mesajı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (SqlConnection connect = new SqlConnection(connection)) // Veritabanı bağlantısı için SqlConnection nesnesi oluşturulur ve bağlantı dizesi sağlanır
                    {
                        connect.Open(); // Veritabanı bağlantısını açar
                        string updateData = "DELETE FROM kategoriler WHERE id = @id"; // SQL sorgusu, seçilen kategoriyi silmek için kullanılır

                        using (SqlCommand cmd = new SqlCommand(updateData, connect)) // SQL sorgusunu çalıştırmak için SqlCommand nesnesi oluşturulur
                        {
                            cmd.Parameters.AddWithValue("@id", getID); // Kullanıcının girdiği kategori adını parametre olarak ekler
                           
                            cmd.ExecuteNonQuery(); // SQL sorgusunu çalıştırır ve kategoriyi veritabanında günceller
                            alaniTemizle();// Güncelleme işlemi tamamlandıktan sonra alanları temizler

                            MessageBox.Show("Kategori silindi!", "Bilgi Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Information); // Kategori başarıyla güncellendiğinde kullanıcıya bilgi mesajı gösterir


                        }
                        connect.Close(); // Veritabanı bağlantısını kapatır
                    }
                }

            }
            kategoriGoster(); // Kategorileri göstermek için kategoriGoster() metodunu çağırır. en aşağıda
        }
    }
}
