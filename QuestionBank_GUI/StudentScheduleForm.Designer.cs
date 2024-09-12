using System.Drawing;
using System.Windows.Forms;

namespace QuestionBank_GUI
{
    partial class StudentScheduleForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentScheduleForm));
            this.lbTittle = new System.Windows.Forms.Label();
            this.dataGridViewSchedule = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxMaLop = new System.Windows.Forms.CheckBox();
            this.checkBoxMaMon = new System.Windows.Forms.CheckBox();
            this.checkBoxHocKy = new System.Windows.Forms.CheckBox();
            this.cbHocKy = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaMon = new System.Windows.Forms.TextBox();
            this.txtMaLop = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panelNotice = new System.Windows.Forms.Panel();
            this.btNotice = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSchedule)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panelNotice.SuspendLayout();
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
            this.lbTittle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTittle.Name = "lbTittle";
            this.lbTittle.Size = new System.Drawing.Size(1047, 78);
            this.lbTittle.TabIndex = 4;
            this.lbTittle.Text = "Danh sách lịch thi";
            this.lbTittle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewSchedule
            // 
            this.dataGridViewSchedule.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewSchedule.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSchedule.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewSchedule.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSchedule.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridViewSchedule.Location = new System.Drawing.Point(12, 264);
            this.dataGridViewSchedule.Name = "dataGridViewSchedule";
            this.dataGridViewSchedule.ReadOnly = true;
            this.dataGridViewSchedule.RowHeadersWidth = 51;
            this.dataGridViewSchedule.RowTemplate.Height = 24;
            this.dataGridViewSchedule.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSchedule.Size = new System.Drawing.Size(1003, 287);
            this.dataGridViewSchedule.TabIndex = 11;
            this.dataGridViewSchedule.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSchedule_CellClick);
            this.dataGridViewSchedule.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSchedule_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.groupBox1.Location = new System.Drawing.Point(12, 138);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1003, 120);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // checkBoxMaLop
            // 
            this.checkBoxMaLop.Checked = true;
            this.checkBoxMaLop.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxMaLop.Location = new System.Drawing.Point(600, 59);
            this.checkBoxMaLop.Name = "checkBoxMaLop";
            this.checkBoxMaLop.Size = new System.Drawing.Size(18, 27);
            this.checkBoxMaLop.TabIndex = 11;
            this.checkBoxMaLop.UseVisualStyleBackColor = true;
            // 
            // checkBoxMaMon
            // 
            this.checkBoxMaMon.Checked = true;
            this.checkBoxMaMon.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxMaMon.Location = new System.Drawing.Point(947, 60);
            this.checkBoxMaMon.Name = "checkBoxMaMon";
            this.checkBoxMaMon.Size = new System.Drawing.Size(18, 27);
            this.checkBoxMaMon.TabIndex = 10;
            this.checkBoxMaMon.UseVisualStyleBackColor = true;
            // 
            // checkBoxHocKy
            // 
            this.checkBoxHocKy.Checked = true;
            this.checkBoxHocKy.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxHocKy.Location = new System.Drawing.Point(308, 58);
            this.checkBoxHocKy.Name = "checkBoxHocKy";
            this.checkBoxHocKy.Size = new System.Drawing.Size(18, 27);
            this.checkBoxHocKy.TabIndex = 9;
            this.checkBoxHocKy.UseVisualStyleBackColor = true;
            this.checkBoxHocKy.Visible = false;
            // 
            // cbHocKy
            // 
            this.cbHocKy.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbHocKy.FormattingEnabled = true;
            this.cbHocKy.Location = new System.Drawing.Point(102, 51);
            this.cbHocKy.Name = "cbHocKy";
            this.cbHocKy.Size = new System.Drawing.Size(200, 29);
            this.cbHocKy.TabIndex = 8;
            this.cbHocKy.SelectedIndexChanged += new System.EventHandler(this.cbHocKy_SelectedIndexChanged);
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
            // txtMaMon
            // 
            this.txtMaMon.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaMon.ForeColor = System.Drawing.Color.DarkGray;
            this.txtMaMon.Location = new System.Drawing.Point(749, 52);
            this.txtMaMon.Name = "txtMaMon";
            this.txtMaMon.Size = new System.Drawing.Size(192, 29);
            this.txtMaMon.TabIndex = 4;
            // 
            // txtMaLop
            // 
            this.txtMaLop.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaLop.ForeColor = System.Drawing.Color.DarkGray;
            this.txtMaLop.Location = new System.Drawing.Point(468, 53);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Size = new System.Drawing.Size(126, 29);
            this.txtMaLop.TabIndex = 6;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Teal;
            this.flowLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.flowLayoutPanel1.Controls.Add(this.panelNotice);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 78);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1047, 57);
            this.flowLayoutPanel1.TabIndex = 15;
            // 
            // panelNotice
            // 
            this.panelNotice.BackColor = System.Drawing.Color.Honeydew;
            this.panelNotice.Controls.Add(this.btNotice);
            this.panelNotice.Location = new System.Drawing.Point(3, 3);
            this.panelNotice.Name = "panelNotice";
            this.panelNotice.Size = new System.Drawing.Size(132, 51);
            this.panelNotice.TabIndex = 16;
            // 
            // btNotice
            // 
            this.btNotice.BackColor = System.Drawing.Color.Teal;
            this.btNotice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btNotice.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btNotice.FlatAppearance.BorderSize = 0;
            this.btNotice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btNotice.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNotice.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btNotice.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btNotice.ImageIndex = 0;
            this.btNotice.ImageList = this.imageList1;
            this.btNotice.Location = new System.Drawing.Point(-1, -13);
            this.btNotice.Name = "btNotice";
            this.btNotice.Size = new System.Drawing.Size(130, 71);
            this.btNotice.TabIndex = 2;
            this.btNotice.Text = "Thông báo   ";
            this.btNotice.UseVisualStyleBackColor = false;
            this.btNotice.Click += new System.EventHandler(this.btNotice_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Notice.png");
            this.imageList1.Images.SetKeyName(1, "Notice1.png");
            // 
            // StudentScheduleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 590);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridViewSchedule);
            this.Controls.Add(this.lbTittle);
            this.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.Name = "StudentScheduleForm";
            this.Text = "StudentScheduleForm";
            this.Load += new System.EventHandler(this.StudentScheduleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSchedule)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panelNotice.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbTittle;
        private System.Windows.Forms.DataGridView dataGridViewSchedule;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBoxMaLop;
        private System.Windows.Forms.CheckBox checkBoxMaMon;
        private System.Windows.Forms.CheckBox checkBoxHocKy;
        private System.Windows.Forms.ComboBox cbHocKy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaMon;
        private System.Windows.Forms.TextBox txtMaLop;
        private FlowLayoutPanel flowLayoutPanel1;
        private ImageList imageList1;
        private Button btNotice;
        private Panel panelNotice;
    }
}