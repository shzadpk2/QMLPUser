using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QMLPModels
{
    public class SubjectModel
    {
        public long SubjectID { get; set; }
        public long GradeID { get; set; }
        public string SubjectName { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public int ModifiedBy { get; set; }

    }
}
