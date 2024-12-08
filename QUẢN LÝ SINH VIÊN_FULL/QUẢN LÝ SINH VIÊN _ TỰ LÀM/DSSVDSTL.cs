using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using System.Windows.Media.Media3D;
using BUS;
using DAL;
using OfficeOpenXml;
using System.IO;
using Color = System.Drawing.Color;
namespace QUẢN_LÝ_SINH_VIÊN___TỰ_LÀM
{
    public partial class DSSVDSTL : Form
    {
        public DSSVDSTL()
        {
            InitializeComponent();
        }
        BUS_Diem bus = new BUS_Diem();
        private void DSSVDSTL_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = bus.LoadCboLop();
            comboBox1.DisplayMember = "TENLOP";
            comboBox2.DataSource = bus.LoadCboLop();
            comboBox2.DisplayMember = "TENLOP";
            comboBox3.DataSource = bus.LoadCboTenmon();
            comboBox3.DisplayMember = "TENMON";
        }
        Connect ob = new Connect();
        private void button1_Click(object sender, EventArgs e)
        {
            string sql1 = "SELECT * FROM SINHVIEN WHERE MALOP = (SELECT MALOP FROM LOP WHERE TENLOP = N'" + comboBox1.Text + "')";
            DataTable dt1 = ob.Load(sql1);
            string sql2 = "SELECT SINHVIEN.MASV, HOTEN, NGAYSINH, DIEM FROM SINHVIEN, LOP, MON, DIEM WHERE SINHVIEN.MASV = DIEM.MASV AND SINHVIEN.MALOP = LOP.MALOP AND MON.MAMON = DIEM.MAMON AND TENLOP = N'" + comboBox2.Text + "' AND TENMON = N'" + comboBox3.Text + "' AND DIEM <= 4";
            DataTable dt2 = ob.Load(sql2);
            string filePath = "C:\\Users\\HP\\Desktop\\dssv.xlsx";
            //SaveFileDialog dialog = new SaveFileDialog();
            /*dialog.Filter = "Excel | *.xlsx | Excel 2012 | *.xls";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                filePath = dialog.FileName;
            }
            if (string.IsNullOrEmpty(filePath))
            {
                MessageBox.Show("Đường dẫn báo cáo không hợp lệ");
                return;
            }*/
            using (ExcelPackage p = new ExcelPackage())
            {
                p.Workbook.Properties.Author = "Nguyễn Văn Đính";
                p.Workbook.Properties.Title = "DS sinh viên + DS Thi lại";
                p.Workbook.Worksheets.Add("DSSV_DSTL");
                ExcelWorksheet ws = p.Workbook.Worksheets[1];
                ws.Name = "DSSV_DSTL";
                string[] arrColumnHeader1 = { "Số thứ tự", "Mã sinh viên", "Họ tên", "Ngày sinh", "Mã lớp" };
                string[] arrColumnHeader2 = { "Số thứ tự", "Mã sinh viên", "Họ tên", "Ngày sinh", "Điểm" };
                var countColHeader1 = arrColumnHeader1.Count();
                var countColHeader2 = arrColumnHeader2.Count();
                ws.Cells[1, 1].Value = "Danh sách sinh viên";
                ws.Cells[1, 1, 1, countColHeader1].Merge = true;
                ws.Cells[2, 1, 2, countColHeader1].Merge = true;
                ws.Cells[1, 1].Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                ws.Cells[1, 1].Style.Fill.BackgroundColor.SetColor(Color.Aqua);
                ws.Cells[2, 1, 2, countColHeader1].Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                ws.Cells[2, 1, 2, countColHeader1].Style.Fill.BackgroundColor.SetColor(Color.Yellow);
                ws.Cells[2, 1, 2, countColHeader1].Value = "Lớp: " + comboBox1.Text;
                ws.Cells[1, 1, 1, countColHeader1].Style.Font.Bold = true;
                ws.Cells[2, 1, 2, countColHeader1].Style.Font.Bold = true;
                int colIndex = 1;
                int rowIndex = 3;
                foreach (var item in arrColumnHeader1)
                {
                    ws.Cells[rowIndex, colIndex++].Value = item; //[3,1]                         ;
                }
                ws.Cells[3, 1, 3, countColHeader1].Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                ws.Cells[3, 1, 3, countColHeader1].Style.Fill.BackgroundColor.SetColor(Color.LightGreen);
                int stt = 1;
                foreach (DataRow r in dt1.Rows)
                {
                    colIndex = 1;
                    rowIndex++;
                    ws.Cells[rowIndex, colIndex++].Value = stt++;
                    ws.Cells[rowIndex, colIndex++].Value = r[0].ToString();
                    ws.Cells[rowIndex, colIndex++].Value = r[1].ToString();
                    ws.Cells[rowIndex, colIndex++].Value = Convert.ToDateTime(r[2]).ToString("dd/MM/yyyy");
                    ws.Cells[rowIndex, colIndex++].Value = r[3].ToString();
                }
                ws.Cells[4, 1, dt1.Rows.Count + 3, countColHeader1].Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                ws.Cells[4, 1, dt1.Rows.Count + 3, countColHeader1].Style.Fill.BackgroundColor.SetColor(Color.LightPink);
                var r1 = ws.Cells[dt1.Rows.Count + 4, 1, dt1.Rows.Count + 4, countColHeader2];
                r1.Merge = true;
                r1.Value = "Danh sách thi lại";
                r1.Style.Font.Bold = true;
                r1.Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                r1.Style.Fill.BackgroundColor.SetColor(Color.LightGoldenrodYellow);
                var r2 = ws.Cells[dt1.Rows.Count + 5, 1, dt1.Rows.Count + 5, countColHeader2];
                r2.Merge = true;
                r2.Style.Font.Bold = true;
                r2.Value = "Lớp: " + comboBox2.Text;
                r2.Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                r2.Style.Fill.BackgroundColor.SetColor(Color.LightBlue);
                var r3 = ws.Cells[dt1.Rows.Count + 6, 1, dt1.Rows.Count + 6, countColHeader2];
                r3.Merge = true;
                r3.Style.Font.Bold = true;
                r3.Value = "Môn: " + comboBox3.Text;
                r3.Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                r3.Style.Fill.BackgroundColor.SetColor(Color.LightBlue);
                int chisocot = 1;
                int chisohang = dt1.Rows.Count + 7;
                foreach (var item in arrColumnHeader2)
                {
                    ws.Cells[chisohang, chisocot++].Value = item;                      
                }
                ws.Cells[dt1.Rows.Count + 7, 1, dt1.Rows.Count + 7, countColHeader2].Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                ws.Cells[dt1.Rows.Count + 7, 1, dt1.Rows.Count + 7, countColHeader2].Style.Fill.BackgroundColor.SetColor(Color.Red);
                int stt1 = 1;
                foreach (DataRow r in dt2.Rows)
                {
                    chisocot = 1;
                    chisohang++;
                    ws.Cells[chisohang, chisocot++].Value = stt1++;
                    ws.Cells[chisohang, chisocot++].Value = r[0].ToString();
                    ws.Cells[chisohang, chisocot++].Value = r[1].ToString();
                    ws.Cells[chisohang, chisocot++].Value = Convert.ToDateTime(r[2]).ToString("dd/MM/yyyy");
                    ws.Cells[chisohang, chisocot++].Value = r[3].ToString();
                }
                int bigger;
                if (countColHeader1 > countColHeader2)
                {
                    bigger = countColHeader1;
                } 
                else
                {
                    bigger = countColHeader2;
                }
                var range1 = ws.Cells[1, 1, dt1.Rows.Count + dt2.Rows.Count + 7, bigger];
                range1.Style.Border.Top.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;
                range1.Style.Border.Bottom.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;
                range1.Style.Border.Left.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;
                range1.Style.Border.Right.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;
                range1.Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                range1.Style.VerticalAlignment = OfficeOpenXml.Style.ExcelVerticalAlignment.Center;
                range1.AutoFitColumns();
                var range = ws.Cells[dt1.Rows.Count + dt2.Rows.Count + 7, 1, dt1.Rows.Count + dt2.Rows.Count + 7, bigger];
                
                range.Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                range.Style.Fill.BackgroundColor.SetColor(Color.Bisque);
                Byte[] bin = p.GetAsByteArray();
                File.WriteAllBytes(filePath, bin);
            }
            MessageBox.Show("Xuất excel thành công!");
        }
    }
}
