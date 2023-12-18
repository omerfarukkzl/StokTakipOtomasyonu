using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace StokTakipOtomasyonu
{
    public partial class frmMüşteriListele : Form
    {
        public frmMüşteriListele()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-OFK;Initial Catalog=Stok_Takip;Integrated Security=True;Encrypt=False");
        DataSet daset = new DataSet();
        public void KayıtGoster()
        {
            SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-OFK;Initial Catalog=Stok_Takip;Integrated Security=True;Encrypt=False");
            

            baglanti.Open();

            SqlDataAdapter adtr = new SqlDataAdapter("select *from müşteri", baglanti);
            adtr.Fill(daset, "müşteri");
            dataGridView1.DataSource = daset.Tables["müşteri"];
            baglanti.Close();
        }

        


        private void frmMüşteriListele_Load(object sender, EventArgs e)
        {
            
            


            KayıtGoster();


        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            txtTC.Text = dataGridView1.CurrentRow.Cells["TcNo"].Value.ToString();
            txtAdSoyad.Text = dataGridView1.CurrentRow.Cells["AdSoyad"].Value.ToString();
            txtTelefon.Text = dataGridView1.CurrentRow.Cells["Telefon"].Value.ToString();
            txtAdres.Text = dataGridView1.CurrentRow.Cells["Adres"].Value.ToString();
            txtEmail.Text = dataGridView1.CurrentRow.Cells["eMail"].Value.ToString();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {

            baglanti.Open();
            SqlCommand komut = new SqlCommand("update müşteri set AdSoyad=@AdSoyad, Telefon=@Telefon, Adres=@Adres, eMail=@eMail where TcNo=@TcNo ", baglanti);
            komut.Parameters.AddWithValue("@TcNo", txtTC.Text);
            komut.Parameters.AddWithValue("@AdSoyad", txtAdSoyad.Text);
            komut.Parameters.AddWithValue("@Telefon", txtTelefon.Text);
            komut.Parameters.AddWithValue("@Adres", txtAdres.Text);
            komut.Parameters.AddWithValue("@eMail", txtEmail.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
            daset.Tables["müşteri"].Clear();
            KayıtGoster();
            MessageBox.Show("Müşteri kaydı güncellendi.");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string selectedTcNo = dataGridView1.CurrentRow.Cells["TcNo"].Value.ToString();

                // Parametre kullanarak SQL sorgusu oluşturuluyor
                string query = "DELETE FROM müşteri WHERE TcNo = @TcNo";

                using (SqlCommand komut = new SqlCommand(query, baglanti))
                {
                    komut.Parameters.AddWithValue("@TcNo", selectedTcNo);

                    baglanti.Open();
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                }

                daset.Tables["müşteri"].Clear();
                KayıtGoster();
                MessageBox.Show("Müşteri kaydı silindi.");
            }
            else
            {
                MessageBox.Show("Lütfen silinecek bir müşteri seçin.");
            }

        }

        private void txtTcAra_TextChanged(object sender, EventArgs e)
        {
            DataTable tablo = new DataTable();
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from müşteri where TcNo like '%" + txtTcAra.Text + "%'", baglanti);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();

        }
    }
}


