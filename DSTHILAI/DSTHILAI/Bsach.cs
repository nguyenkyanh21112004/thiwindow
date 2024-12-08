using OfficeOpenXml.FormulaParsing.Excel.Functions.DateTime;
using OfficeOpenXml.FormulaParsing.Excel.Functions.Logical;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Excel = Microsoft.Office.Interop.Excel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DSTHILAI
{
    internal class Bsach
    {
        // Chuỗi kết nối có thể lấy trong này, hoặc lấy ở GUI (tùy)
        public SqlConnection con = new SqlConnection("Data Source=LAPTOP-VVIKK9CB\\MSSQLSERVER2022;Initial Catalog=GV;Integrated Security=True"); 
        //add class, bao gồm tất cả các thuộc tính mình muốn xuất ra Excel
        public string Masach { get; set; }
        public string Soluong { get; set; }
        public string Tensach { get; set; }
       

        }
    }

