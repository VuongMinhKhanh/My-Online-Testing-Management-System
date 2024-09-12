namespace QuestionBank_GUI
{
    partial class StatsForm
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
            this.chartScores = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label3 = new System.Windows.Forms.Label();
            this.cbSubject = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbSemester = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbSchoolYear = new System.Windows.Forms.ComboBox();
            this.toolTipPoint = new System.Windows.Forms.ToolTip(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.cbChartType = new System.Windows.Forms.ComboBox();
            this.btnExportToPdf = new System.Windows.Forms.Button();
            this.ckboxSemester = new System.Windows.Forms.CheckBox();
            this.ckboxYear = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.chartScores)).BeginInit();
            this.SuspendLayout();
            // 
            // chartScores
            // 
            this.chartScores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chartScores.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalLeft;
            this.chartScores.Location = new System.Drawing.Point(18, 94);
            this.chartScores.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chartScores.Name = "chartScores";
            this.chartScores.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            this.chartScores.Size = new System.Drawing.Size(1164, 529);
            this.chartScores.TabIndex = 0;
            this.chartScores.Text = "chart1";
            this.chartScores.MouseMove += new System.Windows.Forms.MouseEventHandler(this.chartScores_MouseMove);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(294, 18);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Môn học";
            // 
            // cbSubject
            // 
            this.cbSubject.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbSubject.FormattingEnabled = true;
            this.cbSubject.Location = new System.Drawing.Point(537, 15);
            this.cbSubject.Margin = new System.Windows.Forms.Padding(6);
            this.cbSubject.Name = "cbSubject";
            this.cbSubject.Size = new System.Drawing.Size(370, 28);
            this.cbSubject.TabIndex = 17;
            this.cbSubject.Tag = "";
            this.cbSubject.SelectedIndexChanged += new System.EventHandler(this.cbSubject_SelectedIndexChanged);
            this.cbSubject.SelectionChangeCommitted += new System.EventHandler(this.cbSubject_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(255, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Học kỳ";
            // 
            // cbSemester
            // 
            this.cbSemester.AutoCompleteCustomSource.AddRange(new string[] {
            "1",
            "2",
            "3"});
            this.cbSemester.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbSemester.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbSemester.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbSemester.FormattingEnabled = true;
            this.cbSemester.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cbSemester.Location = new System.Drawing.Point(347, 55);
            this.cbSemester.Margin = new System.Windows.Forms.Padding(6);
            this.cbSemester.Name = "cbSemester";
            this.cbSemester.Size = new System.Drawing.Size(66, 28);
            this.cbSemester.TabIndex = 19;
            this.cbSemester.Tag = "";
            this.cbSemester.SelectedIndexChanged += new System.EventHandler(this.cbSemester_SelectedIndexChanged);
            this.cbSemester.SelectionChangeCommitted += new System.EventHandler(this.cbSemester_SelectionChangeCommitted);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(677, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "Năm học";
            // 
            // cbSchoolYear
            // 
            this.cbSchoolYear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbSchoolYear.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbSchoolYear.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbSchoolYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbSchoolYear.FormattingEnabled = true;
            this.cbSchoolYear.Items.AddRange(new object[] {
            "2023-2024",
            "2022-2023",
            "2021-2022",
            "2020-2021"});
            this.cbSchoolYear.Location = new System.Drawing.Point(769, 55);
            this.cbSchoolYear.Margin = new System.Windows.Forms.Padding(6);
            this.cbSchoolYear.Name = "cbSchoolYear";
            this.cbSchoolYear.Size = new System.Drawing.Size(170, 28);
            this.cbSchoolYear.TabIndex = 21;
            this.cbSchoolYear.Tag = "";
            this.cbSchoolYear.SelectedIndexChanged += new System.EventHandler(this.cbSchoolYear_SelectedIndexChanged);
            this.cbSchoolYear.SelectionChangeCommitted += new System.EventHandler(this.cbSchoolYear_SelectionChangeCommitted);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(15, 36);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 25;
            this.label4.Text = "Biểu đồ";
            // 
            // cbChartType
            // 
            this.cbChartType.AutoCompleteCustomSource.AddRange(new string[] {
            "1",
            "2",
            "3"});
            this.cbChartType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbChartType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbChartType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbChartType.FormattingEnabled = true;
            this.cbChartType.Location = new System.Drawing.Point(107, 33);
            this.cbChartType.Margin = new System.Windows.Forms.Padding(6);
            this.cbChartType.Name = "cbChartType";
            this.cbChartType.Size = new System.Drawing.Size(104, 28);
            this.cbChartType.TabIndex = 24;
            this.cbChartType.Tag = "";
            this.cbChartType.SelectionChangeCommitted += new System.EventHandler(this.cbChartType_SelectionChangeCommitted);
            // 
            // btnExportToPdf
            // 
            this.btnExportToPdf.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportToPdf.Location = new System.Drawing.Point(547, 643);
            this.btnExportToPdf.Name = "btnExportToPdf";
            this.btnExportToPdf.Size = new System.Drawing.Size(107, 37);
            this.btnExportToPdf.TabIndex = 26;
            this.btnExportToPdf.Text = "Xuất ra PDF";
            this.btnExportToPdf.UseVisualStyleBackColor = true;
            this.btnExportToPdf.Click += new System.EventHandler(this.btnExportToPdf_Click);
            // 
            // ckboxSemester
            // 
            this.ckboxSemester.AutoSize = true;
            this.ckboxSemester.Checked = true;
            this.ckboxSemester.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckboxSemester.Location = new System.Drawing.Point(422, 62);
            this.ckboxSemester.Name = "ckboxSemester";
            this.ckboxSemester.Size = new System.Drawing.Size(15, 14);
            this.ckboxSemester.TabIndex = 27;
            this.ckboxSemester.UseVisualStyleBackColor = true;
            this.ckboxSemester.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // ckboxYear
            // 
            this.ckboxYear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ckboxYear.AutoSize = true;
            this.ckboxYear.Checked = true;
            this.ckboxYear.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckboxYear.Location = new System.Drawing.Point(948, 64);
            this.ckboxYear.Name = "ckboxYear";
            this.ckboxYear.Size = new System.Drawing.Size(15, 14);
            this.ckboxYear.TabIndex = 28;
            this.ckboxYear.UseVisualStyleBackColor = true;
            this.ckboxYear.CheckedChanged += new System.EventHandler(this.ckboxYear_CheckedChanged);
            // 
            // StatsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.ckboxYear);
            this.Controls.Add(this.ckboxSemester);
            this.Controls.Add(this.btnExportToPdf);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbChartType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbSchoolYear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbSemester);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbSubject);
            this.Controls.Add(this.chartScores);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "StatsForm";
            this.Text = "StatsForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.StatsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartScores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartScores;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbSubject;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbSemester;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbSchoolYear;
        private System.Windows.Forms.ToolTip toolTipPoint;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbChartType;
        private System.Windows.Forms.Button btnExportToPdf;
        private System.Windows.Forms.CheckBox ckboxSemester;
        private System.Windows.Forms.CheckBox ckboxYear;
    }
}