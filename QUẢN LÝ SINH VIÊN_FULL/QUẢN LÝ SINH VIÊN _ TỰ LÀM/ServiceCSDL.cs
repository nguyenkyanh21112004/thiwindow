using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using QUẢN_LÝ_SINH_VIÊN___TỰ_LÀM.ServiceReference2;
namespace QUẢN_LÝ_SINH_VIÊN___TỰ_LÀM
{
    public partial class ServiceCSDL : Form
    {
        public ServiceCSDL()
        {
            InitializeComponent();
        }
        ThaotacCSDLClient ob = new ThaotacCSDLClient();
        private void view()
        {
            var lstLop = ob.Load(); // Lấy danh sách các đối tượng Lop
            if (lstLop != null && lstLop.Length > 0)
            {
                dataGridView1.DataSource = lstLop;
            }
        }
        private void ServiceCSDL_Load(object sender, EventArgs e)
        {
            try
            {
                var lstLop = ob.Load(); // Lấy danh sách các đối tượng Lop
                if (lstLop != null && lstLop.Length > 0)
                {
                    dataGridView1.DataSource = lstLop;
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Lop lop = new Lop(txtmalop.Text, txttenlop.Text);
            ob.Insert(lop);
            view();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Lop lop = new Lop(txtmalop.Text, txttenlop.Text);
            ob.Update(lop);
            view();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Lop lop = new Lop(txtmalop.Text, txttenlop.Text);
            ob.Delete(lop);
            view();
        }

        private void chondong(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            txtmalop.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            txttenlop.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
        }
    }
}
