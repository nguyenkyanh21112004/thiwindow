using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_CN
    {
        SqlConnection con=new SqlConnection("Data Source=LAPTOP-VVIKK9CB\\MSSQLSERVER2022;Initial Catalog=QLKS;Integrated Security=True");
        public DataTable Loaddl(string sql)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter ad= new SqlDataAdapter(sql,con);
            ad.Fill(dt);
            return dt;
        }
        public void thucthi(string sql)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter ad = new SqlDataAdapter(sql, con);
            ad.Fill(dt);
            ad.Update(dt);
        }
    }
}
