namespace Restaurant_Management_System
{
    partial class siparisForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(siparisForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.siparis_odenenTutar = new System.Windows.Forms.TextBox();
            this.siparis_fisYazdirBtn = new System.Windows.Forms.Button();
            this.siparis_siparisTamamlaBtn = new System.Windows.Forms.Button();
            this.siparis_paraustu = new System.Windows.Forms.Label();
            this.siparis_toplam = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(22, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(690, 659);
            this.panel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Black;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(16, 15);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(658, 632);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panel2.Controls.Add(this.siparis_odenenTutar);
            this.panel2.Controls.Add(this.siparis_fisYazdirBtn);
            this.panel2.Controls.Add(this.siparis_siparisTamamlaBtn);
            this.panel2.Controls.Add(this.siparis_paraustu);
            this.panel2.Controls.Add(this.siparis_toplam);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(733, 20);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(402, 659);
            this.panel2.TabIndex = 0;
            // 
            // siparis_odenenTutar
            // 
            this.siparis_odenenTutar.Location = new System.Drawing.Point(238, 406);
            this.siparis_odenenTutar.Name = "siparis_odenenTutar";
            this.siparis_odenenTutar.Size = new System.Drawing.Size(125, 22);
            this.siparis_odenenTutar.TabIndex = 5;
            this.siparis_odenenTutar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.siparis_odenenTutar_KeyDown);
            // 
            // siparis_fisYazdirBtn
            // 
            this.siparis_fisYazdirBtn.FlatAppearance.BorderSize = 0;
            this.siparis_fisYazdirBtn.Location = new System.Drawing.Point(51, 573);
            this.siparis_fisYazdirBtn.Name = "siparis_fisYazdirBtn";
            this.siparis_fisYazdirBtn.Size = new System.Drawing.Size(312, 43);
            this.siparis_fisYazdirBtn.TabIndex = 4;
            this.siparis_fisYazdirBtn.Text = "FİŞ YAZDIR";
            this.siparis_fisYazdirBtn.UseVisualStyleBackColor = true;
            this.siparis_fisYazdirBtn.Click += new System.EventHandler(this.siparis_fisYazdirBtn_Click);
            // 
            // siparis_siparisTamamlaBtn
            // 
            this.siparis_siparisTamamlaBtn.FlatAppearance.BorderSize = 0;
            this.siparis_siparisTamamlaBtn.Location = new System.Drawing.Point(51, 499);
            this.siparis_siparisTamamlaBtn.Name = "siparis_siparisTamamlaBtn";
            this.siparis_siparisTamamlaBtn.Size = new System.Drawing.Size(312, 44);
            this.siparis_siparisTamamlaBtn.TabIndex = 3;
            this.siparis_siparisTamamlaBtn.Text = "SİPARİŞİ TAMAMLA";
            this.siparis_siparisTamamlaBtn.UseVisualStyleBackColor = true;
            this.siparis_siparisTamamlaBtn.Click += new System.EventHandler(this.siparis_siparisTamamlaBtn_Click);
            // 
            // siparis_paraustu
            // 
            this.siparis_paraustu.AutoSize = true;
            this.siparis_paraustu.ForeColor = System.Drawing.Color.White;
            this.siparis_paraustu.Location = new System.Drawing.Point(236, 457);
            this.siparis_paraustu.Name = "siparis_paraustu";
            this.siparis_paraustu.Size = new System.Drawing.Size(31, 16);
            this.siparis_paraustu.TabIndex = 1;
            this.siparis_paraustu.Text = "0.00";
            // 
            // siparis_toplam
            // 
            this.siparis_toplam.AutoSize = true;
            this.siparis_toplam.ForeColor = System.Drawing.Color.White;
            this.siparis_toplam.Location = new System.Drawing.Point(235, 375);
            this.siparis_toplam.Name = "siparis_toplam";
            this.siparis_toplam.Size = new System.Drawing.Size(31, 16);
            this.siparis_toplam.TabIndex = 1;
            this.siparis_toplam.Text = "0.00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(140, 409);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ödenen Tutar:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(161, 457);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Para Üstü:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(160, 375);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Toplam($):";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.urunAdi,
            this.Adet,
            this.Fiyat});
            this.dataGridView1.Location = new System.Drawing.Point(28, 11);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(353, 339);
            this.dataGridView1.TabIndex = 0;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            // 
            // urunAdi
            // 
            this.urunAdi.HeaderText = "UrunAdi";
            this.urunAdi.MinimumWidth = 6;
            this.urunAdi.Name = "urunAdi";
            // 
            // Adet
            // 
            this.Adet.HeaderText = "adet";
            this.Adet.MinimumWidth = 6;
            this.Adet.Name = "Adet";
            // 
            // Fiyat
            // 
            this.Fiyat.HeaderText = "Fiyat";
            this.Fiyat.MinimumWidth = 6;
            this.Fiyat.Name = "Fiyat";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // printDocument1
            // 
            this.printDocument1.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument1_BeginPrint);
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Text = "Baskı önizleme";
            this.printPreviewDialog1.Visible = false;
            // 
            // siparisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "siparisForm";
            this.Size = new System.Drawing.Size(1155, 703);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label siparis_toplam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button siparis_siparisTamamlaBtn;
        private System.Windows.Forms.Label siparis_paraustu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button siparis_fisYazdirBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fiyat;
        private System.Windows.Forms.TextBox siparis_odenenTutar;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}
