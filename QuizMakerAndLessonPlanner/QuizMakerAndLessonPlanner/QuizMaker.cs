using QMLPModels;
using QMLPRepository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizMakerAndLessonPlanner
{
    public partial class QuizMaker : Form
    {
        public static List<MultipleQuestionModel> multipleQuestionModelsGlobal = new List<MultipleQuestionModel>();
        public static List<TrueFalseQuestionModel> trueFalseQuestionModelsGlobal = new List<TrueFalseQuestionModel>();
        public static List<FillBlankQuestionModel> fillBlankQuestionModelsGlobal = new List<FillBlankQuestionModel>();
        public QuizMaker()
        {
            InitializeComponent();
        }
        public QuizMaker(QuizMakerModel quizMakerModel)
        {
            InitializeComponent();
        }
        private void QuizMaker_Load(object sender, EventArgs e)
        {
            lblQuizMakerID.Text = "0";
            FillGradesCombo();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            Home home = new Home();
            home.Show();
        }
        private void FillGradesCombo()
        {
            GradeRepository gradeRepository = new GradeRepository();
            List<GradeModel> gradesList = new List<GradeModel>();

            try
            {
                DataTable dataTable = gradeRepository.GetAllGrades();

                gradesList = TranslateDataTableToGradeModel(dataTable);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Network error...Please try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.cmbGrades.SelectedIndexChanged -= new EventHandler(cmbGrades_SelectedIndexChanged);

            BindingSource bs = new BindingSource();
            bs.DataSource = gradesList;

            cmbGrades.ValueMember = "GradeID";
            cmbGrades.DisplayMember = "GradeName";
            cmbGrades.DataSource = bs;

            cmbGrades.SelectedIndex = -1;

            this.cmbGrades.SelectedIndexChanged += new EventHandler(cmbGrades_SelectedIndexChanged);
        }

        private List<GradeModel> TranslateDataTableToGradeModel(DataTable dataTable)
        {
            List<GradeModel> gradeModels = new List<GradeModel>();

            foreach (DataRow row in dataTable.Rows)
            {
                GradeModel gradeModel = new GradeModel();
                gradeModel.GradeID = row["GradeID"] != DBNull.Value ? Convert.ToInt32(row["GradeID"].ToString()) : 0;
                gradeModel.GradeName = row["GradeName"] != DBNull.Value ? Convert.ToString(row["GradeName"]) : string.Empty;

                gradeModels.Add(gradeModel);
            }

            return gradeModels;
        }

        private void FillSubjectComboByGradeID(long gradeID)
        {
            SubjectsRepository subjectsRepository = new SubjectsRepository();
            List<SubjectModel> subjectModels = new List<SubjectModel>();

            DataTable dataTable = new DataTable();

            try
            {
                dataTable = subjectsRepository.GetAllSubjectsByGradeID(gradeID);

                subjectModels = TranslateDataTableToSubjectsModel(dataTable);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Network error...Please try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {

                dataTable.Clear();
                dataTable = null;
            }

            this.cmbSubjects.SelectedIndexChanged -= new EventHandler(cmbSubjects_SelectedIndexChanged);

            BindingSource bs = new BindingSource();
            bs.DataSource = subjectModels;
            cmbSubjects.ValueMember = "SubjectID";
            cmbSubjects.DisplayMember = "SubjectName";
            cmbSubjects.DataSource = bs;
            cmbSubjects.SelectedIndex = -1;

            this.cmbSubjects.SelectedIndexChanged += new EventHandler(cmbSubjects_SelectedIndexChanged);
        }

        private List<SubjectModel> TranslateDataTableToSubjectsModel(DataTable dataTable)
        {
            List<SubjectModel> subjectModels = new List<SubjectModel>();

            foreach (DataRow row in dataTable.Rows)
            {
                SubjectModel subjectModel = new SubjectModel();
                subjectModel.SubjectID = row["SubjectID"] != DBNull.Value ? Convert.ToInt32(row["SubjectID"].ToString()) : 0;
                subjectModel.SubjectName = row["SubjectName"] != DBNull.Value ? Convert.ToString(row["SubjectName"]) : string.Empty;

                subjectModels.Add(subjectModel);
            }

            return subjectModels;
        }

        private void cmbGrades_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt64(cmbGrades.SelectedValue) > 0)
            {
                FillSubjectComboByGradeID(Convert.ToInt64(cmbGrades.SelectedValue));
            }

            ChangeQuizNumberValue();
        }
        private void cmbSubjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            long gradeID = 0;
            long subjectID = 0;

            if (!string.IsNullOrEmpty(cmbGrades.Text))
            {
                // Get the Topic from DB and fill Topics Combo
                gradeID = Convert.ToInt64(cmbGrades.SelectedValue);
                subjectID = Convert.ToInt64(cmbSubjects.SelectedValue);

                QuizMakerRepository quizMakerRepository = new QuizMakerRepository();
                List<QuizMakerTopicNumberDetail> quizMakerTopicNumberDetails = quizMakerRepository.GetAllSubTopicDetails(gradeID, subjectID);

                this.cmbTopicNo.SelectedIndexChanged -= new EventHandler(cmbTopicNo_SelectedIndexChanged);

                BindingSource bs = new BindingSource();
                bs.DataSource = quizMakerTopicNumberDetails;

                cmbTopicNo.ValueMember = "TopicID";
                cmbTopicNo.DisplayMember = "TopicNumber";

                cmbTopicNo.SelectedValue = subjectID;

                cmbTopicNo.DataSource = bs;

                this.cmbTopicNo.SelectedIndexChanged += new EventHandler(cmbTopicNo_SelectedIndexChanged);
                ChangeQuizNumberValue();
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmbGrades.Text))
            {
                MessageBox.Show("Grade can't be blank!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (string.IsNullOrEmpty(cmbSubjects.Text))
            {
                MessageBox.Show("Subjec can't be blank!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (string.IsNullOrEmpty(cmbTopicNo.Text))
            {
                MessageBox.Show("Topic number can't be blank!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (string.IsNullOrEmpty(txtQuizNumber.Text))
            {
                MessageBox.Show("Quiz number can't be blank!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (string.IsNullOrEmpty(txtTimeLimit.Text))
            {
                MessageBox.Show("Time limit can't be blank!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //else if (string.IsNullOrEmpty(txtTotalScores.Text))
            //{
            //    MessageBox.Show("Total scores can't be blank!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}
            //else if (string.IsNullOrEmpty(txtTotalQuestions.Text))
            //{
            //    MessageBox.Show("Total questions can't be blank!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}
            else if (multipleQuestionModelsGlobal.Count == 0 && trueFalseQuestionModelsGlobal.Count == 0)
            {
                MessageBox.Show("Please add at least one question!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                QuizMakerModel quizMakerModel = new QuizMakerModel();

                quizMakerModel.QuizMakerID = Convert.ToInt64(lblQuizMakerID.Text);
                quizMakerModel.GradeID = Convert.ToInt64(cmbGrades.SelectedValue);
                quizMakerModel.SubjectID = Convert.ToInt64(cmbSubjects.SelectedValue);

                long topicID = 0;
                string topicNumberString = Convert.ToString(cmbTopicNo.SelectedValue);
                if (!string.IsNullOrEmpty(topicNumberString))
                {
                    string topicType = topicNumberString.Substring(topicNumberString.IndexOf("-") + 1);
                    if (topicType.ToLower() == "mt")
                    {
                        quizMakerModel.MainTopicID = Convert.ToInt64(topicNumberString.Substring(0, topicNumberString.IndexOf("-")));
                        quizMakerModel.SubTopicID = 0;
                    }
                    else if (topicType.ToLower() == "st")
                    {
                        quizMakerModel.SubTopicID = Convert.ToInt64(topicNumberString.Substring(0, topicNumberString.IndexOf("-")));
                        quizMakerModel.MainTopicID = 0;
                    }
                }

                quizMakerModel.TopicNumber = cmbTopicNo.Text;
                quizMakerModel.QuizNumber = txtQuizNumber.Text;
                quizMakerModel.TimeLimit = txtTimeLimit.Text;
                quizMakerModel.TotalQuestions = txtTotalQuestions.Text;
                quizMakerModel.TotalScore = txtTotalScores.Text;
                quizMakerModel.Instructions = txtInstructions.Text;
                quizMakerModel.IsMultiple = rdbMultiple.Checked ? true : false;
                quizMakerModel.IsTF = rdbTF.Checked ? true : false;
                quizMakerModel.IsFillBlank = rdbFillBlank.Checked ? true : false;

                quizMakerModel.CreatedOn = DateTime.Now;
                quizMakerModel.CreatedBy = 1; // It will be added from users
                quizMakerModel.ModifiedOn = DateTime.Now;
                quizMakerModel.ModifiedBy = 1; // It will be added from users

                try
                {
                    QuizMakerRepository quizMakerRepository = new QuizMakerRepository();

                    DataTable dataTableQuizMaker = TranslateQuizMakerListToDataTable(quizMakerModel);
                    DataTable dataTableMultipleQuestion = TranslateMultipleQuestionAnswerListToDataTable(multipleQuestionModelsGlobal);
                    DataTable dataTableTrueFalseQuestion = TranslateTrueFalseQuestionAnswerListToDataTable(trueFalseQuestionModelsGlobal);
                    DataTable dataTableFillBlankQuestion = TranslateFillBlankQuestionAnswerListToDataTable(fillBlankQuestionModelsGlobal);

                    long result = quizMakerRepository.SaveUpdateQuizMaker(dataTableQuizMaker, dataTableMultipleQuestion, dataTableTrueFalseQuestion, dataTableFillBlankQuestion);
                    if (result > 0)
                    {
                        ShowStatus(true, "ADD");
                    }
                    else
                    {
                        ShowStatus(false, string.Empty);
                    }

                    QuizMaker.multipleQuestionModelsGlobal = new List<MultipleQuestionModel>();
                    QuizMaker.trueFalseQuestionModelsGlobal = new List<TrueFalseQuestionModel>();
                    QuizMaker.fillBlankQuestionModelsGlobal = new List<FillBlankQuestionModel>();

                    //this.Close();
                    //Home home = new Home();
                    //home.Show();

                }
                catch (Exception ex)
                {
                    ShowStatus(false, string.Empty);
                }
            }
        }
        private DataTable TranslateQuizMakerListToDataTable(QuizMakerModel quizMakerModel)
        {
            DataTable dataTable = new DataTable();
            dataTable.Clear();
            //Create DataTable Columns

            dataTable.Columns.Add("GradeID", typeof(string));
            dataTable.Columns.Add("SubjectID", typeof(string));
            dataTable.Columns.Add("TopicNumber", typeof(string));
            dataTable.Columns.Add("QuizNumber", typeof(string));
            dataTable.Columns.Add("TimeLimit", typeof(string));
            dataTable.Columns.Add("TotalQuestions", typeof(string));
            dataTable.Columns.Add("TotalScore", typeof(string));
            dataTable.Columns.Add("Instructions", typeof(string));
            dataTable.Columns.Add("IsMultiple", typeof(bool));
            dataTable.Columns.Add("IsTF", typeof(bool));
            dataTable.Columns.Add("IsFillBlank", typeof(bool));
            dataTable.Columns.Add("MainTopicID", typeof(long));
            dataTable.Columns.Add("SubTopicID", typeof(long));

            dataTable.Columns.Add("CreatedOn", typeof(DateTime));
            dataTable.Columns.Add("CreatedBy", typeof(int));
            dataTable.Columns.Add("ModifiedOn", typeof(DateTime));
            dataTable.Columns.Add("ModifiedBy", typeof(int));


            if (quizMakerModel != null)
            {
                DataRow dr = dataTable.NewRow();

                dr["GradeID"] = quizMakerModel.GradeID;
                dr["SubjectID"] = quizMakerModel.SubjectID;
                dr["TopicNumber"] = quizMakerModel.TopicNumber;
                dr["QuizNumber"] = quizMakerModel.QuizNumber;
                dr["TimeLimit"] = quizMakerModel.TimeLimit;
                dr["TotalQuestions"] = quizMakerModel.TotalQuestions;
                dr["TotalScore"] = quizMakerModel.TotalScore;
                dr["Instructions"] = quizMakerModel.Instructions;
                dr["IsMultiple"] = quizMakerModel.IsMultiple;
                dr["IsTF"] = quizMakerModel.IsTF;
                dr["IsFillBlank"] = quizMakerModel.IsFillBlank;
                dr["MainTopicID"] = quizMakerModel.MainTopicID;
                dr["SubTopicID"] = quizMakerModel.SubTopicID;

                dr["CreatedOn"] = quizMakerModel.CreatedOn;
                dr["CreatedBy"] = quizMakerModel.CreatedBy;
                dr["ModifiedOn"] = quizMakerModel.ModifiedOn;
                dr["ModifiedBy"] = quizMakerModel.ModifiedBy;

                dataTable.Rows.Add(dr);

            }

            return dataTable;
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
            ClearFields();
        }
        public void ClearFields() // Clear the fields after Insert or Update or Delete operation  
        {
            cmbGrades.SelectedIndex = -1;
            cmbSubjects.SelectedIndex = -1; 
            cmbTopicNo.SelectedIndex = -1;
            lblQuizMakerID.Text = "0";
            txtQuizNumber.Text = "";
            txtTimeLimit.Text = "";
            txtTotalScores.Text = "";
            txtTotalQuestions.Text = "";
            txtInstructions.Text = "";
            rdbMultiple.Checked = false;
            rdbFillBlank.Checked = false;
            rdbTF.Checked = false;
            lblMultipleOptions.Visible = false;
            txtOptionsNumeric.Visible = false;
            btnAddMultiple.Visible = false;
            pnlQuestions.Controls.Clear();
        }

        private void rdbMultiple_CheckedChanged(object sender, EventArgs e)
        {
            pnlQuestions.Controls.Clear();
            txtOptionsNumeric.Visible = true;
            lblMultipleOptions.Visible = true;
            btnAddMultiple.Visible = true;
        }

        private void rdbTF_CheckedChanged(object sender, EventArgs e)
        {
            pnlQuestions.Controls.Clear();

            txtOptionsNumeric.Visible = false;
            lblMultipleOptions.Visible = false;

            btnAddMultiple.Visible = true;

        }

        private void rdbFillBlank_CheckedChanged(object sender, EventArgs e)
        {
            pnlQuestions.Controls.Clear();

            txtOptionsNumeric.Visible = false;
            lblMultipleOptions.Visible = false;

            btnAddMultiple.Visible = true;

        }

        private void btnAddMultiple_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmbGrades.Text))
            {
                MessageBox.Show("Grade can't be blank!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (string.IsNullOrEmpty(cmbSubjects.Text))
            {
                MessageBox.Show("Subjec can't be blank!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (string.IsNullOrEmpty(cmbTopicNo.Text))
            {
                MessageBox.Show("Topic can't be blank!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                pnlQuestions.Controls.Clear();
                if (rdbMultiple.Checked)
                {
                    int numberOfOptions = Convert.ToInt32(txtOptionsNumeric.Value);
                    AddMultipleQuestions addMultipleQuestions = new AddMultipleQuestions();
                    addMultipleQuestions.numerOfOptions = numberOfOptions;

                    addMultipleQuestions.TopLevel = false;
                    pnlQuestions.Controls.Add(addMultipleQuestions);
                    addMultipleQuestions.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                    addMultipleQuestions.Dock = DockStyle.Fill;
                    addMultipleQuestions.Show();
                }
                else if (rdbTF.Checked)
                {
                    AddTrueFalseQuestion addTrueFalse = new AddTrueFalseQuestion();
                    addTrueFalse.TopLevel = false;
                    pnlQuestions.Controls.Add(addTrueFalse);
                    addTrueFalse.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                    addTrueFalse.Dock = DockStyle.Fill;
                    addTrueFalse.Show();
                }
                else if (true)
                {
                    AddFillBlankQuestions addFillBlankQuestions = new AddFillBlankQuestions();
                    addFillBlankQuestions.TopLevel = false;
                    pnlQuestions.Controls.Add(addFillBlankQuestions);
                    addFillBlankQuestions.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                    addFillBlankQuestions.Dock = DockStyle.Fill;
                    addFillBlankQuestions.Show();
                }
                
            }
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Home home = new Home();
            home.Show();
        }

        private void cmbTopicNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeQuizNumberValue();
        }

        private void ChangeQuizNumberValue()
        {
            long topicNumber = 0;
            QuizMakerRepository quizMakerRepository = new QuizMakerRepository();
            if (!string.IsNullOrEmpty(cmbGrades.Text) && !string.IsNullOrEmpty(cmbSubjects.Text) && !string.IsNullOrEmpty(cmbTopicNo.Text))
            {
                topicNumber = quizMakerRepository.GetMaxQuixNumber(Convert.ToInt64(cmbGrades.SelectedValue), Convert.ToInt64(cmbSubjects.SelectedValue), cmbTopicNo.Text);
                txtQuizNumber.Text = AddToStartOfString(Convert.ToString(topicNumber + 1));

            }

        }
        public static string AddToStartOfString(string s, int digitCount = 5)
        {
            return "Q" + s.PadLeft(digitCount, '0');
        }
    }
}
