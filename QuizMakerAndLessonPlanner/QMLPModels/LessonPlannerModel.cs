using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QMLPModels
{
    public class LessonPlannerModel
    {
        public long LessonPlannerID { get; set; }
        public long GradeID { get; set; }
        public string GradeName { get; set; }
        public long SubjectID { get; set; }
        public string SubjectName { get; set; }
        public long MainTopicID { get; set; }
        public string MainTopicNumber { get; set; }
        public string TitleMainTopic { get; set; }
        public string Introduction { get; set; }
        public string Objectives { get; set; }
        public string Material { get; set; }
        public DateTime CreatedOn { get; set; }
        public int  CreatedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public int ModifiedBy { get; set; }

        public List<SubTopicModel> subTopicModels { get; set; }
        public List<GamesModel> gamesModels { get; set; }
        public List<MoviesModel> moviesModels { get; set; }
        public List<DocumentariesModel> documentariesModels { get; set; }
        public List<BooksModel> booksModels { get; set; }

    }
}
