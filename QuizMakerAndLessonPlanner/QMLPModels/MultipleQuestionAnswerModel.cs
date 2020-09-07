using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QMLPModels
{
    public class MultipleQuestionAnswerModel
    {
        public long AnswerID { get; set; }
        public long QuestionID { get; set; }
        public int OptionNo { get; set; }
        public string OptionText { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public int ModifiedBy { get; set; }
        

    }
}
