namespace QuestionBank_GUI
{
    partial class TestForm
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
            this.lbTitle = new System.Windows.Forms.Label();
            this.flpForm = new System.Windows.Forms.FlowLayoutPanel();
            this.lbTimer = new System.Windows.Forms.Label();
            this.pbAnswer = new System.Windows.Forms.ProgressBar();
            this.lbProgress = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(424, 9);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(0, 31);
            this.lbTitle.TabIndex = 2;
            this.lbTitle.Visible = false;
            // 
            // flpForm
            // 
            this.flpForm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpForm.AutoScroll = true;
            this.flpForm.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpForm.Location = new System.Drawing.Point(12, 47);
            this.flpForm.Name = "flpForm";
            this.flpForm.Size = new System.Drawing.Size(948, 493);
            this.flpForm.TabIndex = 4;
            this.flpForm.WrapContents = false;
            this.flpForm.Click += new System.EventHandler(this.flpForm_Click);
            this.flpForm.Paint += new System.Windows.Forms.PaintEventHandler(this.flpForm_Paint);
            // 
            // lbTimer
            // 
            this.lbTimer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbTimer.AutoSize = true;
            this.lbTimer.BackColor = System.Drawing.SystemColors.Info;
            this.lbTimer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTimer.Location = new System.Drawing.Point(434, 9);
            this.lbTimer.Name = "lbTimer";
            this.lbTimer.Size = new System.Drawing.Size(129, 35);
            this.lbTimer.TabIndex = 5;
            this.lbTimer.Text = "00:00:00";
            this.lbTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbAnswer
            // 
            this.pbAnswer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbAnswer.Location = new System.Drawing.Point(12, 55);
            this.pbAnswer.Name = "pbAnswer";
            this.pbAnswer.Size = new System.Drawing.Size(948, 31);
            this.pbAnswer.TabIndex = 6;
            this.pbAnswer.Tag = "";
            this.pbAnswer.Visible = false;
            // 
            // lbProgress
            // 
            this.lbProgress.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbProgress.AutoSize = true;
            this.lbProgress.BackColor = System.Drawing.Color.Transparent;
            this.lbProgress.Location = new System.Drawing.Point(456, 60);
            this.lbProgress.Name = "lbProgress";
            this.lbProgress.Size = new System.Drawing.Size(72, 20);
            this.lbProgress.TabIndex = 0;
            this.lbProgress.Text = "Progress";
            this.lbProgress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbProgress.Visible = false;
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.lbProgress);
            this.Controls.Add(this.pbAnswer);
            this.Controls.Add(this.lbTimer);
            this.Controls.Add(this.flpForm);
            this.Controls.Add(this.lbTitle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "TestForm";
            this.Text = "Bài thi môn";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TestForm_Load);
            this.Click += new System.EventHandler(this.TestForm_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.FlowLayoutPanel flpForm;
        private System.Windows.Forms.Label lbTimer;
        private System.Windows.Forms.ProgressBar pbAnswer;
        private System.Windows.Forms.Label lbProgress;
    }
}