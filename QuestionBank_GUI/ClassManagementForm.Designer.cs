namespace QuestionBank_GUI
{
    partial class ClassManagementForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClassManagementForm));
            this.lbTittle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtPage = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btNext = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btPrevious = new System.Windows.Forms.Button();
            this.dataGridViewClass = new System.Windows.Forms.DataGridView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panelOption = new System.Windows.Forms.Panel();
            this.btDetail = new System.Windows.Forms.Button();
            this.btFind = new System.Windows.Forms.Button();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.dataGridViewSearchResult = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClass)).BeginInit();
            this.panelOption.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearchResult)).BeginInit();
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
            this.lbTittle.Size = new System.Drawing.Size(1047, 83);
            this.lbTittle.TabIndex = 5;
            this.lbTittle.Text = "Quản lý lớp";
            this.lbTittle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.dataGridViewClass);
            this.panel1.Location = new System.Drawing.Point(26, 134);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(983, 280);
            this.panel1.TabIndex = 16;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtPage);
            this.panel4.Location = new System.Drawing.Point(782, 252);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(93, 17);
            this.panel4.TabIndex = 5;
            // 
            // txtPage
            // 
            this.txtPage.BackColor = System.Drawing.Color.Silver;
            this.txtPage.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPage.Location = new System.Drawing.Point(-3, -4);
            this.txtPage.Name = "txtPage";
            this.txtPage.Size = new System.Drawing.Size(101, 23);
            this.txtPage.TabIndex = 6;
            this.txtPage.Text = "Page 1 of 2";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btNext);
            this.panel3.Location = new System.Drawing.Point(706, 247);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(59, 31);
            this.panel3.TabIndex = 5;
            // 
            // btNext
            // 
            this.btNext.BackColor = System.Drawing.Color.Silver;
            this.btNext.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNext.Location = new System.Drawing.Point(-5, -6);
            this.btNext.Name = "btNext";
            this.btNext.Size = new System.Drawing.Size(75, 41);
            this.btNext.TabIndex = 1;
            this.btNext.Text = ">";
            this.btNext.UseVisualStyleBackColor = false;
            this.btNext.Click += new System.EventHandler(this.btNext_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btPrevious);
            this.panel2.Location = new System.Drawing.Point(641, 247);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(59, 31);
            this.panel2.TabIndex = 4;
            // 
            // btPrevious
            // 
            this.btPrevious.BackColor = System.Drawing.Color.Silver;
            this.btPrevious.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPrevious.Location = new System.Drawing.Point(-5, -6);
            this.btPrevious.Name = "btPrevious";
            this.btPrevious.Size = new System.Drawing.Size(75, 41);
            this.btPrevious.TabIndex = 1;
            this.btPrevious.Text = "<";
            this.btPrevious.UseVisualStyleBackColor = false;
            this.btPrevious.Click += new System.EventHandler(this.btPrevious_Click);
            // 
            // dataGridViewClass
            // 
            this.dataGridViewClass.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewClass.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewClass.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewClass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewClass.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewClass.Location = new System.Drawing.Point(4, 1);
            this.dataGridViewClass.Name = "dataGridViewClass";
            this.dataGridViewClass.ReadOnly = true;
            this.dataGridViewClass.RowHeadersVisible = false;
            this.dataGridViewClass.RowHeadersWidth = 51;
            this.dataGridViewClass.RowTemplate.Height = 24;
            this.dataGridViewClass.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridViewClass.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewClass.Size = new System.Drawing.Size(970, 234);
            this.dataGridViewClass.TabIndex = 2;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "find.png");
            // 
            // panelOption
            // 
            this.panelOption.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelOption.BackColor = System.Drawing.Color.RosyBrown;
            this.panelOption.Controls.Add(this.btDetail);
            this.panelOption.Controls.Add(this.btFind);
            this.panelOption.Controls.Add(this.txtFind);
            this.panelOption.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelOption.Location = new System.Drawing.Point(0, 83);
            this.panelOption.Name = "panelOption";
            this.panelOption.Size = new System.Drawing.Size(1047, 41);
            this.panelOption.TabIndex = 17;
            // 
            // btDetail
            // 
            this.btDetail.Location = new System.Drawing.Point(19, 3);
            this.btDetail.Name = "btDetail";
            this.btDetail.Size = new System.Drawing.Size(89, 34);
            this.btDetail.TabIndex = 12;
            this.btDetail.Text = "Xem lớp";
            this.btDetail.UseVisualStyleBackColor = true;
            this.btDetail.Click += new System.EventHandler(this.btDetail_Click);
            // 
            // btFind
            // 
            this.btFind.BackColor = System.Drawing.Color.Teal;
            this.btFind.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btFind.BackgroundImage")));
            this.btFind.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFind.ImageIndex = 0;
            this.btFind.ImageList = this.imageList1;
            this.btFind.Location = new System.Drawing.Point(948, 3);
            this.btFind.Name = "btFind";
            this.btFind.Size = new System.Drawing.Size(67, 34);
            this.btFind.TabIndex = 11;
            this.btFind.UseVisualStyleBackColor = false;
            this.btFind.Click += new System.EventHandler(this.btFind_Click);
            // 
            // txtFind
            // 
            this.txtFind.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFind.ForeColor = System.Drawing.Color.DarkGray;
            this.txtFind.Location = new System.Drawing.Point(550, 6);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(392, 29);
            this.txtFind.TabIndex = 10;
            this.txtFind.TextChanged += new System.EventHandler(this.txtFind_TextChanged);
            // 
            // dataGridViewSearchResult
            // 
            this.dataGridViewSearchResult.AllowUserToAddRows = false;
            this.dataGridViewSearchResult.AllowUserToDeleteRows = false;
            this.dataGridViewSearchResult.AllowUserToResizeColumns = false;
            this.dataGridViewSearchResult.AllowUserToResizeRows = false;
            this.dataGridViewSearchResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSearchResult.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewSearchResult.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewSearchResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSearchResult.ColumnHeadersVisible = false;
            this.dataGridViewSearchResult.Location = new System.Drawing.Point(550, 126);
            this.dataGridViewSearchResult.Name = "dataGridViewSearchResult";
            this.dataGridViewSearchResult.RowHeadersVisible = false;
            this.dataGridViewSearchResult.RowHeadersWidth = 51;
            this.dataGridViewSearchResult.RowTemplate.Height = 30;
            this.dataGridViewSearchResult.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSearchResult.Size = new System.Drawing.Size(392, 0);
            this.dataGridViewSearchResult.TabIndex = 6;
            this.dataGridViewSearchResult.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSearchResult_CellClick);
            // 
            // ClassManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 431);
            this.Controls.Add(this.dataGridViewSearchResult);
            this.Controls.Add(this.panelOption);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbTittle);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "ClassManagementForm";
            this.Text = "ScoreManagedForm";
            this.Load += new System.EventHandler(this.ScoreManagedForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClass)).EndInit();
            this.panelOption.ResumeLayout(false);
            this.panelOption.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearchResult)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbTittle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btNext;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btPrevious;
        private System.Windows.Forms.DataGridView dataGridViewClass;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtPage;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel panelOption;
        private System.Windows.Forms.Button btFind;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.Button btDetail;
        private System.Windows.Forms.DataGridView dataGridViewSearchResult;
    }
}