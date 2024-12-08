namespace QUẢN_LÝ_SINH_VIÊN___TỰ_LÀM
{
    partial class ThuchanhWS
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
            this.txtchuoi = new System.Windows.Forms.TextBox();
            this.txtmang = new System.Windows.Forms.TextBox();
            this.chuoikq = new System.Windows.Forms.TextBox();
            this.mangkq = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập chuỗi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập mảng";
            // 
            // txtchuoi
            // 
            this.txtchuoi.Location = new System.Drawing.Point(252, 54);
            this.txtchuoi.Name = "txtchuoi";
            this.txtchuoi.Size = new System.Drawing.Size(310, 26);
            this.txtchuoi.TabIndex = 2;
            // 
            // txtmang
            // 
            this.txtmang.Location = new System.Drawing.Point(252, 104);
            this.txtmang.Name = "txtmang";
            this.txtmang.Size = new System.Drawing.Size(310, 26);
            this.txtmang.TabIndex = 3;
            // 
            // chuoikq
            // 
            this.chuoikq.Location = new System.Drawing.Point(252, 167);
            this.chuoikq.Name = "chuoikq";
            this.chuoikq.Size = new System.Drawing.Size(310, 26);
            this.chuoikq.TabIndex = 4;
            // 
            // mangkq
            // 
            this.mangkq.Location = new System.Drawing.Point(252, 228);
            this.mangkq.Name = "mangkq";
            this.mangkq.Size = new System.Drawing.Size(310, 26);
            this.mangkq.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Chuyển thành chữ hoa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Số lớn nhất trong mảng";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(278, 295);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(234, 69);
            this.button1.TabIndex = 8;
            this.button1.Text = "Tính toán";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ThuchanhWS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mangkq);
            this.Controls.Add(this.chuoikq);
            this.Controls.Add(this.txtmang);
            this.Controls.Add(this.txtchuoi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ThuchanhWS";
            this.Text = "ThuchanhWS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtchuoi;
        private System.Windows.Forms.TextBox txtmang;
        private System.Windows.Forms.TextBox chuoikq;
        private System.Windows.Forms.TextBox mangkq;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}