using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuestionBank_GUI
{
    public partial class ToastMessageForm : Form
    {
        public ToastMessageForm()
        {
            InitializeComponent();
        }
        public static string title;
        public static string message;
        public static Color borderColor;
        public static int icon;
        private void ToastMessageForm_Load(object sender, EventArgs e)
        {
            lbMessage.Text = message;
            lbTitle.Text = title;
            borderToastMessage.BackColor = borderColor;
            btIcon.ImageIndex = icon;
            this.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width-this.Width-10, Screen.PrimaryScreen.WorkingArea.Height - this.Height-10);
        }
    }
}
