using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using QuestionBank_BUS;
using QuestionBank_DTO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuestionBank_GUI
{
    public partial class StatsForm : Form
    {
        private Subject_BUS subject_bus = new Subject_BUS();
        private Score_BUS score_bus = new Score_BUS();
        private DataRow[] drSubjects, drScores;
        private string subjectId = "ITEC3406";
        private int semester = 2;
        private int year = 2023;
        public StatsForm()
        {
            InitializeComponent();
        }

        private void StatsForm_Load(object sender, EventArgs e)
        {
            drSubjects = subject_bus.getId_Subjects().Select();
            Utils.LoadSubjects(cbSubject, drSubjects, "ten_mon_hoc");

            cbSubject_SelectedIndexChanged(sender, e);
            cbSubject.SelectedIndex = 0;
            cbSubject.Tag = drSubjects[0]["id_MonHoc"];
            cbSubject.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbSubject.AutoCompleteSource = AutoCompleteSource.ListItems;

            cbSubject.SelectedIndex = 0;
            cbSemester.SelectedIndex = 1;
            cbSchoolYear.SelectedIndex = 0;

            subjectId = cbSubject.Tag.ToString().Trim(' ');
            semester = int.Parse(cbSemester.SelectedItem.ToString());
            year = Utils.extractSchoolYear(cbSchoolYear.SelectedItem.ToString());
            
            ReloadStats();
            // Customize the chart title
            chartScores.Titles.Add("Test Scores of Students on Course");
            chartScores.Titles[0].Alignment = ContentAlignment.TopCenter;

            // Load chart types
            foreach (var chartType in Enum.GetValues(typeof(SeriesChartType)))
                cbChartType.Items.Add(chartType);

            cbChartType.SelectedIndex = 3;

        }

        private void ReloadStats()
        {
            drScores = score_bus.getScores(subjectId, semester, year).Select();
            // Set up chart area and series
            Utils.LoadScores(chartScores, drScores);
        }

        private void cbSemester_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cbSchoolYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cbSubject_SelectionChangeCommitted(object sender, EventArgs e)
        {
            

            if (cbSubject.SelectedIndex != -1)
                cbSubject.Tag = drSubjects[cbSubject.SelectedIndex]["id_MonHoc"];
                subjectId = cbSubject.Tag.ToString().Trim(' ');

            if (subjectId == cbSubject.Tag.ToString())
                return;
            //MessageBox.Show(subjectId + semester.ToString() + year.ToString());
            ReloadStats();
        }

        private void cbSemester_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (semester == int.Parse(cbSemester.SelectedItem.ToString()))
                return;

            semester = int.Parse(cbSemester.SelectedItem.ToString());

            ReloadStats();
        }

        private void cbSchoolYear_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (year == Utils.extractSchoolYear(cbSchoolYear.SelectedItem.ToString()))
                return;

            year = Utils.extractSchoolYear(cbSchoolYear.SelectedItem.ToString());

            ReloadStats();
        }

        private void chartScores_MouseMove(object sender, MouseEventArgs e)
        {
            // Call HitTest
            HitTestResult result = chartScores.HitTest(e.X, e.Y);

            // Reset the tooltip and hide it
            toolTipPoint.RemoveAll();

            // If the mouse is over a data point
            if (result.ChartElementType == ChartElementType.DataPoint)
            {
                // Retrieve the data point
                DataPoint dataPoint = chartScores.Series[0].Points[result.PointIndex];

                // Set the tooltip text
                string tooltip = string.Format("Score: {0}, Quantity: {1}", dataPoint.XValue, dataPoint.YValues[0]);

                // Show tooltip with data point values
                toolTipPoint.Show(tooltip, chartScores, e.X, e.Y - 15);
            }
        }

        private void cbChartType_SelectionChangeCommitted(object sender, EventArgs e)
        {
            chartScores.Series[0].ChartType = (SeriesChartType)Enum.Parse(typeof(SeriesChartType), cbChartType.SelectedItem.ToString());
        }

        private void btnExportToPdf_Click(object sender, EventArgs e)
        {
            if (chartScores.Series[0].Points.Count == 0)
            {
                MessageBox.Show("Chart Missing Data");
                return;
            }    

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF Files|*.pdf";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Utils.ExportChartToPdf(chartScores, saveFileDialog.FileName,
                    cbSubject.SelectedItem.ToString(), semester, cbSchoolYear.SelectedItem.ToString());
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (ckboxSemester.Checked)
                semester = int.Parse(cbSemester.SelectedItem.ToString());
            else
                semester = 0;

            cbSemester.Enabled = !cbSemester.Enabled;
            ReloadStats();
        }

        private void ckboxYear_CheckedChanged(object sender, EventArgs e)
        {
            if (ckboxYear.Checked)
                year = Utils.extractSchoolYear(cbSchoolYear.SelectedItem.ToString());
            else
                year = 0;

            cbSchoolYear.Enabled = !cbSchoolYear.Enabled;
            ReloadStats();
        }

        private void cbSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSubject.SelectedIndex != -1)
            {
                cbSubject.Tag = drSubjects[cbSubject.SelectedIndex]["id_MonHoc"];
                subjectId = cbSubject.Tag.ToString();
            }
        }
    }
}
