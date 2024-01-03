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
        public frmÜrünListele()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-OFK;Initial Catalog=Stok_Takip;Integrated Security=True;Encrypt=False");
        DataSet daset = new DataSet();

        private void UrunListele()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from urun", baglanti);
            adtr.Fill(daset, "urun");
            dataGridView1.DataSource = daset.Tables["urun"];
            baglanti.Close();
        }
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

        private void frmÜrünListele_Load(object sender, EventArgs e)
        {
            UrunListele();
            KategoriGetir();

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
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update urun set urunadi=@urunadi, miktar=@miktar, alisfiyat=@alisfiyat, satisfiyat=@satisfiyat where barkodno=@barkodno ", baglanti);
            komut.Parameters.AddWithValue("@barkodno", txtBarkodNo.Text);
            komut.Parameters.AddWithValue("@urunadi", txtUrunAdi.Text);
            komut.Parameters.AddWithValue("@miktar", int.Parse(txtMiktar.Text));
            komut.Parameters.AddWithValue("@alisfiyat", double.Parse(txtAlisFiyat.Text));
            komut.Parameters.AddWithValue("@satisfiyat", double.Parse(txtSatisFiyat.Text));
            komut.ExecuteNonQuery();
            baglanti.Close();
            daset.Tables["urun"].Clear();
            UrunListele();
            MessageBox.Show("Güncelleme yapıldı.");

            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }


        }

        private void btnMarkaGuncelle_Click(object sender, EventArgs e)
        {
            if (txtBarkodNo.Text != "")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("update urun set kategori=@kategori, marka=@marka  where barkodno=@barkodno ", baglanti);
                komut.Parameters.AddWithValue("@barkodno", txtBarkodNo.Text);
                komut.Parameters.AddWithValue("@kategori", cmbKategori.Text);
                komut.Parameters.AddWithValue("@marka", cmbMarka.Text);

                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Güncelleme yapıldı.");
                daset.Tables["urun"].Clear();
                UrunListele();



            }
            else
            {
                MessageBox.Show("BarkodNo yazılı değil.");
            }
            foreach (Control item in this.Controls)
            {
                if (item is ComboBox)
                {
                    item.Text = "";
                }
            }

        }

        private void cmbKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            MarkaGetir();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from urun where barkodno='" + dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString() + "'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            daset.Tables["urun"].Clear();
            UrunListele();
            MessageBox.Show("Kayıt Silindi.");

        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            DataTable tablo = new DataTable();
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from urun where barkodno like '%" + txtAra.Text + "%'", baglanti);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }
    }
}
