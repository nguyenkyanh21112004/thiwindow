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
using DTO;
namespace QUẢN_LÝ_SINH_VIÊN___TỰ_LÀM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void nhậpBảngLớpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLop f1 = new FormLop();
            f1.Show();
        }

        private void nhậpBảngSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSinhvien f2 = new FormSinhvien();
            f2.Show();
        }

        private void nhậpBảngMônToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMon f3 = new FormMon();
            f3.Show();
        }

        private void nhậpBảngĐiểmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDiem f4 = new FormDiem();
            f4.Show();
        }

        private void điểmThiCủaSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDiemthi f5 = new FormDiemthi();
            f5.Show();
        }

        private void danhSáchThiLạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormThilai f6 = new FormThilai();
            f6.Show();
        }

        private void tổngHợpSốSinhViênThiLạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTonghop f7 = new FormTonghop();
            f7.Show();
        }

        private void xuấtDanhSáchSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DanhsachSV f8 = new DanhsachSV();
            f8.Show();
        }

        private void xuấtDanhSáchThiLạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DSThilaiExcel f9 = new DSThilaiExcel();
            f9.Show();
        }

        private void thựcHànhWebServicesĐơnGiảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThuchanhWS f10 = new ThuchanhWS();
            f10.Show();
        }

        private void thựcHànhServicesThaoTácVớiCSDLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ServiceCSDL f11 = new ServiceCSDL();
            f11.Show();
        }

        private void xuấtDSSVDSTLVàoCùng1FileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DSSVDSTL f12 = new DSSVDSTL();
            f12.Show();
        }
    }
}
