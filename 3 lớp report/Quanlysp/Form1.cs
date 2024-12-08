
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

namespace Quanlysp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        THANHPHAM_Bus thanhpham = new THANHPHAM_Bus();

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Insert_Click(object sender, EventArgs e)
        {
            THANHPHAM ob = new THANHPHAM(txtmasp.Text, txtmanv.Text, txtngaythanhpham.Text, txtsoluongnop.Text);
            thanhpham.Insert_Bus(ob);
            Form1_Load(sender, e);
            txtmasp.Clear(); txtmanv.Clear(); txtngaythanhpham.Clear(); txtsoluongnop.Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            txtmasp.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            txtmanv.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            txtngaythanhpham.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            txtsoluongnop.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            txtmasp.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            txtmanv.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            txtngaythanhpham.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            txtsoluongnop.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = thanhpham.Load_Bus();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            THANHPHAM ob = new THANHPHAM(txtmasp.Text, txtmanv.Text, txtngaythanhpham.Text, txtsoluongnop.Text);
            thanhpham.Update_Bus(ob);
            Form1_Load(sender, e);
            txtmasp.Clear(); txtmanv.Clear(); txtngaythanhpham.Clear(); txtsoluongnop.Clear();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            thanhpham.Delete_Bus(txtmasp.Text);
            Form1_Load(sender, e);
            txtmasp.Clear(); txtmanv.Clear(); txtngaythanhpham.Clear(); txtsoluongnop.Clear();
        }
    }
}
