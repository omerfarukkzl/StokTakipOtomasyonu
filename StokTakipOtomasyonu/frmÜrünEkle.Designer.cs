namespace StokTakipOtomasyonu
{
    partial class frmÜrünEkle
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
            groupBox1 = new GroupBox();
            cmbMarka = new ComboBox();
            cmbKategori = new ComboBox();
            btnYeniEkle = new Button();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtSatisFiyatı = new TextBox();
            txtAlisFiyati = new TextBox();
            txtMiktar = new TextBox();
            txtUrunAdi = new TextBox();
            txtBarkodNo = new TextBox();
            groupBox2 = new GroupBox();
            lblMiktar = new Label();
            btnEkleVarOlan = new Button();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            VtxtKategori = new TextBox();
            VtxtMarka = new TextBox();
            VtxtSatisFiyati = new TextBox();
            VtxtAlisFiyati = new TextBox();
            VtxtMiktar = new TextBox();
            VtxtUrunAdi = new TextBox();
            VtxtBarkodNo = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cmbMarka);
            groupBox1.Controls.Add(cmbKategori);
            groupBox1.Controls.Add(btnYeniEkle);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtSatisFiyatı);
            groupBox1.Controls.Add(txtAlisFiyati);
            groupBox1.Controls.Add(txtMiktar);
            groupBox1.Controls.Add(txtUrunAdi);
            groupBox1.Controls.Add(txtBarkodNo);
            groupBox1.Location = new Point(53, 74);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(310, 394);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Yeni Ürün";
            // 
            // cmbMarka
            // 
            cmbMarka.FormattingEnabled = true;
            cmbMarka.Location = new Point(151, 123);
            cmbMarka.Name = "cmbMarka";
            cmbMarka.Size = new Size(125, 28);
            cmbMarka.TabIndex = 15;
            // 
            // cmbKategori
            // 
            cmbKategori.FormattingEnabled = true;
            cmbKategori.Location = new Point(151, 81);
            cmbKategori.Name = "cmbKategori";
            cmbKategori.Size = new Size(125, 28);
            cmbKategori.TabIndex = 14;
            cmbKategori.SelectedIndexChanged += cmbKategori_SelectedIndexChanged;
            // 
            // btnYeniEkle
            // 
            btnYeniEkle.Location = new Point(182, 343);
            btnYeniEkle.Name = "btnYeniEkle";
            btnYeniEkle.Size = new Size(94, 29);
            btnYeniEkle.TabIndex = 13;
            btnYeniEkle.Text = "Ekle";
            btnYeniEkle.UseVisualStyleBackColor = true;
            btnYeniEkle.Click += btnYeniEkle_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(19, 299);
            label7.Name = "label7";
            label7.Size = new Size(79, 20);
            label7.TabIndex = 12;
            label7.Text = "Satış Fiyatı";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(19, 257);
            label6.Name = "label6";
            label6.Size = new Size(72, 20);
            label6.TabIndex = 11;
            label6.Text = "Alış Fiyatı";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 215);
            label5.Name = "label5";
            label5.Size = new Size(51, 20);
            label5.TabIndex = 10;
            label5.Text = "Miktar";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 173);
            label4.Name = "label4";
            label4.Size = new Size(67, 20);
            label4.TabIndex = 9;
            label4.Text = "Ürün Adı";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 131);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 8;
            label3.Text = "Marka";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 89);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 7;
            label2.Text = "Kategori";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 47);
            label1.Name = "label1";
            label1.Size = new Size(76, 20);
            label1.TabIndex = 2;
            label1.Text = "BarkodNo";
            // 
            // txtSatisFiyatı
            // 
            txtSatisFiyatı.Location = new Point(151, 288);
            txtSatisFiyatı.Name = "txtSatisFiyatı";
            txtSatisFiyatı.Size = new Size(125, 27);
            txtSatisFiyatı.TabIndex = 4;
            // 
            // txtAlisFiyati
            // 
            txtAlisFiyati.Location = new Point(151, 247);
            txtAlisFiyati.Name = "txtAlisFiyati";
            txtAlisFiyati.Size = new Size(125, 27);
            txtAlisFiyati.TabIndex = 3;
            // 
            // txtMiktar
            // 
            txtMiktar.Location = new Point(151, 206);
            txtMiktar.Name = "txtMiktar";
            txtMiktar.Size = new Size(125, 27);
            txtMiktar.TabIndex = 2;
            // 
            // txtUrunAdi
            // 
            txtUrunAdi.Location = new Point(151, 165);
            txtUrunAdi.Name = "txtUrunAdi";
            txtUrunAdi.Size = new Size(125, 27);
            txtUrunAdi.TabIndex = 1;
            // 
            // txtBarkodNo
            // 
            txtBarkodNo.Location = new Point(151, 40);
            txtBarkodNo.Name = "txtBarkodNo";
            txtBarkodNo.Size = new Size(125, 27);
            txtBarkodNo.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblMiktar);
            groupBox2.Controls.Add(btnEkleVarOlan);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(label14);
            groupBox2.Controls.Add(VtxtKategori);
            groupBox2.Controls.Add(VtxtMarka);
            groupBox2.Controls.Add(VtxtSatisFiyati);
            groupBox2.Controls.Add(VtxtAlisFiyati);
            groupBox2.Controls.Add(VtxtMiktar);
            groupBox2.Controls.Add(VtxtUrunAdi);
            groupBox2.Controls.Add(VtxtBarkodNo);
            groupBox2.Location = new Point(454, 74);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(310, 394);
            groupBox2.TabIndex = 14;
            groupBox2.TabStop = false;
            groupBox2.Text = "Var Olan Ürün";
            // 
            // lblMiktar
            // 
            lblMiktar.AutoSize = true;
            lblMiktar.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblMiktar.Location = new Point(19, 344);
            lblMiktar.Name = "lblMiktar";
            lblMiktar.Size = new Size(134, 28);
            lblMiktar.TabIndex = 14;
            lblMiktar.Text = "Güncel Miktar";
            // 
            // btnEkleVarOlan
            // 
            btnEkleVarOlan.Location = new Point(182, 343);
            btnEkleVarOlan.Name = "btnEkleVarOlan";
            btnEkleVarOlan.Size = new Size(94, 29);
            btnEkleVarOlan.TabIndex = 13;
            btnEkleVarOlan.Text = "Ekle";
            btnEkleVarOlan.UseVisualStyleBackColor = true;
            btnEkleVarOlan.Click += btnEkleVarOlan_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(19, 299);
            label8.Name = "label8";
            label8.Size = new Size(79, 20);
            label8.TabIndex = 12;
            label8.Text = "Satış Fiyatı";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(19, 257);
            label9.Name = "label9";
            label9.Size = new Size(72, 20);
            label9.TabIndex = 11;
            label9.Text = "Alış Fiyatı";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(19, 215);
            label10.Name = "label10";
            label10.Size = new Size(55, 20);
            label10.TabIndex = 10;
            label10.Text = "Miktarı";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(19, 173);
            label11.Name = "label11";
            label11.Size = new Size(67, 20);
            label11.TabIndex = 9;
            label11.Text = "Ürün Adı";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(19, 131);
            label12.Name = "label12";
            label12.Size = new Size(50, 20);
            label12.TabIndex = 8;
            label12.Text = "Marka";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(19, 89);
            label13.Name = "label13";
            label13.Size = new Size(66, 20);
            label13.TabIndex = 7;
            label13.Text = "Kategori";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(19, 47);
            label14.Name = "label14";
            label14.Size = new Size(76, 20);
            label14.TabIndex = 2;
            label14.Text = "BarkodNo";
            // 
            // VtxtKategori
            // 
            VtxtKategori.Location = new Point(151, 82);
            VtxtKategori.Name = "VtxtKategori";
            VtxtKategori.Size = new Size(125, 27);
            VtxtKategori.TabIndex = 6;
            // 
            // VtxtMarka
            // 
            VtxtMarka.Location = new Point(151, 124);
            VtxtMarka.Name = "VtxtMarka";
            VtxtMarka.Size = new Size(125, 27);
            VtxtMarka.TabIndex = 5;
            // 
            // VtxtSatisFiyati
            // 
            VtxtSatisFiyati.Location = new Point(151, 292);
            VtxtSatisFiyati.Name = "VtxtSatisFiyati";
            VtxtSatisFiyati.Size = new Size(125, 27);
            VtxtSatisFiyati.TabIndex = 4;
            // 
            // VtxtAlisFiyati
            // 
            VtxtAlisFiyati.Location = new Point(151, 250);
            VtxtAlisFiyati.Name = "VtxtAlisFiyati";
            VtxtAlisFiyati.Size = new Size(125, 27);
            VtxtAlisFiyati.TabIndex = 3;
            // 
            // VtxtMiktar
            // 
            VtxtMiktar.Location = new Point(151, 208);
            VtxtMiktar.Name = "VtxtMiktar";
            VtxtMiktar.Size = new Size(125, 27);
            VtxtMiktar.TabIndex = 2;
            // 
            // VtxtUrunAdi
            // 
            VtxtUrunAdi.Location = new Point(151, 166);
            VtxtUrunAdi.Name = "VtxtUrunAdi";
            VtxtUrunAdi.Size = new Size(125, 27);
            VtxtUrunAdi.TabIndex = 1;
            // 
            // VtxtBarkodNo
            // 
            VtxtBarkodNo.Location = new Point(151, 40);
            VtxtBarkodNo.Name = "VtxtBarkodNo";
            VtxtBarkodNo.Size = new Size(125, 27);
            VtxtBarkodNo.TabIndex = 0;
            VtxtBarkodNo.TextChanged += VtxtBarkodNo_TextChanged;
            // 
            // frmÜrünEkle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(800, 532);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmÜrünEkle";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ürün Ekleme Sayfası";
            Load += frmÜrünEkle_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtSatisFiyatı;
        private TextBox txtAlisFiyati;
        private TextBox txtMiktar;
        private TextBox txtUrunAdi;
        private TextBox txtBarkodNo;
        private Button btnYeniEkle;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private Button btnEkleVarOlan;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private TextBox VtxtKategori;
        private TextBox VtxtMarka;
        private TextBox VtxtSatisFiyati;
        private TextBox VtxtAlisFiyati;
        private TextBox VtxtMiktar;
        private TextBox VtxtUrunAdi;
        private TextBox VtxtBarkodNo;
        private ComboBox cmbMarka;
        private ComboBox cmbKategori;
        private Label lblMiktar;
    }
}