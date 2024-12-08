using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QUẢN_LÝ_SINH_VIÊN___TỰ_LÀM.ServiceReference1;
namespace QUẢN_LÝ_SINH_VIÊN___TỰ_LÀM
{
    public partial class ThuchanhWS : Form
    {
        public ThuchanhWS()
        {
            InitializeComponent();
            chuoikq.Enabled = false;
            mangkq.Enabled = false;
        }
        MyServiceClient ob = new MyServiceClient();
        private void button1_Click(object sender, EventArgs e)
        {
            chuoikq.Text = ob.chuyendoi(txtchuoi.Text);
            string mang = txtmang.Text;
            try
            {
                //Cho người dùng nhập mảng ngăn cách các số bằng dấu phẩy, dấu cách, hoặc chấm phẩy đều oke
                char[] ngancach = new char[] { ',', ' ', ';' };
                int[]a = mang.Split(ngancach, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                mangkq.Text = ob.max(a).ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Vui lòng nhập các số hợp lệ, phân tách bởi dấu phẩy, dấu cách hoặc dấu chấm phẩy.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }
    }
}
