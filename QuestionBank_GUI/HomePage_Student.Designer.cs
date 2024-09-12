namespace QuestionBank_GUI
{
    partial class HomePage_Student
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
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageHome = new System.Windows.Forms.TabPage();
            this.tabPageCalendar = new System.Windows.Forms.TabPage();
            this.tabPageScoreView = new System.Windows.Forms.TabPage();
            this.panelUserInfo = new System.Windows.Forms.Panel();
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.labelUserName = new System.Windows.Forms.Label();
            this.tabControlMain.SuspendLayout();
            this.panelUserInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlMain.Controls.Add(this.tabPageHome);
            this.tabControlMain.Controls.Add(this.tabPageCalendar);
            this.tabControlMain.Controls.Add(this.tabPageScoreView);
            this.tabControlMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlMain.Location = new System.Drawing.Point(9, 63);
            this.tabControlMain.Margin = new System.Windows.Forms.Padding(2);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(582, 292);
            this.tabControlMain.TabIndex = 0;
            this.tabControlMain.SelectedIndexChanged += new System.EventHandler(this.tabControlMain_SelectedIndexChanged);
            // 
            // tabPageHome
            // 
            this.tabPageHome.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tabPageHome.Location = new System.Drawing.Point(4, 29);
            this.tabPageHome.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageHome.Name = "tabPageHome";
            this.tabPageHome.Padding = new System.Windows.Forms.Padding(2);
            this.tabPageHome.Size = new System.Drawing.Size(574, 259);
            this.tabPageHome.TabIndex = 0;
            this.tabPageHome.Text = "Trang chủ";
            this.tabPageHome.UseVisualStyleBackColor = true;
            this.tabPageHome.Click += new System.EventHandler(this.tabPageHome_Click);
            // 
            // tabPageCalendar
            // 
            this.tabPageCalendar.Location = new System.Drawing.Point(4, 29);
            this.tabPageCalendar.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageCalendar.Name = "tabPageCalendar";
            this.tabPageCalendar.Padding = new System.Windows.Forms.Padding(2);
            this.tabPageCalendar.Size = new System.Drawing.Size(574, 259);
            this.tabPageCalendar.TabIndex = 3;
            this.tabPageCalendar.Text = "Lịch thi";
            this.tabPageCalendar.UseVisualStyleBackColor = true;
            // 
            // tabPageScoreView
            // 
            this.tabPageScoreView.Location = new System.Drawing.Point(4, 29);
            this.tabPageScoreView.Name = "tabPageScoreView";
            this.tabPageScoreView.Size = new System.Drawing.Size(574, 259);
            this.tabPageScoreView.TabIndex = 4;
            this.tabPageScoreView.Text = "Xem điểm";
            this.tabPageScoreView.UseVisualStyleBackColor = true;
            // 
            // panelUserInfo
            // 
            this.panelUserInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelUserInfo.Controls.Add(this.pictureBoxProfile);
            this.panelUserInfo.Controls.Add(this.labelUserName);
            this.panelUserInfo.Location = new System.Drawing.Point(9, 10);
            this.panelUserInfo.Margin = new System.Windows.Forms.Padding(2);
            this.panelUserInfo.Name = "panelUserInfo";
            this.panelUserInfo.Size = new System.Drawing.Size(582, 49);
            this.panelUserInfo.TabIndex = 1;
            this.panelUserInfo.Visible = false;
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.Location = new System.Drawing.Point(2, 6);
            this.pictureBoxProfile.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(38, 41);
            this.pictureBoxProfile.TabIndex = 0;
            this.pictureBoxProfile.TabStop = false;
            this.pictureBoxProfile.Visible = false;
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserName.Location = new System.Drawing.Point(44, 16);
            this.labelUserName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(75, 20);
            this.labelUserName.TabIndex = 1;
            this.labelUserName.Text = "Xin chào ";
            this.labelUserName.Visible = false;
            // 
            // HomePage_Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.panelUserInfo);
            this.Controls.Add(this.tabControlMain);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "HomePage_Student";
            this.Text = "Trang chủ sinh viên ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HomePage_Student_FormClosing);
            this.Load += new System.EventHandler(this.HomePage_Student_Load);
            this.tabControlMain.ResumeLayout(false);
            this.panelUserInfo.ResumeLayout(false);
            this.panelUserInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageHome;
        private System.Windows.Forms.TabPage tabPageCalendar;
        private System.Windows.Forms.Panel panelUserInfo;
        private System.Windows.Forms.PictureBox pictureBoxProfile;
        private System.Windows.Forms.Label labelUserName;

        #endregion

        private System.Windows.Forms.TabPage tabPageScoreView;
    }
}
