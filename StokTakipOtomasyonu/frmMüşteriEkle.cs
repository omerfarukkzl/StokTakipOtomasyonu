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
            Proje.StokTakip.Musteri entity = new Proje.StokTakip.Musteri();

            entity.TcNo = long.Parse(txtTC.Text);
            entity.AdSoyad = txtAdSoyad.Text;
            entity.Telefon = txtTelefon.Text;
            entity.Adres = txtAdres.Text;
            entity.eMail = txtEmail.Text;

            entity.MusteriEkle(entity.TcNo, entity.AdSoyad, entity.Telefon, entity.Adres, entity.eMail);

            MessageBox.Show("Müşteri Eklendi.");

        }
    }
}
