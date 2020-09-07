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
    public partial class SubTopicQuizMakerIndex : Form
    {
        private long _subTopicID = 0;
        public SubTopicQuizMakerIndex()
        {
            InitializeComponent();
        }
        public SubTopicQuizMakerIndex(long subTopicID)
        {
            _subTopicID = subTopicID;
            InitializeComponent();
            BindGridViewQuizMakerBySubTopicID(subTopicID);

            DataGridViewLinkColumn AddQuestionslink = new DataGridViewLinkColumn();
            AddQuestionslink.UseColumnTextForLinkValue = true;
            AddQuestionslink.HeaderText = "Add Questions";
            AddQuestionslink.Name = "AddQuestions";
            AddQuestionslink.DataPropertyName = "lnkColumn";
            AddQuestionslink.LinkBehavior = LinkBehavior.SystemDefault;
            AddQuestionslink.Text = "Add Questions";
            dataGridViewSubTopicQuizMaker.Columns.Add(AddQuestionslink);

            DataGridViewLinkColumn ViewQuestionslink = new DataGridViewLinkColumn();
            ViewQuestionslink.UseColumnTextForLinkValue = true;
            ViewQuestionslink.HeaderText = "Show All Questions";
            ViewQuestionslink.Name = "ViewQuestions";
            ViewQuestionslink.DataPropertyName = "lnkColumn";
            ViewQuestionslink.LinkBehavior = LinkBehavior.SystemDefault;
            ViewQuestionslink.Text = "Show All Questions";
            dataGridViewSubTopicQuizMaker.Columns.Add(ViewQuestionslink);

            //DataGridViewLinkColumn Editlink = new DataGridViewLinkColumn();
            //Editlink.UseColumnTextForLinkValue = true;
            //Editlink.HeaderText = "Edit";
            //Editlink.Name = "Edit";
            //Editlink.DataPropertyName = "lnkColumn";
            //Editlink.LinkBehavior = LinkBehavior.SystemDefault;
            //Editlink.Text = "Edit";
            //dataGridViewSubTopicQuizMaker.Columns.Add(Editlink);

            //DataGridViewLinkColumn Deletelink = new DataGridViewLinkColumn();
            //Deletelink.UseColumnTextForLinkValue = true;
            //Deletelink.HeaderText = "Delete";
            //Deletelink.Name = "Delete";
            //Deletelink.DataPropertyName = "lnkColumn";
            //Deletelink.LinkBehavior = LinkBehavior.SystemDefault;
            //Deletelink.Text = "Delete";
            //dataGridViewSubTopicQuizMaker.Columns.Add(Deletelink);
        }

        private void dataGridViewSubTopicQuizMaker_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SubTopicQuizMakerIndex_Load(object sender, EventArgs e)
        {

        }

        private void BindGridViewQuizMakerBySubTopicID(long subTopicID)
        {
            QuizMakerRepository lessonPlannerRepository = new QuizMakerRepository();
            dataGridViewSubTopicQuizMaker.DataSource = lessonPlannerRepository.GetAllQuizMakersBySubTopicID(subTopicID);
        }

        private void dataGridViewSubTopicQuizMaker_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex == dataGridViewSubTopicQuizMaker.NewRowIndex || e.RowIndex < 0)
                return;

            //if (e.ColumnIndex == dataGridViewSubTopicQuizMaker.Columns["Edit"].Index)
            //{
            //    var data = (QuizMakerModel)dataGridViewSubTopicQuizMaker.Rows[e.RowIndex].DataBoundItem;

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
            //else if (e.ColumnIndex == dataGridViewSubTopicQuizMaker.Columns["Delete"].Index)
            //{
            //    //Put some logic here, for example to remove row from your binding list.
            //    //yourBindingList.RemoveAt(e.RowIndex);

            //    // Or
            //    // var data = (Product)dataGridView1.Rows[e.RowIndex].DataBoundItem;
            //    // do something 

            //    int rowCount = 0;
            //    long lessonPlannerID = Convert.ToInt64(dataGridViewSubTopicQuizMaker.Rows[e.RowIndex].Cells["QuizMakerID"].Value);

            //    QuizMakerRepository quizMakerRepository = new QuizMakerRepository();
            //    //rowCount = lessonPlannerRepository.DeleteLessonPlannerByID(lessonPlannerID);

            //    if (rowCount > 0)
            //    {
            //        ShowStatus(true, "DELETE");
            //        BindGridViewQuizMakerBySubTopicID(_subTopicID);
            //    }


            //}
            //else 
            if (e.ColumnIndex == dataGridViewSubTopicQuizMaker.Columns["AddQuestions"].Index)
            {
                long quizMakerID = Convert.ToInt64(dataGridViewSubTopicQuizMaker.Rows[e.RowIndex].Cells["QuizMakerID"].Value);
                AddMoreQuestions addMoreQuestions = new AddMoreQuestions(quizMakerID);
                addMoreQuestions.Show();
            }
            else if (e.ColumnIndex == dataGridViewSubTopicQuizMaker.Columns["ViewQuestions"].Index)
            {
                long quizMakerID = Convert.ToInt64(dataGridViewSubTopicQuizMaker.Rows[e.RowIndex].Cells["QuizMakerID"].Value);
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

        private void dataGridViewSubTopicQuizMaker_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            this.dataGridViewSubTopicQuizMaker.Columns["QuizMakerID"].Visible = false;
            this.dataGridViewSubTopicQuizMaker.Columns["GradeID"].Visible = false;
            this.dataGridViewSubTopicQuizMaker.Columns["SubjectID"].Visible = false;
            this.dataGridViewSubTopicQuizMaker.Columns["MainTopicID"].Visible = false;
            this.dataGridViewSubTopicQuizMaker.Columns["SubTopicID"].Visible = false;
            this.dataGridViewSubTopicQuizMaker.Columns["MainTopicNumber"].Visible = false;
            this.dataGridViewSubTopicQuizMaker.Columns["TimeLimit"].Visible = false;
            this.dataGridViewSubTopicQuizMaker.Columns["TotalQuestions"].Visible = false;
            this.dataGridViewSubTopicQuizMaker.Columns["TotalScore"].Visible = false;
            this.dataGridViewSubTopicQuizMaker.Columns["Instructions"].Visible = false;
            this.dataGridViewSubTopicQuizMaker.Columns["TopicNumber"].Visible = false;
            this.dataGridViewSubTopicQuizMaker.Columns["IsMultiple"].Visible = false;
            this.dataGridViewSubTopicQuizMaker.Columns["IsTF"].Visible = false;
            this.dataGridViewSubTopicQuizMaker.Columns["IsFillBlank"].Visible = false;
            this.dataGridViewSubTopicQuizMaker.Columns["CreatedOn"].Visible = false;
            this.dataGridViewSubTopicQuizMaker.Columns["CreatedBy"].Visible = false;
            this.dataGridViewSubTopicQuizMaker.Columns["ModifiedOn"].Visible = false;
            this.dataGridViewSubTopicQuizMaker.Columns["ModifiedBy"].Visible = false;
        }
    }
}
