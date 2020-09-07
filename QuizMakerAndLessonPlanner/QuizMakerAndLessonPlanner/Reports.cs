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
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
        }

        private void btnLessons_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            LessonPlannerIndex lessonPlannerIndex = new LessonPlannerIndex();
            lessonPlannerIndex.TopLevel = false;
            panel1.Controls.Add(lessonPlannerIndex);
            lessonPlannerIndex.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            lessonPlannerIndex.Dock = DockStyle.Fill;
            lessonPlannerIndex.Show();
            //this.Hide();
            //LessonPlannerIndex lessonPlannerIndex = new LessonPlannerIndex();
            //lessonPlannerIndex.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.Show();

        }

        private void btnQuizzes_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuizMakerIndex quizMakerIndex = new QuizMakerIndex();
            quizMakerIndex.Show();
        }

        private void btnMovies_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            MoviesIndex moviesIndex = new MoviesIndex();
            moviesIndex.TopLevel = false;
            panel1.Controls.Add(moviesIndex);
            moviesIndex.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            moviesIndex.Dock = DockStyle.Fill;
            moviesIndex.Show();

            //this.Hide();
            //MoviesIndex moviesIndex = new MoviesIndex();
            //moviesIndex.Show();
        }

        private void btnDocumentaries_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            DocumentariesIndex documentaries = new DocumentariesIndex();
            documentaries.TopLevel = false;
            panel1.Controls.Add(documentaries);
            documentaries.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            documentaries.Dock = DockStyle.Fill;
            documentaries.Show();

            //this.Hide();
            //DocumentariesIndex documentaries = new DocumentariesIndex();
            //documentaries.Show();
        }

        private void btnGames_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            GamesIndex gamesIndex = new GamesIndex();
            gamesIndex.TopLevel = false;
            panel1.Controls.Add(gamesIndex);
            gamesIndex.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            gamesIndex.Dock = DockStyle.Fill;
            gamesIndex.Show();

            //this.Hide();
            //GamesIndex gamesIndex = new GamesIndex();
            //gamesIndex.Show();
        }

        private void btnBooks_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            BooksIndex booksIndex = new BooksIndex();
            booksIndex.TopLevel = false;
            panel1.Controls.Add(booksIndex);
            booksIndex.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            booksIndex.Dock = DockStyle.Fill;
            booksIndex.Show();

            //this.Hide();
            //BooksIndex booksIndex = new BooksIndex();
            //booksIndex.Show();
        }
    }
}
