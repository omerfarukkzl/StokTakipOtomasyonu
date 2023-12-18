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
using System.Data.SqlClient;
using Proje.Stok;

namespace StokTakipOtomasyonu
{
    public partial class frmMüşteriEkle : Form
    {
        public frmMüşteriEkle()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Proje.Stok.Musteri entity = new Proje.Stok.Musteri();

            if (long.TryParse(txtTC.Text, out long tcNo))
            {
                entity.TcNo = tcNo;
            }
            else
            {
                MessageBox.Show("TcNo geçerli bir sayı değil.");
                return;
            }
            entity.AdSoyad = txtAdSoyad.Text;
            entity.Telefon = txtTelefon.Text;
            entity.Adres = txtAdres.Text;
            entity.eMail = txtEmail.Text;

            try
            {
                using (SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-OFK;Initial Catalog=Stok_Takip;Integrated Security=True;Encrypt=False"))
                {
                    entity.MusteriEkleDB(baglanti);
                }

                MessageBox.Show("Müşteri başarıyla eklendi.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata oluştu: {ex.Message}");
            }







        }
    }
}
