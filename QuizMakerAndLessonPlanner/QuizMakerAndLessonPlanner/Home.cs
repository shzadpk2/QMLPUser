using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizMakerAndLessonPlanner
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btnLessonPlanner_Click(object sender, EventArgs e)
        {
            //panel3.Controls.Clear();
            //panel3.Height = 10;
            //panel3.Hide();
            panel2.Controls.Clear();

            LessonPlanner lessonPlanner = new LessonPlanner();
            lessonPlanner.TopLevel = false;
            panel2.Controls.Add(lessonPlanner);
            lessonPlanner.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            lessonPlanner.Dock = DockStyle.Fill;
            lessonPlanner.Show();

            //if (!panel2.Controls.Contains(LessonPlanner.Instance))
            //{
            //    LessonPlanner.Instance.TopLevel = false;
            //    panel2.Controls.Add(LessonPlanner.Instance);
            //    LessonPlanner.Instance.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            //    LessonPlanner.Instance.Dock = DockStyle.Fill;
            //    LessonPlanner.Instance.Show();
            //}
            //else
            //    LessonPlanner.Instance.BringToFront();


            //Add module1 to panel control
            ////if (!panel2.Controls.Contains(LessonPlanner.Instance))
            ////{
            ////    panel2.Controls.Add(UserControl1.Instance);
            ////    UserControl1.Instance.Dock = DockStyle.Fill;
            ////    UserControl1.Instance.BringToFront();
            ////}
            ////else
            ////    UserControl1.Instance.BringToFront();

            //this.Hide();
            //LessonPlanner lessonPlanner = new LessonPlanner();
            //lessonPlanner.Show();
        }

        private void btnQuizMaker_Click(object sender, EventArgs e)
        {
            //panel3.Controls.Clear();
            //panel3.Height = 10;
            //panel3.Hide();
            panel2.Controls.Clear();

            QuizMaker quizMaker = new QuizMaker();
            quizMaker.TopLevel = false;
            panel2.Controls.Add(quizMaker);
            quizMaker.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            quizMaker.Dock = DockStyle.Fill;
            quizMaker.Show();


            //this.Hide();
            //QuizMaker quizMaker = new QuizMaker();
            //quizMaker.Show();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            //panel3.Show();
            //panel3.Height = 50;
            //panel3.Controls.Clear();
            Reports reports = new Reports();
            reports.TopLevel = false;
            panel2.Controls.Add(reports);
            reports.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            reports.Dock = DockStyle.Fill;
            reports.Show();
            //this.Hide();
            //Reports reports = new Reports();
            //reports.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowAllQuestions showAllQuestions = new ShowAllQuestions();
            showAllQuestions.Show();
        }
    }
}
