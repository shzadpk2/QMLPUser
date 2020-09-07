using QMLPModels;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QMLPRepository
{
    public class SubjectsRepository
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["QMLPconnectionstring"].ConnectionString;

        public List<SubjectModel> GetAllSubjects()
        {
            List<SubjectModel> subjectModels = new List<SubjectModel>();
            DataTable dataTable = new DataTable();
            try
            {
                SqlConnection conn = new SqlConnection(connectionString);

                SqlCommand command = new SqlCommand(@"dbo.uspGetAllSubjects", conn);
                command.CommandType = CommandType.StoredProcedure;
                //command.Parameters.AddWithValue("@ProviderID", ProviderID);

                conn.Open();

                //command.Connection = DatabaseContext.Connection;
                //command.Transaction = DatabaseContext.Transaction;

                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                dataAdapter.Fill(dataTable);

                foreach (DataRow row in dataTable.Rows)
                {
                    SubjectModel subjectModel = new SubjectModel();
                    subjectModel.SubjectID = row["SubjectID"] != DBNull.Value ? Convert.ToInt32(row["SubjectID"].ToString()) : 0;
                    subjectModel.SubjectName = row["SubjectName"] != DBNull.Value ? Convert.ToString(row["SubjectName"]) : string.Empty;

                    subjectModels.Add(subjectModel);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {

                dataTable.Clear();
                dataTable = null;
            }

            return subjectModels;
        }
        public DataTable GetAllSubjectsByGradeID(long gradeID)
        {
            DataTable dataTable = new DataTable();

            SqlConnection conn = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand(@"dbo.uspGetAllSubjectsByGradeID", conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@GradeID", gradeID);

            conn.Open();

            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            dataAdapter.Fill(dataTable);
            conn.Close();



            return dataTable;
        }

    }

}
