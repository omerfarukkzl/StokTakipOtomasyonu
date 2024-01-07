    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.SqlClient;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    
    
 

namespace Proje.Stok
{

    public class Musteri : GenelClass
    {
        public long TcNo { get; set; }
        public string Adres { get; set; }
        public string eMail { get; set; }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-OFK;Initial Catalog=Stok_Takip;Integrated Security=True;Encrypt=False");

        public void MusteriEkle(long TcNo,string AdSoyad,string Telefon,string Adres,string eMail)
        {
            baglanti.Open();

            SqlCommand komut = new SqlCommand("INSERT INTO müşteri(tcno, adsoyad, telefon, adres, email) VALUES (@tcno, @adsoyad, @telefon, @adres, @email)", baglanti);

            komut.Parameters.AddWithValue("@TcNo", TcNo);
            komut.Parameters.AddWithValue("@AdSoyad", AdSoyad);
            komut.Parameters.AddWithValue("@Telefon", Telefon);
            komut.Parameters.AddWithValue("@Adres", Adres);
            komut.Parameters.AddWithValue("@eMail", eMail);

            komut.ExecuteNonQuery();

            baglanti.Close();

        }

        public class MusteriListele
        {
            
            public MusteriListele()
            {

                SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-OFK;Initial Catalog=Stok_Takip;Integrated Security=True;Encrypt=False");

                DataSet daset = new DataSet();

                baglanti.Open();

                SqlDataAdapter adtr = new SqlDataAdapter("select *from müşteri", baglanti);
                adtr.Fill(daset, "müşteri");
                dataGridView1.DataSource = daset.Tables["müşteri"];
                baglanti.Close();
            }
        }
        







    }
}
