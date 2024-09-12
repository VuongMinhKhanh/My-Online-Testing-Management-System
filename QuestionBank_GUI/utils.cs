using iTextSharp.text.pdf;
using iTextSharp.text;
using QuestionBank_DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms.VisualStyles;
//using iTextSharp.text;
//using iTextSharp.text.pdf;

namespace QuestionBank_GUI
{
    public static class Utils
    {
        private static Random rng = new Random();
        public static void LoadSubjects(ComboBox comboBox, DataRow[] dr, string columnName)
        {
            foreach (DataRow dr2 in dr)
            {
                comboBox.Items.Add(dr2[columnName].ToString());
            }
        }

        public static void LoadQuestions(ListView listView, DataRow[] dr, string idColumn, string questionColumn, string answerColumn)
        {
            listView.Items.Clear();

            foreach (DataRow dr2 in dr)
            {
                ListViewItem item = new ListViewItem(new string[] { dr2[questionColumn].ToString(), dr2[answerColumn].ToString() });
                item.Font = new System.Drawing.Font("arial", 12, FontStyle.Regular);
                item.Tag = dr2[idColumn].ToString();
                listView.Items.Add(item);
            }
        }

        public static void LoadQuestions(ListView listView, DataRow[] dr, string idColumn, string questionColumn, string answerColumn, string keyword)
        {
            listView.Items.Clear();

            foreach (DataRow dr2 in dr)
            {
                if (dr2[questionColumn].ToString().StartsWith(keyword))
                {
                    ListViewItem item = new ListViewItem(new string[] { dr2[questionColumn].ToString(), dr2[answerColumn].ToString() });
                    item.Font = new System.Drawing.Font("arial", 12, FontStyle.Regular);
                    item.Tag = dr2[idColumn].ToString();
                    listView.Items.Add(item);
                }
            }
        }

        public static Question_DTO GetQuestion(DataRow[] drQuestion, DataRow[] drAnswers, string idSubject)
        {
            List<string> answers = new List<string>();
            List<int> idAnswers = new List<int>();
            int index = 1;
            int correctAnswer = 0;
            foreach (DataRow dr in drAnswers)
            {
                answers.Add(dr["cau_tra_loi"].ToString());
                idAnswers.Add(int.Parse(dr["id_ChiTietCauHoi"].ToString()));

                if (dr["cau_tra_loi"].ToString() == drQuestion[0]["cau_tra_loi"].ToString())
                {
                    correctAnswer = index;
                }

                index++;
            }

            Question_DTO question = new Question_DTO(
                int.Parse(drQuestion[0]["id_CauHoi"].ToString()),
                drQuestion[0]["cau_hoi"].ToString(),
                idAnswers,
                answers,
                int.Parse(drQuestion[0]["id_DapAn"].ToString()),
                correctAnswer,
                true,
                idSubject
                );

            return question;
        }

        public static bool IsValidQuestion(
            TextBox txtQuestion,
            TextBox txt1, RadioButton rd1,
            TextBox txt2, RadioButton rd2,
            TextBox txt3, RadioButton rd3,
            TextBox txt4, RadioButton rd4
            )
        {
            if (txtQuestion.Text == "")
            {
                MessageBox.Show("Question missing");
                return false;
            }    

            int countTxt = 0;
            if (txt1.Text != "")
                countTxt++;
            if (txt2.Text != "")
                countTxt++;
            if (txt3.Text != "")
                countTxt++;
            if (txt4.Text != "")
                countTxt++;
            if (countTxt < 2)
            {
                MessageBox.Show("Answers must be more than 2");
                return false;
            }
            else
            {
                if (txt1.Text == "" && rd1.Checked ||
                    txt2.Text == "" && rd2.Checked ||
                    txt3.Text == "" && rd3.Checked ||
                    txt4.Text == "" && rd4.Checked)
                {
                    MessageBox.Show("Correct answers mustn't be ticked in a null answer");
                    return false;
                }
            }

            return true;
        }

        public static void AddGroupBoxQuestionsToControl
            (Control containerControl,
            DataRow[] drQuestions,
            List<GroupBox> containerGroupBox)
        {
            try
            {
                int questionNo = 1;
                int answerIndex = 0;

                GroupBox groupBox = new GroupBox()
                {
                    Width = containerControl.Width,
                    Name = "gb0",
                    Text = $"Câu {questionNo}: " + drQuestions[0]["cau_hoi"].ToString(),
                    Tag = drQuestions[0]["id_CauHoi"].ToString(),
                    //Font = new Font("Arial", 12, FontStyle.Bold),
                };
                containerControl.Controls.Add(groupBox);
                FlowLayoutPanel flpInner = new FlowLayoutPanel()
                {
                    AutoSize = true,
                    FlowDirection = FlowDirection.TopDown,
                    Width = containerControl.Width,
                    Dock = DockStyle.Fill,
                };
                groupBox.Controls.Add(flpInner);
                groupBox.Height = flpInner.Height * 2;
                containerGroupBox.Add(groupBox);

                string[] answer = { "A", "B", "C", "D" };
                int id = int.Parse(drQuestions[0]["id_CauHoi"].ToString());
                int startY = 20;
                List<RadioButton> rdList = new List<RadioButton>();

                foreach (DataRow dr in drQuestions)
                {
                    //MessageBox.Show(id.ToString() + " " + dr["id_CauHoi"].ToString());
                    if (int.Parse(dr["id_CauHoi"].ToString()) != id)
                    {
                        questionNo++;
                        answerIndex = 0;

                        Shuffle(rdList);
                        foreach (RadioButton radio in rdList)
                            flpInner.Controls.Add(radio);

                        rdList = new List<RadioButton>();

                        groupBox = new GroupBox()
                        {
                            Width = containerControl.Width,
                            Name = "rd" + questionNo.ToString(),
                            Text = $"Câu {questionNo}: " + dr["cau_hoi"].ToString(),
                            Tag = dr["id_CauHoi"].ToString(),
                        };

                        containerControl.Controls.Add(groupBox);
                        containerGroupBox.Add(groupBox);

                        flpInner = new FlowLayoutPanel()
                        {
                            AutoSize = true,
                            FlowDirection = FlowDirection.TopDown,
                            Width = containerControl.Width,
                            Dock = DockStyle.Fill,
                        };
                        groupBox.Controls.Add(flpInner);
                        groupBox.Height = flpInner.Height * 2;

                        startY = 20;

                        id = int.Parse(dr["id_CauHoi"].ToString());
                    }

                    RadioButton rd = new RadioButton()
                    {
                        Text = $"{answer[answerIndex]}. {dr["cau_tra_loi"]}",
                        AutoSize = true,
                        Location = new Point(6, startY),
                        Width = containerControl.Width,
                        Tag = int.Parse(dr["id_ChiTietCauHoi"].ToString()),
                    };
                    //rd.CheckedChanged += Rd_CheckedChanged;
                    rdList.Add(rd);
                    //flpInner.Controls.Add(rd);
                    answerIndex++;
                    startY += 30;
                }

                if (rdList.Count != 0)
                {
                    Shuffle(rdList);
                    foreach (RadioButton rd in rdList)
                        flpInner.Controls.Add(rd);
                }
            }
            catch
            {
                MessageBox.Show("Lỗi nạp đề thi do chưa có câu hỏi");
            }
        }

        private static void Rd_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        public static void Shuffle<T>(this IList<T> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }

        public static Dictionary<string, int> getListOfCorrectAnswers(DataRow[] drQuestions )
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();

            foreach (DataRow dr in drQuestions)
            {
                if (dr["id_DapAn"].ToString() != "")
                    dict.Add(dr["id_CauHoi"].ToString(), int.Parse(dr["id_ChiTietCauHoi"].ToString()));
            }

            return dict;
        }

        public static bool CheckFormCompleted(List<GroupBox> gbList)
        {
            foreach (GroupBox gb in gbList)
            {
                if (gb.Controls[0].Controls.OfType<RadioButton>()
                .FirstOrDefault(rb => rb.Checked) is null)
                {
                    if (MessageBox.Show("The form is incomplete. Would you like to proceed anyway?",
                        "Incomplete Form Warning",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning,
                        MessageBoxDefaultButton.Button2) == DialogResult.No)
                        return false;
                }
            }

            if (MessageBox.Show("Are you ready to submit your form?",
                        "Confirm Submission",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button2) == DialogResult.No)
                return false;

            return true;
        }

        public static int CalculateScore(List<GroupBox> gbList, Dictionary<string, int> answerDict)
        {
            int score = 0;

            foreach (GroupBox gb in gbList)
            {
                RadioButton rdObj = gb.Controls[0].Controls.OfType<RadioButton>()
                .FirstOrDefault(rb => rb.Checked);
                int userAnswerId = 0;
                if (!(rdObj is null))
                    userAnswerId = int.Parse(rdObj.Tag.ToString());

                if (answerDict[gb.Tag.ToString()] == userAnswerId)
                    score++;
            }

            return score;
        }
        public static Score_DTO GetScore(string idStudent, string idSubject, double score, int idClass_Subject)
        {
            Score_DTO score_dto = new Score_DTO(idStudent, idSubject, score, idClass_Subject);

            return score_dto;
        }
        public static void UpdateProgressBarValue(ProgressBar bar, int count)
        {

        }
        public static int CountCompletedAnsers(List<GroupBox> gbList)
        {
            int count = 0;

            foreach (GroupBox gb in gbList)
                if (gb.Controls[0].Controls.OfType<RadioButton>()
                .FirstOrDefault(rb => rb.Checked) != null)
                    count++;

            return count;
        }
        public static void LoadScores(Chart chart, DataRow[] drScores)
        {
            chart.ChartAreas.Clear();
            chart.Series.Clear();
            ChartArea chartArea = new ChartArea();
            chart.ChartAreas.Add(chartArea);

            chartArea.AxisX.Title = "Test score";
            chartArea.AxisY.Title = "Number of Students";
            chartArea.AxisX.MajorGrid.LineColor = Color.LightGray;
            chartArea.AxisY.MajorGrid.LineColor = Color.LightGray;

            // Caps X always max at 10
            chartArea.AxisX.Maximum = 10;

            double minX = 0;

            // Check if there are any rows in the DataTable
            if (drScores.Length > 0)
            {
                minX = drScores.AsEnumerable()
                .Min(row => double.Parse(row["diem"].ToString())); // finds the min value in datarows
                minX = Math.Floor(minX);
            }

            chartArea.AxisX.Minimum = minX; // sets min value from the data set
            chartArea.AxisX.Maximum = 10;
            // Makes sure to show the highest value on X axis
            chartArea.AxisX.Interval = 1;

            // Caps Y always be int values
            chartArea.AxisY.Interval = 1;

            // Add and configure series
            Series series = new Series
            {
                Name = "Score Series",
                ChartType = SeriesChartType.Line,
                BorderWidth = 3,
                Color = Color.Blue, // Line color
                BackGradientStyle = GradientStyle.TopBottom,
                BackSecondaryColor = Color.LightBlue, // Choose a secondary color for the gradient
            };

            // Enable markers
            series.MarkerStyle = MarkerStyle.Diamond;
            series.MarkerSize = 10;
            series.MarkerColor = Color.Blue;

            chart.Series.Add(series);

            // Add data points here
            if (drScores.Length > 0)
                foreach (DataRow dr in drScores)
                    series.Points.AddXY(double.Parse(dr["diem"].ToString()), int.Parse(dr["Qty"].ToString()));

            chart.Invalidate();

        }
        public static int extractSchoolYear(string schoolYear)
        {
            return int.Parse(schoolYear.Split('-')[1]);
        }

        private static MemoryStream ChartToImage(Chart chart)
        {
            MemoryStream ms = new MemoryStream();
            chart.SaveImage(ms, ChartImageFormat.Png);
            ms.Seek(0, SeekOrigin.Begin);

            return ms;
        }

        public static void ExportChartToPdf(Chart chart, string filePath,
            string subjectName, int semester, string schoolYear)
        {
            // Convert chart to an image
            MemoryStream chartImageStream = ChartToImage(chart);

            // Create a PDF document
            Document document = new Document(PageSize.A4, 50, 50, 50, 50);
            PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(filePath, FileMode.Create));
            document.Open();

            // Add title
            //string fontPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "DejaVuSans.ttf");
            string fontPath = Application.StartupPath + "\\fonts\\DejaVuSans.ttf";
            BaseFont bfSansUni = BaseFont.CreateFont(fontPath, BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
            iTextSharp.text.Font titleFont = new iTextSharp.text.Font(bfSansUni, 18, iTextSharp.text.Font.BOLD);

            string title = $"Score Report for subject {subjectName} in semester {semester} in {schoolYear}";
            //iTextSharp.text.Font titleFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 18);
            Paragraph titleParagraph = new Paragraph(title, titleFont)
            {
                Alignment = Element.ALIGN_CENTER,
                SpacingAfter = 20
            };
            document.Add(titleParagraph);

            // Add summary
            string summary = "Dear Falcuty Board,\n...";
            iTextSharp.text.Font textFont = FontFactory.GetFont(FontFactory.HELVETICA, 12);
            Paragraph summaryParagraph = new Paragraph(summary, textFont)
            {
                SpacingAfter = 20
            };
            document.Add(summaryParagraph);

            // Add the chart image
            iTextSharp.text.Image chartImage = iTextSharp.text.Image.GetInstance(chartImageStream.ToArray());
            chartImage.Alignment = iTextSharp.text.Image.ALIGN_CENTER;
            chartImage.ScaleToFit(document.PageSize.Width - 100, document.PageSize.Height - 300); // Adjusted to leave space for signature
            document.Add(chartImage);

            // Signature area
            iTextSharp.text.Font signatureFont = FontFactory.GetFont(FontFactory.HELVETICA, 12);
            Paragraph signatureParagraph = new Paragraph("Signature:\n\n\n", signatureFont);
            signatureParagraph.SpacingBefore = 25;
            signatureParagraph.IndentationLeft = 50;
            document.Add(signatureParagraph);

            // Footer
            iTextSharp.text.Font footerFont = FontFactory.GetFont(FontFactory.HELVETICA, 10);
            Paragraph footerParagraph = new Paragraph("Report generated on: " + DateTime.Now.ToString("yyyy-MM-dd"), footerFont)
            {
                Alignment = Element.ALIGN_CENTER,
                SpacingBefore = 25
            };
            document.Add(footerParagraph);

            // Close document
            document.Close();
        }
        public static void AddFormToTab(TabPage tabPage, Form form)
        {
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None; // Remove the border and title bar
            form.Dock = DockStyle.Fill;

            tabPage.Controls.Add(form); // Add the form to the tab page's controls
            form.Show();
        }
        private static void AddFormToPanel(Panel panel, Form form)
        {
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None; // Remove the border and title bar
            form.Dock = DockStyle.Fill;

            panel.Controls.Add(form); // Add the form to the tab page's controls
            form.Show();
        }
        public static void AddUserHomeToTab(TabPage tabPage, Form userForm)
        {
            AddFormToTab(tabPage, userForm);
        }

        public static void AddCalendarToTab(TabPage tabPage, string userId)
        {
            StudentScheduleForm studentScheduleForm = new StudentScheduleForm(userId);
            AddFormToTab(tabPage, studentScheduleForm);
        }
        public static void AddScoreToTab(TabPage tabPage, string userId)
        {
            StudentScoreForm studentScoreForm = new StudentScoreForm(userId);
            AddFormToTab(tabPage, studentScoreForm);
        }
        public static void AddQuestionBankToTab(TabPage tabPage, string userId)
        {
            QuestionBankForm questionBankForm = new QuestionBankForm(userId);
            AddFormToTab(tabPage, questionBankForm);
        }
        public static void AddStudentScoreToPanel(SplitContainer split)
        {
            StudentScoreResult studentScoreResult = new StudentScoreResult(split.Panel2);
            AddFormToPanel(split.Panel1, studentScoreResult);
        }
        public static void AddStudentInfoToPanel(Panel panel, Manage_Users_DTO student)
        {
            UserInfoForm studentInfoForm = new UserInfoForm(student);
            AddFormToPanel(panel, studentInfoForm);
        }
        public static void AddScheduleFormToPanel(TabPage tabPage)
        {
            ScheduleForm scheduleForm = new ScheduleForm();
            AddFormToTab(tabPage, scheduleForm);
        }
        public static void AddStatsFormToPanel(TabPage tabPage)
        {
            StatsForm statsForm = new StatsForm();
            AddFormToTab(tabPage, statsForm);
        }
    }
}
