using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class DAL_MON : Connect
    {
        public DataTable LoadDL()
        {
            return Load("SELECT * FROM MON");
        }
        public void Insert(Mon mon)
        {
            //string sql = "EXEC CHENMON " + mon.Mamon + "," + mon.Tenmon + ", " + mon.Sotinchi;
            //Execute(sql);

            /*con.Open();
            string sql = "INSERT INTO MON VALUES (@MAMON, @TENMON, @SOTC)";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sql;
            //Dòng 24 đến 27, có thể thay bằng dòng 29-30
            //SqlCommand cmd = new SqlCommand(sql, con);
            //cmd.CommandType = CommandType.Text;

            cmd.Parameters.AddWithValue("@MAMON", SqlDbType.VarChar).Value = mon.Mamon;
            cmd.Parameters.AddWithValue("@TENMON", SqlDbType.NVarChar).Value = mon.Tenmon;
            cmd.Parameters.AddWithValue("@SOTC", SqlDbType.Int).Value = mon.Sotinchi;
            cmd.ExecuteNonQuery();
            con.Close();*/

            /*SqlCommand cmd = new SqlCommand("CHENMON", con);
            //Gọi stored procedure CHENMON thông qua kết nối con
            cmd.CommandType = CommandType.StoredProcedure;
            //chỉ định type là stored proc, nếu câu lệnh bth thì là text
            cmd.Parameters.AddWithValue("@MAMON", mon.Mamon);
            //addwithvalue(tên tham số, giá trị tham số)
            cmd.Parameters.AddWithValue("@TENMON", mon.Tenmon);
            cmd.Parameters.AddWithValue("@SOTC", mon.Sotinchi);
            con.Open();
            cmd.ExecuteNonQuery();*/
            SqlParameter[] p = new SqlParameter[]
            {
                new SqlParameter("MAMON", mon.Mamon),
                new SqlParameter("TENMON", mon.Tenmon),
                new SqlParameter("SOTC", mon.Sotinchi)
            };
            Execute1("CHENMON", p);

        }
        public void Update(Mon mon)
        {
            string sql = "UPDATE MON SET TENMON = N'" + mon.Tenmon + ", SOTC =" + mon.Sotinchi + "' WHERE MAMON ='" + mon.Mamon + "'";
            Execute(sql);
        }
        public void Delete(Mon mon)
        {
            string sql = "DELETE FROM MON WHERE MAMON = '" + mon.Mamon + "'";
            Execute(sql);
        }
    }
}
