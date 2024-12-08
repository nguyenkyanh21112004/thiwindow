using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Connect
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-1P8E4CK\\BUIVIET;Initial Catalog=Quanly;Integrated Security=True");
        // Phương load CSDL
        public DataTable Load_DL(string sql)
        {
            conn.Open();
            SqlDataAdapter ad = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            conn.Close();
            return dt;
        }
        public void Excecute(string sql)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
