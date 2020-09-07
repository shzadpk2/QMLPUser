using QMLPModels;
using QMLPRepository;
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
    public partial class MoviesIndex : Form
    {
        public MoviesIndex()
        {
            InitializeComponent();
        }

        private void MoviesIndex_Load(object sender, EventArgs e)
        {
            BindGridViewMovies();

            //DataGridViewLinkColumn Editlink = new DataGridViewLinkColumn();
            //Editlink.UseColumnTextForLinkValue = true;
            //Editlink.HeaderText = "Edit";
            //Editlink.Name = "Edit";
            //Editlink.DataPropertyName = "lnkColumn";
            //Editlink.LinkBehavior = LinkBehavior.SystemDefault;
            //Editlink.Text = "Edit";
            //dataGridViewQuizMaker.Columns.Add(Editlink);

            //DataGridViewLinkColumn Deletelink = new DataGridViewLinkColumn();
            //Deletelink.UseColumnTextForLinkValue = true;
            //Deletelink.HeaderText = "Delete";
            //Deletelink.Name = "Delete";
            //Deletelink.DataPropertyName = "lnkColumn";
            //Deletelink.LinkBehavior = LinkBehavior.SystemDefault;
            //Deletelink.Text = "Delete";
            //dataGridViewMovies.Columns.Add(Deletelink);
        }
        private void BindGridViewMovies()
        {
            LessonPlannerRepository lessonPlannerRepository = new LessonPlannerRepository();
            List<MoviesModel> moviesModels = new List<MoviesModel>();

            DataTable dataTable = new DataTable();

            try
            {
                dataTable = lessonPlannerRepository.GetAllMovies();

                moviesModels = TranslateDataTableToMoviesModel(dataTable);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Network error...Please try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {

                dataTable.Clear();
                dataTable = null;
                dataGridViewMovies.DataSource = moviesModels;
            }
        }

        private List<MoviesModel> TranslateDataTableToMoviesModel(DataTable dataTable)
        {
            List<MoviesModel> moviesModels = new List<MoviesModel>();


            foreach (DataRow row in dataTable.Rows)
            {
                MoviesModel movies = new MoviesModel();
                movies.MovieID = row["MovieID"] != DBNull.Value ? Convert.ToInt64(row["MovieID"].ToString()) : 0;
                movies.MainTopicID = row["MainTopicID"] != DBNull.Value ? Convert.ToInt64(row["MainTopicID"].ToString()) : 0;
                movies.MainTopicNumber = row["MainTopicNumber"] != DBNull.Value ? Convert.ToString(row["MainTopicNumber"]) : string.Empty;
                movies.MovieDescription = row["MovieDescription"] != DBNull.Value ? Convert.ToString(row["MovieDescription"].ToString()) : string.Empty;

                moviesModels.Add(movies);
            }

            return moviesModels;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Reports reports = new Reports();
            reports.Show();
        }

        private void dataGridViewMovies_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //Width
            this.dataGridViewMovies.Columns["MovieDescription"].Width = 400;
            this.dataGridViewMovies.Columns["MainTopicNumber"].Width = 150;

            //Visibility
            //this.dataGridViewMovies.Columns["MovieID"].Visible = false;
            this.dataGridViewMovies.Columns["MainTopicID"].Visible = false;            
            this.dataGridViewMovies.Columns["CreatedOn"].Visible = false;
            this.dataGridViewMovies.Columns["CreatedBy"].Visible = false;
            this.dataGridViewMovies.Columns["ModifiedOn"].Visible = false;
            this.dataGridViewMovies.Columns["ModifiedBy"].Visible = false;
        }

        private void dataGridViewMovies_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.ColumnIndex == dataGridViewMovies.Columns["Delete"].Index)
            //{
            //    int rowCount = 0;
            //    long gameID = Convert.ToInt64(dataGridViewMovies.Rows[e.RowIndex].Cells["MovieID"].Value);

            //    LessonPlannerRepository lessonPlannerRepository = new LessonPlannerRepository();
            //    rowCount = lessonPlannerRepository.DeleteMovieByID(gameID);

            //    if (rowCount > 0)
            //    {
            //        ShowStatus(true, "DELETE");
            //        BindGridViewMovies();
            //    }
            //}
        }

        public void ShowStatus(bool result, string Action)
        {
            if (result)
            {
                if (Action.ToUpper() == "ADD")
                {
                    MessageBox.Show("Saved Successfully!..", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (Action.ToUpper() == "UPDATE")
                {
                    MessageBox.Show("Updated Successfully!..", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Deleted Successfully!..", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Something went wrong!. Please try again!..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
