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
    public partial class frmÜrünListele : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-OFK;Initial Catalog=Stok_Takip;Integrated Security=True;Encrypt=False");
        public frmÜrünListele()
        {
            InitializeComponent();
        }
        private void Temizle()
        {
            foreach (Control item in this.Controls)
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

        private void frmÜrünListele_Load(object sender, EventArgs e)
        {
            Urunler entity = new Urunler();
            entity.UrunListele(dataGridView1);
            entity.KategoriGetir(cmbKategori);

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtBarkodNo.Text = dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString();
            txtKategori.Text = dataGridView1.CurrentRow.Cells["kategori"].Value.ToString();
            txtMarka.Text = dataGridView1.CurrentRow.Cells["marka"].Value.ToString();
            txtUrunAdi.Text = dataGridView1.CurrentRow.Cells["urunadi"].Value.ToString();
            txtMiktar.Text = dataGridView1.CurrentRow.Cells["miktar"].Value.ToString();
            txtAlisFiyat.Text = dataGridView1.CurrentRow.Cells["alisfiyat"].Value.ToString();
            txtSatisFiyat.Text = dataGridView1.CurrentRow.Cells["satisfiyat"].Value.ToString();


        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Urunler entity = new Urunler();

            entity.UrunListelemeGuncelle(txtBarkodNo, txtUrunAdi, txtMiktar, txtAlisFiyat, txtSatisFiyat);

            entity.UrunListele(dataGridView1);
            MessageBox.Show("Güncelleme yapıldı.");

            Temizle();


        }

        private void btnMarkaGuncelle_Click(object sender, EventArgs e)
        {
            Urunler entity = new Urunler();
            entity.MarkaGuncelle(txtBarkodNo, cmbKategori, cmbMarka);
            entity.UrunListele(dataGridView1);


            Temizle();

        }

        private void cmbKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            Urunler entity = new Urunler();
            entity.MarkaGetir(cmbMarka,cmbKategori);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            Urunler entity = new Urunler();

            entity.UrunSilme(dataGridView1);
            
            entity.UrunListele(dataGridView1);

            MessageBox.Show("Kayıt Silindi.");

        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            Urunler entity = new Urunler();
            entity.UrunBarkodAra(dataGridView1, txtAra);
        }
    }
}
