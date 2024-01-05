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
namespace StokTakipOtomasyonu
{
    public partial class frmSatis : Form
    {
        public frmSatis()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-OFK;Initial Catalog=Stok_Takip;Integrated Security=True;Encrypt=False");
        DataSet daset = new DataSet();
        private void sepetListele()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from sepet", baglanti);
            adtr.Fill(daset, "sepet");
            dataGridView1.DataSource = daset.Tables["sepet"];
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            baglanti.Close();
        }
        private void Temizle()
        {
            if (txtBarkodNo.Text == "")
            {
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
        }

        private void Hesapla()
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("select sum(toplamfiyat) from sepet", baglanti);
                lblGenelToplam.Text = komut.ExecuteScalar() + "TL";
                baglanti.Close();

            }
            catch (Exception)
            {

                throw;
            }
        }

        

        private void button4_Click(object sender, EventArgs e)
        {
            frmÜrünListele listele = new frmÜrünListele();
            listele.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmMüşteriEkle listele = new frmMüşteriEkle();
            listele.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmMüşteriListele listele = new frmMüşteriListele();
            listele.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
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
            sepetListele();
        }

        private void txtTC_TextChanged(object sender, EventArgs e)
        {
            if (txtTC.Text == "")
            {
                txtAdSoyad.Text = "";
                txtTelefon.Text = "";
            }
            else
            {
                baglanti.Open();

                SqlCommand komut = new SqlCommand("select *from müşteri where TcNo like '" + txtTC.Text + "%'", baglanti);

                SqlDataReader read = komut.ExecuteReader();
                while (read.Read())
                {
                    txtAdSoyad.Text = read["AdSoyad"].ToString();
                    txtTelefon.Text = read["Telefon"].ToString();

                }
                baglanti.Close();

            }

        }

        private void txtBarkodNo_TextChanged(object sender, EventArgs e)
        {
            Temizle();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from urun where barkodno like @barkod", baglanti);
            komut.Parameters.AddWithValue("@barkod", txtBarkodNo.Text + "%");
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                txtUrunAdı.Text = read["urunadi"].ToString();
                txtSatısFiyat.Text = read["satisfiyat"].ToString();
            }
            baglanti.Close();
        }



        private void btnEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into sepet(tc,adsoyad,telefon,barkodno,urunadi,miktar,satisfiyat,toplamfiyat,tarih) values(@tc,@adsoyad,@telefon,@barkodno,@urunadi,@miktar,@satisfiyat,@toplamfiyat,@tarih)", baglanti);
            komut.Parameters.AddWithValue("@tc", txtTC.Text);
            komut.Parameters.AddWithValue("@adsoyad", txtAdSoyad.Text);
            komut.Parameters.AddWithValue("@telefon", txtTelefon.Text);
            komut.Parameters.AddWithValue("@barkodno", txtBarkodNo.Text);
            komut.Parameters.AddWithValue("@urunadi", txtUrunAdı.Text);
            komut.Parameters.AddWithValue("@miktar", int.Parse(txtMiktar.Text));
            komut.Parameters.AddWithValue("@satisfiyat", double.Parse(txtSatısFiyat.Text));
            komut.Parameters.AddWithValue("@toplamfiyat", double.Parse(txtToplamFiyat.Text));
            komut.Parameters.AddWithValue("@tarih", DateTime.Now.ToString());
            komut.ExecuteNonQuery();
            baglanti.Close();
            txtMiktar.Text = "1";
            daset.Tables["sepet"].Clear();
            sepetListele();
            Hesapla();
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
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from sepet where barkodno='" + dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString() + "'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ürün sepetten çıkarıldı.");
            daset.Tables["sepet"].Clear();
            sepetListele();
            Hesapla();
        }

        private void btnSatisIptal_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from sepet", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Satış iptal edildi. Sepet temizlendi.");
            daset.Tables["sepet"].Clear();
            sepetListele();
            Hesapla();

        }

        private void btn_SatısYap_Click(object sender, EventArgs e)
        {
            for (int i = 0;i< dataGridView1.Rows.Count-1 ;i++)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into satis(tc,adsoyad,telefon,barkodno,urunadi,miktar,satisfiyat,toplamfiyat,tarih) values(@tc,@adsoyad,@telefon,@barkodno,@urunadi,@miktar,@satisfiyat,@toplamfiyat,@tarih)", baglanti);
                komut.Parameters.AddWithValue("@tc", txtTC.Text);
                komut.Parameters.AddWithValue("@adsoyad", txtAdSoyad.Text);
                komut.Parameters.AddWithValue("@telefon", txtTelefon.Text);
                komut.Parameters.AddWithValue("@barkodno", dataGridView1.Rows[i].Cells["barkodno"].Value.ToString());
                komut.Parameters.AddWithValue("@urunadi", dataGridView1.Rows[i].Cells["urunadi"].Value.ToString());
                komut.Parameters.AddWithValue("@miktar", int.Parse(dataGridView1.Rows[i].Cells["miktar"].Value.ToString()));
                komut.Parameters.AddWithValue("@satisfiyat", double.Parse(dataGridView1.Rows[i].Cells["satisfiyat"].Value.ToString()));
                komut.Parameters.AddWithValue("@toplamfiyat", double.Parse(dataGridView1.Rows[i].Cells["toplamfiyat"].Value.ToString()));
                komut.Parameters.AddWithValue("@tarih", DateTime.Now.ToString());
                komut.ExecuteNonQuery();


                SqlCommand komut2 = new SqlCommand("update urun set miktar=miktar-" + int.Parse(dataGridView1.Rows[i].Cells["miktar"].Value.ToString()) + " where barkodno='" + dataGridView1.Rows[i].Cells["barkodno"].Value.ToString() + "'", baglanti);
                komut2.ExecuteNonQuery();
                baglanti.Close();


            }
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("delete from sepet", baglanti);
            komut3.ExecuteNonQuery();
            baglanti.Close();
            daset.Tables["sepet"].Clear();
            sepetListele();
            Hesapla();
            MessageBox.Show("Satış yapıldı.");
        }
    }
}
