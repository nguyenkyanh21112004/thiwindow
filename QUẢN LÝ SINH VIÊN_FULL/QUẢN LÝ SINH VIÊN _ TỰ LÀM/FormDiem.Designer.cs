namespace QUẢN_LÝ_SINH_VIÊN___TỰ_LÀM
{
    partial class FormDiem
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbochonlop = new System.Windows.Forms.ComboBox();
            this.cbochonmon = new System.Windows.Forms.ComboBox();
            this.btnlapds = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MASV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HOTEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYSINH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIEM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(167, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chọn lớp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(167, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Chọn môn";
            // 
            // cbochonlop
            // 
            this.cbochonlop.FormattingEnabled = true;
            this.cbochonlop.Location = new System.Drawing.Point(298, 29);
            this.cbochonlop.Name = "cbochonlop";
            this.cbochonlop.Size = new System.Drawing.Size(265, 28);
            this.cbochonlop.TabIndex = 2;
            // 
            // cbochonmon
            // 
            this.cbochonmon.FormattingEnabled = true;
            this.cbochonmon.Location = new System.Drawing.Point(298, 79);
            this.cbochonmon.Name = "cbochonmon";
            this.cbochonmon.Size = new System.Drawing.Size(265, 28);
            this.cbochonmon.TabIndex = 3;
            // 
            // btnlapds
            // 
            this.btnlapds.Location = new System.Drawing.Point(141, 125);
            this.btnlapds.Name = "btnlapds";
            this.btnlapds.Size = new System.Drawing.Size(175, 42);
            this.btnlapds.TabIndex = 4;
            this.btnlapds.Text = "Lấy danh sách";
            this.btnlapds.UseVisualStyleBackColor = true;
            this.btnlapds.Click += new System.EventHandler(this.btnlapds_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(451, 125);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(175, 42);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Lưu điểm";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MASV,
            this.HOTEN,
            this.NGAYSINH,
            this.DIEM});
            this.dataGridView1.Location = new System.Drawing.Point(42, 188);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(779, 288);
            this.dataGridView1.TabIndex = 6;
            // 
            // MASV
            // 
            this.MASV.DataPropertyName = "MASV";
            this.MASV.HeaderText = "Mã sinh viên";
            this.MASV.MinimumWidth = 8;
            this.MASV.Name = "MASV";
            this.MASV.Width = 150;
            // 
            // HOTEN
            // 
            this.HOTEN.DataPropertyName = "HOTEN";
            this.HOTEN.HeaderText = "Họ tên";
            this.HOTEN.MinimumWidth = 8;
            this.HOTEN.Name = "HOTEN";
            this.HOTEN.Width = 150;
            // 
            // NGAYSINH
            // 
            this.NGAYSINH.DataPropertyName = "NGAYSINH";
            this.NGAYSINH.HeaderText = "Ngày sinh";
            this.NGAYSINH.MinimumWidth = 8;
            this.NGAYSINH.Name = "NGAYSINH";
            this.NGAYSINH.Width = 150;
            // 
            // DIEM
            // 
            this.DIEM.DataPropertyName = "DIEM";
            this.DIEM.HeaderText = "Điểm số";
            this.DIEM.MinimumWidth = 8;
            this.DIEM.Name = "DIEM";
            this.DIEM.Width = 150;
            // 
            // FormDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 488);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnlapds);
            this.Controls.Add(this.cbochonmon);
            this.Controls.Add(this.cbochonlop);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormDiem";
            this.Text = "FormDiem";
            this.Load += new System.EventHandler(this.FormDiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbochonlop;
        private System.Windows.Forms.ComboBox cbochonmon;
        private System.Windows.Forms.Button btnlapds;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MASV;
        private System.Windows.Forms.DataGridViewTextBoxColumn HOTEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYSINH;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIEM;
    }
}