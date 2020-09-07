using QMLPModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace QMLPRepository
{
    public class QuizMakerRepository
    {
        public List<QuizMakerTopicNumberDetail> GetAllSubTopicDetails(long gradeID, long subjectID)
        {
            List<QuizMakerTopicNumberDetail> quizMakerTopicNumberDetails = new List<QuizMakerTopicNumberDetail>();
            DataTable dataTable = new DataTable();
            try
            {
                SqlConnection conn = new SqlConnection(DbHelper.ConnectionString);

                SqlCommand command = new SqlCommand(@"dbo.uspGetAllSubTopicDetails", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@gradeID", gradeID);
                command.Parameters.AddWithValue("@subjectID", subjectID);

                conn.Open();

                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                dataAdapter.Fill(dataTable);

                foreach (DataRow row in dataTable.Rows)
                {
                    QuizMakerTopicNumberDetail quizMakerTopicNumberDetail = new QuizMakerTopicNumberDetail();

                    quizMakerTopicNumberDetail.TopicID = row["TopicID"] != DBNull.Value ? Convert.ToString(row["TopicID"].ToString()) : string.Empty;
                    quizMakerTopicNumberDetail.TopicNumber = row["TopicNumber"] != DBNull.Value ? Convert.ToString(row["TopicNumber"].ToString()) : string.Empty;


                    quizMakerTopicNumberDetails.Add(quizMakerTopicNumberDetail);
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

            return quizMakerTopicNumberDetails;
        }

        public DataTable GetAllQuizMakers()
        {
            DataTable dataTable = new DataTable();

            SqlConnection conn = new SqlConnection(DbHelper.ConnectionString);

            SqlCommand command = new SqlCommand(@"dbo.uspGetAllQuizMakers", conn);
            command.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            dataAdapter.Fill(dataTable);

            return dataTable;
        }

        public List<QuizMakerModel> GetAllQuizMakersByMainTopicID(long mainTopicID)
        {
            List<QuizMakerModel> quizMakerModels = new List<QuizMakerModel>();
            DataTable dataTable = new DataTable();
            try
            {
                SqlConnection conn = new SqlConnection(DbHelper.ConnectionString);

                SqlCommand command = new SqlCommand(@"dbo.uspGetAllQuizzesByMainTopicID", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@MainTopicID", mainTopicID);

                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                dataAdapter.Fill(dataTable);

                foreach (DataRow row in dataTable.Rows)
                {
                    QuizMakerModel quizMakerModel = new QuizMakerModel();
                    quizMakerModel.QuizMakerID = row["QuizMakerID"] != DBNull.Value ? Convert.ToInt64(row["QuizMakerID"].ToString()) : 0;
                    quizMakerModel.GradeID = row["GradeID"] != DBNull.Value ? Convert.ToInt64(row["GradeID"].ToString()) : 0;
                    quizMakerModel.GradeName = row["GradeName"] != DBNull.Value ? Convert.ToString(row["GradeName"]) : string.Empty;
                    quizMakerModel.SubjectID = row["SubjectID"] != DBNull.Value ? Convert.ToInt64(row["SubjectID"].ToString()) : 0;
                    quizMakerModel.SubjectName = row["SubjectName"] != DBNull.Value ? Convert.ToString(row["SubjectName"]) : string.Empty;
                    quizMakerModel.MainTopicID = row["MainTopicID"] != DBNull.Value ? Convert.ToInt64(row["MainTopicID"].ToString()) : 0;
                    quizMakerModel.MainTopicNumber = row["MainTopicNumber"] != DBNull.Value ? Convert.ToString(row["MainTopicNumber"]) : string.Empty;
                    quizMakerModel.QuizNumber = row["QuizNumber"] != DBNull.Value ? Convert.ToString(row["QuizNumber"]) : string.Empty;
                    //quizMakerModel.SubTopicID = row["SubTopicID"] != DBNull.Value ? Convert.ToInt64(row["SubTopicID"].ToString()) : 0;
                    //quizMakerModel.SubTopicNumber = row["SubTopicNumber"] != DBNull.Value ? Convert.ToString(row["SubTopicNumber"]) : string.Empty;
                    quizMakerModel.TimeLimit = row["TimeLimit"] != DBNull.Value ? Convert.ToString(row["TimeLimit"]) : string.Empty;
                    quizMakerModel.TotalQuestions = row["TotalQuestions"] != DBNull.Value ? Convert.ToString(row["TotalQuestions"]) : string.Empty;
                    quizMakerModel.TotalScore = row["TotalScore"] != DBNull.Value ? Convert.ToString(row["TotalScore"]) : string.Empty;
                    quizMakerModel.Instructions = row["Instructions"] != DBNull.Value ? Convert.ToString(row["Instructions"]) : string.Empty;

                    quizMakerModels.Add(quizMakerModel);
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

            return quizMakerModels;
        }
        public List<QuizMakerModel> GetAllQuizMakersBySubTopicID(long subTopicID)
        {
            List<QuizMakerModel> quizMakerModels = new List<QuizMakerModel>();
            DataTable dataTable = new DataTable();
            try
            {
                SqlConnection conn = new SqlConnection(DbHelper.ConnectionString);

                SqlCommand command = new SqlCommand(@"dbo.uspGetAllQuizzesBySubTopicID", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@SubTopicID", subTopicID);

                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                dataAdapter.Fill(dataTable);

                foreach (DataRow row in dataTable.Rows)
                {
                    QuizMakerModel quizMakerModel = new QuizMakerModel();
                    quizMakerModel.QuizMakerID = row["QuizMakerID"] != DBNull.Value ? Convert.ToInt64(row["QuizMakerID"].ToString()) : 0;
                    quizMakerModel.GradeID = row["GradeID"] != DBNull.Value ? Convert.ToInt64(row["GradeID"].ToString()) : 0;
                    quizMakerModel.GradeName = row["GradeName"] != DBNull.Value ? Convert.ToString(row["GradeName"]) : string.Empty;
                    quizMakerModel.SubjectID = row["SubjectID"] != DBNull.Value ? Convert.ToInt64(row["SubjectID"].ToString()) : 0;
                    quizMakerModel.SubjectName = row["SubjectName"] != DBNull.Value ? Convert.ToString(row["SubjectName"]) : string.Empty;
                    quizMakerModel.SubTopicID = row["SubTopicID"] != DBNull.Value ? Convert.ToInt64(row["SubTopicID"].ToString()) : 0;
                    quizMakerModel.SubTopicNumber = row["SubTopicNumber"] != DBNull.Value ? Convert.ToString(row["SubTopicNumber"]) : string.Empty;
                    quizMakerModel.QuizNumber = row["QuizNumber"] != DBNull.Value ? Convert.ToString(row["QuizNumber"]) : string.Empty;
                    quizMakerModel.TimeLimit = row["TimeLimit"] != DBNull.Value ? Convert.ToString(row["TimeLimit"]) : string.Empty;
                    quizMakerModel.TotalQuestions = row["TotalQuestions"] != DBNull.Value ? Convert.ToString(row["TotalQuestions"]) : string.Empty;
                    quizMakerModel.TotalScore = row["TotalScore"] != DBNull.Value ? Convert.ToString(row["TotalScore"]) : string.Empty;
                    quizMakerModel.Instructions = row["Instructions"] != DBNull.Value ? Convert.ToString(row["Instructions"]) : string.Empty;

                    quizMakerModels.Add(quizMakerModel);
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

            return quizMakerModels;
        }

        public long SaveUpdateQuizMaker(DataTable dataTablequizMaker, DataTable dataTableMultipleQuestions, DataTable dataTableTrueFalseQuestion, DataTable dataTablefillBlankQuestion)
        {
            long result = 0;

            SqlConnection conn = new SqlConnection(DbHelper.ConnectionString);

            try
            {
                SqlCommand command = new SqlCommand(@"dbo.uspSaveQuizMaker", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@QuizMakerUDT", dataTablequizMaker);
                command.Parameters.AddWithValue("@MultipleQuesionsUDT", dataTableMultipleQuestions);
                command.Parameters.AddWithValue("@TrueFalseQuesionsUDT", dataTableTrueFalseQuestion);
                command.Parameters.AddWithValue("@FillBlankQuesionsUDT", dataTablefillBlankQuestion);

                conn.Open();
                //command.Connection = DatabaseContext.Connection;
                //command.Transaction = DatabaseContext.Transaction;

                result = Convert.ToInt64(command.ExecuteScalar());
                conn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }


            return result;
        }

        public long SaveMoreQuestions(DataTable dataTableMultipleQuestions, DataTable dataTableTrueFalseQuestion, DataTable dataTablefillBlankQuestion)
        {
            long result = 0;

            SqlConnection conn = new SqlConnection(DbHelper.ConnectionString);

            try
            {
                SqlCommand command = new SqlCommand(@"dbo.uspSaveMoreQuestions", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@MultipleQuesionsUDT", dataTableMultipleQuestions);
                command.Parameters.AddWithValue("@TrueFalseQuesionsUDT", dataTableTrueFalseQuestion);
                command.Parameters.AddWithValue("@FillBlankQuesionsUDT", dataTablefillBlankQuestion);

                conn.Open();
                //command.Connection = DatabaseContext.Connection;
                //command.Transaction = DatabaseContext.Transaction;

                result = Convert.ToInt64(command.ExecuteScalar());
                conn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }


            return result;
        }

        public long GetMaxQuixNumber(long gradeID, long subjectID, string topicNumber)
        {
            long result = 0;
            SqlConnection conn = new SqlConnection(DbHelper.ConnectionString);

            try
            {
                SqlCommand command = new SqlCommand(@"dbo.uspGetMaxTopicNumber", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@GradeID", gradeID);
                command.Parameters.AddWithValue("@SubjectID", subjectID);
                command.Parameters.AddWithValue("@TopicNumber", topicNumber);

                conn.Open();
                //command.Connection = DatabaseContext.Connection;
                //command.Transaction = DatabaseContext.Transaction;

                result = Convert.ToInt64(command.ExecuteScalar());
                conn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }

            return result;
        }

        public int DeleteMultipleQuestionByQuestionID(long questionID)
        {

            string strSql = "DELETE FROM MultipleQuestion WHERE QuestionID = " + questionID + "; DELETE MultipleQuestionAnswer WHERE MultipleQuestionID =" + questionID;

            int rows = 0;

            rows = DbHelper.ExecuteSql(strSql.ToString());

            return rows;
        }
        public List<MultipleQuestionModel> GetAllMultipleQuestionsByQuizMakerID(long quizMakerID)
        {
            List<MultipleQuestionModel> multipleQuestionModels = new List<MultipleQuestionModel>();
            DataTable dataTable = new DataTable();
            try
            {
                SqlConnection conn = new SqlConnection(DbHelper.ConnectionString);

                SqlCommand command = new SqlCommand(@"dbo.uspGetAllMultipleQuestionsByQuizMakerID", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@QuizMakerID", quizMakerID);

                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                dataAdapter.Fill(dataTable);

                foreach (DataRow row in dataTable.Rows)
                {
                    MultipleQuestionModel multipleQuestionModel = new MultipleQuestionModel();
                    multipleQuestionModel.QuestionID = row["QuestionID"] != DBNull.Value ? Convert.ToInt64(row["QuestionID"].ToString()) : 0;
                    multipleQuestionModel.QuizMakerID = row["QuizMakerID"] != DBNull.Value ? Convert.ToInt64(row["QuizMakerID"].ToString()) : 0;
                    multipleQuestionModel.QuestionText = row["QuestionText"] != DBNull.Value ? Convert.ToString(row["QuestionText"]) : string.Empty;
                    multipleQuestionModel.NoOfOption = row["NoOfOptions"] != DBNull.Value ? Convert.ToInt32(row["NoOfOptions"].ToString()) : 0;
                    multipleQuestionModel.OptionOneText = row["OptionOneText"] != DBNull.Value ? Convert.ToString(row["OptionOneText"]) : string.Empty;
                    multipleQuestionModel.OptionTwoText = row["OptionTwoText"] != DBNull.Value ? Convert.ToString(row["OptionTwoText"]) : string.Empty;
                    multipleQuestionModel.OptionThreeText = row["OptionThreeText"] != DBNull.Value ? Convert.ToString(row["OptionThreeText"]) : string.Empty;
                    multipleQuestionModel.OptionFourText = row["OptionFourText"] != DBNull.Value ? Convert.ToString(row["OptionFourText"]) : string.Empty;
                    multipleQuestionModel.AnswerOptionNo = row["AnswerOption"] != DBNull.Value ? Convert.ToInt32(row["AnswerOption"].ToString()) : 0;
                    multipleQuestionModels.Add(multipleQuestionModel);
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

            return multipleQuestionModels;
        }

        public int DeleteTrueFalseQuestionByQuestionID(long questionID)
        {

            string strSql = "DELETE FROM TrueFalseQuestion WHERE QuestionID = " + questionID;

            int rows = 0;

            rows = DbHelper.ExecuteSql(strSql.ToString());

            return rows;
        }
        public List<TrueFalseQuestionModel> GetAllTrueQuestionsByQuizMakerID(long quizMakerID)
        {
            List<TrueFalseQuestionModel> trueFalseQuestionModels = new List<TrueFalseQuestionModel>();
            DataTable dataTable = new DataTable();
            try
            {
                SqlConnection conn = new SqlConnection(DbHelper.ConnectionString);

                SqlCommand command = new SqlCommand(@"dbo.uspGetAllTrueFalseQuestionsByQuizMakerID", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@QuizMakerID", quizMakerID);

                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                dataAdapter.Fill(dataTable);

                foreach (DataRow row in dataTable.Rows)
                {
                    TrueFalseQuestionModel trueFalseQuestionModel = new TrueFalseQuestionModel();
                    trueFalseQuestionModel.QuestionID = row["QuestionID"] != DBNull.Value ? Convert.ToInt64(row["QuestionID"].ToString()) : 0;
                    trueFalseQuestionModel.QuizMakerID = row["QuizMakerID"] != DBNull.Value ? Convert.ToInt64(row["QuizMakerID"].ToString()) : 0;
                    trueFalseQuestionModel.TrueText = row["TrueText"] != DBNull.Value ? Convert.ToString(row["TrueText"]) : string.Empty;
                    trueFalseQuestionModel.FalseText = row["FalseText"] != DBNull.Value ? Convert.ToString(row["FalseText"]) : string.Empty;

                    trueFalseQuestionModels.Add(trueFalseQuestionModel);
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

            return trueFalseQuestionModels;
        }

        public int DeleteFillBlankQuestionByQuestionID(long questionID)
        {

            string strSql = "DELETE FROM FillBlankQuestion WHERE QuestionID = " + questionID + "; DELETE FillBlankQuestionAnswer WHERE FillBlankQuestionID =" + questionID;

            int rows = 0;

            rows = DbHelper.ExecuteSql(strSql.ToString());

            return rows;
        }
        public List<FillBlankQuestionModel> GetAllFillBlankQuestionsByQuizMakerID(long quizMakerID)
        {
            List<FillBlankQuestionModel> fillBlankQuestionModels = new List<FillBlankQuestionModel>();
            DataTable dataTable = new DataTable();
            try
            {
                SqlConnection conn = new SqlConnection(DbHelper.ConnectionString);

                SqlCommand command = new SqlCommand(@"dbo.uspGetAllFillBlankQuestionsByQuizMakerID", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@QuizMakerID", quizMakerID);

                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                dataAdapter.Fill(dataTable);

                foreach (DataRow row in dataTable.Rows)
                {
                    FillBlankQuestionModel fillBlankQuestionModel = new FillBlankQuestionModel();
                    fillBlankQuestionModel.QuestionID = row["QuestionID"] != DBNull.Value ? Convert.ToInt64(row["QuestionID"].ToString()) : 0;
                    fillBlankQuestionModel.QuizMakerID = row["QuizMakerID"] != DBNull.Value ? Convert.ToInt64(row["QuizMakerID"].ToString()) : 0;
                    fillBlankQuestionModel.QuestionText = row["QuestionText"] != DBNull.Value ? Convert.ToString(row["QuestionText"]) : string.Empty;
                    fillBlankQuestionModel.AnswerText = row["AnswerText"] != DBNull.Value ? Convert.ToString(row["AnswerText"]) : string.Empty;

                    fillBlankQuestionModels.Add(fillBlankQuestionModel);
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

            return fillBlankQuestionModels;
        }
    }
}
