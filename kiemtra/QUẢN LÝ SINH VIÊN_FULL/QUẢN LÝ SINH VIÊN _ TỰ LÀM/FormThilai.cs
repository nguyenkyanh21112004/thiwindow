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
    public partial class FormThilai : Form
    {
        public FormThilai()
        {
            InitializeComponent();
        }
        Connect ob = new Connect();
        BUS_Diem bus = new BUS_Diem();
        private void FormThilai_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
            cbolop.DataSource = bus.LoadCboLop();
            cbolop.DisplayMember = "TENLOP";
            cbomon.DataSource = bus.LoadCboTenmon();
            cbomon.DisplayMember = "TENMON";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "SELECT TENLOP, TENMON, SINHVIEN.MASV, HOTEN, NGAYSINH FROM SINHVIEN, LOP, MON, DIEM WHERE SINHVIEN.MASV = DIEM.MASV AND SINHVIEN.MALOP = LOP.MALOP AND MON.MAMON = DIEM.MAMON AND TENLOP = N'" + cbolop.Text + "' AND TENMON = N'" + cbomon.Text + "' AND DIEM <= 4";
            DataTable dt = ob.Load(sql);
            reportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
            reportViewer1.LocalReport.ReportPath = "D:\\Windows Form\\QUẢN LÝ SINH VIÊN_FULL\\QUẢN LÝ SINH VIÊN _ TỰ LÀM\\Danhsachthilai.rdlc";

            if (dt.Rows.Count > 0)
            {
                ReportDataSource rds = new ReportDataSource();
                rds.Name = "DSThilai";
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
