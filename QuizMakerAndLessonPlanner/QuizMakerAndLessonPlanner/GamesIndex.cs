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
    public partial class GamesIndex : Form
    {
        public GamesIndex()
        {
            InitializeComponent();
        }

        private void dataGridViewGames_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //Width
            this.dataGridViewGames.Columns["GameDescription"].Width = 400;
            this.dataGridViewGames.Columns["MainTopicNumber"].Width = 150;

            //Visibility
            //this.dataGridViewMovies.Columns["MovieID"].Visible = false;
            this.dataGridViewGames.Columns["MainTopicID"].Visible = false;
            this.dataGridViewGames.Columns["CreatedOn"].Visible = false;
            this.dataGridViewGames.Columns["CreatedBy"].Visible = false;
            this.dataGridViewGames.Columns["ModifiedOn"].Visible = false;
            this.dataGridViewGames.Columns["ModifiedBy"].Visible = false;
        }

        private void BindGridViewGames()
        {
            LessonPlannerRepository lessonPlannerRepository = new LessonPlannerRepository();
            List<GamesModel> gamesModels = new List<GamesModel>();
            DataTable dataTable = new DataTable();

            try
            {
                dataTable = lessonPlannerRepository.GetAllGames();

                gamesModels = TranslateDataTableToGamesModel(dataTable);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Network error...Please try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {

                dataTable.Clear();
                dataTable = null;
                dataGridViewGames.DataSource = gamesModels;
            }
        }

        private List<GamesModel> TranslateDataTableToGamesModel(DataTable dataTable)
        {
            List<GamesModel> gamesModels = new List<GamesModel>();


            foreach (DataRow row in dataTable.Rows)
            {
                GamesModel gamesModel = new GamesModel();
                gamesModel.GameID = row["GameID"] != DBNull.Value ? Convert.ToInt64(row["GameID"].ToString()) : 0;
                gamesModel.MainTopicID = row["MainTopicID"] != DBNull.Value ? Convert.ToInt64(row["MainTopicID"].ToString()) : 0;
                gamesModel.MainTopicNumber = row["MainTopicNumber"] != DBNull.Value ? Convert.ToString(row["MainTopicNumber"]) : string.Empty;
                gamesModel.GameDescription = row["GameDescription"] != DBNull.Value ? Convert.ToString(row["GameDescription"].ToString()) : string.Empty;

                gamesModels.Add(gamesModel);
            }

            return gamesModels;
        }

        private void GamesIndex_Load(object sender, EventArgs e)
        {
            BindGridViewGames();

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
            //dataGridViewGames.Columns.Add(Deletelink);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Reports reports = new Reports();
            reports.Show();
        }

        private void dataGridViewGames_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.ColumnIndex == dataGridViewGames.Columns["Delete"].Index)
            //{
            //    int rowCount = 0;
            //    long gameID = Convert.ToInt64(dataGridViewGames.Rows[e.RowIndex].Cells["GameID"].Value);

            //    LessonPlannerRepository lessonPlannerRepository = new LessonPlannerRepository();
            //    rowCount = lessonPlannerRepository.DeleteGameByID(gameID);

            //    if (rowCount > 0)
            //    {
            //        ShowStatus(true, "DELETE");
            //        BindGridViewGames();
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
