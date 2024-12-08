namespace Kiểm_tra_31_10
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbmakh = new System.Windows.Forms.TextBox();
            this.tbmaphong = new System.Windows.Forms.TextBox();
            this.tbngayden = new System.Windows.Forms.TextBox();
            this.tbngaydi = new System.Windows.Forms.TextBox();
            this.btThem = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btxoa = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Makh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Maphong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngayden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngaydi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbmakh
            // 
            this.tbmakh.Location = new System.Drawing.Point(424, 92);
            this.tbmakh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbmakh.Name = "tbmakh";
            this.tbmakh.Size = new System.Drawing.Size(148, 26);
            this.tbmakh.TabIndex = 0;
            // 
            // tbmaphong
            // 
            this.tbmaphong.Location = new System.Drawing.Point(424, 149);
            this.tbmaphong.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbmaphong.Name = "tbmaphong";
            this.tbmaphong.Size = new System.Drawing.Size(148, 26);
            this.tbmaphong.TabIndex = 1;
            // 
            // tbngayden
            // 
            this.tbngayden.Location = new System.Drawing.Point(424, 211);
            this.tbngayden.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbngayden.Name = "tbngayden";
            this.tbngayden.Size = new System.Drawing.Size(148, 26);
            this.tbngayden.TabIndex = 2;
            // 
            // tbngaydi
            // 
            this.tbngaydi.Location = new System.Drawing.Point(424, 272);
            this.tbngaydi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbngaydi.Name = "tbngaydi";
            this.tbngaydi.Size = new System.Drawing.Size(148, 26);
            this.tbngaydi.TabIndex = 3;
            // 
            // btThem
            // 
            this.btThem.Location = new System.Drawing.Point(639, 86);
            this.btThem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(112, 35);
            this.btThem.TabIndex = 4;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btSua
            // 
            this.btSua.Location = new System.Drawing.Point(639, 145);
            this.btSua.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(112, 35);
            this.btSua.TabIndex = 5;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btxoa
            // 
            this.btxoa.Location = new System.Drawing.Point(639, 208);
            this.btxoa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btxoa.Name = "btxoa";
            this.btxoa.Size = new System.Drawing.Size(112, 35);
            this.btxoa.TabIndex = 6;
            this.btxoa.Text = "Xóa";
            this.btxoa.UseVisualStyleBackColor = true;
            this.btxoa.Click += new System.EventHandler(this.btxoa_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(639, 269);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(244, 35);
            this.button4.TabIndex = 7;
            this.button4.Text = "In phiếu thanh toán";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Makh,
            this.Maphong,
            this.Ngayden,
            this.Ngaydi});
            this.dataGridView1.Location = new System.Drawing.Point(94, 363);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(1078, 458);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.chondong);
            // 
            // Makh
            // 
            this.Makh.DataPropertyName = "Makh";
            this.Makh.HeaderText = "Mã khách hàng";
            this.Makh.MinimumWidth = 8;
            this.Makh.Name = "Makh";
            this.Makh.Width = 150;
            // 
            // Maphong
            // 
            this.Maphong.DataPropertyName = "Maphong";
            this.Maphong.HeaderText = "Mã phòng";
            this.Maphong.MinimumWidth = 8;
            this.Maphong.Name = "Maphong";
            this.Maphong.Width = 150;
            // 
            // Ngayden
            // 
            this.Ngayden.DataPropertyName = "Ngayden";
            this.Ngayden.HeaderText = "Ngày đến";
            this.Ngayden.MinimumWidth = 8;
            this.Ngayden.Name = "Ngayden";
            this.Ngayden.Width = 150;
            // 
            // Ngaydi
            // 
            this.Ngaydi.DataPropertyName = "Ngaydi";
            this.Ngaydi.HeaderText = "Ngày đi";
            this.Ngaydi.MinimumWidth = 8;
            this.Ngaydi.Name = "Ngaydi";
            this.Ngaydi.Width = 150;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(286, 102);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Mã Khách hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(286, 160);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Mã phòng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(286, 222);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Ngày đến";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(286, 283);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Ngày đi";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 840);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btxoa);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.tbngaydi);
            this.Controls.Add(this.tbngayden);
            this.Controls.Add(this.tbmaphong);
            this.Controls.Add(this.tbmakh);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbmakh;
        private System.Windows.Forms.TextBox tbmaphong;
        private System.Windows.Forms.TextBox tbngayden;
        private System.Windows.Forms.TextBox tbngaydi;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btxoa;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Makh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Maphong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngayden;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngaydi;
    }
}

