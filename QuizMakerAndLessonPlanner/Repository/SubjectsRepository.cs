using Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Repository
{
    public class SubjectsRepository
    {
        public List<SubjectModel> GetAllSubjects()
        {
            List<SubjectModel> subjectModels = new List<SubjectModel>();
            DataTable dataTable = new DataTable();

            try
            {
                SqlConnection con = new SqlConnection("");

                //SqlCommand cmd = new SqlCommand(SQL, con);
                ////SqlCommand command = new SqlCommand(@"Scheduling.uspGetBlockAppts");
                //command.CommandType = CommandType.StoredProcedure;
                //command.Parameters.AddWithValue("@ProviderID", ProviderID);
                //command.Parameters.AddWithValue("@StartDateTime", StartDateTime);
                //command.Parameters.AddWithValue("@EndDateTime", EndDateTime);
                //OpenConnection();

                //command.Connection = DatabaseContext.Connection;
                //command.Transaction = DatabaseContext.Transaction;

                //SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                //dataAdapter.Fill(dataTable);

                //foreach (DataRow dataRow in dataTable.Rows)
                //{
                //    lstBlockAppts.Add(new BlockedAppointment
                //    {
                //        MasterBlockID = Convert.ToInt32(dataRow["MasterBlockID"].ToString()),
                //        BgColor = dataRow["BgColor"].ToString(),
                //        Type = dataRow["BType"].ToString(),
                //        StartDateTime = DateTime.Parse(dataRow["StartDateTime"].ToString()),
                //        EndDateTime = DateTime.Parse(dataRow["EndDateTime"].ToString()),
                //        BlockID = Convert.ToInt32(dataRow["BlockID"].ToString()),
                //        ProviderID = dataRow["ProviderID"].ToString(),
                //    });
                //}
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
    }
}
