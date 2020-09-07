using Microsoft.Win32;
using QMLPModels;
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
    public partial class AddMultipleQuestions : Form
    {
        public int numerOfOptions = 0;
        private long _quizMakeID = 0;
        public AddMultipleQuestions()
        {
            InitializeComponent();
        }

        public AddMultipleQuestions(long quizMakerID)
        {
            _quizMakeID = quizMakerID;
            InitializeComponent();
        }

        public AddMultipleQuestions(int numerOfOptions)
        {
            InitializeComponent();
        }

        private void AddMultipleQuestions_Load(object sender, EventArgs e)
        {
            ShowQuestionOptions(numerOfOptions);
        }
        private class CmbAnswers
        {
            public string _Name;
            public string _Id;

            public CmbAnswers(string name, string id)
            {
                _Name = name;
                _Id = id;
            }

            public string Name
            {
                get { return _Name; }
                set { _Name = value; }
            }

            public string Id
            {
                get { return _Id; }
                set { _Id = value; }
            }
        }
        private void ShowQuestionOptions(int numberOfOptions)
        {
            cmbAnswers.DisplayMember = "Name";
            cmbAnswers.ValueMember = "Id";

            if (numerOfOptions == 1)
            {
                lblOption1.Visible = true;
                txtOption1.Visible = true;

                cmbAnswers.Items.Add(new CmbAnswers("Option1", "1"));
            }
            else if (numerOfOptions == 2)
            {
                lblOption1.Visible = true;
                txtOption1.Visible = true;
                lblOption2.Visible = true;
                txtOption2.Visible = true;

                cmbAnswers.Items.Add(new CmbAnswers("Option1", "1"));
                cmbAnswers.Items.Add(new CmbAnswers("Option2", "2"));
            }
            else if (numerOfOptions == 3)
            {
                lblOption1.Visible = true;
                txtOption1.Visible = true;
                lblOption2.Visible = true;
                txtOption2.Visible = true;
                lblOption3.Visible = true;
                txtOption3.Visible = true;

                cmbAnswers.Items.Add(new CmbAnswers("Option1", "1"));
                cmbAnswers.Items.Add(new CmbAnswers("Option2", "2"));
                cmbAnswers.Items.Add(new CmbAnswers("Option3", "3"));
            }
            else if (numerOfOptions == 4)
            {
                lblOption1.Visible = true;
                txtOption1.Visible = true;
                lblOption2.Visible = true;
                txtOption2.Visible = true;
                lblOption3.Visible = true;
                txtOption3.Visible = true;
                lblOption4.Visible = true;
                txtOption4.Visible = true;

                cmbAnswers.Items.Add(new CmbAnswers("Option1", "1"));
                cmbAnswers.Items.Add(new CmbAnswers("Option2", "2"));
                cmbAnswers.Items.Add(new CmbAnswers("Option3", "3"));
                cmbAnswers.Items.Add(new CmbAnswers("Option4", "4"));
            }
        }

        private void btnAddMultipleQuestion_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtQuestion.Text))
            {
                MessageBox.Show("Question can't be blank!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (numerOfOptions == 1)
            {
                if (string.IsNullOrEmpty(txtOption1.Text))
                {
                    MessageBox.Show("Option1 can't be blank!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else if (numerOfOptions == 2)
            {
                if (string.IsNullOrEmpty(txtOption1.Text))
                {
                    MessageBox.Show("Option1 can't be blank!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (string.IsNullOrEmpty(txtOption2.Text))
                {
                    MessageBox.Show("Option2 can't be blank!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else if (numerOfOptions == 3)
            {
                if (string.IsNullOrEmpty(txtOption1.Text))
                {
                    MessageBox.Show("Option1 can't be blank!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (string.IsNullOrEmpty(txtOption2.Text))
                {
                    MessageBox.Show("Option2 can't be blank!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (string.IsNullOrEmpty(txtOption3.Text))
                {
                    MessageBox.Show("Option3 can't be blank!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else if (numerOfOptions == 4)
            {
                if (string.IsNullOrEmpty(txtOption1.Text))
                {
                    MessageBox.Show("Option1 can't be blank!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (string.IsNullOrEmpty(txtOption2.Text))
                {
                    MessageBox.Show("Option2 can't be blank!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (string.IsNullOrEmpty(txtOption3.Text))
                {
                    MessageBox.Show("Option3 can't be blank!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (string.IsNullOrEmpty(txtOption4.Text))
                {
                    MessageBox.Show("Option4 can't be blank!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            if (string.IsNullOrEmpty(cmbAnswers.Text))
            {
                MessageBox.Show("Answer can't be blank!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (_quizMakeID == 0)
            {
                MultipleQuestionModel multipleQuestionModel = new MultipleQuestionModel();

                multipleQuestionModel.QuestionText = txtQuestion.Text;
                multipleQuestionModel.NoOfOption = numerOfOptions;
                multipleQuestionModel.QuizMakerID = 0;
                multipleQuestionModel.MainTopicID = 0;
                multipleQuestionModel.SubTopicID = 0;
                multipleQuestionModel.OptionOneText = txtOption1.Text;
                multipleQuestionModel.OptionTwoText = txtOption2.Text;
                multipleQuestionModel.OptionThreeText = txtOption3.Text;
                multipleQuestionModel.OptionFourText = txtOption4.Text;

                switch (cmbAnswers.Text)
                {
                    case "Option1":
                        multipleQuestionModel.AnswerOptionNo = 1;
                        break;
                    case "Option2":
                        multipleQuestionModel.AnswerOptionNo = 2;
                        break;
                    case "Option3":
                        multipleQuestionModel.AnswerOptionNo = 3;
                        break;
                    case "Option4":
                        multipleQuestionModel.AnswerOptionNo = 4;
                        break;
                    default:
                        multipleQuestionModel.AnswerOptionNo = 0;
                        break;
                }

                multipleQuestionModel.AnswerOptionText = cmbAnswers.Text;

                multipleQuestionModel.CreatedOn = DateTime.Now;
                multipleQuestionModel.CreatedBy = 1;
                multipleQuestionModel.ModifiedOn = DateTime.Now;
                multipleQuestionModel.ModifiedBy = 1;

                if (QuizMaker.multipleQuestionModelsGlobal != null && QuizMaker.multipleQuestionModelsGlobal.Count > 0)
                {
                    multipleQuestionModel.QuestionCounter = QuizMaker.multipleQuestionModelsGlobal.Max(x => x.QuestionCounter) + 1;
                }
                else
                {
                    multipleQuestionModel.QuestionCounter = 1;
                }

                QuizMaker.multipleQuestionModelsGlobal.Add(multipleQuestionModel);

                if (QuizMaker.multipleQuestionModelsGlobal != null)
                {
                    QuizMaker quiz = (QuizMaker)Application.OpenForms["QuizMaker"];
                    if (quiz != null)
                    {
                        int totalQuestions = QuizMaker.multipleQuestionModelsGlobal.Count() + QuizMaker.trueFalseQuestionModelsGlobal.Count() + QuizMaker.fillBlankQuestionModelsGlobal.Count();
                        quiz.txtTotalQuestions.Text = totalQuestions.ToString();
                    }
                }
            }
            else
            {
                MultipleQuestionModel multipleQuestionModel = new MultipleQuestionModel();

                multipleQuestionModel.QuestionText = txtQuestion.Text;
                multipleQuestionModel.NoOfOption = numerOfOptions;
                multipleQuestionModel.QuizMakerID = _quizMakeID;
                multipleQuestionModel.MainTopicID = 0;
                multipleQuestionModel.SubTopicID = 0;
                multipleQuestionModel.OptionOneText = txtOption1.Text;
                multipleQuestionModel.OptionTwoText = txtOption2.Text;
                multipleQuestionModel.OptionThreeText = txtOption3.Text;
                multipleQuestionModel.OptionFourText = txtOption4.Text;

                switch (cmbAnswers.Text)
                {
                    case "Option1":
                        multipleQuestionModel.AnswerOptionNo = 1;
                        break;
                    case "Option2":
                        multipleQuestionModel.AnswerOptionNo = 2;
                        break;
                    case "Option3":
                        multipleQuestionModel.AnswerOptionNo = 3;
                        break;
                    case "Option4":
                        multipleQuestionModel.AnswerOptionNo = 4;
                        break;
                    default:
                        multipleQuestionModel.AnswerOptionNo = 0;
                        break;
                }

                multipleQuestionModel.AnswerOptionText = cmbAnswers.Text;

                multipleQuestionModel.CreatedOn = DateTime.Now;
                multipleQuestionModel.CreatedBy = 1;
                multipleQuestionModel.ModifiedOn = DateTime.Now;
                multipleQuestionModel.ModifiedBy = 1;

                if (AddMoreQuestions.addMoreMultipleQuestionModelsGlobal != null && AddMoreQuestions.addMoreMultipleQuestionModelsGlobal.Count > 0)
                {
                    multipleQuestionModel.QuestionCounter = AddMoreQuestions.addMoreMultipleQuestionModelsGlobal.Max(x => x.QuestionCounter) + 1;
                }
                else
                {
                    multipleQuestionModel.QuestionCounter = 1;
                }

                AddMoreQuestions.addMoreMultipleQuestionModelsGlobal.Add(multipleQuestionModel);
            }
            this.Close();
        }

        private void btnCancelMultipleQuestion_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
