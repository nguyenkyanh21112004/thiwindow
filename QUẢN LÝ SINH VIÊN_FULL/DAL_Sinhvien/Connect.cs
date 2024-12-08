using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Sinhvien
{
    public class Connect
    {
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-3ICHCQG9\\MSSQLSERVER2022;Initial Catalog=QUANLYSV;Integrated Security=True");
        public DataTable Load(string sql)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter ad = new SqlDataAdapter(sql, con);
            ad.Fill(dt);
            return dt;
        }
        public void Execute(string sql)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter ad = new SqlDataAdapter(sql, con);
            ad.Fill(dt);
            ad.Update(dt);
        }
    }
}
