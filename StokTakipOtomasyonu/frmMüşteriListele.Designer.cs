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
            textBox2 = new TextBox();
            label1 = new Label();
            textBox5 = new TextBox();
            textBox1 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            txtTcAra = new TextBox();
            btnSil = new Button();
            btnGüncelle = new Button();
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
            // textBox2
            // 
            textBox2.Location = new Point(104, 293);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 12;
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
            // textBox5
            // 
            textBox5.Location = new Point(104, 161);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(125, 27);
            textBox5.TabIndex = 15;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(104, 117);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 10;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(104, 205);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 14;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(104, 249);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 13;
            // 
            // txtTcAra
            // 
            txtTcAra.Location = new Point(629, 49);
            txtTcAra.Name = "txtTcAra";
            txtTcAra.Size = new Size(125, 27);
            txtTcAra.TabIndex = 20;
            txtTcAra.Text = "Tc Ara";
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
            // 
            // btnGüncelle
            // 
            btnGüncelle.ForeColor = Color.Black;
            btnGüncelle.Location = new Point(123, 358);
            btnGüncelle.Name = "btnGüncelle";
            btnGüncelle.Size = new Size(94, 29);
            btnGüncelle.TabIndex = 22;
            btnGüncelle.Text = "Güncelle";
            btnGüncelle.UseVisualStyleBackColor = true;
            // 
            // frmMüşteriListele
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(1072, 450);
            Controls.Add(btnGüncelle);
            Controls.Add(btnSil);
            Controls.Add(txtTcAra);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(textBox5);
            Controls.Add(textBox1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(dataGridView1);
            ForeColor = Color.BurlyWood;
            Name = "frmMüşteriListele";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Müşteri Listeleme Sayfası";
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
        private TextBox textBox2;
        private Label label1;
        private TextBox textBox5;
        private TextBox textBox1;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox txtTcAra;
        private Button btnSil;
        private Button btnGüncelle;
    }
}