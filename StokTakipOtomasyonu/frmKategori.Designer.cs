namespace StokTakipOtomasyonu
{
    partial class frmKategori
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
            txtKategoriEkle = new TextBox();
            btnKategoriEkle = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtKategoriEkle
            // 
            txtKategoriEkle.Location = new Point(159, 158);
            txtKategoriEkle.Name = "txtKategoriEkle";
            txtKategoriEkle.Size = new Size(125, 27);
            txtKategoriEkle.TabIndex = 0;
            // 
            // btnKategoriEkle
            // 
            btnKategoriEkle.Location = new Point(190, 207);
            btnKategoriEkle.Name = "btnKategoriEkle";
            btnKategoriEkle.Size = new Size(94, 29);
            btnKategoriEkle.TabIndex = 1;
            btnKategoriEkle.Text = "Ekle";
            btnKategoriEkle.UseVisualStyleBackColor = true;
            btnKategoriEkle.Click += btnKategoriEkle_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(87, 161);
            label1.Name = "label1";
            label1.Size = new Size(66, 20);
            label1.TabIndex = 2;
            label1.Text = "Kategori";
            // 
            // frmKategori
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(383, 452);
            Controls.Add(label1);
            Controls.Add(btnKategoriEkle);
            Controls.Add(txtKategoriEkle);
            Name = "frmKategori";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kategori Ekleme Sayfası";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtKategoriEkle;
        private Button btnKategoriEkle;
        private Label label1;
    }
}