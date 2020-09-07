using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QMLPModels
{
    public class MainTopicModel
    {
        public long MainTopicID { get; set; }
        public string MainTopicNumber { get; set; }
        public string MainTopicTitle { get; set; }
        public long LessonPlannerID { get; set; }
        
        public string Introduction { get; set; }
        public string Objectives { get; set; }
        public string Material { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public int ModifiedBy { get; set; }
    }
}
