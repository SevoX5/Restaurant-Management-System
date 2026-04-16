namespace Restaurant_Management_System
{
    partial class stokyonetimiForm
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.stokYonetimi_ekleBtn = new Guna.UI2.WinForms.Guna2Button();
            this.stokYonetimi_guncelleBtn = new Guna.UI2.WinForms.Guna2Button();
            this.stokYonetimi_silBtn = new Guna.UI2.WinForms.Guna2Button();
            this.stokYonetimi_temizleBtn = new Guna.UI2.WinForms.Guna2Button();
            this.stokYonetimi_ImportBtn = new Guna.UI2.WinForms.Guna2Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.stokYonetimi_stokDurumu = new System.Windows.Forms.ComboBox();
            this.stokYonetimi_fiyat = new System.Windows.Forms.TextBox();
            this.stokYonetimi_stok = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.stokYonetimi_kategori = new System.Windows.Forms.ComboBox();
            this.stokYonetimi_urunadi = new System.Windows.Forms.TextBox();
            this.stokYonetmi_urunıd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(18, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1114, 413);
            this.panel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(24, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Ürün Kataloğu";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1084, 357);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panel2.Controls.Add(this.stokYonetimi_ekleBtn);
            this.panel2.Controls.Add(this.stokYonetimi_guncelleBtn);
            this.panel2.Controls.Add(this.stokYonetimi_silBtn);
            this.panel2.Controls.Add(this.stokYonetimi_temizleBtn);
            this.panel2.Controls.Add(this.stokYonetimi_ImportBtn);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.stokYonetimi_stokDurumu);
            this.panel2.Controls.Add(this.stokYonetimi_fiyat);
            this.panel2.Controls.Add(this.stokYonetimi_stok);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.stokYonetimi_kategori);
            this.panel2.Controls.Add(this.stokYonetimi_urunadi);
            this.panel2.Controls.Add(this.stokYonetmi_urunıd);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(18, 460);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1114, 219);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // stokYonetimi_ekleBtn
            // 
            this.stokYonetimi_ekleBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.stokYonetimi_ekleBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.stokYonetimi_ekleBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.stokYonetimi_ekleBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.stokYonetimi_ekleBtn.FillColor = System.Drawing.Color.White;
            this.stokYonetimi_ekleBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.stokYonetimi_ekleBtn.ForeColor = System.Drawing.Color.Black;
            this.stokYonetimi_ekleBtn.Location = new System.Drawing.Point(51, 172);
            this.stokYonetimi_ekleBtn.Name = "stokYonetimi_ekleBtn";
            this.stokYonetimi_ekleBtn.Size = new System.Drawing.Size(122, 34);
            this.stokYonetimi_ekleBtn.TabIndex = 10;
            this.stokYonetimi_ekleBtn.Text = "EKLE";
            this.stokYonetimi_ekleBtn.Click += new System.EventHandler(this.stokYonetimi_ekleBtn_Click);
            // 
            // stokYonetimi_guncelleBtn
            // 
            this.stokYonetimi_guncelleBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.stokYonetimi_guncelleBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.stokYonetimi_guncelleBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.stokYonetimi_guncelleBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.stokYonetimi_guncelleBtn.FillColor = System.Drawing.Color.White;
            this.stokYonetimi_guncelleBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.stokYonetimi_guncelleBtn.ForeColor = System.Drawing.Color.Black;
            this.stokYonetimi_guncelleBtn.Location = new System.Drawing.Point(248, 172);
            this.stokYonetimi_guncelleBtn.Name = "stokYonetimi_guncelleBtn";
            this.stokYonetimi_guncelleBtn.Size = new System.Drawing.Size(122, 34);
            this.stokYonetimi_guncelleBtn.TabIndex = 10;
            this.stokYonetimi_guncelleBtn.Text = "GÜNCELLE";
            this.stokYonetimi_guncelleBtn.Click += new System.EventHandler(this.stokYonetimi_guncelleBtn_Click);
            // 
            // stokYonetimi_silBtn
            // 
            this.stokYonetimi_silBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.stokYonetimi_silBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.stokYonetimi_silBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.stokYonetimi_silBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.stokYonetimi_silBtn.FillColor = System.Drawing.Color.White;
            this.stokYonetimi_silBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.stokYonetimi_silBtn.ForeColor = System.Drawing.Color.Black;
            this.stokYonetimi_silBtn.Location = new System.Drawing.Point(492, 172);
            this.stokYonetimi_silBtn.Name = "stokYonetimi_silBtn";
            this.stokYonetimi_silBtn.Size = new System.Drawing.Size(122, 34);
            this.stokYonetimi_silBtn.TabIndex = 10;
            this.stokYonetimi_silBtn.Text = "SİL";
            this.stokYonetimi_silBtn.Click += new System.EventHandler(this.stokYonetimi_silBtn_Click);
            // 
            // stokYonetimi_temizleBtn
            // 
            this.stokYonetimi_temizleBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.stokYonetimi_temizleBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.stokYonetimi_temizleBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.stokYonetimi_temizleBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.stokYonetimi_temizleBtn.FillColor = System.Drawing.Color.White;
            this.stokYonetimi_temizleBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.stokYonetimi_temizleBtn.ForeColor = System.Drawing.Color.Black;
            this.stokYonetimi_temizleBtn.Location = new System.Drawing.Point(678, 172);
            this.stokYonetimi_temizleBtn.Name = "stokYonetimi_temizleBtn";
            this.stokYonetimi_temizleBtn.Size = new System.Drawing.Size(122, 34);
            this.stokYonetimi_temizleBtn.TabIndex = 10;
            this.stokYonetimi_temizleBtn.Text = "TEMİZLE";
            this.stokYonetimi_temizleBtn.Click += new System.EventHandler(this.stokYonetimi_temizleBtn_Click);
            // 
            // stokYonetimi_ImportBtn
            // 
            this.stokYonetimi_ImportBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.stokYonetimi_ImportBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.stokYonetimi_ImportBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.stokYonetimi_ImportBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.stokYonetimi_ImportBtn.FillColor = System.Drawing.Color.White;
            this.stokYonetimi_ImportBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.stokYonetimi_ImportBtn.ForeColor = System.Drawing.Color.Black;
            this.stokYonetimi_ImportBtn.Location = new System.Drawing.Point(951, 145);
            this.stokYonetimi_ImportBtn.Name = "stokYonetimi_ImportBtn";
            this.stokYonetimi_ImportBtn.Size = new System.Drawing.Size(122, 45);
            this.stokYonetimi_ImportBtn.TabIndex = 10;
            this.stokYonetimi_ImportBtn.Text = "IMPORT";
            this.stokYonetimi_ImportBtn.Click += new System.EventHandler(this.stokYonetimi_ImportBtn_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(35)))));
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(951, 10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(122, 129);
            this.panel3.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(122, 129);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // stokYonetimi_stokDurumu
            // 
            this.stokYonetimi_stokDurumu.FormattingEnabled = true;
            this.stokYonetimi_stokDurumu.Items.AddRange(new object[] {
            "Mevcut",
            "Tükendi"});
            this.stokYonetimi_stokDurumu.Location = new System.Drawing.Point(521, 118);
            this.stokYonetimi_stokDurumu.Name = "stokYonetimi_stokDurumu";
            this.stokYonetimi_stokDurumu.Size = new System.Drawing.Size(264, 24);
            this.stokYonetimi_stokDurumu.TabIndex = 8;
            // 
            // stokYonetimi_fiyat
            // 
            this.stokYonetimi_fiyat.Location = new System.Drawing.Point(521, 79);
            this.stokYonetimi_fiyat.Name = "stokYonetimi_fiyat";
            this.stokYonetimi_fiyat.Size = new System.Drawing.Size(264, 22);
            this.stokYonetimi_fiyat.TabIndex = 6;
            // 
            // stokYonetimi_stok
            // 
            this.stokYonetimi_stok.Location = new System.Drawing.Point(521, 37);
            this.stokYonetimi_stok.Name = "stokYonetimi_stok";
            this.stokYonetimi_stok.Size = new System.Drawing.Size(264, 22);
            this.stokYonetimi_stok.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(431, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Stok Durumu :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(478, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Fiyat :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(480, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "Stok :";
            // 
            // stokYonetimi_kategori
            // 
            this.stokYonetimi_kategori.FormattingEnabled = true;
            this.stokYonetimi_kategori.Location = new System.Drawing.Point(106, 115);
            this.stokYonetimi_kategori.Name = "stokYonetimi_kategori";
            this.stokYonetimi_kategori.Size = new System.Drawing.Size(264, 24);
            this.stokYonetimi_kategori.TabIndex = 2;
            // 
            // stokYonetimi_urunadi
            // 
            this.stokYonetimi_urunadi.Location = new System.Drawing.Point(106, 76);
            this.stokYonetimi_urunadi.Name = "stokYonetimi_urunadi";
            this.stokYonetimi_urunadi.Size = new System.Drawing.Size(264, 22);
            this.stokYonetimi_urunadi.TabIndex = 1;
            this.stokYonetimi_urunadi.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // stokYonetmi_urunıd
            // 
            this.stokYonetmi_urunıd.Location = new System.Drawing.Point(106, 34);
            this.stokYonetmi_urunıd.Name = "stokYonetmi_urunıd";
            this.stokYonetmi_urunıd.Size = new System.Drawing.Size(264, 22);
            this.stokYonetmi_urunıd.TabIndex = 1;
            this.stokYonetmi_urunıd.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(41, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Kategori :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(41, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ürün Adı :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(48, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün ID :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // stokyonetimiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "stokyonetimiForm";
            this.Size = new System.Drawing.Size(1155, 703);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox stokYonetimi_urunadi;
        private System.Windows.Forms.TextBox stokYonetmi_urunıd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox stokYonetimi_kategori;
        private System.Windows.Forms.ComboBox stokYonetimi_stokDurumu;
        private System.Windows.Forms.TextBox stokYonetimi_fiyat;
        private System.Windows.Forms.TextBox stokYonetimi_stok;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2Button stokYonetimi_ImportBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button stokYonetimi_ekleBtn;
        private Guna.UI2.WinForms.Guna2Button stokYonetimi_guncelleBtn;
        private Guna.UI2.WinForms.Guna2Button stokYonetimi_silBtn;
        private Guna.UI2.WinForms.Guna2Button stokYonetimi_temizleBtn;
    }
}
