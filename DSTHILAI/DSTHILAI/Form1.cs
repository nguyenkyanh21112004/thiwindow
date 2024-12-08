using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using OfficeOpenXml;
using System.IO;
using Microsoft.Office.Interop.Excel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace DSTHILAI
{
    public class DataAccess
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-9LNK3O8\MSSQLSERVER2022;Initial Catalog=QLNS;Integrated Security=True");

        public DataTable laydl()
        {
            DataTable dt = new DataTable();
            string sql = "SELECT Order_Detail.Masach, Sach.Tensach, SUM(Order_Detail.Soluong) AS Soluong, Sach.Giaban, Sach.Mota " +
                         "FROM Order_Detail " +
                         "WHERE Order_Detail.Masach = Sach.Masach " +
                         "GROUP BY Order_Detail.Masach, Sach.Tensach, Sach.Mota, Sach.Giaban";
            SqlDataAdapter ad = new SqlDataAdapter(sql, con);
            ad.Fill(dt);
            return dt;
        }
    }
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Bsach ob = new Bsach();

     

        private void xuatds_Click(object sender, EventArgs e)
        {
            // Tạo một đối tượng Excel  

             Excel.Application excelApp = new Excel.Application();

            // Tạo một workbook mới  

            Excel.Workbook workbook = excelApp.Workbooks.Add(Type.Missing);

            Excel.Worksheet ws = (Excel.Worksheet)workbook.ActiveSheet;

            ws.Name = "Dữ liệu xuất";

            string[] arrColumnHeader = { "Mã sách", "Tên sách", "Số lượng" };

            var countColHeader = arrColumnHeader.Count();

            // merge các column lại từ column 1 đến số column header 

            // gán giá trị cho cell vừa merge  

            ws.Cells[1, 1].Value = "Thống kê sách đã bán được";

            ws.Cells[1, 1, 1, countColHeader].Merge = true;

            // in đậm 

            ws.Cells[1, 1, 1, countColHeader].Style.Font.Bold = true;

            int colIndex = 1;  // Cột bắt đầu tính từ 1 trong Excel 

            int rowIndex = 2;  // dòng thứ 2 trừ dòng tiêu đề 

            foreach (var item in arrColumnHeader)
            {

                var cell = ws.Cells[rowIndex, colIndex];

                //gán giá trị 

                cell.Value = item;
                colIndex++;

            }

            // Khai báo danh sách sinh viên 

            List<Bsach> userList = new List<Bsach>();

            // lấy ra danh sách chuyển sang List từ gridview 

            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)

            {

                Bsach ob = new Bsach();

                ob.Masach = dataGridView1.Rows[i].Cells[0].Value.ToString();

                ob.Soluong = dataGridView1.Rows[i].Cells[1].Value.ToString();

                ob.Tensach = dataGridView1.Rows[i].Cells[2].Value.ToString();

                userList.Add(ob);

            }



            foreach (var item in userList)

            {

                // bắt đầu ghi từ cột 1. Excel bắt đầu từ 1 không phải từ 0 

                colIndex = 1;

                // rowIndex tương ứng từng dòng dữ liệu 

                rowIndex++;

                //gán giá trị cho từng cell                       

                ws.Cells[rowIndex, colIndex++].Value = item.Masach;

                ws.Cells[rowIndex, colIndex++].Value = item.Soluong;

                ws.Cells[rowIndex, colIndex++].Value = item.Tensach;



            }



            // Lưu file Excel vào một đường dẫn cụ thể 

            string filePath = @"D:\OutputData.xlsx";

            ws.SaveAs(filePath);



            // Đóng workbook và ứng dụng Excel 

            workbook.Close();

            excelApp.Quit();



            // Giải phóng các đối tượng COM để tránh lỗi 

            System.Runtime.InteropServices.Marshal.ReleaseComObject(worksheet);

            System.Runtime.InteropServices.Marshal.ReleaseComObject(workbook);

            System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);



        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       
    }
}
