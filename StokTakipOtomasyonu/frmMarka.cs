
using Proje.StokTakip;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StokTakipOtomasyonu
{
    public partial class frmMarka : Form
    {
        public frmMarka()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-OFK;Initial Catalog=Stok_Takip;Integrated Security=True;Encrypt=False");

        private void frmMarka_Load(object sender, EventArgs e)
        {
            Urunler entity = new Urunler();
            entity.KategoriGetir(cmbKategoriSec);
            

        }
     
        private void btnMarkaEkle_Click(object sender, EventArgs e)
        {
            Marka entity = new Marka();

            entity.MarkaAd = txtMarka.Text;
            entity.KategoriAd = cmbKategoriSec.Text;

            IMarka m1 = (IMarka)entity; 


            m1.MarkaEke(entity.MarkaAd, entity.KategoriAd);

            txtMarka.Text = "";
            cmbKategoriSec.Text = "";

            MessageBox.Show("Marka Eklendi.");
        }

       
    }
}
