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
    public partial class frmÜrünEkle : Form
    {
        public frmÜrünEkle()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-OFK;Initial Catalog=Stok_Takip;Integrated Security=True;Encrypt=False");

        

        private void ComboboxTemizle()
        {
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
        
        private void frmÜrünEkle_Load(object sender, EventArgs e)
        {
            Proje.StokTakip.Urunler entity = new Proje.StokTakip.Urunler();

            entity.KategoriGetir(cmbKategori);

        }

        private void cmbKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            Proje.StokTakip.Urunler entity = new Proje.StokTakip.Urunler();

            entity.MarkaGetir(cmbMarka,cmbKategori);
        }



        private void VtxtBarkodNo_TextChanged(object sender, EventArgs e)
        {
            Urunler entity = new Urunler();
            entity.UrunStokGuncelle(VtxtBarkodNo, lblMiktar, groupBox2, VtxtKategori, VtxtMarka, VtxtUrunAdi, VtxtAlisFiyati, VtxtSatisFiyati);


        }

        private void btnYeniEkle_Click(object sender, EventArgs e)
        {
            Proje.StokTakip.Urunler entity = new Proje.StokTakip.Urunler();

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

            ComboboxTemizle();

        }

        private void btnEkleVarOlan_Click(object sender, EventArgs e)
        {
            Proje.StokTakip.Urunler entity = new Proje.StokTakip.Urunler();

            
            entity.VarOlanUrunEkleDB(int.Parse(VtxtMiktar.Text), VtxtBarkodNo.Text);

            
            
            MessageBox.Show("Var olan ürüne ekleme yapıldı.");
            

        }
    }
}
