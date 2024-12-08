namespace QUẢN_LÝ_SINH_VIÊN___TỰ_LÀM
{
    partial class FormDiemthi
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
            this.txtmasv = new System.Windows.Forms.TextBox();
            this.indiemthi = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã sinh viên";
            // 
            // txtmasv
            // 
            this.txtmasv.Location = new System.Drawing.Point(230, 29);
            this.txtmasv.Name = "txtmasv";
            this.txtmasv.Size = new System.Drawing.Size(196, 26);
            this.txtmasv.TabIndex = 1;
            // 
            // indiemthi
            // 
            this.indiemthi.Location = new System.Drawing.Point(501, 29);
            this.indiemthi.Name = "indiemthi";
            this.indiemthi.Size = new System.Drawing.Size(141, 39);
            this.indiemthi.TabIndex = 2;
            this.indiemthi.Text = "In diểm thi";
            this.indiemthi.UseVisualStyleBackColor = true;
            this.indiemthi.Click += new System.EventHandler(this.indiemthi_Click);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(52, 87);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(655, 334);
            this.reportViewer1.TabIndex = 3;
            // 
            // FormDiemthi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 450);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.indiemthi);
            this.Controls.Add(this.txtmasv);
            this.Controls.Add(this.label1);
            this.Name = "FormDiemthi";
            this.Text = "FormDiemthi";
            this.Load += new System.EventHandler(this.FormDiemthi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtmasv;
        private System.Windows.Forms.Button indiemthi;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}