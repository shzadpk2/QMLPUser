using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QMLPModels
{
    public class SubTopicModel
    {
        public long SubTopicID { get; set; }
        public long MainTopicID { get; set; }
        public string MainTopicNumber { get; set; }
        public string SubTopicNumber { get; set; }
        public string SubTopicTitle { get; set; }
        public string Introduction { get; set; }
        public string Objectives { get; set; }
        public string Material { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public int ModifiedBy { get; set; }
    }
}
