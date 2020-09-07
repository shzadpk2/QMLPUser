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
    public partial class ShowAllQuestions : Form
    {
        private long _quizMakerID = 0;
        public ShowAllQuestions()
        {
            InitializeComponent();
        }

        public ShowAllQuestions(long quizMakerID)
        {
            InitializeComponent();
            _quizMakerID = quizMakerID;
        }

        private void ShowAllQuestions_Load(object sender, EventArgs e)
        {
            FillQuestionTypeCombo();
            //ShowMultipleQuestion showMultipleQuestion = new ShowMultipleQuestion();
            //showMultipleQuestion.txtQuestion.Text = "ssss";
            //showMultipleQuestion.TopLevel = false;
            //pnlShowAllQuesitons.Controls.Add(showMultipleQuestion);
            //showMultipleQuestion.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            //showMultipleQuestion.Dock = DockStyle.Fill;
            //showMultipleQuestion.Parent = pnlShowAllQuesitons;
            //showMultipleQuestion.Show();
        }

        private void FillQuestionTypeCombo()
        {

            this.cmbQuestionType.SelectedIndexChanged -= new EventHandler(cmbQuestionType_SelectedIndexChanged);

            cmbQuestionType.Items.Add("MCQs");
            cmbQuestionType.Items.Add("True/False");
            cmbQuestionType.Items.Add("Fill-Blanks");

            cmbQuestionType.SelectedIndex = -1;

            this.cmbQuestionType.SelectedIndexChanged += new EventHandler(cmbQuestionType_SelectedIndexChanged);

        }
        private void cmbQuestionType_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridViewShowMultipleQuestions.DataSource = null;
            dataGridViewShowMultipleQuestions.Rows.Clear();
            dataGridViewShowMultipleQuestions.Columns.Clear();

            dataGridViewTrueFalseQuestions.DataSource = null;
            dataGridViewTrueFalseQuestions.Rows.Clear();
            dataGridViewTrueFalseQuestions.Columns.Clear();

            if (!string.IsNullOrEmpty(cmbQuestionType.Text) && cmbQuestionType.Text.ToLower() == "mcqs")
            {
                dataGridViewFillBlankQuestion.Visible = false;
                dataGridViewTrueFalseQuestions.Visible = false;
                ShowMultipleQuestionGrid();
            }
            else if (!string.IsNullOrEmpty(cmbQuestionType.Text) && cmbQuestionType.Text.ToLower() == "true/false")
            {
                dataGridViewShowMultipleQuestions.Visible = false;
                dataGridViewFillBlankQuestion.Visible = false;
                ShowTrueFalseQuestionGrid();
            }
            else if (!string.IsNullOrEmpty(cmbQuestionType.Text) && cmbQuestionType.Text.ToLower() == "fill-blanks")
            {
                dataGridViewShowMultipleQuestions.Visible = false;
                dataGridViewTrueFalseQuestions.Visible = false;
                ShowFillBlankQuestionGrid();
            }
        }

        #region MultipleQuestionGrid
        private void ShowMultipleQuestionGrid()
        {
            dataGridViewShowMultipleQuestions.Height = 290;
            dataGridViewShowMultipleQuestions.Location = new Point(){ X = 44, Y= 56};
            dataGridViewShowMultipleQuestions.Visible = true;
            BindGridViewShowAllMultipleQuestionByQuizMakerID(_quizMakerID);
            //BindGridViewShowAllMultipleQuestionByQuizMakerID(_quizMakerID);
            //DataGridViewLinkColumn Editlink = new DataGridViewLinkColumn();
            //Editlink.UseColumnTextForLinkValue = true;
            //Editlink.HeaderText = "Add";
            //Editlink.Name = "Add";
            //Editlink.DataPropertyName = "lnkColumn";
            //Editlink.LinkBehavior = LinkBehavior.SystemDefault;
            //Editlink.Text = "Add";
            //dataGridViewShowMultipleQuestions.Columns.Add(Editlink);

            //DataGridViewLinkColumn Deletelink = new DataGridViewLinkColumn();
            //Deletelink.UseColumnTextForLinkValue = true;
            //Deletelink.HeaderText = "Delete";
            //Deletelink.Name = "Delete";
            //Deletelink.DataPropertyName = "lnkColumn";
            //Deletelink.LinkBehavior = LinkBehavior.SystemDefault;
            //Deletelink.Text = "Delete";
            //dataGridViewShowMultipleQuestions.Columns.Add(Deletelink);
        }
        private void BindGridViewShowAllMultipleQuestionByQuizMakerID(long quizMakerID)
        {
            QuizMakerRepository quizMakerRepository = new QuizMakerRepository();
            dataGridViewShowMultipleQuestions.DataSource = quizMakerRepository.GetAllMultipleQuestionsByQuizMakerID(quizMakerID);
        }
        private void dataGridViewShowMultipleQuestions_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == dataGridViewShowMultipleQuestions.NewRowIndex || e.RowIndex < 0)
                return;

            //if (e.ColumnIndex == dataGridViewShowMultipleQuestions.Columns["Add"].Index)
            //{
            //    AddMoreQuestions addMoreQuestions = new AddMoreQuestions(_quizMakerID);
            //    addMoreQuestions.Show();
            //}
            //else 
            //if (e.ColumnIndex == dataGridViewShowMultipleQuestions.Columns["Delete"].Index)
            //{
            //    long questionID = Convert.ToInt64(dataGridViewShowMultipleQuestions.Rows[e.RowIndex].Cells["QuestionID"].Value);
            //    QuizMakerRepository quizMakerRepository = new QuizMakerRepository();
            //    int rowCount = quizMakerRepository.DeleteMultipleQuestionByQuestionID(questionID);

            //    if (rowCount > 0)
            //    {
            //        ShowStatus(true, "DELETE");
            //        BindGridViewShowAllMultipleQuestionByQuizMakerID(_quizMakerID);
            //    }
            //}
        }
        private void dataGridViewShowMultipleQuestions_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            this.dataGridViewShowMultipleQuestions.Columns["QuizMakerID"].Visible = false;
            this.dataGridViewShowMultipleQuestions.Columns["MainTopicID"].Visible = false;
            this.dataGridViewShowMultipleQuestions.Columns["SubTopicID"].Visible = false;
            this.dataGridViewShowMultipleQuestions.Columns["CreatedOn"].Visible = false;
            this.dataGridViewShowMultipleQuestions.Columns["CreatedBy"].Visible = false;
            this.dataGridViewShowMultipleQuestions.Columns["ModifiedOn"].Visible = false;
            this.dataGridViewShowMultipleQuestions.Columns["ModifiedBy"].Visible = false;
        }

        #endregion

        #region TrueFalseQuestionGrid

        private void ShowTrueFalseQuestionGrid()
        {
            dataGridViewTrueFalseQuestions.Height = 290;
            dataGridViewTrueFalseQuestions.Location = new Point() { X = 44, Y = 56 };
            dataGridViewTrueFalseQuestions.Visible = true;
            BindGridViewShowAllTrueFalseQuestionByQuizMakerID(_quizMakerID);

            //BindGridViewShowAllMultipleQuestionByQuizMakerID(_quizMakerID);
            //DataGridViewLinkColumn Editlink = new DataGridViewLinkColumn();
            //Editlink.UseColumnTextForLinkValue = true;
            //Editlink.HeaderText = "Add";
            //Editlink.Name = "Add";
            //Editlink.DataPropertyName = "lnkColumn";
            //Editlink.LinkBehavior = LinkBehavior.SystemDefault;
            //Editlink.Text = "Add";
            //dataGridViewShowMultipleQuestions.Columns.Add(Editlink);

            //DataGridViewLinkColumn Deletelink = new DataGridViewLinkColumn();
            //Deletelink.UseColumnTextForLinkValue = true;
            //Deletelink.HeaderText = "Delete";
            //Deletelink.Name = "Delete";
            //Deletelink.DataPropertyName = "lnkColumn";
            //Deletelink.LinkBehavior = LinkBehavior.SystemDefault;
            //Deletelink.Text = "Delete";
            //dataGridViewTrueFalseQuestions.Columns.Add(Deletelink);
        }
        private void BindGridViewShowAllTrueFalseQuestionByQuizMakerID(long quizMakerID)
        {
            QuizMakerRepository quizMakerRepository = new QuizMakerRepository();
            dataGridViewTrueFalseQuestions.DataSource = quizMakerRepository.GetAllTrueQuestionsByQuizMakerID(quizMakerID);
        }

        private void dataGridViewTrueFalseQuestions_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == dataGridViewTrueFalseQuestions.NewRowIndex || e.RowIndex < 0)
                return;

            //if (e.ColumnIndex == dataGridViewShowMultipleQuestions.Columns["Add"].Index)
            //{
            //    AddMoreQuestions addMoreQuestions = new AddMoreQuestions(_quizMakerID);
            //    addMoreQuestions.Show();
            //}
            //else 
            //if (e.ColumnIndex == dataGridViewTrueFalseQuestions.Columns["Delete"].Index)
            //{
            //    long questionID = Convert.ToInt64(dataGridViewTrueFalseQuestions.Rows[e.RowIndex].Cells["QuestionID"].Value);
            //    QuizMakerRepository quizMakerRepository = new QuizMakerRepository();
            //    int rowCount = quizMakerRepository.DeleteTrueFalseQuestionByQuestionID(questionID);

            //    if (rowCount > 0)
            //    {
            //        ShowStatus(true, "DELETE");
            //        BindGridViewShowAllTrueFalseQuestionByQuizMakerID(_quizMakerID);
            //    }
            //}
        }
        private void dataGridViewTrueFalseQuestions_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            this.dataGridViewTrueFalseQuestions.Columns["QuizMakerID"].Visible = false;
            this.dataGridViewTrueFalseQuestions.Columns["MainTopicID"].Visible = false;
            this.dataGridViewTrueFalseQuestions.Columns["SubTopicID"].Visible = false;
            this.dataGridViewTrueFalseQuestions.Columns["AnswerID"].Visible = false;
            this.dataGridViewTrueFalseQuestions.Columns["AnswerBool"].Visible = false;
            this.dataGridViewTrueFalseQuestions.Columns["AnswerText"].Visible = false;
            this.dataGridViewTrueFalseQuestions.Columns["QuestionCounter"].Visible = false;
            this.dataGridViewTrueFalseQuestions.Columns["CreatedOn"].Visible = false;
            this.dataGridViewTrueFalseQuestions.Columns["CreatedBy"].Visible = false;
            this.dataGridViewTrueFalseQuestions.Columns["ModifiedOn"].Visible = false;
            this.dataGridViewTrueFalseQuestions.Columns["ModifiedBy"].Visible = false;
        }
        #endregion

        #region FillBlankQuestionGrid

        private void ShowFillBlankQuestionGrid()
        {
            dataGridViewFillBlankQuestion.Height = 290;
            dataGridViewFillBlankQuestion.Location = new Point() { X = 44, Y = 56 };
            dataGridViewFillBlankQuestion.Visible = true;
            BindGridViewShowAllFillBlankQuestionByQuizMakerID(_quizMakerID);

            //BindGridViewShowAllMultipleQuestionByQuizMakerID(_quizMakerID);
            //DataGridViewLinkColumn Editlink = new DataGridViewLinkColumn();
            //Editlink.UseColumnTextForLinkValue = true;
            //Editlink.HeaderText = "Add";
            //Editlink.Name = "Add";
            //Editlink.DataPropertyName = "lnkColumn";
            //Editlink.LinkBehavior = LinkBehavior.SystemDefault;
            //Editlink.Text = "Add";
            //dataGridViewShowMultipleQuestions.Columns.Add(Editlink);

            //DataGridViewLinkColumn Deletelink = new DataGridViewLinkColumn();
            //Deletelink.UseColumnTextForLinkValue = true;
            //Deletelink.HeaderText = "Delete";
            //Deletelink.Name = "Delete";
            //Deletelink.DataPropertyName = "lnkColumn";
            //Deletelink.LinkBehavior = LinkBehavior.SystemDefault;
            //Deletelink.Text = "Delete";
            //dataGridViewFillBlankQuestion.Columns.Add(Deletelink);
        }
        private void BindGridViewShowAllFillBlankQuestionByQuizMakerID(long quizMakerID)
        {
            QuizMakerRepository quizMakerRepository = new QuizMakerRepository();
            dataGridViewFillBlankQuestion.DataSource = quizMakerRepository.GetAllFillBlankQuestionsByQuizMakerID(quizMakerID);
        }

        private void dataGridViewFillBlankQuestion_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == dataGridViewFillBlankQuestion.NewRowIndex || e.RowIndex < 0)
                return;

            //if (e.ColumnIndex == dataGridViewFillBlankQuestion.Columns["Delete"].Index)
            //{
            //    long questionID = Convert.ToInt64(dataGridViewFillBlankQuestion.Rows[e.RowIndex].Cells["QuestionID"].Value);
            //    QuizMakerRepository quizMakerRepository = new QuizMakerRepository();
            //    int rowCount = quizMakerRepository.DeleteFillBlankQuestionByQuestionID(questionID);

            //    if (rowCount > 0)
            //    {
            //        ShowStatus(true, "DELETE");
            //        BindGridViewShowAllFillBlankQuestionByQuizMakerID(_quizMakerID);
            //    }
            //}
        }

        private void dataGridViewFillBlankQuestion_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            this.dataGridViewFillBlankQuestion.Columns["QuizMakerID"].Visible = false;
            this.dataGridViewFillBlankQuestion.Columns["MainTopicID"].Visible = false;
            this.dataGridViewFillBlankQuestion.Columns["SubTopicID"].Visible = false;
            this.dataGridViewFillBlankQuestion.Columns["AnswerID"].Visible = false;
            this.dataGridViewFillBlankQuestion.Columns["CreatedOn"].Visible = false;
            this.dataGridViewFillBlankQuestion.Columns["CreatedBy"].Visible = false;
            this.dataGridViewFillBlankQuestion.Columns["ModifiedOn"].Visible = false;
            this.dataGridViewFillBlankQuestion.Columns["ModifiedBy"].Visible = false;
        }

        #endregion
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
