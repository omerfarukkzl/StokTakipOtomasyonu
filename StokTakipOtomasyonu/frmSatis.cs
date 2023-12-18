using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace StokTakipOtomasyonu
{
    public partial class frmSatis : Form
    {
        public frmSatis()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmÜrünListele listele = new frmÜrünListele();
            listele.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmMüşteriEkle listele = new frmMüşteriEkle();
            listele.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmMüşteriListele listele = new frmMüşteriListele();
            listele.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmÜrünEkle listele = new frmÜrünEkle();
            listele.ShowDialog();
        }

        private void btnKategoriListele_Click(object sender, EventArgs e)
        {
            frmKategori listele = new frmKategori();
            listele.ShowDialog();
        }

        private void btnMarkaListele_Click(object sender, EventArgs e)
        {
            frmMarka listele = new frmMarka();
            listele.ShowDialog();
        }

        private void btnSatislariListele_Click(object sender, EventArgs e)
        {
            frmSatislariListele listele = new frmSatislariListele();
            listele.ShowDialog();
        }
    }
}
