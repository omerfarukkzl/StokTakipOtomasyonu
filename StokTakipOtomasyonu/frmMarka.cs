using Proje.Stok;
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
            KategoriGetir();

        }

        private void KategoriGetir()
        {
            baglanti.Open();

            SqlCommand komut = new SqlCommand("select *from kategoribilgileri", baglanti);
            SqlDataReader reader = komut.ExecuteReader();

            while (reader.Read())
            {
                cmbKategoriSec.Items.Add(reader["kategori"].ToString());
            }
            baglanti.Close();
        }

        private void btnMarkaEkle_Click(object sender, EventArgs e)
        {
            Proje.Stok.Marka entity = new Proje.Stok.Marka();

            entity.MarkaAd = txtMarka.Text;
            entity.KategoriAd = cmbKategoriSec.Text;

            entity.MarkaEke(entity.MarkaAd, entity.KategoriAd);

            txtMarka.Text = "";
            cmbKategoriSec.Text = "";

            MessageBox.Show("Marka Eklendi.");
        }

       
    }
}
