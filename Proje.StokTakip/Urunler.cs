using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje.StokTakip
{
    public class Urunler
    {
        public string BarkodNo {  get; set; }
        public string UrunAdi {  get; set; }
        public int Miktar {  get; set; }
        public decimal SatisFiyati {  get; set; }
        public decimal ToplamFiyat {  get; set; }
        
        public decimal AlisFiyati { get; set; }

        public string KategoriAd {  get; set; }

        public string MarkaAd { get; set; }
        public IEnumerable<Control> Controls { get; private set; }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-OFK;Initial Catalog=Stok_Takip;Integrated Security=True;Encrypt=False");
        static DataSet daset = new DataSet();


        public void UrunEkleDB()
        {
            
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into urun(barkodno,kategori,marka,urunadi,miktar,alisfiyat,satisfiyat,tarih) values(@barkodno,@kategori,@marka,@urunadi,@miktar,@alisfiyat,@satisfiyat,@tarih)", baglanti);
            komut.Parameters.AddWithValue("@barkodno", BarkodNo);
            komut.Parameters.AddWithValue("@kategori", KategoriAd);
            komut.Parameters.AddWithValue("@marka", MarkaAd);
            komut.Parameters.AddWithValue("@urunadi", UrunAdi);
            komut.Parameters.AddWithValue("@miktar", Miktar);
            komut.Parameters.AddWithValue("@alisfiyat", AlisFiyati);
            komut.Parameters.AddWithValue("@satisfiyat", SatisFiyati);
            komut.Parameters.AddWithValue("@tarih", DateTime.Now.ToString());

            komut.ExecuteNonQuery();

            baglanti.Close();
        }

        public void VarOlanUrunEkleDB(int miktar, string barkodno)
        {
            
            baglanti.Open();

            SqlCommand komut = new SqlCommand("update urun set miktar=miktar+'" + (miktar) + "' where barkodno='" + barkodno + "'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            

            
        }

        public void KategoriGetir(ComboBox cmbKategori)
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

        public void MarkaGetir(ComboBox cmbMarka,ComboBox cmbKategori)
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

        public void UrunStokGuncelle(TextBox VtxtBarkodNo, Label lblMiktar, GroupBox groupBox2, TextBox VtxtKategori,TextBox VtxtMarka, TextBox VtxtUrunAdi, TextBox VtxtAlisFiyati, TextBox VtxtSatisFiyati)
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
        public void UrunListele(DataGridView dataGridView1)
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from urun", baglanti);
            adtr.Fill(daset, "urun");
            dataGridView1.DataSource = daset.Tables["urun"];
            baglanti.Close();
        }
        public void UrunListelemeGuncelle(TextBox txtBarkodNo, TextBox txtUrunAdi, TextBox txtMiktar,TextBox txtAlisFiyat, TextBox txtSatisFiyat)
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
        }
        public void MarkaGuncelle(TextBox txtBarkodNo,ComboBox cmbKategori,ComboBox cmbMarka)
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

                


            }
            else
            {
                MessageBox.Show("BarkodNo yazılı değil.");
            }
        }

        public void UrunSilme(DataGridView dataGridView1)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from kategoribilgileri where barkodno='" + dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString() + "'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            daset.Tables["urun"].Clear();
                      
        }
        public void UrunBarkodAra(DataGridView dataGridView1,TextBox txtAra)
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
