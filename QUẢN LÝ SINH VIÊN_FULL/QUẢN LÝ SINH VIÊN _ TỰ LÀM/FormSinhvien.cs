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
    public partial class FormSinhvien : Form
    {
        public FormSinhvien()
        {
            InitializeComponent();
        }
        BUS_Sinhvien bus = new BUS_Sinhvien();
        private void FormSinhvien_Load(object sender, EventArgs e)
        {
            cbomalop.DataSource = bus.LayMalop();
            cbomalop.DisplayMember = "Tenlop";
            cbomalop.ValueMember = "Malop";
            dgvSinhvien.DataSource = bus.LayDL();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Sinhvien sv = new Sinhvien(txtmasv.Text, txthoten.Text, Convert.ToDateTime(txtngaysinh.Text), cbomalop.SelectedValue.ToString());
            bus.Insert(sv);
            dgvSinhvien.DataSource = bus.LayDL();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Sinhvien sv = new Sinhvien(txtmasv.Text, txthoten.Text, Convert.ToDateTime(txtngaysinh.Text), cbomalop.SelectedValue.ToString());
            bus.Update(sv);
            dgvSinhvien.DataSource = bus.LayDL();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            Sinhvien sv = new Sinhvien(txtmasv.Text, txthoten.Text, Convert.ToDateTime(txtngaysinh.Text), cbomalop.SelectedValue.ToString());
            bus.Delete(sv);
            dgvSinhvien.DataSource = bus.LayDL();
        }

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            txtmasv.Clear();
            txthoten.Clear();
            txtngaysinh.Clear();
        }

        private void chondong(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            txtmasv.Text = dgvSinhvien.Rows[i].Cells[0].Value.ToString();
            txthoten.Text = dgvSinhvien.Rows[i].Cells[1].Value.ToString();
            txtngaysinh.Text = dgvSinhvien.Rows[i].Cells[2].Value.ToString();
            cbomalop.Text = dgvSinhvien.Rows[i].Cells[3].Value.ToString();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn thoát form Sinh viên?", "Xác nhận thoát", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                Close();
            }
        }
    }
}
