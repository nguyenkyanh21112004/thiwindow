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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using OfficeOpenXml;
using System.IO;

namespace Kiểm_tra_31_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        BUS_KS bus=new BUS_KS();
        private void btThem_Click(object sender, EventArgs e)
        {
            DTO_KS kS = new DTO_KS(tbmakh.Text,tbmaphong.Text,tbngayden.Text,tbngaydi.Text);
            bus.BUS_Them(kS);
            dataGridView1.DataSource = bus.BUS_loaddl();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bus.BUS_loaddl();
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            DTO_KS kS = new DTO_KS(tbmakh.Text, tbmaphong.Text, tbngayden.Text, tbngaydi.Text);
            bus.BUS_Sua(kS);
            dataGridView1.DataSource = bus.BUS_loaddl();
        }

        private void chondong(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            tbmakh.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            tbmaphong.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            tbngayden.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            tbngaydi.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
                DTO_makh k= new DTO_makh(tbmakh.Text);
                DataTable dt = new DataTable();
                dt = bus.BUS_loadEX(k);
                string filePath = "F:\\excel1.xlsx";
                SaveFileDialog dialog = new SaveFileDialog();
                dialog.Filter = "Excel | *.xlsx | Excel 2012 | *.xls";
                if (string.IsNullOrEmpty(filePath))
                {
                    MessageBox.Show("Đường dẫn báo cáo không hợp lệ");

                }
                using (ExcelPackage p = new ExcelPackage())
                {

                    p.Workbook.Worksheets.Add("HOADON"); 
                                                                  
                    ExcelWorksheet ws = p.Workbook.Worksheets[1];

                 
                    string[] arrColumnHeader = { "Mã Khách", "Họ Tên", "Mã phòng", "Ngày đến", "Ngày đi","Giá","số ngày","số tiền" };
                   
                    var countColHeader = arrColumnHeader.Count();

                    
                    ws.Cells[1, 1].Value = "Hóa đơn ";
                    ws.Cells[1, 1, 1, countColHeader].Merge = true;
                    ws.Cells[1, 1, 1, countColHeader].Style.Font.Bold = true;

                    int colIndex = 1;  // Cột bắt đầu tính từ 1 trong Excel
                    int rowIndex = 2;  // dòng thứ 2 trừ dòng tiêu đề
                    foreach (var item in arrColumnHeader)
                    {
                        ws.Cells[rowIndex, colIndex++].Value = item;

                    }
                
                    
                    foreach (DataRow row in dt.Rows)
                    {
                        colIndex = 1;
                        rowIndex++;
                      
                       
                        ws.Cells[rowIndex, colIndex++].Value = row[0].ToString();
                        ws.Cells[rowIndex, colIndex++].Value = row[1].ToString();
                        ws.Cells[rowIndex, colIndex++].Value = row[2].ToString();
                        ws.Cells[rowIndex, colIndex++].Value = row[3].ToString();
                        ws.Cells[rowIndex, colIndex++].Value = row[4].ToString();
                        ws.Cells[rowIndex, colIndex++].Value = row[5].ToString();
                        ws.Cells[rowIndex, colIndex++].Value = row[6].ToString();
                        ws.Cells[rowIndex, colIndex++].Value = row[7].ToString();
                }
                    Byte[] bin = p.GetAsByteArray();
                    File.WriteAllBytes(filePath, bin);
                }
                MessageBox.Show("Xuất Excel thành công!");

            }

        private void btxoa_Click(object sender, EventArgs e)
        {
            DTO_makh k = new DTO_makh(tbmakh.Text);
            bus.BUS_Xoa(k);
            dataGridView1.DataSource = bus.BUS_loaddl();
        }
    }
}
