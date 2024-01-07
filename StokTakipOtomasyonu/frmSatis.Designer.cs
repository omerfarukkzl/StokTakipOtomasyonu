namespace StokTakipOtomasyonu
{
    partial class frmSatis
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
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            btnMarkaListele = new Button();
            btnKategoriListele = new Button();
            btnSatislariListele = new Button();
            btnUrunListeleme = new Button();
            btnMusteriListele = new Button();
            btnMusteriEkle = new Button();
            groupBox1 = new GroupBox();
            lblTelefon = new Label();
            lblAdSoyad = new Label();
            lblTC = new Label();
            txtTelefon = new TextBox();
            txtAdSoyad = new TextBox();
            txtTC = new TextBox();
            groupBox2 = new GroupBox();
            lblToplamFiyat = new Label();
            lblSatısFiyatı = new Label();
            lblMiktar = new Label();
            lblUrunAdı = new Label();
            lblBarkodNo = new Label();
            txtToplamFiyat = new TextBox();
            txtSatısFiyat = new TextBox();
            txtMiktar = new TextBox();
            txtUrunAdı = new TextBox();
            txtBarkodNo = new TextBox();
            btnEkle = new Button();
            btn_SatısYap = new Button();
            btnSil = new Button();
            btnSatisIptal = new Button();
            label1 = new Label();
            lblGenelToplam = new Label();
            btnUrunEkleme = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(332, 140);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(858, 428);
            dataGridView1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkGray;
            panel1.Controls.Add(btnUrunEkleme);
            panel1.Controls.Add(btnMarkaListele);
            panel1.Controls.Add(btnKategoriListele);
            panel1.Controls.Add(btnSatislariListele);
            panel1.Controls.Add(btnUrunListeleme);
            panel1.Controls.Add(btnMusteriListele);
            panel1.Controls.Add(btnMusteriEkle);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1332, 125);
            panel1.TabIndex = 1;
            // 
            // btnMarkaListele
            // 
            btnMarkaListele.Font = new Font("Segoe UI Black", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnMarkaListele.Location = new Point(1213, 35);
            btnMarkaListele.Name = "btnMarkaListele";
            btnMarkaListele.Size = new Size(98, 62);
            btnMarkaListele.TabIndex = 6;
            btnMarkaListele.Text = "Marka";
            btnMarkaListele.UseVisualStyleBackColor = true;
            btnMarkaListele.Click += btnMarkaListele_Click;
            // 
            // btnKategoriListele
            // 
            btnKategoriListele.Font = new Font("Segoe UI Black", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnKategoriListele.Location = new Point(1109, 35);
            btnKategoriListele.Name = "btnKategoriListele";
            btnKategoriListele.Size = new Size(98, 62);
            btnKategoriListele.TabIndex = 5;
            btnKategoriListele.Text = "Kategori";
            btnKategoriListele.UseVisualStyleBackColor = true;
            btnKategoriListele.Click += btnKategoriListele_Click;
            // 
            // btnSatislariListele
            // 
            btnSatislariListele.Font = new Font("Segoe UI Black", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnSatislariListele.Location = new Point(859, 35);
            btnSatislariListele.Name = "btnSatislariListele";
            btnSatislariListele.Size = new Size(155, 62);
            btnSatislariListele.TabIndex = 4;
            btnSatislariListele.Text = "Satışları Listeleme";
            btnSatislariListele.UseVisualStyleBackColor = true;
            btnSatislariListele.Click += btnSatislariListele_Click;
            // 
            // btnUrunListeleme
            // 
            btnUrunListeleme.Font = new Font("Segoe UI Black", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnUrunListeleme.Location = new Point(625, 35);
            btnUrunListeleme.Name = "btnUrunListeleme";
            btnUrunListeleme.Size = new Size(155, 62);
            btnUrunListeleme.TabIndex = 3;
            btnUrunListeleme.Text = "Ürün Listeleme";
            btnUrunListeleme.UseVisualStyleBackColor = true;
            btnUrunListeleme.Click += btnUrunListeleme_Click;
            // 
            // btnMusteriListele
            // 
            btnMusteriListele.Font = new Font("Segoe UI Black", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnMusteriListele.Location = new Point(228, 35);
            btnMusteriListele.Name = "btnMusteriListele";
            btnMusteriListele.Size = new Size(155, 62);
            btnMusteriListele.TabIndex = 1;
            btnMusteriListele.Text = "Müşteri Listeleme";
            btnMusteriListele.UseVisualStyleBackColor = true;
            btnMusteriListele.Click += btnMusteriListeleme_Click;
            // 
            // btnMusteriEkle
            // 
            btnMusteriEkle.Font = new Font("Segoe UI Black", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnMusteriEkle.Location = new Point(67, 35);
            btnMusteriEkle.Name = "btnMusteriEkle";
            btnMusteriEkle.Size = new Size(155, 62);
            btnMusteriEkle.TabIndex = 0;
            btnMusteriEkle.Text = "Müşteri Ekleme";
            btnMusteriEkle.UseVisualStyleBackColor = true;
            btnMusteriEkle.Click += btnMusteriEkle_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblTelefon);
            groupBox1.Controls.Add(lblAdSoyad);
            groupBox1.Controls.Add(lblTC);
            groupBox1.Controls.Add(txtTelefon);
            groupBox1.Controls.Add(txtAdSoyad);
            groupBox1.Controls.Add(txtTC);
            groupBox1.Location = new Point(22, 140);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(285, 166);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Müşteri İşlemleri";
            // 
            // lblTelefon
            // 
            lblTelefon.AutoSize = true;
            lblTelefon.Location = new Point(51, 122);
            lblTelefon.Name = "lblTelefon";
            lblTelefon.Size = new Size(58, 20);
            lblTelefon.TabIndex = 5;
            lblTelefon.Text = "Telefon";
            // 
            // lblAdSoyad
            // 
            lblAdSoyad.AutoSize = true;
            lblAdSoyad.Location = new Point(36, 76);
            lblAdSoyad.Name = "lblAdSoyad";
            lblAdSoyad.Size = new Size(73, 20);
            lblAdSoyad.TabIndex = 4;
            lblAdSoyad.Text = "Ad Soyad";
            // 
            // lblTC
            // 
            lblTC.AutoSize = true;
            lblTC.Location = new Point(84, 30);
            lblTC.Name = "lblTC";
            lblTC.Size = new Size(25, 20);
            lblTC.TabIndex = 3;
            lblTC.Text = "TC";
            // 
            // txtTelefon
            // 
            txtTelefon.Location = new Point(135, 119);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(125, 27);
            txtTelefon.TabIndex = 2;
            // 
            // txtAdSoyad
            // 
            txtAdSoyad.Location = new Point(135, 73);
            txtAdSoyad.Name = "txtAdSoyad";
            txtAdSoyad.Size = new Size(125, 27);
            txtAdSoyad.TabIndex = 1;
            // 
            // txtTC
            // 
            txtTC.Location = new Point(135, 27);
            txtTC.Name = "txtTC";
            txtTC.Size = new Size(125, 27);
            txtTC.TabIndex = 0;
            txtTC.TextChanged += txtTC_TextChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblToplamFiyat);
            groupBox2.Controls.Add(lblSatısFiyatı);
            groupBox2.Controls.Add(lblMiktar);
            groupBox2.Controls.Add(lblUrunAdı);
            groupBox2.Controls.Add(lblBarkodNo);
            groupBox2.Controls.Add(txtToplamFiyat);
            groupBox2.Controls.Add(txtSatısFiyat);
            groupBox2.Controls.Add(txtMiktar);
            groupBox2.Controls.Add(txtUrunAdı);
            groupBox2.Controls.Add(txtBarkodNo);
            groupBox2.Location = new Point(22, 321);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(285, 247);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ürün İşlemleri";
            // 
            // lblToplamFiyat
            // 
            lblToplamFiyat.AutoSize = true;
            lblToplamFiyat.Location = new Point(15, 204);
            lblToplamFiyat.Name = "lblToplamFiyat";
            lblToplamFiyat.Size = new Size(94, 20);
            lblToplamFiyat.TabIndex = 9;
            lblToplamFiyat.Text = "Toplam Fiyat";
            // 
            // lblSatısFiyatı
            // 
            lblSatısFiyatı.AutoSize = true;
            lblSatısFiyatı.Location = new Point(30, 161);
            lblSatısFiyatı.Name = "lblSatısFiyatı";
            lblSatısFiyatı.Size = new Size(79, 20);
            lblSatısFiyatı.TabIndex = 8;
            lblSatısFiyatı.Text = "Satış Fiyatı";
            // 
            // lblMiktar
            // 
            lblMiktar.AutoSize = true;
            lblMiktar.Location = new Point(58, 118);
            lblMiktar.Name = "lblMiktar";
            lblMiktar.Size = new Size(51, 20);
            lblMiktar.TabIndex = 7;
            lblMiktar.Text = "Miktar";
            // 
            // lblUrunAdı
            // 
            lblUrunAdı.AutoSize = true;
            lblUrunAdı.Location = new Point(42, 75);
            lblUrunAdı.Name = "lblUrunAdı";
            lblUrunAdı.Size = new Size(67, 20);
            lblUrunAdı.TabIndex = 6;
            lblUrunAdı.Text = "Ürün Adı";
            // 
            // lblBarkodNo
            // 
            lblBarkodNo.AutoSize = true;
            lblBarkodNo.Location = new Point(33, 32);
            lblBarkodNo.Name = "lblBarkodNo";
            lblBarkodNo.Size = new Size(76, 20);
            lblBarkodNo.TabIndex = 5;
            lblBarkodNo.Text = "BarkodNo";
            // 
            // txtToplamFiyat
            // 
            txtToplamFiyat.Location = new Point(135, 201);
            txtToplamFiyat.Name = "txtToplamFiyat";
            txtToplamFiyat.Size = new Size(125, 27);
            txtToplamFiyat.TabIndex = 4;
            // 
            // txtSatısFiyat
            // 
            txtSatısFiyat.Location = new Point(135, 158);
            txtSatısFiyat.Name = "txtSatısFiyat";
            txtSatısFiyat.Size = new Size(125, 27);
            txtSatısFiyat.TabIndex = 3;
            // 
            // txtMiktar
            // 
            txtMiktar.Location = new Point(135, 115);
            txtMiktar.Name = "txtMiktar";
            txtMiktar.Size = new Size(125, 27);
            txtMiktar.TabIndex = 2;
            txtMiktar.Text = "1";
            txtMiktar.TextAlign = HorizontalAlignment.Center;
            txtMiktar.TextChanged += txtMiktar_TextChanged;
            // 
            // txtUrunAdı
            // 
            txtUrunAdı.Location = new Point(135, 72);
            txtUrunAdı.Name = "txtUrunAdı";
            txtUrunAdı.Size = new Size(125, 27);
            txtUrunAdı.TabIndex = 1;
            // 
            // txtBarkodNo
            // 
            txtBarkodNo.Location = new Point(135, 29);
            txtBarkodNo.Name = "txtBarkodNo";
            txtBarkodNo.Size = new Size(125, 27);
            txtBarkodNo.TabIndex = 0;
            txtBarkodNo.TextChanged += txtBarkodNo_TextChanged;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(347, 574);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(124, 58);
            btnEkle.TabIndex = 4;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // btn_SatısYap
            // 
            btn_SatısYap.Location = new Point(1055, 574);
            btn_SatısYap.Name = "btn_SatısYap";
            btn_SatısYap.Size = new Size(124, 58);
            btn_SatısYap.TabIndex = 5;
            btn_SatısYap.Text = "Satış Yap";
            btn_SatısYap.UseVisualStyleBackColor = true;
            btn_SatısYap.Click += btn_SatısYap_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(1198, 140);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(124, 58);
            btnSil.TabIndex = 6;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // btnSatisIptal
            // 
            btnSatisIptal.Location = new Point(1198, 216);
            btnSatisIptal.Name = "btnSatisIptal";
            btnSatisIptal.Size = new Size(124, 58);
            btnSatisIptal.TabIndex = 7;
            btnSatisIptal.Text = "Satış İptal";
            btnSatisIptal.UseVisualStyleBackColor = true;
            btnSatisIptal.Click += btnSatisIptal_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(655, 593);
            label1.Name = "label1";
            label1.Size = new Size(131, 28);
            label1.TabIndex = 8;
            label1.Text = "Genel Toplam";
            // 
            // lblGenelToplam
            // 
            lblGenelToplam.AutoSize = true;
            lblGenelToplam.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            lblGenelToplam.Location = new Point(794, 593);
            lblGenelToplam.Name = "lblGenelToplam";
            lblGenelToplam.Size = new Size(52, 28);
            lblGenelToplam.TabIndex = 9;
            lblGenelToplam.Text = "0 TL";
            // 
            // btnUrunEkleme
            // 
            btnUrunEkleme.Font = new Font("Segoe UI Black", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnUrunEkleme.Location = new Point(450, 35);
            btnUrunEkleme.Name = "btnUrunEkleme";
            btnUrunEkleme.Size = new Size(155, 62);
            btnUrunEkleme.TabIndex = 7;
            btnUrunEkleme.Text = "Ürün Ekleme";
            btnUrunEkleme.UseVisualStyleBackColor = true;
            btnUrunEkleme.Click += btnUrunEkleme_Click;
            // 
            // frmSatis
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(1332, 644);
            Controls.Add(lblGenelToplam);
            Controls.Add(label1);
            Controls.Add(btnSatisIptal);
            Controls.Add(btnSil);
            Controls.Add(btn_SatısYap);
            Controls.Add(btnEkle);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Name = "frmSatis";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Satış Sayfası";
            Load += frmSatis_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Panel panel1;
        private GroupBox groupBox1;
        private Label lblTelefon;
        private Label lblAdSoyad;
        private Label lblTC;
        private TextBox txtTelefon;
        private TextBox txtAdSoyad;
        private TextBox txtTC;
        private GroupBox groupBox2;
        private Label lblToplamFiyat;
        private Label lblSatısFiyatı;
        private Label lblMiktar;
        private Label lblUrunAdı;
        private Label lblBarkodNo;
        private TextBox txtToplamFiyat;
        private TextBox txtSatısFiyat;
        private TextBox txtMiktar;
        private TextBox txtUrunAdı;
        private TextBox txtBarkodNo;
        private Button btnEkle;
        private Button btn_SatısYap;
        private Button btnSil;
        private Button btnSatisIptal;
        private Button btnSatislariListele;
        private Button btnUrunListeleme;
      
        private Button btnMusteriListele;
        private Button btnMusteriEkle;
        private Label label1;
        private Label lblGenelToplam;
        private Button btnMarkaListele;
        private Button btnKategoriListele;
        private Button btnUrunEkleme;
    }
}