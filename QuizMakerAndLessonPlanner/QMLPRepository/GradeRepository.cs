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
    public class GradeRepository
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["QMLPconnectionstring"].ConnectionString;

        public DataTable GetAllGrades()
        {
            DataTable dataTable = new DataTable();
            SqlConnection conn = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand(@"dbo.uspGetAllGrades", conn);
            command.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            dataAdapter.Fill(dataTable);

            return dataTable;
        }

    }

}
