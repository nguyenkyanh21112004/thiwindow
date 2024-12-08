using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace kiemtra
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeComponent();
            this.Controls.Add(this.reportViewer1);
            this.reportViewer1.RefreshReport();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            this.Controls.Add(this.reportViewer2);
            this.reportViewer2.RefreshReport();
        }

        private void reportViewer2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string sql = "select giaovien.magv, giaovien.hoten, detai.madt, detai.tendt, detai.kinhphi from giaovien, detai where giaovien.magv = detai.madt and giaovien.hoten = detai.tendt ";
            DataTable dt = new DataTable();
            reportViewer1.ProcessingMode =
            Microsoft.Reporting.WinForms.ProcessingMode.Local;

            reportViewer1.LocalReport.ReportPath = @"Kiemtra.rdlc";
            if (dt.Rows.Count > 0)
            {
                ReportDataSource rds = new ReportDataSource();
                rds.Name = "Danh Sách Giáo Viên";
                rds.Value = dt;
                reportViewer2.LocalReport.DataSources.Clear();
                reportViewer2.LocalReport.DataSources.Add(rds);
                reportViewer2.RefreshReport();
            }
            else MessageBox.Show("Khong co du lieu");

        }
    }
}
