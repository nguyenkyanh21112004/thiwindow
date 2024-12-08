namespace DSTHILAI
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Masach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tensach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Giaban = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xemds = new System.Windows.Forms.Button();
            this.xuatds = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Masach,
            this.Tensach,
            this.Soluong,
            this.Giaban,
            this.Mota});
            this.dataGridView1.Location = new System.Drawing.Point(42, 196);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(807, 242);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Masach
            // 
            this.Masach.HeaderText = "Mã sách";
            this.Masach.MinimumWidth = 8;
            this.Masach.Name = "Masach";
            this.Masach.Width = 150;
            // 
            // Tensach
            // 
            this.Tensach.HeaderText = "Tên sách";
            this.Tensach.MinimumWidth = 8;
            this.Tensach.Name = "Tensach";
            this.Tensach.Width = 150;
            // 
            // Soluong
            // 
            this.Soluong.HeaderText = "Số lượng";
            this.Soluong.MinimumWidth = 8;
            this.Soluong.Name = "Soluong";
            this.Soluong.Width = 150;
            // 
            // Giaban
            // 
            this.Giaban.HeaderText = "Giá bán";
            this.Giaban.MinimumWidth = 8;
            this.Giaban.Name = "Giaban";
            this.Giaban.Width = 150;
            // 
            // Mota
            // 
            this.Mota.HeaderText = "Mô tả";
            this.Mota.MinimumWidth = 8;
            this.Mota.Name = "Mota";
            this.Mota.Width = 150;
            // 
            // xemds
            // 
            this.xemds.Location = new System.Drawing.Point(140, 117);
            this.xemds.Name = "xemds";
            this.xemds.Size = new System.Drawing.Size(185, 33);
            this.xemds.TabIndex = 3;
            this.xemds.Text = "xem";
            this.xemds.UseVisualStyleBackColor = true;
            this.xemds.Click += new System.EventHandler(this.xemds_Click);
            // 
            // xuatds
            // 
            this.xuatds.Location = new System.Drawing.Point(443, 117);
            this.xuatds.Name = "xuatds";
            this.xuatds.Size = new System.Drawing.Size(185, 33);
            this.xuatds.TabIndex = 4;
            this.xuatds.Text = "Xuất DL ra excel";
            this.xuatds.UseVisualStyleBackColor = true;
            this.xuatds.Click += new System.EventHandler(this.xuatds_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 504);
            this.Controls.Add(this.xuatds);
            this.Controls.Add(this.xemds);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button xemds;
        private System.Windows.Forms.Button xuatds;
        private System.Windows.Forms.DataGridViewTextBoxColumn Masach;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tensach;
        private System.Windows.Forms.DataGridViewTextBoxColumn Soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Giaban;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mota;
    }
}

