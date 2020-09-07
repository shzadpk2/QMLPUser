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
    public partial class QuizMakerIndex : Form
    {
        public QuizMakerIndex()
        {
            InitializeComponent();
        }
        public QuizMakerIndex(long mainTopicID)
        {
            InitializeComponent();
            BindGridViewQuizMakerByMainTopicID(mainTopicID);

            DataGridViewLinkColumn AddQuestionslink = new DataGridViewLinkColumn();
            AddQuestionslink.UseColumnTextForLinkValue = true;
            AddQuestionslink.HeaderText = "Add Questions";
            AddQuestionslink.Name = "AddQuestions";
            AddQuestionslink.DataPropertyName = "lnkColumn";
            AddQuestionslink.LinkBehavior = LinkBehavior.SystemDefault;
            AddQuestionslink.Text = "Add Questions";
            dataGridViewQuizMaker.Columns.Add(AddQuestionslink);

            DataGridViewLinkColumn ViewQuestionslink = new DataGridViewLinkColumn();
            ViewQuestionslink.UseColumnTextForLinkValue = true;
            ViewQuestionslink.HeaderText = "Show All Questions";
            ViewQuestionslink.Name = "ViewQuestions";
            ViewQuestionslink.DataPropertyName = "lnkColumn";
            ViewQuestionslink.LinkBehavior = LinkBehavior.SystemDefault;
            ViewQuestionslink.Text = "Show All Questions";
            dataGridViewQuizMaker.Columns.Add(ViewQuestionslink);

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
            //dataGridViewQuizMaker.Columns.Add(Deletelink);
        }

        private void dataGridViewQuizMaker_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

     
        private void BindGridViewQuizMaker()
        {
            QuizMakerRepository lessonPlannerRepository = new QuizMakerRepository();
            List<QuizMakerModel> quizMakerModels = new List<QuizMakerModel>();

            DataTable dataTable = new DataTable();

            try
            {
                dataTable = lessonPlannerRepository.GetAllQuizMakers();

                quizMakerModels = TranslateDataTableToQuizMakersModel(dataTable);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Network error...Please try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {

                dataTable.Clear();
                dataTable = null;
                dataGridViewQuizMaker.DataSource = quizMakerModels;
            }

        }

        private List<QuizMakerModel> TranslateDataTableToQuizMakersModel(DataTable dataTable)
        {
            List<QuizMakerModel> quizMakerModels = new List<QuizMakerModel>();

            foreach (DataRow row in dataTable.Rows)
            {
                QuizMakerModel quizMakerModel = new QuizMakerModel();
                quizMakerModel.QuizMakerID = row["QuizMakerID"] != DBNull.Value ? Convert.ToInt64(row["QuizMakerID"].ToString()) : 0;
                quizMakerModel.GradeID = row["GradeID"] != DBNull.Value ? Convert.ToInt64(row["GradeID"].ToString()) : 0;
                quizMakerModel.GradeName = row["GradeName"] != DBNull.Value ? Convert.ToString(row["GradeName"]) : string.Empty;
                quizMakerModel.SubjectID = row["SubjectID"] != DBNull.Value ? Convert.ToInt64(row["SubjectID"].ToString()) : 0;
                quizMakerModel.SubjectName = row["SubjectName"] != DBNull.Value ? Convert.ToString(row["SubjectName"]) : string.Empty;
                quizMakerModel.MainTopicID = row["MainTopicID"] != DBNull.Value ? Convert.ToInt64(row["MainTopicID"].ToString()) : 0;
                quizMakerModel.MainTopicNumber = row["MainTopicNumber"] != DBNull.Value ? Convert.ToString(row["MainTopicNumber"]) : string.Empty;
                quizMakerModel.SubTopicID = row["SubTopicID"] != DBNull.Value ? Convert.ToInt64(row["SubTopicID"].ToString()) : 0;
                quizMakerModel.SubTopicNumber = row["SubTopicNumber"] != DBNull.Value ? Convert.ToString(row["SubTopicNumber"]) : string.Empty;
                quizMakerModel.TimeLimit = row["TimeLimit"] != DBNull.Value ? Convert.ToString(row["TimeLimit"]) : string.Empty;
                quizMakerModel.TotalQuestions = row["TotalQuestions"] != DBNull.Value ? Convert.ToString(row["TotalQuestions"]) : string.Empty;
                quizMakerModel.TotalScore = row["TotalScore"] != DBNull.Value ? Convert.ToString(row["TotalScore"]) : string.Empty;
                quizMakerModel.Instructions = row["Instructions"] != DBNull.Value ? Convert.ToString(row["Instructions"]) : string.Empty;

                quizMakerModels.Add(quizMakerModel);
            }

            return quizMakerModels;
        }

        private void BindGridViewQuizMakerByMainTopicID(long mainTopicID)
        {
            QuizMakerRepository lessonPlannerRepository = new QuizMakerRepository();
            dataGridViewQuizMaker.DataSource = lessonPlannerRepository.GetAllQuizMakersByMainTopicID(mainTopicID);
        }
        private void dataGridViewQuizMaker_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == dataGridViewQuizMaker.NewRowIndex || e.RowIndex < 0)
                return;

            //if (e.ColumnIndex == dataGridViewQuizMaker.Columns["Edit"].Index)
            //{
            //    var data = (QuizMakerModel)dataGridViewQuizMaker.Rows[e.RowIndex].DataBoundItem;

            //    QuizMaker quizMaker = new QuizMaker(data);
            //    quizMaker.lblQuizMakerID.Text = Convert.ToString(data.QuizMakerID);
            //    //quizMaker.cmbGrades.SelectedValue = data.GradeID;
            //    //quizMaker.cmbSubjects.SelectedValue = data.SubjectID;
            //    //quizMaker.txt .Text = data.MainTopicNumber;
            //    //lessonPlanner.txtTitleMainTopic.Text = data.TitleMainTopic;
            //    //lessonPlanner.txtIntroduction.Text = data.Introduction;
            //    //lessonPlanner.txtObjectives.Text = data.Objectives;
            //    //lessonPlanner.txtMaterial.Text = data.Material;

            //    quizMaker.Show();

            //    this.Close();
            //}
            //else if (e.ColumnIndex == dataGridViewQuizMaker.Columns["Delete"].Index)
            //{
            //    //Put some logic here, for example to remove row from your binding list.
            //    //yourBindingList.RemoveAt(e.RowIndex);

            //    // Or
            //    // var data = (Product)dataGridView1.Rows[e.RowIndex].DataBoundItem;
            //    // do something 

            //    int rowCount = 0;
            //    long quizMakerID = Convert.ToInt64(dataGridViewQuizMaker.Rows[e.RowIndex].Cells["QuizMakerID"].Value);

            //    QuizMakerRepository quizMakerRepository = new QuizMakerRepository();
            //    //rowCount = lessonPlannerRepository.DeleteLessonPlannerByID(lessonPlannerID);

            //    if (rowCount > 0)
            //    {
            //        ShowStatus(true, "DELETE");
            //        BindGridViewQuizMaker();
            //    }
            //}
            //else 
            if (e.ColumnIndex == dataGridViewQuizMaker.Columns["AddQuestions"].Index)
            {
                long quizMakerID = Convert.ToInt64(dataGridViewQuizMaker.Rows[e.RowIndex].Cells["QuizMakerID"].Value);
                AddMoreQuestions addMoreQuestions = new AddMoreQuestions(quizMakerID);
                addMoreQuestions.Show();
            }
            else if (e.ColumnIndex == dataGridViewQuizMaker.Columns["ViewQuestions"].Index)
            {
                long quizMakerID = Convert.ToInt64(dataGridViewQuizMaker.Rows[e.RowIndex].Cells["QuizMakerID"].Value);
                ShowAllQuestions showAllQuestions = new ShowAllQuestions(quizMakerID);
                showAllQuestions.Show();
            }
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
        private void dataGridViewQuizMaker_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            this.dataGridViewQuizMaker.Columns["QuizMakerID"].Visible = false;
            this.dataGridViewQuizMaker.Columns["GradeID"].Visible = false;
            this.dataGridViewQuizMaker.Columns["SubjectID"].Visible = false;
            this.dataGridViewQuizMaker.Columns["MainTopicID"].Visible = false;
            this.dataGridViewQuizMaker.Columns["SubTopicID"].Visible = false;
            this.dataGridViewQuizMaker.Columns["SubTopicNumber"].Visible = false;
            this.dataGridViewQuizMaker.Columns["TimeLimit"].Visible = false;
            this.dataGridViewQuizMaker.Columns["TotalQuestions"].Visible = false;
            this.dataGridViewQuizMaker.Columns["TotalScore"].Visible = false;
            this.dataGridViewQuizMaker.Columns["Instructions"].Visible = false;
            this.dataGridViewQuizMaker.Columns["TopicNumber"].Visible = false;
            this.dataGridViewQuizMaker.Columns["IsMultiple"].Visible = false;
            this.dataGridViewQuizMaker.Columns["IsTF"].Visible = false;
            this.dataGridViewQuizMaker.Columns["IsFillBlank"].Visible = false;
            this.dataGridViewQuizMaker.Columns["CreatedOn"].Visible = false;
            this.dataGridViewQuizMaker.Columns["CreatedBy"].Visible = false;
            this.dataGridViewQuizMaker.Columns["ModifiedOn"].Visible = false;
            this.dataGridViewQuizMaker.Columns["ModifiedBy"].Visible = false;
        }

    }
}
