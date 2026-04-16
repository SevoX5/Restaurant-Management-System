namespace Restaurant_Management_System
{
    partial class urunKart
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.urunadi = new System.Windows.Forms.Label();
            this.fiyat = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.stok = new System.Windows.Forms.Label();
            this.adet = new System.Windows.Forms.TextBox();
            this.ekle_btn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(191, 136);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(192, 136);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // urunadi
            // 
            this.urunadi.AutoSize = true;
            this.urunadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.urunadi.Location = new System.Drawing.Point(3, 139);
            this.urunadi.Name = "urunadi";
            this.urunadi.Size = new System.Drawing.Size(82, 20);
            this.urunadi.TabIndex = 1;
            this.urunadi.Text = "Ürün Adı";
            // 
            // fiyat
            // 
            this.fiyat.AutoSize = true;
            this.fiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.fiyat.Location = new System.Drawing.Point(3, 159);
            this.fiyat.Name = "fiyat";
            this.fiyat.Size = new System.Drawing.Size(38, 16);
            this.fiyat.TabIndex = 1;
            this.fiyat.Text = "$0.00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(3, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Stok :";
            // 
            // stok
            // 
            this.stok.AutoSize = true;
            this.stok.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.stok.Location = new System.Drawing.Point(45, 175);
            this.stok.Name = "stok";
            this.stok.Size = new System.Drawing.Size(14, 16);
            this.stok.TabIndex = 1;
            this.stok.Text = "0";
            // 
            // adet
            // 
            this.adet.Location = new System.Drawing.Point(48, 195);
            this.adet.Name = "adet";
            this.adet.Size = new System.Drawing.Size(57, 22);
            this.adet.TabIndex = 2;
            // 
            // ekle_btn
            // 
            this.ekle_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.ekle_btn.FlatAppearance.BorderSize = 0;
            this.ekle_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.ekle_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ekle_btn.ForeColor = System.Drawing.Color.White;
            this.ekle_btn.Location = new System.Drawing.Point(111, 194);
            this.ekle_btn.Name = "ekle_btn";
            this.ekle_btn.Size = new System.Drawing.Size(62, 24);
            this.ekle_btn.TabIndex = 3;
            this.ekle_btn.Text = "EKLE";
            this.ekle_btn.UseVisualStyleBackColor = false;
            this.ekle_btn.Click += new System.EventHandler(this.ekle_btn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(4, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Adet :";
            // 
            // urunKart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.ekle_btn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.adet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.stok);
            this.Controls.Add(this.fiyat);
            this.Controls.Add(this.urunadi);
            this.Controls.Add(this.panel1);
            this.Name = "urunKart";
            this.Size = new System.Drawing.Size(191, 237);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label urunadi;
        private System.Windows.Forms.Label fiyat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label stok;
        private System.Windows.Forms.TextBox adet;
        private System.Windows.Forms.Button ekle_btn;
        private System.Windows.Forms.Label label5;
    }
}
