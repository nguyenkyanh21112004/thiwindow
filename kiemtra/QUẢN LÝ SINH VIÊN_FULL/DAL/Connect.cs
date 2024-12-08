using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Connect
    {
        public SqlConnection con = new SqlConnection("Data Source=LAPTOP-3ICHCQG9\\MSSQLSERVER2022;Initial Catalog=QUANLYSV;Integrated Security=True");
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
        public void Execute1(string proc, params SqlParameter[] parameters)
        {
            using (SqlCommand cmd = new SqlCommand(proc, con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddRange(parameters);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
