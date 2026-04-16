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
    public partial class signupForm : Form
    {
        string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\alayi\OneDrive\Desktop\Restaurant Management System\Restaurant Management System\Restaurant Management System\DatabaseRestoran.mdf;Integrated Security=True";
        public signupForm()
        {
            InitializeComponent();
        }

        private void close_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Uygulamadan çıkmak istediğinize emin misiniz?", "Çıkış Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit(); // Eğer kullanıcı 'Evet' derse program kapanır.
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Form1 loginForm = new Form1();// Form1 isminde yeni bir sayfa nesnesi oluşturur
            loginForm.Show();            // Oluşturulan sayfayı ekranda gösterir
            this.Hide();                // Mevcut giriş ekranını gizler
        }

        private void signup_showpassword_CheckedChanged(object sender, EventArgs e)
        {
            signup_password.PasswordChar = signup_showpassword.Checked ? '\0' : '*'; // Şifre kutusunun karakterlerini göster/gizle
            signup_confirmPassword.PasswordChar = signup_showpassword.Checked ? '\0' : '*';
        }

        private void signup_btn_Click(object sender, EventArgs e)
        {
            using (SqlConnection connect = new SqlConnection(connection))// Veritabanı bağlantısı için SqlConnection nesnesi oluşturulur ve bağlantı dizesi sağlanır
            {
                connect.Open();

                string checkUsername = "SELECT * FROM users WHERE username = @usern";// Kullanıcı adının veritabanında zaten var olup olmadığını kontrol eden SQL sorgusu//checkUsername değişkeni, kullanıcı adının veritabanında zaten var olup olmadığını kontrol eden SQL sorgusunu içerir. Bu sorgu, "users" tablosunda "username" sütununda belirtilen kullanıcı adını arar ve eşleşen kayıtları döndürür. Eğer sorgu sonuç döndürürse, bu kullanıcı adının zaten var olduğu anlamına gelir ve yeni bir kullanıcı oluşturulamaz.

                using (SqlCommand checkUsern = new SqlCommand(checkUsername, connect))// SQL sorgusunu çalıştırmak ve sonuçları almak için SqlCommand kullanılır
                {
                    checkUsern.Parameters.AddWithValue("@usern", signup_username.Text.Trim());// SQL sorgusuna kullanıcı adını parametre olarak ekler. signup_username.Text.Trim() ifadesi, kullanıcı adını alır ve başındaki ve sonundaki boşlukları kaldırır. Bu şekilde, kullanıcı adının veritabanında doğru bir şekilde karşılaştırılması sağlanır.

                    SqlDataAdapter adapter = new SqlDataAdapter(checkUsern);// SQL sorgusunu çalıştırmak ve sonuçları almak için SqlDataAdapter kullanılır

                    DataTable table = new DataTable();// Sonuçları tutmak için bir DataTable oluşturulur//geçici bir tablo oluşturulur ve SQL sorgusunun sonuçları bu tabloya doldurulur. Bu tablo, kullanıcı adının veritabanında zaten var olup olmadığını kontrol etmek için kullanılır.

                    adapter.Fill(table);// SQL sorgusunun sonuçları DataTable'a doldurulur

                    if (table.Rows.Count != 0)// Eğer DataTable'da en az bir satır varsa, bu kullanıcı adının zaten var olduğu anlamına gelir ve yeni bir kullanıcı oluşturulamaz
                    {
                        MessageBox.Show("Bu kullanıcı adı zaten mevcut! Lütfen başka bir kullanıcı adı seçin.", "Hata Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (signup_password.Text.Trim().Length < 8)
                    {
                        MessageBox.Show("Şifre en az 8 karakter uzunluğunda olmalıdır!", "Hata Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    else if (signup_password.Text.Trim() != signup_confirmPassword.Text.Trim())
                    {
                        MessageBox.Show("Şifreler eşleşmiyor! Lütfen şifreleri kontrol edin.", "Hata Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        string insertData = "INSERT INTO users (username, password,status,date_created) VALUES (@usern, @pass, @status, @date)";// Yeni kullanıcıyı veritabanına eklemek için SQL sorgusu
                        using (SqlCommand cmd = new SqlCommand(insertData, connect))// SQL sorgusunu çalıştırmak ve yeni kullanıcıyı veritabanına eklemek için SqlCommand kullanılır
                        {
                            cmd.Parameters.AddWithValue("@usern", signup_username.Text.Trim());
                            cmd.Parameters.AddWithValue("@pass", signup_password.Text.Trim());
                            cmd.Parameters.AddWithValue("@status", "Active");

                            DateTime today = DateTime.Today; // Bugünün tarihini alır
                            cmd.Parameters.AddWithValue("@date", today);

                            cmd.ExecuteNonQuery();// SQL sorgusunu çalıştırır ve yeni kullanıcıyı veritabanına ekler
                            MessageBox.Show("Kayıt başarılı! Giriş yapabilirsiniz.", "Bilgi Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            Form1 loginForm = new Form1();//bu satır, kullanıcı kaydı başarılı olduktan sonra giriş ekranına yönlendirmek için Form1 sınıfından bir nesne oluşturur. Form1, giriş ekranını temsil eder ve bu nesne oluşturulduktan sonra Show() yöntemi çağrılarak ekranda gösterilir. Ardından, this.Hide() ifadesi ile mevcut kayıt ekranı gizlenir, böylece kullanıcı sadece giriş ekranını görür.
                            loginForm.Show();// Form1 sınıfından bir nesne oluşturur ve giriş ekranını gösterir
                            this.Hide();// Mevcut kayıt ekranını gizler
                        }
                    }


                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
