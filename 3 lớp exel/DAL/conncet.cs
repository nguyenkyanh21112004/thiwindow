using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class conncet
    {
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-VVIKK9CB\\MSSQLSERVER2022;Initial Catalog=QLPX;Integrated Security=True");
        
        public DataTable load_dl(string sql)
        {
            SqlDataAdapter ad = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            return dt;
        }
        public void execute(string sql)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
