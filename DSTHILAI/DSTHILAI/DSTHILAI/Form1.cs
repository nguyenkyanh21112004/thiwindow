using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OfficeOpenXml;
using System.IO;

namespace DSTHILAI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Danhsach ob = new Danhsach();
        private void Form1_Load(object sender, EventArgs e)
        {
            //Khi form load, load tất cả tên môn lên combobox cho người dùng lựa chọn
            DataTable dt = ob.LayDL("SELECT * FROM khoa"); //Bảng mon gồm mamon, tenmon
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "tenkhoa";
        }

        private void xemds_Click(object sender, EventArgs e)
        {
            //Load ds thi lại lên datagridview
            DataTable dt = ob.LayDL("select  giaovien.magv, hoten, ngaysinh, khoa.tenkhoa from giaovien,bomon,khoa,thamgiadt,detai WHERE giaovien.mabm=bomon.mabm and khoa.makhoa=bomon.makhoa and giaovien.magv=thamgiadt.magv and thamgiadt.madt=detai.madt group by giaovien.magv,hoten, ngaysinh,khoa.tenkhoa ");
            dataGridView1.DataSource = dt;
            //ok, đã có danh sách
            //Hàm đánh số thứ tự 
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = i + 1;
            }
        }

        private void xuatds_Click(object sender, EventArgs e)
        {
            //phần xuất dl này chỉ cần copy code của cô thôi =)))
            string filePath = "";
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Excel | *.xlsx | Excel 2012 | *.xls";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                filePath = dialog.FileName;
            }
            if (string.IsNullOrEmpty(filePath))
            {
                MessageBox.Show("Đường dẫn báo cáo không hợp lệ");
                return;
            }
            using (ExcelPackage p = new ExcelPackage())
            {
                // đặt tên người tạo file
                p.Workbook.Properties.Author = "NKA";

                // đặt tiêu đề cho file
                p.Workbook.Properties.Title = "DS khong tham gia de tai";

                //Tạo một sheet để làm việc trên đó
                p.Workbook.Worksheets.Add("DSTHILAI");  //Tên sheet

                // lấy sheet vừa add ra để thao tác
                ExcelWorksheet ws = p.Workbook.Worksheets[1];
                ws.Name = "Danh_sach_ko_tham_gia" + comboBox1.Text;
                string[] arrColumnHeader = {"Số thứ tự","Mã giáo viên","Họ tên","Ngày sinh"};
                var countColHeader = arrColumnHeader.Count();
                ws.Cells[1, 1].Value = "Thống kê thông tin";
                ws.Cells[1, 1, 1, countColHeader].Merge = true;
                // in đậm
                ws.Cells[1, 1, 1, countColHeader].Style.Font.Bold = true;

                int colIndex = 1;  // Cột bắt đầu tính từ 1 trong Excel
                int rowIndex = 2;  // dòng thứ 2 trừ dòng tiêu đề
                foreach (var item in arrColumnHeader)
                {
                    var cell = ws.Cells[rowIndex, colIndex]; //[2,1]                         

                    //gán giá trị
                    cell.Value = item;
                    colIndex++;
                }
                List<Danhsach> userList = new List<Danhsach>();
                // lấy ra danh sách chuyển sang List từ gridview
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    Danhsach ob = new Danhsach();

                    ob.STT = dataGridView1.Rows[i].Cells[0].Value.ToString();
                    ob.magv = dataGridView1.Rows[i].Cells[1].Value.ToString();
                    ob.hoten = dataGridView1.Rows[i].Cells[2].Value.ToString();
                    ob.ngaysinh = dataGridView1.Rows[i].Cells[3].Value.ToString(); 
                    //riêng điểm là float => nhớ convert nhé
                }
                foreach (var item in userList)
                {
                    // bắt đầu ghi từ cột 1. Excel bắt đầu từ 1 không phải từ 0
                    colIndex = 1;
                    // rowIndex tương ứng từng dòng dữ liệu
                    rowIndex++;
                    //gán giá trị cho từng cell                      
                    ws.Cells[rowIndex, colIndex++].Value = item.STT;
                    ws.Cells[rowIndex, colIndex++].Value = item.magv;
                    ws.Cells[rowIndex, colIndex++].Value = item.hoten;
                    ws.Cells[rowIndex, colIndex++].Value = item.ngaysinh;
                }
                Byte[] bin = p.GetAsByteArray();
                File.WriteAllBytes(filePath, bin);
            }
            MessageBox.Show("Xuất excel thành công!");


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
