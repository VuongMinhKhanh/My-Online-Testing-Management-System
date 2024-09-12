namespace QuestionBank_GUI
{
    partial class CreateScheduleForm
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
            this.lbTittle = new System.Windows.Forms.Label();
            this.btExit = new System.Windows.Forms.Button();
            this.btConfirm = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbLopHocMonHoc = new System.Windows.Forms.ComboBox();
            this.cbCaThi = new System.Windows.Forms.ComboBox();
            this.dateNgayThi = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.rtxtQuyCheThi = new System.Windows.Forms.RichTextBox();
            this.txtThoiGianThi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtQuesNum = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbTittle
            // 
            this.lbTittle.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lbTittle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbTittle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbTittle.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTittle.ForeColor = System.Drawing.Color.Black;
            this.lbTittle.Location = new System.Drawing.Point(0, 0);
            this.lbTittle.Name = "lbTittle";
            this.lbTittle.Size = new System.Drawing.Size(955, 62);
            this.lbTittle.TabIndex = 4;
            this.lbTittle.Text = "Thêm lịch thi";
            this.lbTittle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btExit
            // 
            this.btExit.BackColor = System.Drawing.Color.Blue;
            this.btExit.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btExit.Location = new System.Drawing.Point(744, 268);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(136, 92);
            this.btExit.TabIndex = 11;
            this.btExit.Text = "Đóng";
            this.btExit.UseVisualStyleBackColor = false;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // btConfirm
            // 
            this.btConfirm.BackColor = System.Drawing.Color.Blue;
            this.btConfirm.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConfirm.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btConfirm.Location = new System.Drawing.Point(744, 138);
            this.btConfirm.Name = "btConfirm";
            this.btConfirm.Size = new System.Drawing.Size(136, 92);
            this.btConfirm.TabIndex = 10;
            this.btConfirm.Text = "Xác nhận";
            this.btConfirm.UseVisualStyleBackColor = false;
            this.btConfirm.Click += new System.EventHandler(this.btConfirm_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(34, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 22);
            this.label3.TabIndex = 14;
            this.label3.Text = "Ngày thi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(34, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 22);
            this.label2.TabIndex = 13;
            this.label2.Text = "Chọn lớp và môn:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(223, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 22);
            this.label4.TabIndex = 15;
            this.label4.Text = "Ca thi:";
            // 
            // cbLopHocMonHoc
            // 
            this.cbLopHocMonHoc.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLopHocMonHoc.FormattingEnabled = true;
            this.cbLopHocMonHoc.Location = new System.Drawing.Point(39, 118);
            this.cbLopHocMonHoc.Name = "cbLopHocMonHoc";
            this.cbLopHocMonHoc.Size = new System.Drawing.Size(355, 27);
            this.cbLopHocMonHoc.TabIndex = 17;
            this.cbLopHocMonHoc.SelectedIndexChanged += new System.EventHandler(this.cbMaLop_SelectedIndexChanged);
            // 
            // cbCaThi
            // 
            this.cbCaThi.Font = new System.Drawing.Font("Arial Narrow", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCaThi.FormattingEnabled = true;
            this.cbCaThi.Items.AddRange(new object[] {
            "7:30",
            "9:45",
            "13:00",
            "15:30",
            "18:00"});
            this.cbCaThi.Location = new System.Drawing.Point(228, 214);
            this.cbCaThi.Name = "cbCaThi";
            this.cbCaThi.Size = new System.Drawing.Size(166, 30);
            this.cbCaThi.TabIndex = 19;
            this.cbCaThi.SelectedIndexChanged += new System.EventHandler(this.cbCaThi_SelectedIndexChanged);
            // 
            // dateNgayThi
            // 
            this.dateNgayThi.CalendarFont = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateNgayThi.CustomFormat = "dd/MM/yyyy";
            this.dateNgayThi.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateNgayThi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateNgayThi.Location = new System.Drawing.Point(39, 214);
            this.dateNgayThi.Name = "dateNgayThi";
            this.dateNgayThi.Size = new System.Drawing.Size(166, 29);
            this.dateNgayThi.TabIndex = 20;
            this.dateNgayThi.ValueChanged += new System.EventHandler(this.dateNgayThi_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(402, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 22);
            this.label5.TabIndex = 21;
            this.label5.Text = "Quy chế thi:";
            // 
            // rtxtQuyCheThi
            // 
            this.rtxtQuyCheThi.Location = new System.Drawing.Point(407, 108);
            this.rtxtQuyCheThi.Name = "rtxtQuyCheThi";
            this.rtxtQuyCheThi.Size = new System.Drawing.Size(276, 275);
            this.rtxtQuyCheThi.TabIndex = 22;
            this.rtxtQuyCheThi.Text = "";
            // 
            // txtThoiGianThi
            // 
            this.txtThoiGianThi.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThoiGianThi.Location = new System.Drawing.Point(39, 318);
            this.txtThoiGianThi.Name = "txtThoiGianThi";
            this.txtThoiGianThi.Size = new System.Drawing.Size(166, 29);
            this.txtThoiGianThi.TabIndex = 41;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(34, 278);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 22);
            this.label7.TabIndex = 40;
            this.label7.Text = "Thời gian thi:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(224, 278);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 22);
            this.label1.TabIndex = 42;
            this.label1.Text = "Số câu:";
            // 
            // txtQuesNum
            // 
            this.txtQuesNum.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuesNum.Location = new System.Drawing.Point(227, 318);
            this.txtQuesNum.Name = "txtQuesNum";
            this.txtQuesNum.Size = new System.Drawing.Size(166, 29);
            this.txtQuesNum.TabIndex = 43;
            // 
            // CreateScheduleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 405);
            this.Controls.Add(this.txtQuesNum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtThoiGianThi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.rtxtQuyCheThi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateNgayThi);
            this.Controls.Add(this.cbCaThi);
            this.Controls.Add(this.cbLopHocMonHoc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btConfirm);
            this.Controls.Add(this.lbTittle);
            this.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CreateScheduleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CreateScheduleForm";
            this.Load += new System.EventHandler(this.CreateScheduleForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTittle;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Button btConfirm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbLopHocMonHoc;
        private System.Windows.Forms.ComboBox cbCaThi;
        private System.Windows.Forms.DateTimePicker dateNgayThi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox rtxtQuyCheThi;
        private System.Windows.Forms.TextBox txtThoiGianThi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtQuesNum;
    }
}