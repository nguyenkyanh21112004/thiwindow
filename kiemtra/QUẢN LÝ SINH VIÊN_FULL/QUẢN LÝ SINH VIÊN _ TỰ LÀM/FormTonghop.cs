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
using Microsoft.Reporting.WinForms;
namespace QUẢN_LÝ_SINH_VIÊN___TỰ_LÀM
{
    public partial class FormTonghop : Form
    {
        public FormTonghop()
        {
            InitializeComponent();
        }
        BUS_Diem bus = new BUS_Diem();
        Connect ob = new Connect();
        private void FormTonghop_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
            cbomon.DataSource = bus.LoadCboTenmon();
            cbomon.DisplayMember = "TENMON";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "SELECT TENMON, TENLOP, COUNT(SINHVIEN.MASV) AS [SOLUONG] FROM SINHVIEN, LOP, MON, DIEM WHERE SINHVIEN.MASV = DIEM.MASV AND SINHVIEN.MALOP = LOP.MALOP AND DIEM.MAMON = MON.MAMON AND TENMON = N'" + cbomon.Text + "' AND DIEM <= 4 GROUP BY TENMON, TENLOP";
            DataTable dt = ob.Load(sql);
            reportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
            reportViewer1.LocalReport.ReportPath = "D:\\Windows Form\\QUẢN LÝ SINH VIÊN_FULL\\QUẢN LÝ SINH VIÊN _ TỰ LÀM\\Tonghop.rdlc"; 
            if (dt.Rows.Count > 0)
            {
                ReportDataSource rds = new ReportDataSource();
                rds.Name = "DSTonghop";
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
