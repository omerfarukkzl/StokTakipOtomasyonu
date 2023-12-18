using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Proje.Stok
{
    public class Kategori:Urunler
    {
        public string KategoriAd;





        public void KategoriEkle(string KategoriAd)
        {
            SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-OFK;Initial Catalog=Stok_Takip;Integrated Security=True;Encrypt=False");

            baglanti.Open();

            SqlCommand komut = new SqlCommand("insert into kategoribilgileri(kategori) values('" + KategoriAd + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
           

            

        }








    }
}