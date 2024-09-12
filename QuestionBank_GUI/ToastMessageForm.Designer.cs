namespace QuestionBank_GUI
{
    partial class ToastMessageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToastMessageForm));
            this.borderToastMessage = new System.Windows.Forms.Panel();
            this.lbTitle = new System.Windows.Forms.Label();
            this.lbMessage = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btIcon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // borderToastMessage
            // 
            this.borderToastMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.borderToastMessage.Location = new System.Drawing.Point(-73, -7);
            this.borderToastMessage.Name = "borderToastMessage";
            this.borderToastMessage.Size = new System.Drawing.Size(81, 100);
            this.borderToastMessage.TabIndex = 0;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(64, 12);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(65, 24);
            this.lbTitle.TabIndex = 2;
            this.lbTitle.Text = "label1";
            // 
            // lbMessage
            // 
            this.lbMessage.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMessage.Location = new System.Drawing.Point(65, 36);
            this.lbMessage.Name = "lbMessage";
            this.lbMessage.Size = new System.Drawing.Size(337, 41);
            this.lbMessage.TabIndex = 3;
            this.lbMessage.Text = "Thông báo";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "cancel.png");
            this.imageList1.Images.SetKeyName(1, "complete.png");
            // 
            // btIcon
            // 
            this.btIcon.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btIcon.ImageIndex = 1;
            this.btIcon.ImageList = this.imageList1;
            this.btIcon.Location = new System.Drawing.Point(14, 12);
            this.btIcon.Name = "btIcon";
            this.btIcon.Size = new System.Drawing.Size(45, 40);
            this.btIcon.TabIndex = 4;
            this.btIcon.UseVisualStyleBackColor = false;
            // 
            // ToastMessageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 86);
            this.Controls.Add(this.btIcon);
            this.Controls.Add(this.lbMessage);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.borderToastMessage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ToastMessageForm";
            this.Text = "ToastMessageForm";
            this.Load += new System.EventHandler(this.ToastMessageForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel borderToastMessage;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbMessage;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btIcon;
    }
}