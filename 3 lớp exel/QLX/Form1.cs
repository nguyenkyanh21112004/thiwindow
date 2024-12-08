using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DAL;
using DTO;
using OfficeOpenXml;
using System.IO;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace QLX
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        phanxuong_bus phanxuong=new phanxuong_bus();
        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = phanxuong.load_bus();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.DataSource = Load1();
        }
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-VVIKK9CB\\MSSQLSERVER2022;Initial Catalog=QLPX;Integrated Security=True");
        public DataTable Load1()
        {
            
            string sql = "select tenpx , count (manv) as soluong from nhanvien , phanxuong where nhanvien.mapx=phanxuong.mapx group by tenpx ";

            SqlDataAdapter ad = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            return dt;
        }
        private void them_Click(object sender, EventArgs e)
        {
            phanxuong px = new phanxuong(txtmanv.Text, txthoten.Text, txtngaysinh.Text, txtmapx.Text,txtgioitinh.Text);
            phanxuong.Insert_bus(px);
            Form1_Load(sender, e);
            txtmanv.Clear();
            txthoten.Clear();
            txtngaysinh.Clear();
            txtmapx.Clear();
            txtgioitinh.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            phanxuong px = new phanxuong(txtmanv.Text, txthoten.Text, txtngaysinh.Text, txtmapx.Text,txtgioitinh.Text);
            phanxuong.Update_bus(px);
            Form1_Load(sender, e);
            txtmanv.Clear();
            txthoten.Clear();
            txtngaysinh.Clear();
            txtmapx.Clear();
            txtgioitinh.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            phanxuong px = new phanxuong(txtmanv.Text, txthoten.Text, txtngaysinh.Text, txtmapx.Text,txtgioitinh.Text);
            phanxuong.delete_bus(px);
            Form1_Load(sender, e);
            txtmanv.Clear();
            txthoten.Clear();
            txtngaysinh.Clear();
            txtmapx.Clear();
            txtgioitinh.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Load1();
            string filePath = "";
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Excel | *.xlsx | Excel 2012 | *.xls";
            if (dialog.ShowDialog() == DialogResult.OK)
            { filePath = dialog.FileName; }
            if (string.IsNullOrEmpty(filePath))
            {
                MessageBox.Show("đường dẫn k hợp lệ ");
                return;
            }
            using (ExcelPackage p = new ExcelPackage())
            {
                p.Workbook.Properties.Author = " nguyễn kỳ anh";
                p.Workbook.Properties.Title = " danhsachphanxuong";
                p.Workbook.Worksheets.Add("danhsachphanxuong");
                ExcelWorksheet ws = p.Workbook.Worksheets[1];
                // đặt tên cho sheet
                ws.Name = "Danh_sach_phan_xuong" + txtmapx;
                // fontsize mặc định cho cả sheet
                ws.Cells.Style.Font.Size = 11;
                // font family mặc định cho cả sheet
                ws.Cells.Style.Font.Name = "Calibri";

                // Tạo danh sách các column header
                string[] arrColumnHeader = {
                    "Số thứ tự",
                    "tên phân xưởng",
                    "số lượng "
};
                // lấy ra số lượng cột cần dùng dựa vào số lượng header
                var countColHeader = arrColumnHeader.Count();

                // merge các column lại từ column 1 đến số column header
                // gán giá trị cho cell vừa merge 
                ws.Cells[1, 1].Value = "Thống kê thông tin";
                ws.Cells[1, 1, 1, countColHeader].Merge = true;
                // in đậm
                ws.Cells[1, 1, 1, countColHeader].Style.Font.Bold = true;

                int colIndex = 1;  // Cột bắt đầu tính từ 1 trong Excel
                int rowIndex = 2;  // dòng thứ 2 trừ dòng tiêu đề
                                   //tạo các header từ column header đã tạo từ bên trên
                foreach (var item in arrColumnHeader)
                {
                    var cell = ws.Cells[rowIndex, colIndex];

                    //gán giá trị
                    cell.Value = item;
                    colIndex++;
                }
                // Khai báo danh sách sinh viên
                List<phanxuong> userList = new List<phanxuong>();
                // lấy ra danh sách chuyển sang List từ gridview
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    phanxuong px = new phanxuong();

                    px.STT = dataGridView1.Rows[i].Cells[0].Value.ToString();
                    px.Tenpx = dataGridView1.Rows[i].Cells[1].Value.ToString();
                    if (dataGridView1.Rows[i].Cells.Count > 2)
                    {
                        px.Soluong = Convert.ToString(dataGridView1.Rows[i].Cells[2].Value);
                    }
                    userList.Add(px);
                }
                // với mỗi item trong danh sách sẽ ghi trên 1 dòng
                NewMethod(ws, ref colIndex, ref rowIndex, userList);
                //Lưu file lại
                Byte[] bin = p.GetAsByteArray();
                File.WriteAllBytes(filePath, bin);
            }
            MessageBox.Show("Xuất excel thành công!");
        }

        private static void NewMethod(ExcelWorksheet ws, ref int colIndex, ref int rowIndex, List<phanxuong> userList)
        {
            foreach (var item in userList)

            {
                // bắt đầu ghi từ cột 1. Excel bắt đầu từ 1 không phải từ 0
                colIndex = 1;
                // rowIndex tương ứng từng dòng dữ liệu
                rowIndex++;
                //gán giá trị cho từng cell                      
                ws.Cells[rowIndex, colIndex++].Value = item.STT;
                ws.Cells[rowIndex, colIndex++].Value = item.Tenpx;
                ws.Cells[rowIndex, colIndex++].Value = item.Soluong;

                

            }
        }

        
    }
    
}
