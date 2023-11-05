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
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
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
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1332, 125);
            panel1.TabIndex = 1;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI Black", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button5.Location = new Point(1113, 35);
            button5.Name = "button5";
            button5.Size = new Size(155, 62);
            button5.TabIndex = 4;
            button5.Text = "Satışları Listeleme";
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI Black", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(794, 35);
            button4.Name = "button4";
            button4.Size = new Size(155, 62);
            button4.TabIndex = 3;
            button4.Text = "Ürün Listeleme";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI Black", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(633, 35);
            button3.Name = "button3";
            button3.Size = new Size(155, 62);
            button3.TabIndex = 2;
            button3.Text = "Ürün Ekleme";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Black", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(228, 35);
            button2.Name = "button2";
            button2.Size = new Size(155, 62);
            button2.TabIndex = 1;
            button2.Text = "Müşteri Listeleme";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Black", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(67, 35);
            button1.Name = "button1";
            button1.Size = new Size(155, 62);
            button1.TabIndex = 0;
            button1.Text = "Müşteri Ekleme";
            button1.UseVisualStyleBackColor = true;
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
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(347, 574);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(124, 58);
            btnEkle.TabIndex = 4;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            // 
            // btn_SatısYap
            // 
            btn_SatısYap.Location = new Point(1055, 574);
            btn_SatısYap.Name = "btn_SatısYap";
            btn_SatısYap.Size = new Size(124, 58);
            btn_SatısYap.TabIndex = 5;
            btn_SatısYap.Text = "Satış Yap";
            btn_SatısYap.UseVisualStyleBackColor = true;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(1198, 140);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(124, 58);
            btnSil.TabIndex = 6;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            // 
            // btnSatisIptal
            // 
            btnSatisIptal.Location = new Point(1198, 216);
            btnSatisIptal.Name = "btnSatisIptal";
            btnSatisIptal.Size = new Size(124, 58);
            btnSatisIptal.TabIndex = 7;
            btnSatisIptal.Text = "Satış İptal";
            btnSatisIptal.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(655, 593);
            label1.Name = "label1";
            label1.Size = new Size(101, 20);
            label1.TabIndex = 8;
            label1.Text = "Genel Toplam";
            // 
            // lblGenelToplam
            // 
            lblGenelToplam.AutoSize = true;
            lblGenelToplam.Location = new Point(794, 593);
            lblGenelToplam.Name = "lblGenelToplam";
            lblGenelToplam.Size = new Size(50, 20);
            lblGenelToplam.TabIndex = 9;
            lblGenelToplam.Text = "label2";
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
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label1;
        private Label lblGenelToplam;
    }
}