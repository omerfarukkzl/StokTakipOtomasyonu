
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace StokTakipOtomasyonu
{
    public partial class frmMüşteriListele : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-OFK;Initial Catalog=Stok_Takip;Integrated Security=True;Encrypt=False");
        

        private void TextboxTemizle()
        {
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }

        public frmMüşteriListele()
        {
            InitializeComponent();
        }

        private void frmMüşteriListele_Load(object sender, EventArgs e)
        {

            Proje.StokTakip.Musteri.MusteriListele entity = new Proje.StokTakip.Musteri.MusteriListele(dataGridView1);


        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            txtTC.Text = dataGridView1.CurrentRow.Cells["TcNo"].Value.ToString();
            txtAdSoyad.Text = dataGridView1.CurrentRow.Cells["AdSoyad"].Value.ToString();
            txtTelefon.Text = dataGridView1.CurrentRow.Cells["Telefon"].Value.ToString();
            txtAdres.Text = dataGridView1.CurrentRow.Cells["Adres"].Value.ToString();
            txtEmail.Text = dataGridView1.CurrentRow.Cells["eMail"].Value.ToString();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {

            Proje.StokTakip.Musteri entity = new Proje.StokTakip.Musteri();

            entity.TcNo = long.Parse(txtTC.Text);
            entity.AdSoyad = txtAdSoyad.Text;
            entity.Telefon = txtTelefon.Text;
            entity.Adres = txtAdres.Text;
            entity.eMail = txtEmail.Text;

            entity.MusteriGuncelle(entity.TcNo, entity.AdSoyad, entity.Telefon, entity.Adres, entity.eMail);


            TextboxTemizle();

           
            Musteri.MusteriListele entity2 = new Musteri.MusteriListele(dataGridView1);

            MessageBox.Show("Müşteri kaydı güncellendi.");  
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
      

            Proje.StokTakip.Musteri entity = new Proje.StokTakip.Musteri();

            

            entity.MusteriSil(dataGridView1);
            Musteri.MusteriListele entity2 = new Musteri.MusteriListele(dataGridView1);
            MessageBox.Show("Müşteri Silindi.");

        }

        private void txtTcAra_TextChanged(object sender, EventArgs e)
        {
            Proje.StokTakip.Musteri entity = new Proje.StokTakip.Musteri();

            entity.MusteriTcAra(txtTcAra.Text, dataGridView1);



        }
    }
}


