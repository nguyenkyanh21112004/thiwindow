using OfficeOpenXml.FormulaParsing.Excel.Functions.DateTime;
using OfficeOpenXml.FormulaParsing.Excel.Functions.Logical;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSTHILAI
{
    internal class Danhsach
    {
        // Chuỗi kết nối có thể lấy trong này, hoặc lấy ở GUI (tùy)
        public SqlConnection con = new SqlConnection("Data Source=LAPTOP-VVIKK9CB\\MSSQLSERVER2022;Initial Catalog=GV;Integrated Security=True"); 
        //add class, bao gồm tất cả các thuộc tính mình muốn xuất ra Excel
        public string STT { get; set; }
        public string magv { get; set; }
        public string hoten { get; set; }
        public string ngaysinh { get; set; }
       

        public DataTable LayDL(string sql) //Hàm lấy dữ liệu
        {
            DataTable dt = new DataTable();
            SqlDataAdapter ad = new SqlDataAdapter(sql, con);
            ad.Fill(dt);
            return dt;
        }
    }
}
