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
    public partial class FormMon : Form
    {
        public FormMon()
        {
            InitializeComponent();
        }
        BUS_Mon bus = new BUS_Mon();
        private void btnThem_Click(object sender, EventArgs e)
        {
            Mon mon = new Mon(txtmamon.Text, txttenmon.Text, Convert.ToInt32(txtsotc.Text));
            bus.Insert(mon);
            dataGridView1.DataSource = bus.LoadMon();
        }

        private void FormMon_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bus.LoadMon();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Mon mon = new Mon(txtmamon.Text, txttenmon.Text, Convert.ToInt32(txtsotc.Text));
            bus.Update(mon);
            dataGridView1.DataSource = bus.LoadMon();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            Mon mon = new Mon(txtmamon.Text, txttenmon.Text, Convert.ToInt32(txtsotc.Text));
            bus.Delete(mon);
            dataGridView1.DataSource = bus.LoadMon();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn thoát form Môn học?", "Xác nhận thoát", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                this.Close();
            }     
        }

        private void chondong(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            txtmamon.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            txttenmon.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            txtsotc.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            
        }
    }
}
