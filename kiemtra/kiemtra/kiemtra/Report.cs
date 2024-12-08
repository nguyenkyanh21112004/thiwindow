using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Report
{
    public class Report
    {
        public SqlConnection conn = new SqlConnection("Data Source=LAPTOP-VVIKK9CB\\MSSQLSERVER2022;Initial Catalog=GV;Integrated Security=True");
        public DataTable Load(string sql)
        {
            DataTable dt = new DataTable();
            SqlCommand comSelect = new SqlCommand(sql, conn);
            SqlDataAdapter ad = new SqlDataAdapter();
            ad.SelectCommand = comSelect;
            ad.Fill(dt);
            dt.AcceptChanges();
            return dt;
        }
    }
}
    
