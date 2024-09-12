using System;
using System.Data;
using System.Windows.Forms;

namespace QuestionBank_GUI
{
    partial class HomePage_Teacher
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageHome = new System.Windows.Forms.TabPage();
            this.tabPageExams = new System.Windows.Forms.TabPage();
            this.listViewExams = new System.Windows.Forms.ListView();
            this.tabPageScoreView = new System.Windows.Forms.TabPage();
            this.panelUserInfo = new System.Windows.Forms.Panel();
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.labelUserName = new System.Windows.Forms.Label();
            this.tabPageClass = new System.Windows.Forms.TabPage();
            this.tabControlMain.SuspendLayout();
            this.tabPageExams.SuspendLayout();
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
            this.tabControlMain.Controls.Add(this.tabPageExams);
            this.tabControlMain.Controls.Add(this.tabPageClass);
            this.tabControlMain.Controls.Add(this.tabPageScoreView);
            this.tabControlMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlMain.Location = new System.Drawing.Point(9, 63);
            this.tabControlMain.Margin = new System.Windows.Forms.Padding(2);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(582, 292);
            this.tabControlMain.TabIndex = 0;
            this.tabControlMain.SelectedIndexChanged += new System.EventHandler(this.tabControlMain_SelectedIndexChanged);
            this.tabControlMain.TabIndexChanged += new System.EventHandler(this.tabControlMain_TabIndexChanged);
            // 
            // tabPageHome
            // 
            this.tabPageHome.Location = new System.Drawing.Point(4, 29);
            this.tabPageHome.Name = "tabPageHome";
            this.tabPageHome.Size = new System.Drawing.Size(574, 259);
            this.tabPageHome.TabIndex = 4;
            this.tabPageHome.Text = "Trang chủ";
            this.tabPageHome.UseVisualStyleBackColor = true;
            // 
            // tabPageExams
            // 
            this.tabPageExams.Controls.Add(this.listViewExams);
            this.tabPageExams.Location = new System.Drawing.Point(4, 29);
            this.tabPageExams.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageExams.Name = "tabPageExams";
            this.tabPageExams.Padding = new System.Windows.Forms.Padding(2);
            this.tabPageExams.Size = new System.Drawing.Size(574, 259);
            this.tabPageExams.TabIndex = 1;
            this.tabPageExams.Text = "Quản lý đề thi";
            this.tabPageExams.UseVisualStyleBackColor = true;
            // 
            // listViewExams
            // 
            this.listViewExams.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewExams.HideSelection = false;
            this.listViewExams.Location = new System.Drawing.Point(2, 2);
            this.listViewExams.Margin = new System.Windows.Forms.Padding(2);
            this.listViewExams.Name = "listViewExams";
            this.listViewExams.Size = new System.Drawing.Size(570, 255);
            this.listViewExams.TabIndex = 0;
            this.listViewExams.UseCompatibleStateImageBehavior = false;
            this.listViewExams.Enter += new System.EventHandler(this.tabPageExams_Enter);
            // 
            // tabPageScoreView
            // 
            this.tabPageScoreView.Location = new System.Drawing.Point(4, 29);
            this.tabPageScoreView.Name = "tabPageScoreView";
            this.tabPageScoreView.Size = new System.Drawing.Size(574, 259);
            this.tabPageScoreView.TabIndex = 3;
            this.tabPageScoreView.Text = "Xem điểm";
            this.tabPageScoreView.UseVisualStyleBackColor = true;
            // 
            // panelUserInfo
            // 
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
            this.pictureBoxProfile.Location = new System.Drawing.Point(2, 2);
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
            this.labelUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelUserName.Location = new System.Drawing.Point(44, 16);
            this.labelUserName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(119, 20);
            this.labelUserName.TabIndex = 1;
            this.labelUserName.Text = "Tên người dùng";
            this.labelUserName.Visible = false;
            // 
            // tabPageClass
            // 
            this.tabPageClass.Location = new System.Drawing.Point(4, 29);
            this.tabPageClass.Name = "tabPageClass";
            this.tabPageClass.Size = new System.Drawing.Size(574, 259);
            this.tabPageClass.TabIndex = 5;
            this.tabPageClass.Text = "Xem lớp";
            this.tabPageClass.UseVisualStyleBackColor = true;
            // 
            // HomePage_Teacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.panelUserInfo);
            this.Controls.Add(this.tabControlMain);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "HomePage_Teacher";
            this.Text = "Trang chủ giảng viên ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HomePage_Teacher_FormClosing);
            this.Load += new System.EventHandler(this.HomePage_Teacher_Load);
            this.tabControlMain.ResumeLayout(false);
            this.tabPageExams.ResumeLayout(false);
            this.panelUserInfo.ResumeLayout(false);
            this.panelUserInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageExams;
        private System.Windows.Forms.ListView listViewExams;
        private System.Windows.Forms.Panel panelUserInfo;
        private System.Windows.Forms.PictureBox pictureBoxProfile;
        private System.Windows.Forms.Label labelUserName;
        private TabPage tabPageScoreView;
        private TabPage tabPageHome;
        private TabPage tabPageClass;
    }
}
