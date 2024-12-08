namespace QUẢN_LÝ_SINH_VIÊN___TỰ_LÀM
{
    partial class FormThilai
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
            this.cbolop = new System.Windows.Forms.ComboBox();
            this.cbomon = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chọn lớp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Chọn môn";
            // 
            // cbolop
            // 
            this.cbolop.FormattingEnabled = true;
            this.cbolop.Location = new System.Drawing.Point(244, 19);
            this.cbolop.Name = "cbolop";
            this.cbolop.Size = new System.Drawing.Size(242, 28);
            this.cbolop.TabIndex = 2;
            // 
            // cbomon
            // 
            this.cbomon.FormattingEnabled = true;
            this.cbomon.Location = new System.Drawing.Point(244, 68);
            this.cbomon.Name = "cbomon";
            this.cbomon.Size = new System.Drawing.Size(242, 28);
            this.cbomon.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(552, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 55);
            this.button1.TabIndex = 4;
            this.button1.Text = "In danh sách thi lại";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(33, 115);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(720, 323);
            this.reportViewer1.TabIndex = 5;
            // 
            // FormThilai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbomon);
            this.Controls.Add(this.cbolop);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormThilai";
            this.Text = "FormThilai";
            this.Load += new System.EventHandler(this.FormThilai_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbolop;
        private System.Windows.Forms.ComboBox cbomon;
        private System.Windows.Forms.Button button1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}