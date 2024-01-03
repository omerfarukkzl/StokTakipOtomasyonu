namespace StokTakipOtomasyonu
{
    partial class frmÜrünListele
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
            btnGuncelle = new Button();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtKategori = new TextBox();
            txtMarka = new TextBox();
            txtSatisFiyat = new TextBox();
            txtAlisFiyat = new TextBox();
            txtMiktar = new TextBox();
            txtUrunAdi = new TextBox();
            txtBarkodNo = new TextBox();
            dataGridView1 = new DataGridView();
            btnSil = new Button();
            txtAra = new TextBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            cmbKategori = new ComboBox();
            cmbMarka = new ComboBox();
            btnMarkaGuncelle = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(202, 409);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(94, 29);
            btnGuncelle.TabIndex = 28;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(39, 365);
            label7.Name = "label7";
            label7.Size = new Size(79, 20);
            label7.TabIndex = 27;
            label7.Text = "Satış Fiyatı";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(39, 323);
            label6.Name = "label6";
            label6.Size = new Size(72, 20);
            label6.TabIndex = 26;
            label6.Text = "Alış Fiyatı";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(39, 281);
            label5.Name = "label5";
            label5.Size = new Size(55, 20);
            label5.TabIndex = 25;
            label5.Text = "Miktarı";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(39, 239);
            label4.Name = "label4";
            label4.Size = new Size(67, 20);
            label4.TabIndex = 24;
            label4.Text = "Ürün Adı";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 197);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 23;
            label3.Text = "Marka";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 155);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 22;
            label2.Text = "Kategori";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 113);
            label1.Name = "label1";
            label1.Size = new Size(76, 20);
            label1.TabIndex = 16;
            label1.Text = "BarkodNo";
            // 
            // txtKategori
            // 
            txtKategori.Location = new Point(171, 148);
            txtKategori.Name = "txtKategori";
            txtKategori.ReadOnly = true;
            txtKategori.Size = new Size(125, 27);
            txtKategori.TabIndex = 21;
            // 
            // txtMarka
            // 
            txtMarka.Location = new Point(171, 190);
            txtMarka.Name = "txtMarka";
            txtMarka.ReadOnly = true;
            txtMarka.Size = new Size(125, 27);
            txtMarka.TabIndex = 20;
            // 
            // txtSatisFiyat
            // 
            txtSatisFiyat.Location = new Point(171, 358);
            txtSatisFiyat.Name = "txtSatisFiyat";
            txtSatisFiyat.Size = new Size(125, 27);
            txtSatisFiyat.TabIndex = 19;
            // 
            // txtAlisFiyat
            // 
            txtAlisFiyat.Location = new Point(171, 316);
            txtAlisFiyat.Name = "txtAlisFiyat";
            txtAlisFiyat.Size = new Size(125, 27);
            txtAlisFiyat.TabIndex = 18;
            // 
            // txtMiktar
            // 
            txtMiktar.Location = new Point(171, 274);
            txtMiktar.Name = "txtMiktar";
            txtMiktar.Size = new Size(125, 27);
            txtMiktar.TabIndex = 17;
            // 
            // txtUrunAdi
            // 
            txtUrunAdi.Location = new Point(171, 232);
            txtUrunAdi.Name = "txtUrunAdi";
            txtUrunAdi.Size = new Size(125, 27);
            txtUrunAdi.TabIndex = 15;
            // 
            // txtBarkodNo
            // 
            txtBarkodNo.Location = new Point(171, 106);
            txtBarkodNo.Name = "txtBarkodNo";
            txtBarkodNo.Size = new Size(125, 27);
            txtBarkodNo.TabIndex = 14;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(349, 75);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(697, 394);
            dataGridView1.TabIndex = 29;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(1074, 75);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(94, 29);
            btnSil.TabIndex = 30;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // txtAra
            // 
            txtAra.Location = new Point(698, 24);
            txtAra.Name = "txtAra";
            txtAra.Size = new Size(125, 27);
            txtAra.TabIndex = 31;
            txtAra.TextChanged += txtAra_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(532, 27);
            label8.Name = "label8";
            label8.Size = new Size(160, 20);
            label8.TabIndex = 32;
            label8.Text = "BarkodNo'ya göre Ara ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(479, 505);
            label9.Name = "label9";
            label9.Size = new Size(66, 20);
            label9.TabIndex = 35;
            label9.Text = "Kategori";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(495, 547);
            label10.Name = "label10";
            label10.Size = new Size(50, 20);
            label10.TabIndex = 36;
            label10.Text = "Marka";
            // 
            // cmbKategori
            // 
            cmbKategori.FormattingEnabled = true;
            cmbKategori.Location = new Point(570, 497);
            cmbKategori.Name = "cmbKategori";
            cmbKategori.Size = new Size(151, 28);
            cmbKategori.TabIndex = 37;
            cmbKategori.SelectedIndexChanged += cmbKategori_SelectedIndexChanged;
            // 
            // cmbMarka
            // 
            cmbMarka.FormattingEnabled = true;
            cmbMarka.Location = new Point(570, 539);
            cmbMarka.Name = "cmbMarka";
            cmbMarka.Size = new Size(151, 28);
            cmbMarka.TabIndex = 38;
            // 
            // btnMarkaGuncelle
            // 
            btnMarkaGuncelle.Location = new Point(737, 500);
            btnMarkaGuncelle.Name = "btnMarkaGuncelle";
            btnMarkaGuncelle.Size = new Size(104, 62);
            btnMarkaGuncelle.TabIndex = 39;
            btnMarkaGuncelle.Text = "Marka Güncelle";
            btnMarkaGuncelle.UseVisualStyleBackColor = true;
            btnMarkaGuncelle.Click += btnMarkaGuncelle_Click;
            // 
            // frmÜrünListele
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(1186, 593);
            Controls.Add(btnMarkaGuncelle);
            Controls.Add(cmbMarka);
            Controls.Add(cmbKategori);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(txtAra);
            Controls.Add(btnSil);
            Controls.Add(dataGridView1);
            Controls.Add(btnGuncelle);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtKategori);
            Controls.Add(txtMarka);
            Controls.Add(txtSatisFiyat);
            Controls.Add(txtAlisFiyat);
            Controls.Add(txtMiktar);
            Controls.Add(txtUrunAdi);
            Controls.Add(txtBarkodNo);
            Name = "frmÜrünListele";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ürün Listeleme Sayfası";
            Load += frmÜrünListele_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGuncelle;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtKategori;
        private TextBox txtMarka;
        private TextBox txtSatisFiyat;
        private TextBox txtAlisFiyat;
        private TextBox txtMiktar;
        private TextBox txtUrunAdi;
        private TextBox txtBarkodNo;
        private DataGridView dataGridView1;
        private Button btnSil;
        private TextBox txtAra;
        private Label label8;
        private Label label9;
        private Label label10;
        private ComboBox cmbKategori;
        private ComboBox cmbMarka;
        private Button btnMarkaGuncelle;
    }
}