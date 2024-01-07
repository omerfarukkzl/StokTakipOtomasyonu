using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Proje.StokTakip;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
namespace StokTakipOtomasyonu
{
    public partial class frmKategori : Form
    {
        public frmKategori()
        {
            InitializeComponent();
        }

        private void btnKategoriEkle_Click(object sender, EventArgs e)
        {
            Proje.StokTakip.Kategori entity = new Proje.StokTakip.Kategori();

            entity.KategoriAd = txtKategoriEkle.Text;

            entity.KategoriEkle(entity.KategoriAd);

            txtKategoriEkle.Text = "";

            MessageBox.Show("Kategori Eklendi");
        }

        private void frmKategori_Load(object sender, EventArgs e)
        {
            Urunler entity = new Urunler();
            entity.KategoriGetir(cmbKategori);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            Kategori entity = new Kategori();
            entity.KategoriSil(cmbKategori);
            MessageBox.Show("Kategori silindi.");
        }
    }
}
