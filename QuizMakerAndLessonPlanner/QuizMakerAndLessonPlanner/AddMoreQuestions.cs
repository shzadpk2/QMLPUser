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
    public partial class AddMoreQuestions : Form
    {
        private long _quizMakerID = 0;

        public static List<MultipleQuestionModel> addMoreMultipleQuestionModelsGlobal = new List<MultipleQuestionModel>();
        public static List<TrueFalseQuestionModel> addMoreTrueFalseQuestionModelsGlobal = new List<TrueFalseQuestionModel>();
        public static List<FillBlankQuestionModel> addMoreFillBlankQuestionModelsGlobal = new List<FillBlankQuestionModel>();
        public AddMoreQuestions()
        {
            InitializeComponent();
            lblQuizMakerID.Text = "0";
        }
        public AddMoreQuestions(long quizMakerID)
        {
            InitializeComponent();
            _quizMakerID = quizMakerID;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddMultiple_Click(object sender, EventArgs e)
        {
            if (_quizMakerID > 0)
            {
                if (rdbMultiple.Checked)
                {
                    int numberOfOptions = Convert.ToInt32(txtOptionsNumeric.Value);
                    AddMultipleQuestions addMultipleQuestions = new AddMultipleQuestions(_quizMakerID);
                    addMultipleQuestions.numerOfOptions = numberOfOptions;

                    addMultipleQuestions.Show();
                }
                else if (rdbTF.Checked)
                {
                    AddTrueFalseQuestion addTrueFalse = new AddTrueFalseQuestion(_quizMakerID);
                    addTrueFalse.Show();
                }
                else if (true)
                {
                    AddFillBlankQuestions addFillBlankQuestions = new AddFillBlankQuestions(_quizMakerID);
                    addFillBlankQuestions.Show();
                }
            }

        }

        private void rdbMultiple_CheckedChanged(object sender, EventArgs e)
        {
            txtOptionsNumeric.Visible = true;
            lblMultipleOptions.Visible = true;
            btnAddMultiple.Visible = true;
        }

        private void rdbTF_CheckedChanged(object sender, EventArgs e)
        {
            txtOptionsNumeric.Visible = false;
            lblMultipleOptions.Visible = false;

            btnAddMultiple.Visible = true;

        }

        private void rdbFillBlank_CheckedChanged(object sender, EventArgs e)
        {
            txtOptionsNumeric.Visible = false;
            lblMultipleOptions.Visible = false;

            btnAddMultiple.Visible = true;

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            DataTable dataTableMultipleQuestion = TranslateMultipleQuestionAnswerListToDataTable(addMoreMultipleQuestionModelsGlobal);
            DataTable dataTableTrueFalseQuestion = TranslateTrueFalseQuestionAnswerListToDataTable(addMoreTrueFalseQuestionModelsGlobal);
            DataTable dataTableFillBlankQuestion = TranslateFillBlankQuestionAnswerListToDataTable(addMoreFillBlankQuestionModelsGlobal);

            QuizMakerRepository quizMakerRepository = new QuizMakerRepository();
            long result = quizMakerRepository.SaveMoreQuestions(dataTableMultipleQuestion, dataTableTrueFalseQuestion, dataTableFillBlankQuestion);

            if (result > 0)
            {
                ShowStatus(true, "ADD");
            }
            else
            {
                ShowStatus(false, string.Empty);
            }

            addMoreMultipleQuestionModelsGlobal = new List<MultipleQuestionModel>();
            addMoreTrueFalseQuestionModelsGlobal = new List<TrueFalseQuestionModel>();
            addMoreFillBlankQuestionModelsGlobal = new List<FillBlankQuestionModel>();

            this.Close();
        }
        private DataTable TranslateMultipleQuestionAnswerListToDataTable(List<MultipleQuestionModel> multipleQuestionModels)
        {
            DataTable dataTable = new DataTable();

            dataTable.Clear();

            //Create DataTable Columns

            dataTable.Columns.Add("QuestionText", typeof(string));
            dataTable.Columns.Add("QuizMakerID", typeof(long));
            dataTable.Columns.Add("MainTopicID", typeof(long));
            dataTable.Columns.Add("SubTopicID", typeof(long));
            dataTable.Columns.Add("NoOfOption", typeof(int));
            dataTable.Columns.Add("OptionOneText", typeof(string));
            dataTable.Columns.Add("OptionTwoText", typeof(string));
            dataTable.Columns.Add("OptionThreeText", typeof(string));
            dataTable.Columns.Add("OptionFourText", typeof(string));
            dataTable.Columns.Add("QuestionCounter", typeof(string));

            //anwers values
            dataTable.Columns.Add("OptionNo", typeof(int));
            dataTable.Columns.Add("OptionText", typeof(string));

            dataTable.Columns.Add("CreatedOn", typeof(DateTime));
            dataTable.Columns.Add("CreatedBy", typeof(int));
            dataTable.Columns.Add("ModifiedOn", typeof(DateTime));
            dataTable.Columns.Add("ModifiedBy", typeof(int));

            if (multipleQuestionModels != null && multipleQuestionModels.Count > 0)
            {
                foreach (MultipleQuestionModel item in multipleQuestionModels)
                {
                    DataRow dr = dataTable.NewRow();

                    dr["QuestionText"] = item.QuestionText;
                    dr["QuizMakerID"] = item.QuizMakerID;
                    dr["MainTopicID"] = item.MainTopicID;
                    dr["SubTopicID"] = item.SubTopicID;
                    dr["NoOfOption"] = item.NoOfOption;
                    dr["OptionOneText"] = item.OptionOneText;
                    dr["OptionTwoText"] = item.OptionTwoText;
                    dr["OptionThreeText"] = item.OptionThreeText;
                    dr["OptionFourText"] = item.OptionFourText;
                    dr["QuestionCounter"] = item.QuestionCounter;

                    //anwers values
                    dr["OptionNo"] = item.AnswerOptionNo;
                    dr["OptionText"] = item.AnswerOptionText;

                    dr["CreatedOn"] = item.CreatedOn;
                    dr["CreatedBy"] = item.CreatedBy;
                    dr["ModifiedOn"] = item.ModifiedOn;
                    dr["ModifiedBy"] = item.ModifiedBy;

                    dataTable.Rows.Add(dr);
                }

            }

            return dataTable;
        }
        private DataTable TranslateTrueFalseQuestionAnswerListToDataTable(List<TrueFalseQuestionModel> trueFalseQuestionModels)
        {
            DataTable dataTable = new DataTable();

            dataTable.Clear();

            //Create DataTable Columns

            dataTable.Columns.Add("TrueText", typeof(string));
            dataTable.Columns.Add("FalseText", typeof(string));
            dataTable.Columns.Add("QuizMakerID", typeof(long));
            dataTable.Columns.Add("MainTopicID", typeof(long));
            dataTable.Columns.Add("SubTopicID", typeof(long));
            dataTable.Columns.Add("QuestionCounter", typeof(string));

            dataTable.Columns.Add("CreatedOn", typeof(DateTime));
            dataTable.Columns.Add("CreatedBy", typeof(int));
            dataTable.Columns.Add("ModifiedOn", typeof(DateTime));
            dataTable.Columns.Add("ModifiedBy", typeof(int));

            if (trueFalseQuestionModels != null && trueFalseQuestionModels.Count > 0)
            {
                foreach (TrueFalseQuestionModel item in trueFalseQuestionModels)
                {
                    DataRow dr = dataTable.NewRow();

                    dr["TrueText"] = item.TrueText;
                    dr["FalseText"] = item.FalseText;
                    dr["QuizMakerID"] = item.QuizMakerID;
                    dr["MainTopicID"] = item.MainTopicID;
                    dr["SubTopicID"] = item.SubTopicID;
                    dr["QuestionCounter"] = item.QuestionCounter;

                    dr["CreatedOn"] = item.CreatedOn;
                    dr["CreatedBy"] = item.CreatedBy;
                    dr["ModifiedOn"] = item.ModifiedOn;
                    dr["ModifiedBy"] = item.ModifiedBy;

                    dataTable.Rows.Add(dr);
                }

            }

            return dataTable;
        }
        private DataTable TranslateFillBlankQuestionAnswerListToDataTable(List<FillBlankQuestionModel> fillBlankQuestionModels)
        {
            DataTable dataTable = new DataTable();

            dataTable.Clear();

            //Create DataTable Columns

            dataTable.Columns.Add("QuestionText", typeof(string));
            dataTable.Columns.Add("QuizMakerID", typeof(long));
            dataTable.Columns.Add("MainTopicID", typeof(long));
            dataTable.Columns.Add("SubTopicID", typeof(long));
            dataTable.Columns.Add("QuestionCounter", typeof(string));

            //anwers values
            dataTable.Columns.Add("AnswerText", typeof(string));

            dataTable.Columns.Add("CreatedOn", typeof(DateTime));
            dataTable.Columns.Add("CreatedBy", typeof(int));
            dataTable.Columns.Add("ModifiedOn", typeof(DateTime));
            dataTable.Columns.Add("ModifiedBy", typeof(int));

            if (fillBlankQuestionModels != null && fillBlankQuestionModels.Count > 0)
            {
                foreach (FillBlankQuestionModel item in fillBlankQuestionModels)
                {
                    DataRow dr = dataTable.NewRow();

                    dr["QuestionText"] = item.QuestionText;
                    dr["QuizMakerID"] = item.QuizMakerID;
                    dr["MainTopicID"] = item.MainTopicID;
                    dr["SubTopicID"] = item.SubTopicID;
                    dr["QuestionCounter"] = item.QuestionCounter;

                    //anwers values
                    dr["AnswerText"] = item.AnswerText;

                    dr["CreatedOn"] = item.CreatedOn;
                    dr["CreatedBy"] = item.CreatedBy;
                    dr["ModifiedOn"] = item.ModifiedOn;
                    dr["ModifiedBy"] = item.ModifiedBy;

                    dataTable.Rows.Add(dr);
                }

            }

            return dataTable;
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
