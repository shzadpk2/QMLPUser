using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QMLPModels
{
    public class FillBlankQuestionModel
    {
        public FillBlankQuestionModel()
        {
            QuestionCounter = 0;
        }
        public long QuestionID { get; set; }
        public string QuestionText { get; set; }
        public long QuizMakerID { get; set; }
        public long MainTopicID { get; set; }
        public long SubTopicID { get; set; }

        //True Flase Answer Properties

        //AnswerProperties
        public long AnswerID { get; set; }
        public string AnswerText { get; set; }

        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public int ModifiedBy { get; set; }
        public int QuestionCounter { get; set; }

    }
}
