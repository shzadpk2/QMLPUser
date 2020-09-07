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
    public partial class AddTrueFalseQuestion : Form
    {
        private long _quizMakeID = 0;

        public AddTrueFalseQuestion()
        {
            InitializeComponent();
        }
        public AddTrueFalseQuestion(long quizMakerID)
        {
            _quizMakeID = quizMakerID;
            InitializeComponent();
        }

        private void btnAddTrueFalseQuestion_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTrue.Text))
            {
                MessageBox.Show("True statement can't be blank!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(txtFlase.Text))
            {
                MessageBox.Show("False statement can't be blank!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (_quizMakeID == 0)
            {
                TrueFalseQuestionModel trueFalseQuestionModel = new TrueFalseQuestionModel();

                trueFalseQuestionModel.TrueText = txtTrue.Text;
                trueFalseQuestionModel.FalseText = txtFlase.Text;
                trueFalseQuestionModel.QuizMakerID = 0;
                trueFalseQuestionModel.MainTopicID = 0;
                trueFalseQuestionModel.SubTopicID = 0;


                trueFalseQuestionModel.CreatedOn = DateTime.Now;
                trueFalseQuestionModel.CreatedBy = 1;
                trueFalseQuestionModel.ModifiedOn = DateTime.Now;
                trueFalseQuestionModel.ModifiedBy = 1;

                if (QuizMaker.trueFalseQuestionModelsGlobal != null && QuizMaker.trueFalseQuestionModelsGlobal.Count > 0)
                {
                    trueFalseQuestionModel.QuestionCounter = QuizMaker.trueFalseQuestionModelsGlobal.Max(x => x.QuestionCounter) + 1;
                }
                else
                {
                    trueFalseQuestionModel.QuestionCounter = 1;
                }

                QuizMaker.trueFalseQuestionModelsGlobal.Add(trueFalseQuestionModel);
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
                TrueFalseQuestionModel trueFalseQuestionModel = new TrueFalseQuestionModel();

                trueFalseQuestionModel.TrueText = txtTrue.Text;
                trueFalseQuestionModel.FalseText = txtFlase.Text;
                trueFalseQuestionModel.QuizMakerID = _quizMakeID;
                trueFalseQuestionModel.MainTopicID = 0;
                trueFalseQuestionModel.SubTopicID = 0;


                trueFalseQuestionModel.CreatedOn = DateTime.Now;
                trueFalseQuestionModel.CreatedBy = 1;
                trueFalseQuestionModel.ModifiedOn = DateTime.Now;
                trueFalseQuestionModel.ModifiedBy = 1;

                if (AddMoreQuestions.addMoreTrueFalseQuestionModelsGlobal != null && AddMoreQuestions.addMoreTrueFalseQuestionModelsGlobal.Count > 0)
                {
                    trueFalseQuestionModel.QuestionCounter = AddMoreQuestions.addMoreTrueFalseQuestionModelsGlobal.Max(x => x.QuestionCounter) + 1;
                }
                else
                {
                    trueFalseQuestionModel.QuestionCounter = 1;
                }

                AddMoreQuestions.addMoreTrueFalseQuestionModelsGlobal.Add(trueFalseQuestionModel);
                
            }
            this.Close();
        }

        private void btnCancelTrueFalseQuestion_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
