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

        public override void MusteriEkleDB(SqlConnection baglanti)
        {
            baglanti.Open();
            string insertQuery = "INSERT INTO müşteri(TcNo, AdSoyad, Telefon, Adres, eMail) VALUES (@TcNo, @AdSoyad, @Telefon, @Adres, @eMail)";

            using (SqlCommand komut = new SqlCommand(insertQuery, baglanti))
            {
                komut.Parameters.AddWithValue("@TcNo", TcNo);
                komut.Parameters.AddWithValue("@AdSoyad", AdSoyad);
                komut.Parameters.AddWithValue("@Telefon", Telefon);
                komut.Parameters.AddWithValue("@Adres", Adres);
                komut.Parameters.AddWithValue("@eMail", eMail);
                komut.ExecuteNonQuery();
                baglanti.Close();

            }


        }

            


    }
}
