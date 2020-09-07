using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class SubjectModel
    {
        public int SubjectID { get; set; }
        public string SubjectName { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public int ModifiedBy { get; set; }

    }
}
