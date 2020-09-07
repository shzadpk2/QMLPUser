using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QMLPModels
{
    public class MoviesModel
    {
		public long MovieID { get; set; }
		public string MovieDescription { get; set; }
		public long MainTopicID { get; set; }

		public string MainTopicNumber { get; set; }
		public DateTime CreatedOn { get; set; }
		public int CreatedBy { get; set; }
		public DateTime ModifiedOn { get; set; }
		public int ModifiedBy { get; set; }
	}
}
