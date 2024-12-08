using DTO;
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

namespace QUẢN_LÝ_SINH_VIÊN___TỰ_LÀM
{
    public partial class FormLop : Form
    {
        public FormLop()
        {
            InitializeComponent();
        }
        BUS_Lop bus = new BUS_Lop();

        private void btnThem_Click(object sender, EventArgs e)
        {
            string ml = txtmalop.Text;
            string tl = txttenlop.Text;
           
            Lop lop = new Lop(ml,tl);
            if (bus.Insert(lop))
            {
                MessageBox.Show("Thêm lớp thành công!");
                dataGridView1.DataSource = bus.LoadLop();
            }
            else
                MessageBox.Show("Nhập trùng khóa chính!");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Lop lop = new Lop(txtmalop.Text, txttenlop.Text);
            bus.Update(lop);
            dataGridView1.DataSource = bus.LoadLop();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            Lop lop = new Lop(txtmalop.Text, txttenlop.Text);
            bus.Delete(lop);
            dataGridView1.DataSource = bus.LoadLop();
        }

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            txtmalop.Clear();
            txttenlop.Clear();
        }

        private void FormLop_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bus.LoadLop();
        }

        private void chondong(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            txtmalop.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            txttenlop.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn thoát form Lớp?", "Xác nhận thoát", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                Close();
            }
        }
    }
}
