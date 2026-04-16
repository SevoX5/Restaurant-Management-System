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
    public partial class Form1 : Form
    {
        string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\alayi\OneDrive\Desktop\Restaurant Management System\Restaurant Management System\Restaurant Management System\DatabaseRestoran.mdf;Integrated Security=True"; 
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            using (SqlConnection connect = new SqlConnection(connection)) // Veritabanı bağlantısı için SqlConnection nesnesi oluşturulur ve bağlantı dizesi sağlanır
            {
                connect.Open();//Veritabanı bağlantısını açar

                string query = "SELECT * FROM users WHERE username = @usern AND password = @pass";// SQL sorgusu, kullanıcı adı ve şifreyi parametre olarak alır


                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    cmd.Parameters.AddWithValue("@usern", login_username.Text.Trim());
                    cmd.Parameters.AddWithValue("@pass", login_password.Text.Trim());

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);// SQL sorgusunu çalıştırmak ve sonuçları almak için SqlDataAdapter kullanılır
                    DataTable table = new DataTable();// Sonuçları tutmak için bir DataTable oluşturulur

                    adapter.Fill(table);// SQL sorgusunun sonuçları DataTable'a doldurulur

                    if (table.Rows.Count > 0)// Eğer DataTable'da en az bir satır varsa, giriş başarılı demektir
                    {
                        MessageBox.Show("Giriş başarılı!", "Bilgi Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        MainForm mainForm = new MainForm(); // Giriş başarılıysa, ana form oluşturulur
                        mainForm.Show(); // Ana form gösterilir
                        this.Hide(); // Mevcut giriş formu gizlenir
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı adı veya şifre yanlış!", "Hata Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                } // cmd using bloğu kapanışı
            } // connect using bloğu kapanışı
        }


        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

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
            signupForm signupForm = new signupForm();// signupForm isminde yeni bir sayfa nesnesi oluşturur
            signupForm.Show();                      // signupForm sayfasını gösterir
            this.Hide();                          // Mevcut giriş ekranını gizler
        }

        private void login_showpassword_CheckedChanged(object sender, EventArgs e)
        {
          login_password.PasswordChar = login_showpassword.Checked ? '\0' : '•'; // Eğer checkbox işaretliyse şifre karakterlerini göster, değilse gizle
        }

        private void login_password_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
    