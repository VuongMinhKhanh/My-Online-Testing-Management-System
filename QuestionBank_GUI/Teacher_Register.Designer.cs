namespace QuestionBank_GUI
{
    partial class Teacher_Register
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtGiangVienId;
        private System.Windows.Forms.TextBox txtCaThi;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgayThi;
        private System.Windows.Forms.Button btnDangKy;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtGiangVienId = new System.Windows.Forms.TextBox();
            this.txtCaThi = new System.Windows.Forms.TextBox();
            this.dateTimePickerNgayThi = new System.Windows.Forms.DateTimePicker();
            this.btnDangKy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtGiangVienId
            // 
            this.txtGiangVienId.Location = new System.Drawing.Point(12, 12);
            this.txtGiangVienId.Name = "txtGiangVienId";
            this.txtGiangVienId.Size = new System.Drawing.Size(200, 22);
            this.txtGiangVienId.TabIndex = 0;
            // 
            // txtCaThi
            // 
            this.txtCaThi.Location = new System.Drawing.Point(12, 40);
            this.txtCaThi.Name = "txtCaThi";
            this.txtCaThi.Size = new System.Drawing.Size(200, 22);
            this.txtCaThi.TabIndex = 1;
            // 
            // dateTimePickerNgayThi
            // 
            this.dateTimePickerNgayThi.Location = new System.Drawing.Point(12, 68);
            this.dateTimePickerNgayThi.Name = "dateTimePickerNgayThi";
            this.dateTimePickerNgayThi.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerNgayThi.TabIndex = 2;
            // 
            // btnDangKy
            // 
            this.btnDangKy.Location = new System.Drawing.Point(12, 96);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(200, 23);
            this.btnDangKy.TabIndex = 3;
            this.btnDangKy.Text = "Đăng ký";
            this.btnDangKy.UseVisualStyleBackColor = true;
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            // 
            // Teacher_Register
            // 
            this.ClientSize = new System.Drawing.Size(513, 299);
            this.Controls.Add(this.btnDangKy);
            this.Controls.Add(this.dateTimePickerNgayThi);
            this.Controls.Add(this.txtCaThi);
            this.Controls.Add(this.txtGiangVienId);
            this.Name = "Teacher_Register";
            this.Text = "Đăng ký giám thị";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
