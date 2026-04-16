namespace Restaurant_Management_System
{
    partial class kategorilerForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.kategori_silbtn = new System.Windows.Forms.Button();
            this.kategori_temizlebtn = new System.Windows.Forms.Button();
            this.kategori_guncellebtn = new System.Windows.Forms.Button();
            this.kategori_eklebtn = new System.Windows.Forms.Button();
            this.kategori_stokdurumu = new System.Windows.Forms.ComboBox();
            this.kategori_kategori = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.kategori_silbtn);
            this.panel1.Controls.Add(this.kategori_temizlebtn);
            this.panel1.Controls.Add(this.kategori_guncellebtn);
            this.panel1.Controls.Add(this.kategori_eklebtn);
            this.panel1.Controls.Add(this.kategori_stokdurumu);
            this.panel1.Controls.Add(this.kategori_kategori);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(21, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(307, 660);
            this.panel1.TabIndex = 0;
            // 
            // kategori_silbtn
            // 
            this.kategori_silbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kategori_silbtn.Location = new System.Drawing.Point(159, 305);
            this.kategori_silbtn.Name = "kategori_silbtn";
            this.kategori_silbtn.Size = new System.Drawing.Size(114, 48);
            this.kategori_silbtn.TabIndex = 5;
            this.kategori_silbtn.Text = "SİL";
            this.kategori_silbtn.UseVisualStyleBackColor = true;
            this.kategori_silbtn.Click += new System.EventHandler(this.kategori_silbtn_Click);
            // 
            // kategori_temizlebtn
            // 
            this.kategori_temizlebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kategori_temizlebtn.Location = new System.Drawing.Point(25, 305);
            this.kategori_temizlebtn.Name = "kategori_temizlebtn";
            this.kategori_temizlebtn.Size = new System.Drawing.Size(114, 48);
            this.kategori_temizlebtn.TabIndex = 6;
            this.kategori_temizlebtn.Text = "TEMİZLE";
            this.kategori_temizlebtn.UseVisualStyleBackColor = true;
            this.kategori_temizlebtn.Click += new System.EventHandler(this.kategori_temizlebtn_Click);
            // 
            // kategori_guncellebtn
            // 
            this.kategori_guncellebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kategori_guncellebtn.Location = new System.Drawing.Point(159, 240);
            this.kategori_guncellebtn.Name = "kategori_guncellebtn";
            this.kategori_guncellebtn.Size = new System.Drawing.Size(114, 48);
            this.kategori_guncellebtn.TabIndex = 2;
            this.kategori_guncellebtn.Text = "GÜNCELLE";
            this.kategori_guncellebtn.UseVisualStyleBackColor = true;
            this.kategori_guncellebtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // kategori_eklebtn
            // 
            this.kategori_eklebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kategori_eklebtn.Location = new System.Drawing.Point(25, 240);
            this.kategori_eklebtn.Name = "kategori_eklebtn";
            this.kategori_eklebtn.Size = new System.Drawing.Size(114, 48);
            this.kategori_eklebtn.TabIndex = 2;
            this.kategori_eklebtn.Text = "EKLE";
            this.kategori_eklebtn.UseVisualStyleBackColor = true;
            this.kategori_eklebtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // kategori_stokdurumu
            // 
            this.kategori_stokdurumu.FormattingEnabled = true;
            this.kategori_stokdurumu.Items.AddRange(new object[] {
            "Aktif",
            "Pasif"});
            this.kategori_stokdurumu.Location = new System.Drawing.Point(25, 166);
            this.kategori_stokdurumu.Name = "kategori_stokdurumu";
            this.kategori_stokdurumu.Size = new System.Drawing.Size(248, 24);
            this.kategori_stokdurumu.TabIndex = 4;
            // 
            // kategori_kategori
            // 
            this.kategori_kategori.Location = new System.Drawing.Point(25, 63);
            this.kategori_kategori.Name = "kategori_kategori";
            this.kategori_kategori.Size = new System.Drawing.Size(248, 22);
            this.kategori_kategori.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(22, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Stok Durumu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(22, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Kategori";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(346, 19);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(774, 660);
            this.panel2.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(20, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(727, 611);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(17, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kategori Listesi";
            // 
            // kategorilerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "kategorilerForm";
            this.Size = new System.Drawing.Size(1155, 703);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox kategori_stokdurumu;
        private System.Windows.Forms.TextBox kategori_kategori;
        private System.Windows.Forms.Button kategori_eklebtn;
        private System.Windows.Forms.Button kategori_guncellebtn;
        private System.Windows.Forms.Button kategori_silbtn;
        private System.Windows.Forms.Button kategori_temizlebtn;
    }
}
