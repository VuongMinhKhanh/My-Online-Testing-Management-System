using System.Drawing;

namespace QuestionBank_GUI
{
    partial class ScheduleForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.lbTittle = new System.Windows.Forms.Label();
            this.txtMaLop = new System.Windows.Forms.TextBox();
            this.btAdd = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewSchedule = new System.Windows.Forms.DataGridView();
            this.btEdit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxMaLop = new System.Windows.Forms.CheckBox();
            this.checkBoxMaMon = new System.Windows.Forms.CheckBox();
            this.checkBoxHocKy = new System.Windows.Forms.CheckBox();
            this.cbHocKy = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaMon = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSchedule)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(361, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã Lớp:";
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
            this.lbTittle.Size = new System.Drawing.Size(1312, 62);
            this.lbTittle.TabIndex = 3;
            this.lbTittle.Text = "Danh sách lịch thi";
            this.lbTittle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMaLop
            // 
            this.txtMaLop.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaLop.ForeColor = System.Drawing.Color.DarkGray;
            this.txtMaLop.Location = new System.Drawing.Point(455, 56);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Size = new System.Drawing.Size(126, 29);
            this.txtMaLop.TabIndex = 6;
            this.txtMaLop.TextChanged += new System.EventHandler(this.txtMaLop_TextChanged);
            this.txtMaLop.Enter += new System.EventHandler(this.txtMaMon_Enter);
            this.txtMaLop.Leave += new System.EventHandler(this.txtMaMon_Leave);
            // 
            // btAdd
            // 
            this.btAdd.BackColor = System.Drawing.Color.Blue;
            this.btAdd.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdd.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btAdd.Location = new System.Drawing.Point(347, 496);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(136, 92);
            this.btAdd.TabIndex = 8;
            this.btAdd.Text = "Thêm";
            this.btAdd.UseVisualStyleBackColor = false;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btDelete
            // 
            this.btDelete.BackColor = System.Drawing.Color.Blue;
            this.btDelete.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDelete.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btDelete.Location = new System.Drawing.Point(585, 496);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(136, 92);
            this.btDelete.TabIndex = 9;
            this.btDelete.Text = "Xóa";
            this.btDelete.UseVisualStyleBackColor = false;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(184, 191);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(983, 254);
            this.panel1.TabIndex = 10;
            // 
            // dataGridViewSchedule
            // 
            this.dataGridViewSchedule.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSchedule.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSchedule.Location = new System.Drawing.Point(184, 191);
            this.dataGridViewSchedule.Name = "dataGridViewSchedule";
            this.dataGridViewSchedule.ReadOnly = true;
            this.dataGridViewSchedule.RowHeadersWidth = 51;
            this.dataGridViewSchedule.RowTemplate.Height = 24;
            this.dataGridViewSchedule.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSchedule.Size = new System.Drawing.Size(980, 299);
            this.dataGridViewSchedule.TabIndex = 0;
            // 
            // btEdit
            // 
            this.btEdit.BackColor = System.Drawing.Color.Blue;
            this.btEdit.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEdit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btEdit.Location = new System.Drawing.Point(830, 496);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(136, 92);
            this.btEdit.TabIndex = 12;
            this.btEdit.Text = "Chỉnh sửa";
            this.btEdit.UseVisualStyleBackColor = false;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxMaLop);
            this.groupBox1.Controls.Add(this.checkBoxMaMon);
            this.groupBox1.Controls.Add(this.checkBoxHocKy);
            this.groupBox1.Controls.Add(this.cbHocKy);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtMaMon);
            this.groupBox1.Controls.Add(this.txtMaLop);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(184, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(983, 120);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // checkBoxMaLop
            // 
            this.checkBoxMaLop.Checked = true;
            this.checkBoxMaLop.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxMaLop.Location = new System.Drawing.Point(587, 57);
            this.checkBoxMaLop.Name = "checkBoxMaLop";
            this.checkBoxMaLop.Size = new System.Drawing.Size(18, 27);
            this.checkBoxMaLop.TabIndex = 11;
            this.checkBoxMaLop.UseVisualStyleBackColor = true;
            // 
            // checkBoxMaMon
            // 
            this.checkBoxMaMon.Checked = true;
            this.checkBoxMaMon.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxMaMon.Location = new System.Drawing.Point(933, 58);
            this.checkBoxMaMon.Name = "checkBoxMaMon";
            this.checkBoxMaMon.Size = new System.Drawing.Size(18, 27);
            this.checkBoxMaMon.TabIndex = 10;
            this.checkBoxMaMon.UseVisualStyleBackColor = true;
            // 
            // checkBoxHocKy
            // 
            this.checkBoxHocKy.Checked = true;
            this.checkBoxHocKy.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxHocKy.Location = new System.Drawing.Point(305, 57);
            this.checkBoxHocKy.Name = "checkBoxHocKy";
            this.checkBoxHocKy.Size = new System.Drawing.Size(18, 27);
            this.checkBoxHocKy.TabIndex = 9;
            this.checkBoxHocKy.UseVisualStyleBackColor = true;
            // 
            // cbHocKy
            // 
            this.cbHocKy.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbHocKy.FormattingEnabled = true;
            this.cbHocKy.Location = new System.Drawing.Point(99, 56);
            this.cbHocKy.Name = "cbHocKy";
            this.cbHocKy.Size = new System.Drawing.Size(200, 29);
            this.cbHocKy.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(6, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "Học kỳ:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(638, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã môn:";
            // 
            // txtMaMon
            // 
            this.txtMaMon.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaMon.ForeColor = System.Drawing.Color.DarkGray;
            this.txtMaMon.Location = new System.Drawing.Point(735, 56);
            this.txtMaMon.Name = "txtMaMon";
            this.txtMaMon.Size = new System.Drawing.Size(192, 29);
            this.txtMaMon.TabIndex = 4;
            this.txtMaMon.Enter += new System.EventHandler(this.txtMaMon_Enter);
            this.txtMaMon.Leave += new System.EventHandler(this.txtMaMon_Leave);
            // 
            // ScheduleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 745);
            this.Controls.Add(this.dataGridViewSchedule);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btEdit);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.lbTittle);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DarkGray;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "ScheduleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ScheduleForm";
            this.Load += new System.EventHandler(this.ScheduleForm_Load);
            this.Leave += new System.EventHandler(this.txtMaMon_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSchedule)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbTittle;
        private System.Windows.Forms.TextBox txtMaLop;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewSchedule;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaMon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbHocKy;
        private System.Windows.Forms.CheckBox checkBoxHocKy;
        private System.Windows.Forms.CheckBox checkBoxMaLop;
        private System.Windows.Forms.CheckBox checkBoxMaMon;
    }
}