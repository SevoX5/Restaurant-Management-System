namespace Restaurant_Management_System
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cikisyap_btn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.musteriler_btn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.kategoriler_btn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.stokyonetimi_btn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.siparis_btn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.anasayfa_btn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.kategorilerForm1 = new Restaurant_Management_System.kategorilerForm();
            this.stokyonetimiForm1 = new Restaurant_Management_System.stokyonetimiForm();
            this.siparisForm1 = new Restaurant_Management_System.siparisForm();
            this.anasayfaForm1 = new Restaurant_Management_System.anasayfaForm();
            this.musterilerForm1 = new Restaurant_Management_System.musterilerForm();
            this.guna2Panel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(57, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 26);
            this.label2.TabIndex = 10;
            this.label2.Text = "Chef’s Code";
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.close.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.close.Location = new System.Drawing.Point(1347, 2);
            this.close.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(60, 23);
            this.close.TabIndex = 0;
            this.close.Text = "X";
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderRadius = 20;
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Controls.Add(this.cikisyap_btn);
            this.guna2Panel1.Controls.Add(this.musteriler_btn);
            this.guna2Panel1.Controls.Add(this.kategoriler_btn);
            this.guna2Panel1.Controls.Add(this.stokyonetimi_btn);
            this.guna2Panel1.Controls.Add(this.siparis_btn);
            this.guna2Panel1.Controls.Add(this.anasayfa_btn);
            this.guna2Panel1.Controls.Add(this.guna2CirclePictureBox1);
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.guna2Panel1.Location = new System.Drawing.Point(12, 12);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(248, 708);
            this.guna2Panel1.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.close);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1410, 26);
            this.panel1.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.musterilerForm1);
            this.panel2.Controls.Add(this.kategorilerForm1);
            this.panel2.Controls.Add(this.stokyonetimiForm1);
            this.panel2.Controls.Add(this.siparisForm1);
            this.panel2.Controls.Add(this.anasayfaForm1);
            this.panel2.Location = new System.Drawing.Point(252, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1155, 703);
            this.panel2.TabIndex = 13;
            // 
            // cikisyap_btn
            // 
            this.cikisyap_btn.BorderRadius = 10;
            this.cikisyap_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.cikisyap_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.cikisyap_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.cikisyap_btn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.cikisyap_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.cikisyap_btn.FillColor = System.Drawing.Color.Black;
            this.cikisyap_btn.FillColor2 = System.Drawing.Color.Black;
            this.cikisyap_btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cikisyap_btn.ForeColor = System.Drawing.Color.White;
            this.cikisyap_btn.Image = global::Restaurant_Management_System.Properties.Resources.Logout_Icon___Icon;
            this.cikisyap_btn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.cikisyap_btn.ImageSize = new System.Drawing.Size(40, 40);
            this.cikisyap_btn.IndicateFocus = true;
            this.cikisyap_btn.Location = new System.Drawing.Point(17, 629);
            this.cikisyap_btn.Name = "cikisyap_btn";
            this.cikisyap_btn.Size = new System.Drawing.Size(217, 56);
            this.cikisyap_btn.TabIndex = 10;
            this.cikisyap_btn.Text = "Çıkış Yap";
            this.cikisyap_btn.Click += new System.EventHandler(this.guna2GradientButton5_Click);
            // 
            // musteriler_btn
            // 
            this.musteriler_btn.BorderRadius = 10;
            this.musteriler_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.musteriler_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.musteriler_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.musteriler_btn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.musteriler_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.musteriler_btn.FillColor = System.Drawing.Color.Black;
            this.musteriler_btn.FillColor2 = System.Drawing.Color.Black;
            this.musteriler_btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.musteriler_btn.ForeColor = System.Drawing.Color.White;
            this.musteriler_btn.Image = global::Restaurant_Management_System.Properties.Resources.indir__1_;
            this.musteriler_btn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.musteriler_btn.ImageSize = new System.Drawing.Size(40, 40);
            this.musteriler_btn.IndicateFocus = true;
            this.musteriler_btn.Location = new System.Drawing.Point(17, 364);
            this.musteriler_btn.Name = "musteriler_btn";
            this.musteriler_btn.Size = new System.Drawing.Size(217, 56);
            this.musteriler_btn.TabIndex = 10;
            this.musteriler_btn.Text = "Müşteriler";
            this.musteriler_btn.Click += new System.EventHandler(this.musteriler_btn_Click);
            // 
            // kategoriler_btn
            // 
            this.kategoriler_btn.BorderRadius = 10;
            this.kategoriler_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.kategoriler_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.kategoriler_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.kategoriler_btn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.kategoriler_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.kategoriler_btn.FillColor = System.Drawing.Color.Black;
            this.kategoriler_btn.FillColor2 = System.Drawing.Color.Black;
            this.kategoriler_btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.kategoriler_btn.ForeColor = System.Drawing.Color.White;
            this.kategoriler_btn.Image = global::Restaurant_Management_System.Properties.Resources.indir__3_;
            this.kategoriler_btn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.kategoriler_btn.ImageSize = new System.Drawing.Size(40, 40);
            this.kategoriler_btn.IndicateFocus = true;
            this.kategoriler_btn.Location = new System.Drawing.Point(17, 302);
            this.kategoriler_btn.Name = "kategoriler_btn";
            this.kategoriler_btn.Size = new System.Drawing.Size(217, 56);
            this.kategoriler_btn.TabIndex = 10;
            this.kategoriler_btn.Text = "Kategoriler";
            this.kategoriler_btn.Click += new System.EventHandler(this.kategoriler_btn_Click);
            // 
            // stokyonetimi_btn
            // 
            this.stokyonetimi_btn.BorderRadius = 10;
            this.stokyonetimi_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.stokyonetimi_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.stokyonetimi_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.stokyonetimi_btn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.stokyonetimi_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.stokyonetimi_btn.FillColor = System.Drawing.Color.Black;
            this.stokyonetimi_btn.FillColor2 = System.Drawing.Color.Black;
            this.stokyonetimi_btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.stokyonetimi_btn.ForeColor = System.Drawing.Color.White;
            this.stokyonetimi_btn.Image = global::Restaurant_Management_System.Properties.Resources.Icon_Black_IPhone_notas;
            this.stokyonetimi_btn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.stokyonetimi_btn.ImageSize = new System.Drawing.Size(40, 40);
            this.stokyonetimi_btn.IndicateFocus = true;
            this.stokyonetimi_btn.Location = new System.Drawing.Point(17, 240);
            this.stokyonetimi_btn.Name = "stokyonetimi_btn";
            this.stokyonetimi_btn.Size = new System.Drawing.Size(217, 56);
            this.stokyonetimi_btn.TabIndex = 10;
            this.stokyonetimi_btn.Text = "Stok Yönetimi";
            this.stokyonetimi_btn.Click += new System.EventHandler(this.stokyonetimi_btn_Click);
            // 
            // siparis_btn
            // 
            this.siparis_btn.BorderRadius = 10;
            this.siparis_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.siparis_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.siparis_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.siparis_btn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.siparis_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.siparis_btn.FillColor = System.Drawing.Color.Black;
            this.siparis_btn.FillColor2 = System.Drawing.Color.Black;
            this.siparis_btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siparis_btn.ForeColor = System.Drawing.Color.White;
            this.siparis_btn.Image = global::Restaurant_Management_System.Properties.Resources.indir__4_;
            this.siparis_btn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.siparis_btn.ImageSize = new System.Drawing.Size(40, 40);
            this.siparis_btn.IndicateFocus = true;
            this.siparis_btn.Location = new System.Drawing.Point(17, 178);
            this.siparis_btn.Name = "siparis_btn";
            this.siparis_btn.Size = new System.Drawing.Size(217, 56);
            this.siparis_btn.TabIndex = 10;
            this.siparis_btn.Text = "Sipariş";
            this.siparis_btn.Click += new System.EventHandler(this.siparis_btn_Click);
            // 
            // anasayfa_btn
            // 
            this.anasayfa_btn.BorderRadius = 10;
            this.anasayfa_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.anasayfa_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.anasayfa_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.anasayfa_btn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.anasayfa_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.anasayfa_btn.FillColor = System.Drawing.Color.Black;
            this.anasayfa_btn.FillColor2 = System.Drawing.Color.Black;
            this.anasayfa_btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.anasayfa_btn.ForeColor = System.Drawing.Color.White;
            this.anasayfa_btn.Image = global::Restaurant_Management_System.Properties.Resources.indir;
            this.anasayfa_btn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.anasayfa_btn.ImageSize = new System.Drawing.Size(40, 40);
            this.anasayfa_btn.IndicateFocus = true;
            this.anasayfa_btn.Location = new System.Drawing.Point(17, 116);
            this.anasayfa_btn.Name = "anasayfa_btn";
            this.anasayfa_btn.Size = new System.Drawing.Size(217, 56);
            this.anasayfa_btn.TabIndex = 10;
            this.anasayfa_btn.Text = "Ana Sayfa";
            this.anasayfa_btn.Click += new System.EventHandler(this.anasayfa_btn_Click);
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBox1.Image = global::Restaurant_Management_System.Properties.Resources.logo3;
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(87, 3);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(80, 80);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox1.TabIndex = 10;
            this.guna2CirclePictureBox1.TabStop = false;
            this.guna2CirclePictureBox1.UseTransparentBackground = true;
            // 
            // kategorilerForm1
            // 
            this.kategorilerForm1.BackColor = System.Drawing.Color.Black;
            this.kategorilerForm1.Location = new System.Drawing.Point(3, 0);
            this.kategorilerForm1.Name = "kategorilerForm1";
            this.kategorilerForm1.Size = new System.Drawing.Size(1155, 703);
            this.kategorilerForm1.TabIndex = 3;
            // 
            // stokyonetimiForm1
            // 
            this.stokyonetimiForm1.BackColor = System.Drawing.Color.Black;
            this.stokyonetimiForm1.Location = new System.Drawing.Point(3, 0);
            this.stokyonetimiForm1.Name = "stokyonetimiForm1";
            this.stokyonetimiForm1.Size = new System.Drawing.Size(1155, 703);
            this.stokyonetimiForm1.TabIndex = 2;
            // 
            // siparisForm1
            // 
            this.siparisForm1.BackColor = System.Drawing.Color.Black;
            this.siparisForm1.Location = new System.Drawing.Point(3, -3);
            this.siparisForm1.Name = "siparisForm1";
            this.siparisForm1.Size = new System.Drawing.Size(1155, 703);
            this.siparisForm1.TabIndex = 1;
            // 
            // anasayfaForm1
            // 
            this.anasayfaForm1.BackColor = System.Drawing.Color.Black;
            this.anasayfaForm1.Location = new System.Drawing.Point(3, 0);
            this.anasayfaForm1.Name = "anasayfaForm1";
            this.anasayfaForm1.Size = new System.Drawing.Size(1155, 703);
            this.anasayfaForm1.TabIndex = 0;
            // 
            // musterilerForm1
            // 
            this.musterilerForm1.BackColor = System.Drawing.Color.Black;
            this.musterilerForm1.Location = new System.Drawing.Point(0, 0);
            this.musterilerForm1.Name = "musterilerForm1";
            this.musterilerForm1.Size = new System.Drawing.Size(1155, 703);
            this.musterilerForm1.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1410, 732);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button close;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2GradientButton siparis_btn;
        private Guna.UI2.WinForms.Guna2GradientButton anasayfa_btn;
        private Guna.UI2.WinForms.Guna2GradientButton cikisyap_btn;
        private Guna.UI2.WinForms.Guna2GradientButton musteriler_btn;
        private Guna.UI2.WinForms.Guna2GradientButton kategoriler_btn;
        private Guna.UI2.WinForms.Guna2GradientButton stokyonetimi_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private anasayfaForm anasayfaForm1;
        private siparisForm siparisForm1;
        private stokyonetimiForm stokyonetimiForm1;
        private kategorilerForm kategorilerForm1;
        private musterilerForm musterilerForm1;
    }
}