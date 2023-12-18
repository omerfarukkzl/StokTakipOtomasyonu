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
            Proje.Stok.Kategori entity = new Proje.Stok.Kategori();

            entity.KategoriAd = txtKategoriEkle.Text;

            entity.KategoriEkle(entity.KategoriAd);

            txtKategoriEkle.Text = "";

            MessageBox.Show("Kategori Eklendi");
        }
    }
}
