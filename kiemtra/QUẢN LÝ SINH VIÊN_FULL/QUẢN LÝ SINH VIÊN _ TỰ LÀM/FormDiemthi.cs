using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using DTO;
using BUS;
using Microsoft.Reporting.WinForms;
namespace QUẢN_LÝ_SINH_VIÊN___TỰ_LÀM
{
    public partial class FormDiemthi : Form
    {
        Connect ob = new Connect();
        public FormDiemthi()
        {
            InitializeComponent();
        }

        private void FormDiemthi_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void indiemthi_Click(object sender, EventArgs e)
        {
            string sql = "SELECT SINHVIEN.MASV, HOTEN, NGAYSINH, TENMON, SOTC, DIEM FROM SINHVIEN, LOP, MON, DIEM WHERE SINHVIEN.MASV = DIEM.MASV AND SINHVIEN.MALOP = LOP.MALOP AND DIEM.MAMON = MON.MAMON AND SINHVIEN.MASV = '" + txtmasv.Text + "'";
            DataTable dt = ob.Load(sql);
            reportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
            reportViewer1.LocalReport.ReportPath = "D:\\Windows Form\\QUẢN LÝ SINH VIÊN_FULL\\QUẢN LÝ SINH VIÊN _ TỰ LÀM\\DiemthiSV.rdlc"; 
                                                         
            if (dt.Rows.Count > 0)
            {
                ReportDataSource rds = new ReportDataSource();
                rds.Name = "Diemthi"; 
                rds.Value = dt;
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(rds);
                //reportViewer1.Dock = DockStyle.Fill;
                reportViewer1.RefreshReport();
            }
            else MessageBox.Show("Không có dữ liệu");
        }
    }
}
