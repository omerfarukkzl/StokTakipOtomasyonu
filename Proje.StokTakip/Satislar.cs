using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Proje.StokTakip
{
    public class Satislar:GenelClass
    {
        public DateTime SatisTarihi { get; set; } 
        public decimal ToplamTutar { get; set; }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-OFK;Initial Catalog=Stok_Takip;Integrated Security=True;Encrypt=False");

        static DataSet daset = new DataSet();

        public void SatisListele(DataGridView dataGridView1)
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from satis", baglanti);
            adtr.Fill(daset, "satis");
            dataGridView1.DataSource = daset.Tables["satis"];

            baglanti.Close();
        }

        public void sepetListele(DataGridView dataGridView1)
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
        public void Hesapla(Label lblGenelToplam)
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

        public void Temizle(TextBox txtBarkodNo, System.Windows.Forms.GroupBox groupBox2,TextBox txtMiktar )
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
        public void SepeteEkle(TextBox txtTC,TextBox txtAdSoyad , TextBox txtTelefon,TextBox txtBarkodNo, TextBox txtUrunAdı, TextBox txtMiktar, TextBox txtSatısFiyat, TextBox txtToplamFiyat)
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
        }
        public void satisUrunGetirWithBarkod(TextBox txtBarkodNo,TextBox txtUrunAdı, TextBox txtSatısFiyat)
        {
            
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

        public void satisMusteriGetirWithTc(TextBox txtTC, TextBox txtAdSoyad, TextBox txtTelefon)
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

        public void SepettenSil(DataGridView dataGridView1)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from sepet where barkodno='" + dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString() + "'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ürün sepetten çıkarıldı.");
            daset.Tables["sepet"].Clear();
        }
        public void satisIptal()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from sepet", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Satış iptal edildi. Sepet temizlendi.");
            daset.Tables["sepet"].Clear();
        }

        public void SatisYap(DataGridView dataGridView1,TextBox txtTC, TextBox txtAdSoyad, TextBox txtTelefon)
        {
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
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
        }







    }

}
