namespace QuestionBank_GUI
{
    partial class StudentScoreResult
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentScoreResult));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.timerShowMessage = new System.Windows.Forms.Timer(this.components);
            this.dataGridViewScore = new System.Windows.Forms.DataGridView();
            this.lbTittle = new System.Windows.Forms.Label();
            this.txtMSSV = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btExit = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btEdit = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btDelete = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtDiem = new System.Windows.Forms.TextBox();
            this.txtLoaiDiem = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbModify = new System.Windows.Forms.GroupBox();
            this.btSave = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewScore)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.gbModify.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "find.png");
            this.imageList1.Images.SetKeyName(1, "delete.png");
            this.imageList1.Images.SetKeyName(2, "add.png");
            this.imageList1.Images.SetKeyName(3, "edit.png");
            this.imageList1.Images.SetKeyName(4, "exit.png");
            this.imageList1.Images.SetKeyName(5, "diskette.png");
            // 
            // timerShowMessage
            // 
            this.timerShowMessage.Interval = 3000;
            this.timerShowMessage.Tick += new System.EventHandler(this.timerShowMessage_Tick);
            // 
            // dataGridViewScore
            // 
            this.dataGridViewScore.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewScore.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewScore.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewScore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewScore.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewScore.Location = new System.Drawing.Point(9, 131);
            this.dataGridViewScore.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewScore.Name = "dataGridViewScore";
            this.dataGridViewScore.ReadOnly = true;
            this.dataGridViewScore.RowHeadersVisible = false;
            this.dataGridViewScore.RowHeadersWidth = 51;
            this.dataGridViewScore.RowTemplate.Height = 24;
            this.dataGridViewScore.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridViewScore.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewScore.Size = new System.Drawing.Size(453, 261);
            this.dataGridViewScore.TabIndex = 51;
            // 
            // lbTittle
            // 
            this.lbTittle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTittle.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lbTittle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbTittle.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTittle.ForeColor = System.Drawing.Color.Black;
            this.lbTittle.Location = new System.Drawing.Point(9, 0);
            this.lbTittle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTittle.Name = "lbTittle";
            this.lbTittle.Size = new System.Drawing.Size(456, 48);
            this.lbTittle.TabIndex = 49;
            this.lbTittle.Text = "Bảng điểm";
            this.lbTittle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMSSV
            // 
            this.txtMSSV.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMSSV.Location = new System.Drawing.Point(178, 28);
            this.txtMSSV.Margin = new System.Windows.Forms.Padding(2);
            this.txtMSSV.Name = "txtMSSV";
            this.txtMSSV.Size = new System.Drawing.Size(258, 29);
            this.txtMSSV.TabIndex = 41;
            this.txtMSSV.TextChanged += new System.EventHandler(this.txtMSSV_TextChanged);
            this.txtMSSV.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMSSV_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(22, 33);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 21);
            this.label7.TabIndex = 40;
            this.label7.Text = "Mã số sinh viên:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtMSSV);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(9, 50);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(456, 77);
            this.groupBox1.TabIndex = 50;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin sinh viên";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btExit);
            this.panel4.Location = new System.Drawing.Point(426, 2);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(28, 30);
            this.panel4.TabIndex = 56;
            this.panel4.Visible = false;
            // 
            // btExit
            // 
            this.btExit.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btExit.ImageIndex = 4;
            this.btExit.ImageList = this.imageList1;
            this.btExit.Location = new System.Drawing.Point(-6, -4);
            this.btExit.Margin = new System.Windows.Forms.Padding(2);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(39, 38);
            this.btExit.TabIndex = 52;
            this.btExit.UseVisualStyleBackColor = false;
            this.btExit.Visible = false;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // btAdd
            // 
            this.btAdd.BackColor = System.Drawing.SystemColors.Control;
            this.btAdd.ImageIndex = 2;
            this.btAdd.ImageList = this.imageList1;
            this.btAdd.Location = new System.Drawing.Point(-6, -4);
            this.btAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(39, 38);
            this.btAdd.TabIndex = 52;
            this.btAdd.UseVisualStyleBackColor = false;
            this.btAdd.Visible = false;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btAdd);
            this.panel1.Location = new System.Drawing.Point(9, 197);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(28, 30);
            this.panel1.TabIndex = 53;
            this.panel1.Visible = false;
            // 
            // btEdit
            // 
            this.btEdit.BackColor = System.Drawing.SystemColors.Control;
            this.btEdit.ImageIndex = 3;
            this.btEdit.ImageList = this.imageList1;
            this.btEdit.Location = new System.Drawing.Point(-6, -4);
            this.btEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(39, 38);
            this.btEdit.TabIndex = 52;
            this.btEdit.UseVisualStyleBackColor = false;
            this.btEdit.Visible = false;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btEdit);
            this.panel2.Location = new System.Drawing.Point(41, 197);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(28, 30);
            this.panel2.TabIndex = 54;
            this.panel2.Visible = false;
            // 
            // btDelete
            // 
            this.btDelete.BackColor = System.Drawing.SystemColors.Control;
            this.btDelete.ImageIndex = 1;
            this.btDelete.ImageList = this.imageList1;
            this.btDelete.Location = new System.Drawing.Point(-6, -4);
            this.btDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(39, 38);
            this.btDelete.TabIndex = 52;
            this.btDelete.UseVisualStyleBackColor = false;
            this.btDelete.Visible = false;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btDelete);
            this.panel3.Location = new System.Drawing.Point(74, 197);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(28, 30);
            this.panel3.TabIndex = 55;
            this.panel3.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(31, 249);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 21);
            this.label2.TabIndex = 44;
            this.label2.Text = "Họ và tên:";
            this.label2.Visible = false;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTen.Location = new System.Drawing.Point(134, 243);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(2);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.ReadOnly = true;
            this.txtHoTen.Size = new System.Drawing.Size(310, 29);
            this.txtHoTen.TabIndex = 48;
            this.txtHoTen.Visible = false;
            // 
            // txtDiem
            // 
            this.txtDiem.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiem.Location = new System.Drawing.Point(50, 29);
            this.txtDiem.Margin = new System.Windows.Forms.Padding(2);
            this.txtDiem.Name = "txtDiem";
            this.txtDiem.Size = new System.Drawing.Size(51, 24);
            this.txtDiem.TabIndex = 57;
            // 
            // txtLoaiDiem
            // 
            this.txtLoaiDiem.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoaiDiem.Location = new System.Drawing.Point(188, 29);
            this.txtLoaiDiem.Margin = new System.Windows.Forms.Padding(2);
            this.txtLoaiDiem.Name = "txtLoaiDiem";
            this.txtLoaiDiem.Size = new System.Drawing.Size(108, 24);
            this.txtLoaiDiem.TabIndex = 49;
            this.txtLoaiDiem.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(106, 33);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 16);
            this.label3.TabIndex = 58;
            this.label3.Text = "Loại điểm:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(4, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 49;
            this.label1.Text = "Điểm:";
            // 
            // gbModify
            // 
            this.gbModify.Controls.Add(this.label1);
            this.gbModify.Controls.Add(this.label3);
            this.gbModify.Controls.Add(this.txtLoaiDiem);
            this.gbModify.Controls.Add(this.txtDiem);
            this.gbModify.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbModify.Location = new System.Drawing.Point(139, 167);
            this.gbModify.Margin = new System.Windows.Forms.Padding(2);
            this.gbModify.Name = "gbModify";
            this.gbModify.Padding = new System.Windows.Forms.Padding(2);
            this.gbModify.Size = new System.Drawing.Size(309, 60);
            this.gbModify.TabIndex = 59;
            this.gbModify.TabStop = false;
            this.gbModify.Text = "Điền thông tin";
            this.gbModify.Visible = false;
            // 
            // btSave
            // 
            this.btSave.BackColor = System.Drawing.SystemColors.Control;
            this.btSave.ImageIndex = 5;
            this.btSave.ImageList = this.imageList1;
            this.btSave.Location = new System.Drawing.Point(-6, -4);
            this.btSave.Margin = new System.Windows.Forms.Padding(2);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(39, 38);
            this.btSave.TabIndex = 52;
            this.btSave.UseVisualStyleBackColor = false;
            this.btSave.Visible = false;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btSave);
            this.panel5.Location = new System.Drawing.Point(106, 197);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(28, 30);
            this.panel5.TabIndex = 56;
            this.panel5.Visible = false;
            // 
            // StudentScoreResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 574);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.gbModify);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridViewScore);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbTittle);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "StudentScoreResult";
            this.Text = "StudentScoreResult";
            this.Load += new System.EventHandler(this.StudentScoreResult_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.StudentScoreResult_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.StudentScoreResult_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewScore)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.gbModify.ResumeLayout(false);
            this.gbModify.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Timer timerShowMessage;
        private System.Windows.Forms.DataGridView dataGridViewScore;
        private System.Windows.Forms.Label lbTittle;
        private System.Windows.Forms.TextBox txtMSSV;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtDiem;
        private System.Windows.Forms.TextBox txtLoaiDiem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbModify;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Panel panel5;
    }
}