using Proje.StokTakip;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Proje.StokTakip
{
    public class Marka:Kategori,IMarka
    {
        public string MarkaAd;
        public string KategoriAd;
       
        
        void IMarka.MarkaEke(string MarkaAd,string KategoriAd)
        {
            SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-OFK;Initial Catalog=Stok_Takip;Integrated Security=True;Encrypt=False");

            baglanti.Open();

            SqlCommand komut = new SqlCommand("insert into markabilgileri(kategori,marka) values('" + KategoriAd + "','" + MarkaAd + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
         

        }
   


}
}