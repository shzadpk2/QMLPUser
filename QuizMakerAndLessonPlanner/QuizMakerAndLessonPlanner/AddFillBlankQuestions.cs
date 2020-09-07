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
    public partial class AddFillBlankQuestions : Form
    {
        private long _quizMakeID = 0;
        public AddFillBlankQuestions()
        {
            InitializeComponent();
        }
        public AddFillBlankQuestions(long quizMakerID)
        {
            _quizMakeID = quizMakerID;
            InitializeComponent();
        }

        private void btnAddFillBlankQuestion_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtQuestion.Text))
            {
                MessageBox.Show("Question can't be blank!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(txtAnswer.Text))
            {
                MessageBox.Show("Answer can't be blank!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_quizMakeID == 0)
            {
                FillBlankQuestionModel fillBlankQuestionModel = new FillBlankQuestionModel();

                fillBlankQuestionModel.QuestionText = txtQuestion.Text;
                fillBlankQuestionModel.QuizMakerID = 0;
                fillBlankQuestionModel.MainTopicID = 0;
                fillBlankQuestionModel.SubTopicID = 0;

                fillBlankQuestionModel.AnswerText = txtAnswer.Text;

                fillBlankQuestionModel.CreatedOn = DateTime.Now;
                fillBlankQuestionModel.CreatedBy = 1;
                fillBlankQuestionModel.ModifiedOn = DateTime.Now;
                fillBlankQuestionModel.ModifiedBy = 1;

                if (QuizMaker.fillBlankQuestionModelsGlobal != null && QuizMaker.fillBlankQuestionModelsGlobal.Count > 0)
                {
                    fillBlankQuestionModel.QuestionCounter = QuizMaker.fillBlankQuestionModelsGlobal.Max(x => x.QuestionCounter) + 1;
                }
                else
                {
                    fillBlankQuestionModel.QuestionCounter = 1;
                }

                QuizMaker.fillBlankQuestionModelsGlobal.Add(fillBlankQuestionModel);
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
                FillBlankQuestionModel fillBlankQuestionModel = new FillBlankQuestionModel();

                fillBlankQuestionModel.QuestionText = txtQuestion.Text;
                fillBlankQuestionModel.QuizMakerID = _quizMakeID;
                fillBlankQuestionModel.MainTopicID = 0;
                fillBlankQuestionModel.SubTopicID = 0;

                fillBlankQuestionModel.AnswerText = txtAnswer.Text;

                fillBlankQuestionModel.CreatedOn = DateTime.Now;
                fillBlankQuestionModel.CreatedBy = 1;
                fillBlankQuestionModel.ModifiedOn = DateTime.Now;
                fillBlankQuestionModel.ModifiedBy = 1;

                if (AddMoreQuestions.addMoreFillBlankQuestionModelsGlobal != null && AddMoreQuestions.addMoreFillBlankQuestionModelsGlobal.Count > 0)
                {
                    fillBlankQuestionModel.QuestionCounter = AddMoreQuestions.addMoreFillBlankQuestionModelsGlobal.Max(x => x.QuestionCounter) + 1;
                }
                else
                {
                    fillBlankQuestionModel.QuestionCounter = 1;
                }

                AddMoreQuestions.addMoreFillBlankQuestionModelsGlobal.Add(fillBlankQuestionModel);
                
            }
            this.Close();
        }
        private void btnCancelFillBlankQuestion_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearFields()
        {
            txtQuestion.Text = "";
            txtAnswer.Text = "";
        }
    }
}
