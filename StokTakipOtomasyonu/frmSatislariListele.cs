using Proje.StokTakip;
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

namespace StokTakipOtomasyonu
{
    public partial class frmSatislariListele : Form
    {
        public frmSatislariListele()
        {
            InitializeComponent();
        }
        
        

        

        private void frmSatislariListele_Load(object sender, EventArgs e)
        {
            Satislar entity = new  Satislar();

            entity.SatisListele(dataGridView1);
        }
    }
}
