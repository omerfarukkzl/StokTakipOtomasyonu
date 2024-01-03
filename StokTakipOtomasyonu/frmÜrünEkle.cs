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
    public partial class frmÜrünEkle : Form
    {
        public frmÜrünEkle()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-OFK;Initial Catalog=Stok_Takip;Integrated Security=True;Encrypt=False");

        private void KategoriGetir()
        {
            baglanti.Open();

            SqlCommand komut = new SqlCommand("select *from kategoribilgileri", baglanti);
            SqlDataReader reader = komut.ExecuteReader();

            while (reader.Read())
            {
                cmbKategori.Items.Add(reader["kategori"].ToString());
            }
            baglanti.Close();
        }

        private void ClearKontrol(Control container)
        {
            foreach (Control item in container.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";

                }
                if (item is ComboBox)
                {
                    item.Text = "";

                }
            }
        }
        private void MarkaGetir()
        {
            cmbMarka.Items.Clear();
            cmbMarka.Text = "";
            baglanti.Open();

            SqlCommand komut = new SqlCommand("select *from markabilgileri where kategori='" + cmbKategori.SelectedItem + "'", baglanti);
            SqlDataReader reader = komut.ExecuteReader();

            while (reader.Read())
            {
                cmbMarka.Items.Add(reader["marka"].ToString());
            }
            baglanti.Close();
        }
        private void frmÜrünEkle_Load(object sender, EventArgs e)
        {
            KategoriGetir();

        }

        private void cmbKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            MarkaGetir();
        }



        private void VtxtBarkodNo_TextChanged(object sender, EventArgs e)
        {
            if (VtxtBarkodNo.Text == "")
            {
                lblMiktar.Text = "Güncel Miktar: ";
                foreach (Control item in groupBox2.Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
                }
            }
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from urun where barkodno = '" + VtxtBarkodNo.Text + "'", baglanti);
            SqlDataReader reader = komut.ExecuteReader();
            while (reader.Read())
            {
                VtxtKategori.Text = reader["kategori"].ToString();
                VtxtMarka.Text = reader["marka"].ToString();
                VtxtUrunAdi.Text = reader["urunadi"].ToString();
                lblMiktar.Text = "Güncel Miktar: " + reader["miktar"].ToString();
                VtxtAlisFiyati.Text = reader["alisfiyat"].ToString();
                VtxtSatisFiyati.Text = reader["satisfiyat"].ToString();

            }
            baglanti.Close();

        }

        private void btnYeniEkle_Click(object sender, EventArgs e)
        {
            Proje.Stok.Urunler entity = new Proje.Stok.Urunler();
            entity.BarkodNo = txtBarkodNo.Text;
            entity.KategoriAd = cmbKategori.Text;
            entity.MarkaAd = cmbMarka.Text;
            entity.UrunAdi = txtUrunAdi.Text;
            entity.Miktar = int.Parse(txtMiktar.Text);
            entity.AlisFiyati = decimal.Parse(txtAlisFiyati.Text);
            entity.SatisFiyati = decimal.Parse(txtSatisFiyatı.Text);


            entity.UrunEkleDB();

            MessageBox.Show("Ürün Eklendi.");
            cmbMarka.Items.Clear();

            foreach (Control item in groupBox1.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";

                }
                if (item is ComboBox)
                {
                    item.Text = "";

                }

            }

        }

        private void btnEkleVarOlan_Click(object sender, EventArgs e)
        {
            Proje.Stok.Urunler entity = new Proje.Stok.Urunler();

            
            entity.VarOlanUrunEkleDB(int.Parse(VtxtMiktar.Text), VtxtBarkodNo.Text);

            
            
            MessageBox.Show("Var olan ürüne ekleme yapıldı.");
            

        }
    }
}
