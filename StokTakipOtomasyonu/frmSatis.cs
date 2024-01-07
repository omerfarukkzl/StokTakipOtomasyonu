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
namespace StokTakipOtomasyonu
{
    public partial class frmSatis : Form
    {
        public frmSatis()
        {
            InitializeComponent();
        }

        private void btnUrunListeleme_Click(object sender, EventArgs e)
        {
            frmÜrünListele listele = new frmÜrünListele();
            listele.ShowDialog();
        }

        private void btnMusteriEkle_Click(object sender, EventArgs e)
        {
            frmMüşteriEkle listele = new frmMüşteriEkle();
            listele.ShowDialog();
        }

        private void btnMusteriListeleme_Click(object sender, EventArgs e)
        {
            frmMüşteriListele listele = new frmMüşteriListele();
            listele.ShowDialog();
        }

        private void btnUrunEkleme_Click(object sender, EventArgs e)
        {
            frmÜrünEkle listele = new frmÜrünEkle();
            listele.ShowDialog();

        }

        private void btnKategoriListele_Click(object sender, EventArgs e)
        {
            frmKategori listele = new frmKategori();
            listele.ShowDialog();
        }

        private void btnMarkaListele_Click(object sender, EventArgs e)
        {
            frmMarka listele = new frmMarka();
            listele.ShowDialog();
        }

        private void btnSatislariListele_Click(object sender, EventArgs e)
        {
            frmSatislariListele listele = new frmSatislariListele();
            listele.ShowDialog();
        }




        private void frmSatis_Load(object sender, EventArgs e)
        {
            Satislar entity = new Satislar();
            entity.sepetListele(dataGridView1);
        }

        private void txtTC_TextChanged(object sender, EventArgs e)
        {
            Satislar entity = new Satislar();

            entity.satisMusteriGetirWithTc(txtTC, txtAdSoyad, txtTelefon);

        }

        private void txtBarkodNo_TextChanged(object sender, EventArgs e)
        {
            Satislar entity = new Satislar();

            entity.Temizle(txtBarkodNo, groupBox2, txtMiktar);
            entity.satisUrunGetirWithBarkod(txtBarkodNo, txtUrunAdı, txtSatısFiyat);
        }



        private void btnEkle_Click(object sender, EventArgs e)
        {
            Satislar entity = new Satislar();

            entity.SepeteEkle(txtTC, txtAdSoyad, txtTelefon, txtBarkodNo, txtUrunAdı, txtMiktar, txtSatısFiyat, txtToplamFiyat);

            entity.sepetListele(dataGridView1);

            entity.Hesapla(lblGenelToplam);

            foreach (Control item in groupBox2.Controls)
            {
                if (item is TextBox)
                {
                    if (item != txtMiktar)
                    {
                        item.Text = "";
                    }
                }
            }



        }

        private void txtMiktar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtToplamFiyat.Text = (double.Parse(txtMiktar.Text) * double.Parse(txtSatısFiyat.Text)).ToString();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            Satislar entity = new Satislar();

            entity.SepettenSil(dataGridView1);
            entity.sepetListele(dataGridView1);
            entity.Hesapla(lblGenelToplam);
        }

        private void btnSatisIptal_Click(object sender, EventArgs e)
        {

            Satislar entity = new Satislar();

            entity.satisIptal();
            entity.sepetListele(dataGridView1);
            entity.Hesapla(lblGenelToplam);

        }

        private void btn_SatısYap_Click(object sender, EventArgs e)
        {
            Satislar entity = new Satislar();

            entity.SatisYap(dataGridView1, txtTC, txtAdSoyad, txtTelefon);
            entity.sepetListele(dataGridView1);
            entity.Hesapla(lblGenelToplam);

            MessageBox.Show("Satış yapıldı.");
        }
    }
}
