using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QMLPModels
{
    public class DocumentariesModel
    {
		public long DocumentaryID { get; set; }
		public string DocumentaryDescription { get; set; }
		public long MainTopicID { get; set; }

		public string MainTopicNumber { get; set; }
		public DateTime CreatedOn { get; set; }
		public int CreatedBy { get; set; }
		public DateTime ModifiedOn { get; set; }
		public int ModifiedBy { get; set; }
	}
}
