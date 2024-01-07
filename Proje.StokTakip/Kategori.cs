using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Proje.StokTakip
{
    public class Kategori:Urunler
    {
        public string KategoriAd;

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-OFK;Initial Catalog=Stok_Takip;Integrated Security=True;Encrypt=False");

       




        public void KategoriEkle(string KategoriAd)
        {
            SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-OFK;Initial Catalog=Stok_Takip;Integrated Security=True;Encrypt=False");

            baglanti.Open();

            SqlCommand komut = new SqlCommand("insert into kategoribilgileri(kategori) values('" + KategoriAd + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
           

            

        }
        public void KategoriSil(ComboBox cmbKategori)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from kategoribilgileri where kategori= '" + cmbKategori.SelectedItem.ToString()+ "' ", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close() ;
            

        }







    }
}