using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Stok
{
    public class Satislar:GenelClass
    {
        public DateTime SatisTarihi { get; set; } 
        public decimal ToplamTutar { get; set; }
        public List<Urunler> SatislarListesi { get; set; }

        public override void MusteriEkleDB(SqlConnection connection)
        {
            throw new NotImplementedException();
        }
    }

}
