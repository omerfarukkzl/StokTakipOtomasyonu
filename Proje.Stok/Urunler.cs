using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Stok
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




        public void UrunEkleDB()
        {
            SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-OFK;Initial Catalog=Stok_Takip;Integrated Security=True;Encrypt=False");
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



    }
}
