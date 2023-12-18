namespace StokTakipOtomasyonu
{
    partial class frmMarka
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
            cmbKategoriSec = new ComboBox();
            txtMarka = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnMarkaEkle = new Button();
            SuspendLayout();
            // 
            // cmbKategoriSec
            // 
            cmbKategoriSec.FormattingEnabled = true;
            cmbKategoriSec.Location = new Point(147, 160);
            cmbKategoriSec.Name = "cmbKategoriSec";
            cmbKategoriSec.Size = new Size(151, 28);
            cmbKategoriSec.TabIndex = 0;
            // 
            // txtMarka
            // 
            txtMarka.Location = new Point(147, 204);
            txtMarka.Name = "txtMarka";
            txtMarka.Size = new Size(151, 27);
            txtMarka.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 163);
            label1.Name = "label1";
            label1.Size = new Size(93, 20);
            label1.TabIndex = 2;
            label1.Text = "Kategori Seç";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(91, 204);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 3;
            label2.Text = "Marka";
            // 
            // btnMarkaEkle
            // 
            btnMarkaEkle.Location = new Point(204, 246);
            btnMarkaEkle.Name = "btnMarkaEkle";
            btnMarkaEkle.Size = new Size(94, 29);
            btnMarkaEkle.TabIndex = 4;
            btnMarkaEkle.Text = "Ekle";
            btnMarkaEkle.UseVisualStyleBackColor = true;
            btnMarkaEkle.Click += btnMarkaEkle_Click;
            // 
            // frmMarka
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(376, 460);
            Controls.Add(btnMarkaEkle);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtMarka);
            Controls.Add(cmbKategoriSec);
            Name = "frmMarka";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Marka Ekleme Sayfası";
            Load += frmMarka_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbKategoriSec;
        private TextBox txtMarka;
        private Label label1;
        private Label label2;
        private Button btnMarkaEkle;
    }
}