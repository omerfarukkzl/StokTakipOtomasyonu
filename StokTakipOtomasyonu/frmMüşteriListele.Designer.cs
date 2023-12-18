namespace StokTakipOtomasyonu
{
    partial class frmMüşteriListele
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
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtEmail = new TextBox();
            label1 = new Label();
            txtAdSoyad = new TextBox();
            txtTC = new TextBox();
            txtTelefon = new TextBox();
            txtAdres = new TextBox();
            txtTcAra = new TextBox();
            btnSil = new Button();
            btnGuncelle = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(245, 91);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(674, 316);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.White;
            label5.Location = new Point(23, 300);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 19;
            label5.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(23, 256);
            label4.Name = "label4";
            label4.Size = new Size(47, 20);
            label4.TabIndex = 18;
            label4.Text = "Adres";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(23, 212);
            label3.Name = "label3";
            label3.Size = new Size(58, 20);
            label3.TabIndex = 17;
            label3.Text = "Telefon";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(23, 168);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 16;
            label2.Text = "Ad Soyad";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(104, 293);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(125, 27);
            txtEmail.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(23, 124);
            label1.Name = "label1";
            label1.Size = new Size(25, 20);
            label1.TabIndex = 11;
            label1.Text = "TC";
            // 
            // txtAdSoyad
            // 
            txtAdSoyad.Location = new Point(104, 161);
            txtAdSoyad.Name = "txtAdSoyad";
            txtAdSoyad.Size = new Size(125, 27);
            txtAdSoyad.TabIndex = 15;
            // 
            // txtTC
            // 
            txtTC.Location = new Point(104, 117);
            txtTC.Name = "txtTC";
            txtTC.Size = new Size(125, 27);
            txtTC.TabIndex = 10;
            // 
            // txtTelefon
            // 
            txtTelefon.Location = new Point(104, 205);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(125, 27);
            txtTelefon.TabIndex = 14;
            // 
            // txtAdres
            // 
            txtAdres.Location = new Point(104, 249);
            txtAdres.Name = "txtAdres";
            txtAdres.Size = new Size(125, 27);
            txtAdres.TabIndex = 13;
            // 
            // txtTcAra
            // 
            txtTcAra.Location = new Point(629, 49);
            txtTcAra.Name = "txtTcAra";
            txtTcAra.Size = new Size(125, 27);
            txtTcAra.TabIndex = 20;
            txtTcAra.Text = "Tc Ara";
            txtTcAra.TextChanged += txtTcAra_TextChanged;
            // 
            // btnSil
            // 
            btnSil.ForeColor = Color.Black;
            btnSil.Location = new Point(954, 115);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(94, 29);
            btnSil.TabIndex = 21;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.ForeColor = Color.Black;
            btnGuncelle.Location = new Point(123, 358);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(94, 29);
            btnGuncelle.TabIndex = 22;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // frmMüşteriListele
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(1072, 450);
            Controls.Add(btnGuncelle);
            Controls.Add(btnSil);
            Controls.Add(txtTcAra);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtEmail);
            Controls.Add(label1);
            Controls.Add(txtAdSoyad);
            Controls.Add(txtTC);
            Controls.Add(txtTelefon);
            Controls.Add(txtAdres);
            Controls.Add(dataGridView1);
            ForeColor = Color.BurlyWood;
            Name = "frmMüşteriListele";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Müşteri Listeleme Sayfası";
            Load += frmMüşteriListele_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtEmail;
        private Label label1;
        private TextBox txtAdSoyad;
        private TextBox txtTC;
        private TextBox txtTelefon;
        private TextBox txtAdres;
        private TextBox txtTcAra;
        private Button btnSil;
        private Button btnGuncelle;
    }
}