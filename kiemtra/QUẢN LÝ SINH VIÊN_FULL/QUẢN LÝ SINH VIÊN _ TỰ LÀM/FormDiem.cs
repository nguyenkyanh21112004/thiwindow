using BUS;
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
namespace QUẢN_LÝ_SINH_VIÊN___TỰ_LÀM
{
    public partial class FormDiem : Form
    {
        public FormDiem()
        {
            InitializeComponent();
        }
        BUS_Diem bus = new BUS_Diem();
        private void FormDiem_Load(object sender, EventArgs e)
        {
            DataTable dt1 = bus.LoadCboLop();
            foreach(DataRow r in dt1.Rows)
            {
                cbochonlop.Items.Add(r[1].ToString());
            } 
            DataTable dt2 = bus.LoadCboTenmon();
            foreach(DataRow r in dt2.Rows)
            {
                cbochonmon.Items.Add(r[1].ToString());
            }    
        }

        private void btnlapds_Click(object sender, EventArgs e)
        {
            string tenlop = cbochonlop.Text;
            string tenmon = cbochonmon.Text;
            DataTable dt = bus.LayDS(tenlop, tenmon);
            dataGridView1.DataSource = dt;
        }
       

        private void btnSave_Click(object sender, EventArgs e)
        {
            string tenmon = cbochonmon.Text; //Lấy tên môn từ combobox
            string mamon = bus.Laymamon(tenmon); //Lấy mã môn từ tên môn đó
            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                string masv = r.Cells[0].Value?.ToString(); 
                float diemso = Convert.ToSingle(r.Cells[3].Value?.ToString()); 
                Diem diem = new Diem(masv, mamon, diemso); 
                bus.Luudiem(diem);
            }
        }
    }
}
