using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Aplikasi_Penjualan.Kelas
{
    internal class Koneksi
    {
        public SqlConnection GetConn()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source = ROI; Initial Catalog=db_penjualan; Integrated Security=True";
            return conn;
        }
    }
}
