using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_Management_System
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void close_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Uygulamadan çıkmak istediğinize emin misiniz?", "Çıkış Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit(); // Eğer kullanıcı 'Evet' derse program kapanır.
            }
        }

        private void guna2GradientButton5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Oturumu kapatmak istediğinize emin misiniz ? ", "Onay Mesajı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Form1 loginForm = new Form1(); // Giriş formunu oluştur
                loginForm.Show(); // Giriş formunu göster
                this.Hide(); // Eğer kullanıcı 'Evet' derse program kapanır.
            }

        }

        private void anasayfa_btn_Click(object sender, EventArgs e)
        {
            anasayfaForm1.Visible = true;// Anasayfa formunu görünür yapar diğer formları görünmez yapar
            siparisForm1.Visible = false;//tüm butonlar için aynı işeyapacak şekilde kodlar yazıldı
            stokyonetimiForm1.Visible = false;
            kategorilerForm1.Visible = false;
            musterilerForm1.Visible = false;


        }

        private void siparis_btn_Click(object sender, EventArgs e)
        {
            anasayfaForm1.Visible = false;
            siparisForm1.Visible = true;
            stokyonetimiForm1.Visible = false;
            kategorilerForm1.Visible = false;
            musterilerForm1.Visible = false;
        }

        private void stokyonetimi_btn_Click(object sender, EventArgs e)
        {
            anasayfaForm1.Visible = false;
            siparisForm1.Visible = false;
            stokyonetimiForm1.Visible = true;
            kategorilerForm1.Visible = false;
            musterilerForm1.Visible = false;
        }

        private void kategoriler_btn_Click(object sender, EventArgs e)
        {
            anasayfaForm1.Visible = false;
            siparisForm1.Visible = false;
            stokyonetimiForm1.Visible = false;
            kategorilerForm1.Visible = true;
            musterilerForm1.Visible = false;
        }

        private void musteriler_btn_Click(object sender, EventArgs e)
        {
            anasayfaForm1.Visible = false;
            siparisForm1.Visible = false;
            stokyonetimiForm1.Visible = false;
            kategorilerForm1.Visible = false;
            musterilerForm1.Visible = true;
        }
    }
}
