using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using DAL;
using OfficeOpenXml;
using System.IO;
namespace QUẢN_LÝ_SINH_VIÊN___TỰ_LÀM
{
    public partial class DSThilaiExcel : Form
    {
        public DSThilaiExcel()
        {
            InitializeComponent();
        }
        BUS_Diem bus = new BUS_Diem();
        Connect ob = new Connect();
        private void DSThilaiExcel_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = bus.LoadCboLop();
            comboBox1.DisplayMember = "TENLOP";
            comboBox2.DataSource = bus.LoadCboTenmon();
            comboBox2.DisplayMember = "TENMON";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "SELECT SINHVIEN.MASV, HOTEN, NGAYSINH, TENLOP, TENMON, DIEM FROM SINHVIEN, MON, LOP, DIEM WHERE SINHVIEN.MASV = DIEM.MASV AND SINHVIEN.MALOP = LOP.MALOP AND MON.MAMON = DIEM.MAMON AND TENLOP = N'" + comboBox1.Text + "' AND TENMON = N'" + comboBox2.Text + "' AND DIEM < 5";
            DataTable dt = ob.Load(sql);
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
                p.Workbook.Properties.Author = "Nguyễn Văn Đính";
                p.Workbook.Properties.Title = "Danh sách thi lại";
                p.Workbook.Worksheets.Add("DSTL");
                ExcelWorksheet ws = p.Workbook.Worksheets[1];
                ws.Name = "DSThilai";
                string[] arrColumnHeader = { "Số thứ tự", "Mã sinh viên", "Họ tên", "Ngày sinh", "Điểm" };
                var countColHeader = arrColumnHeader.Count();
                ws.Cells[1, 1].Value = "Danh sách thi lại";
                ws.Cells[1, 1, 1, countColHeader].Merge = true;
                ws.Cells[1, 1, 1, countColHeader].Style.Font.Bold = true;
                ws.Cells[2, 1, 2, countColHeader].Merge = true;
                ws.Cells[2, 1].Value = "Lớp: " + comboBox1.Text;
                ws.Cells[3, 1, 3, countColHeader].Merge = true;
                ws.Cells[3, 1].Value = "Môn: " + comboBox2.Text;
                int colIndex = 1;
                int rowIndex = 4;
                foreach (var item in arrColumnHeader)
                {
                    ws.Cells[rowIndex, colIndex++].Value = item; //[2,1]                         ;
                }
                int stt = 1;
                foreach (DataRow r in dt.Rows)
                {
                    colIndex = 1;
                    rowIndex++;
                    ws.Cells[rowIndex, colIndex++].Value = stt++;
                    ws.Cells[rowIndex, colIndex++].Value = r[0].ToString();//MASV
                    ws.Cells[rowIndex, colIndex++].Value = r[1].ToString();//HOTEN
                    ws.Cells[rowIndex, colIndex++].Value = Convert.ToDateTime(r[2]).ToString("dd/MM/yyyy");//NGAYSINH
                    ws.Cells[rowIndex, colIndex++].Value = r[5].ToString();//DIEM
                }
                var range = ws.Cells[1, 1, dt.Rows.Count + 4, countColHeader];
                range.AutoFitColumns();
                range.Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                range.Style.VerticalAlignment = OfficeOpenXml.Style.ExcelVerticalAlignment.Center;
                range.Style.Border.Top.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;
                range.Style.Border.Bottom.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;
                range.Style.Border.Left.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;
                range.Style.Border.Right.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;
                range.Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                range.Style.Fill.BackgroundColor.SetColor(Color.Yellow);
                ws.Cells[2, 1, 3, countColHeader].Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                ws.Cells[2, 1, 3, countColHeader].Style.Fill.BackgroundColor.SetColor(Color.LightGreen);
                ws.Cells[1, 1].Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                ws.Cells[1, 1].Style.Fill.BackgroundColor.SetColor(Color.LightCyan);
                Byte[] bin = p.GetAsByteArray();
                File.WriteAllBytes(filePath, bin);
            }
            MessageBox.Show("Xuất excel thành công!");
        }
    }
}
