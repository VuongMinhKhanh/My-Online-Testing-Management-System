
namespace QuestionBank_GUI
{
    partial class QuestionBankForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuestionBankForm));
            this.cbSubject = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listQuestion = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnAdjust = new System.Windows.Forms.Button();
            this.addDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtQuestionFilter = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cbSubject
            // 
            resources.ApplyResources(this.cbSubject, "cbSubject");
            this.cbSubject.FormattingEnabled = true;
            this.cbSubject.Name = "cbSubject";
            this.cbSubject.Tag = "";
            this.cbSubject.SelectedIndexChanged += new System.EventHandler(this.cbSubject_SelectedIndexChanged);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // listQuestion
            // 
            resources.ApplyResources(this.listQuestion, "listQuestion");
            this.listQuestion.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listQuestion.HideSelection = false;
            this.listQuestion.Name = "listQuestion";
            this.listQuestion.UseCompatibleStateImageBehavior = false;
            this.listQuestion.View = System.Windows.Forms.View.Details;
            this.listQuestion.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged_1);
            this.listQuestion.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listQuestion_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            resources.ApplyResources(this.columnHeader1, "columnHeader1");
            // 
            // columnHeader2
            // 
            resources.ApplyResources(this.columnHeader2, "columnHeader2");
            // 
            // btnAdd
            // 
            resources.ApplyResources(this.btnAdd, "btnAdd");
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnAdjust
            // 
            resources.ApplyResources(this.btnAdjust, "btnAdjust");
            this.btnAdjust.Name = "btnAdjust";
            this.btnAdjust.UseVisualStyleBackColor = true;
            this.btnAdjust.Click += new System.EventHandler(this.btnAdjust_Click);
            // 
            // addDelete
            // 
            resources.ApplyResources(this.addDelete, "addDelete");
            this.addDelete.Name = "addDelete";
            this.addDelete.UseVisualStyleBackColor = true;
            this.addDelete.Click += new System.EventHandler(this.addDelete_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // txtQuestionFilter
            // 
            resources.ApplyResources(this.txtQuestionFilter, "txtQuestionFilter");
            this.txtQuestionFilter.Name = "txtQuestionFilter";
            this.txtQuestionFilter.TextChanged += new System.EventHandler(this.txtQuestionFilter_TextChanged);
            // 
            // QuestionBankForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtQuestionFilter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addDelete);
            this.Controls.Add(this.btnAdjust);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.listQuestion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbSubject);
            this.Name = "QuestionBankForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbSubject;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView listQuestion;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnAdjust;
        private System.Windows.Forms.Button addDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtQuestionFilter;
    }
}

