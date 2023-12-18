using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Proje.Stok
{
    public abstract class GenelClass
    {
        
        public string AdSoyad { get; set; }
        public string Telefon { get; set; }

        public abstract void MusteriEkleDB(SqlConnection connection);
    }

}

