    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.SqlClient;
    using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
    using System.Threading.Tasks;
using System.Windows.Forms;





namespace Proje.StokTakip
{

    public class Musteri : GenelClass
    {
        public long TcNo { get; set; }
        public string Adres { get; set; }
        public string eMail { get; set; }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-OFK;Initial Catalog=Stok_Takip;Integrated Security=True;Encrypt=False");
        static DataSet daset = new DataSet();
        public class MusteriListele 
        {
            
            public MusteriListele(DataGridView dataGridView) // Database deki kayıtları getiren constructor.
            {

                SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-OFK;Initial Catalog=Stok_Takip;Integrated Security=True;Encrypt=False");

                

                baglanti.Open();

                SqlDataAdapter adtr = new SqlDataAdapter("select *from müşteri", baglanti);
                adtr.Fill(daset, "müşteri");
                dataGridView.DataSource = daset.Tables["müşteri"];
                baglanti.Close();
            }
        }
        public void MusteriEkle(long TcNo, string AdSoyad, string Telefon, string Adres, string eMail)
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

        public void MusteriGuncelle(long tcno,string adsoyad, string telefon, string adres, string email)
        {
            
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update müşteri set AdSoyad=@AdSoyad, Telefon=@Telefon, Adres=@Adres, eMail=@eMail where TcNo=@TcNo ", baglanti);
            komut.Parameters.AddWithValue("@TcNo", tcno);
            komut.Parameters.AddWithValue("@AdSoyad", adsoyad);
            komut.Parameters.AddWithValue("@Telefon", telefon);
            komut.Parameters.AddWithValue("@Adres", adres);
            komut.Parameters.AddWithValue("@eMail", email);
            komut.ExecuteNonQuery();
            baglanti.Close();
            daset.Tables["müşteri"].Clear();
        }
        public void MusteriSil(DataGridView dataGridView1 )
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from müşteri where TcNo='" + dataGridView1.CurrentRow.Cells["TcNo"].Value.ToString() + "'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            daset.Tables["müşteri"].Clear();
        }

        public void MusteriTcAra(string tcara, DataGridView dataGridView1)
        {
            DataTable tablo = new DataTable();
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from müşteri where TcNo like '%" + tcara + "%'", baglanti);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }








    }
}
