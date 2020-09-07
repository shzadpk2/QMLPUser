using QMLPModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QMLPRepository
{
    public class LessonPlannerRepository
    {
        public long GetMaxMainTopic(long gradeID, long subjectID)
        {
            long result = 0;
            SqlConnection conn = new SqlConnection(DbHelper.ConnectionString);

            try
            {
                SqlCommand command = new SqlCommand(@"dbo.uspGetMaxMainTopic", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@GradeID", gradeID);
                command.Parameters.AddWithValue("@SubjectID", subjectID);

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
        public long SaveUpdateLessonPlanner(LessonPlannerModel lessonPlannerModel)
        {
            long result = 0;
            if (lessonPlannerModel != null)
            {
                if (lessonPlannerModel.LessonPlannerID == 0)  //Add
                {
                    StringBuilder strSql = new StringBuilder();
                    strSql.Append("DECLARE @SeedValue INT ");
                    strSql.Append("SET @SeedValue = (SELECT ISNULL(MAX(LessonPlannerID), 0) FROM dbo.LessonPlanner) ");
                    strSql.Append("DBCC CHECKIDENT('dbo.LessonPlanner',RESEED,@SeedValue)");
                    strSql.Append("INSERT INTO LessonPlanner(");
                    strSql.Append("GradeID,Grade,SubjectID,Introduction,Objectives,");
                    strSql.Append("Material,CreatedOn,CreatedBy,ModifiedOn,ModifiedBy)");
                    strSql.Append(" VALUES (");
                    strSql.Append("@GradeID,@Grade,@SubjectID,@Introduction,@Objectives,@Material,");
                    strSql.Append("@CreatedOn,@CreatedBy,@ModifiedOn,@ModifiedBy)");
                    strSql.Append(";SELECT SCOPE_IDENTITY()");
                    SqlParameter[] parameters = {
                    new SqlParameter("@GradeID", SqlDbType.BigInt),
                    new SqlParameter("@Grade", SqlDbType.NVarChar,300),
                    new SqlParameter("@SubjectID", SqlDbType.BigInt),
                    new SqlParameter("@Introduction", SqlDbType.NVarChar,-1),
                    new SqlParameter("@Objectives", SqlDbType.NVarChar,-1),
                    new SqlParameter("@Material", SqlDbType.NVarChar,-1),
                    new SqlParameter("@CreatedOn", SqlDbType.DateTime),
                    new SqlParameter("@CreatedBy", SqlDbType.Int),
                    new SqlParameter("@ModifiedOn", SqlDbType.DateTime),
                    new SqlParameter("@ModifiedBy", SqlDbType.Int)
                };
                    parameters[0].Value = lessonPlannerModel.GradeID;
                    parameters[1].Value = lessonPlannerModel.GradeName;
                    parameters[2].Value = lessonPlannerModel.SubjectID;
                    parameters[3].Value = lessonPlannerModel.Introduction;
                    parameters[4].Value = lessonPlannerModel.Objectives;
                    parameters[5].Value = lessonPlannerModel.Material;
                    parameters[6].Value = lessonPlannerModel.CreatedOn;
                    parameters[7].Value = lessonPlannerModel.CreatedBy;
                    parameters[8].Value = lessonPlannerModel.ModifiedOn;
                    parameters[9].Value = lessonPlannerModel.ModifiedBy;

                    object obj = DbHelper.GetSingle(strSql.ToString(), parameters);
                    if (obj == null)
                    {
                        result = 0;
                    }
                    else
                    {
                        result = Convert.ToInt64(obj);
                    }
                }
                else
                {
                    StringBuilder strSql = new StringBuilder();
                    strSql.Append("UPDATE LessonPlanner SET ");
                    strSql.Append("GradeID=@GradeID,Grade=@Grade,SubjectID=@SubjectID,");
                    strSql.Append("Introduction=@Introduction,Objectives=@Objectives,");
                    strSql.Append("Material=@Material,ModifiedOn=@ModifiedOn,ModifiedBy=@ModifiedBy");
                    strSql.Append(" where LessonPlannerID=@LessonPlannerID");

                    SqlParameter[] parameters = {
                    new SqlParameter("@GradeID", SqlDbType.Int),
                    new SqlParameter("@Grade", SqlDbType.NVarChar,300),
                    new SqlParameter("@SubjectID", SqlDbType.Int),
                    new SqlParameter("@Introduction", SqlDbType.NVarChar,-1),
                    new SqlParameter("@Objectives", SqlDbType.NVarChar,-1),
                    new SqlParameter("@Material", SqlDbType.NVarChar,-1),
                    new SqlParameter("@CreatedOn", SqlDbType.DateTime),
                    new SqlParameter("@CreatedBy", SqlDbType.Int),
                    new SqlParameter("@ModifiedOn", SqlDbType.DateTime),
                    new SqlParameter("@ModifiedBy", SqlDbType.Int),
                    new SqlParameter("@LessonPlannerID", SqlDbType.BigInt,4)};
                    parameters[0].Value = lessonPlannerModel.GradeID;
                    parameters[1].Value = lessonPlannerModel.GradeName;
                    parameters[2].Value = lessonPlannerModel.SubjectID;
                    parameters[3].Value = lessonPlannerModel.Introduction;
                    parameters[4].Value = lessonPlannerModel.Objectives;
                    parameters[5].Value = lessonPlannerModel.Material;
                    parameters[6].Value = lessonPlannerModel.CreatedOn;
                    parameters[7].Value = lessonPlannerModel.CreatedBy;
                    parameters[8].Value = lessonPlannerModel.ModifiedOn;
                    parameters[9].Value = lessonPlannerModel.ModifiedBy;
                    parameters[10].Value = lessonPlannerModel.LessonPlannerID;

                    result = DbHelper.ExecuteSql(strSql.ToString(), parameters);
                    result = lessonPlannerModel.LessonPlannerID;
                }
            }

            if (result > 0)
            {
                AddUpdateMainTopic(lessonPlannerModel, result);
            }

            return result;
        }

        public long AddUpdateMainTopic(LessonPlannerModel lessonPlannerModel, long lessonPlannerID)
        {
            long result = 0;
            if (lessonPlannerModel != null)
            {
                if (lessonPlannerModel.MainTopicID == 0)  //Add
                {
                    StringBuilder strSql = new StringBuilder();
                    strSql.Append("DECLARE @SeedValue INT ");
                    strSql.Append("SET @SeedValue = (SELECT ISNULL(MAX(MainTopicID), 0) FROM dbo.MainTopic) ");
                    strSql.Append("DBCC CHECKIDENT('dbo.MainTopic',RESEED,@SeedValue)");
                    strSql.Append("INSERT INTO MainTopic(");
                    strSql.Append("MainTopicNumber,MainTopicTitle,LessonPlannerID,Introduction,Objectives,Material,");
                    strSql.Append("CreatedOn,CreatedBy,ModifiedOn,ModifiedBy)");
                    strSql.Append(" VALUES (");
                    strSql.Append("@MainTopicNumber,@MainTopicTitle,@LessonPlannerID,@Introduction,@Objectives,@Material,");
                    strSql.Append("@CreatedOn,@CreatedBy,@ModifiedOn,@ModifiedBy)");
                    strSql.Append(";SELECT SCOPE_IDENTITY()");

                    SqlParameter[] parameters = {
                    new SqlParameter("@MainTopicNumber", SqlDbType.NVarChar,50),
                    new SqlParameter("@MainTopicTitle", SqlDbType.NVarChar,-1),
                    new SqlParameter("@LessonPlannerID", SqlDbType.BigInt),
                    new SqlParameter("@Introduction", SqlDbType.NVarChar,-1),
                    new SqlParameter("@Objectives", SqlDbType.NVarChar,-1),
                    new SqlParameter("@Material", SqlDbType.NVarChar,-1),
                    new SqlParameter("@CreatedOn", SqlDbType.DateTime),
                    new SqlParameter("@CreatedBy", SqlDbType.Int),
                    new SqlParameter("@ModifiedOn", SqlDbType.DateTime),
                    new SqlParameter("@ModifiedBy", SqlDbType.Int)
                };
                    parameters[0].Value = lessonPlannerModel.MainTopicNumber;
                    parameters[1].Value = lessonPlannerModel.TitleMainTopic;
                    parameters[2].Value = lessonPlannerID;
                    parameters[3].Value = lessonPlannerModel.Introduction;
                    parameters[4].Value = lessonPlannerModel.Objectives;
                    parameters[5].Value = lessonPlannerModel.Material;
                    parameters[6].Value = lessonPlannerModel.CreatedOn;
                    parameters[7].Value = lessonPlannerModel.CreatedBy;
                    parameters[8].Value = lessonPlannerModel.ModifiedOn;
                    parameters[9].Value = lessonPlannerModel.ModifiedBy;

                    object obj = DbHelper.GetSingle(strSql.ToString(), parameters);
                    if (obj == null)
                    {
                        result = 0;
                    }
                    else
                    {
                        result = Convert.ToInt64(obj);
                    }
                }
                else
                {
                    StringBuilder strSql = new StringBuilder();
                    strSql.Append("UPDATE MainTopic SET ");
                    strSql.Append("MainTopicNumber=@MainTopicNumber,MainTopicTitle=@MainTopicTitle,");
                    strSql.Append("LessonPlannerID=@LessonPlannerID,Introduction=@Introduction,Objectives=@Objectives,");
                    strSql.Append("Material=@Material,ModifiedOn=@ModifiedOn,ModifiedBy=@ModifiedBy");
                    strSql.Append(" where MainTopicID=@MainTopicID");

                    SqlParameter[] parameters = {
                    new SqlParameter("@MainTopicNumber", SqlDbType.NVarChar,50),
                    new SqlParameter("@MainTopicTitle", SqlDbType.NVarChar,-1),
                    new SqlParameter("@LessonPlannerID", SqlDbType.BigInt),
                    new SqlParameter("@Introduction", SqlDbType.NVarChar,-1),
                    new SqlParameter("@Objectives", SqlDbType.NVarChar,-1),
                    new SqlParameter("@Material", SqlDbType.NVarChar,-1),
                    new SqlParameter("@CreatedOn", SqlDbType.DateTime),
                    new SqlParameter("@CreatedBy", SqlDbType.Int),
                    new SqlParameter("@ModifiedOn", SqlDbType.DateTime),
                    new SqlParameter("@ModifiedBy", SqlDbType.Int),
                    new SqlParameter("@MainTopicID", SqlDbType.BigInt),

                };
                    parameters[0].Value = lessonPlannerModel.MainTopicNumber;
                    parameters[1].Value = lessonPlannerModel.TitleMainTopic;
                    parameters[2].Value = lessonPlannerModel.LessonPlannerID;
                    parameters[3].Value = lessonPlannerModel.Introduction;
                    parameters[4].Value = lessonPlannerModel.Objectives;
                    parameters[5].Value = lessonPlannerModel.Material;
                    parameters[6].Value = lessonPlannerModel.CreatedOn;
                    parameters[7].Value = lessonPlannerModel.CreatedBy;
                    parameters[8].Value = lessonPlannerModel.ModifiedOn;
                    parameters[9].Value = lessonPlannerModel.ModifiedBy;
                    parameters[10].Value = lessonPlannerModel.MainTopicID;

                    result = DbHelper.ExecuteSql(strSql.ToString(), parameters);
                    result = lessonPlannerModel.MainTopicID;
                }

                if (result > 0)
                {
                    DataTable dataTableSubTopics = TranslateSubToicListToDataTable(lessonPlannerModel.subTopicModels, result);

                    DataTable dataTableGames = TranslateGamesListToDataTable(lessonPlannerModel.gamesModels, result);

                    DataTable dataTableMovies = TranslateMoviesListToDataTable(lessonPlannerModel.moviesModels, result);

                    DataTable dataTableDocumentaries = TranslateDocumentariesListToDataTable(lessonPlannerModel.documentariesModels, result);

                    DataTable dataTableBooks = TranslateBooksListToDataTable(lessonPlannerModel.booksModels, result);

                    SaveSubTopicsAndExtras(dataTableSubTopics, dataTableGames, dataTableMovies, dataTableDocumentaries, dataTableBooks);
                }
            }



            return result;
        }

        private void SaveSubTopicsAndExtras(DataTable dataTableSubTopics,
                                            DataTable dataTableGames,
                                            DataTable dataTableMovies,
                                            DataTable dataTableDocumentaries,
                                            DataTable dataTableBooks)
        {
            SqlConnection conn = new SqlConnection(DbHelper.ConnectionString);

            try
            {
                SqlCommand command = new SqlCommand(@"dbo.uspSaveSubTopicsAndExtras", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@SubTopicUDT", dataTableSubTopics);
                command.Parameters.AddWithValue("@GamesUDT", dataTableGames);
                command.Parameters.AddWithValue("@MoviesUDT", dataTableMovies);
                command.Parameters.AddWithValue("@DocumentariesUDT", dataTableDocumentaries);
                command.Parameters.AddWithValue("@BooksUDT", dataTableBooks);

                conn.Open();
                //command.Connection = DatabaseContext.Connection;
                //command.Transaction = DatabaseContext.Transaction;

                command.ExecuteNonQuery();
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

        }
        private DataTable TranslateSubToicListToDataTable(List<SubTopicModel> subTopicModels, long mainTopicID)
        {
            DataTable dataTable = new DataTable();

            dataTable.Clear();

            //Create DataTable Columns

            dataTable.Columns.Add("SubTopicNumber", typeof(string));
            dataTable.Columns.Add("SubTopicTitle", typeof(string));
            //dataTable.Columns.Add("Introduction", typeof(string));
            //dataTable.Columns.Add("Objectives", typeof(string));
            dataTable.Columns.Add("Material", typeof(string));
            dataTable.Columns.Add("MainTopicID", typeof(long));
            dataTable.Columns.Add("CreatedOn", typeof(DateTime));
            dataTable.Columns.Add("CreatedBy", typeof(int));
            dataTable.Columns.Add("ModifiedOn", typeof(DateTime));
            dataTable.Columns.Add("ModifiedBy", typeof(int));

            if (mainTopicID > 0)
            {
                if (subTopicModels != null && subTopicModels.Count > 0)
                {
                    foreach (SubTopicModel item in subTopicModels)
                    {
                        DataRow dr = dataTable.NewRow();

                        dr["SubTopicNumber"] = item.SubTopicNumber;
                        dr["SubTopicTitle"] = item.SubTopicTitle;
                        dr["Material"] = item.Material;
                        dr["MainTopicID"] = mainTopicID;
                        dr["CreatedOn"] = item.CreatedOn;
                        dr["CreatedBy"] = item.CreatedBy;
                        dr["ModifiedOn"] = item.ModifiedOn;
                        dr["ModifiedBy"] = item.ModifiedBy;

                        dataTable.Rows.Add(dr);
                    }

                }
            }

            return dataTable;
        }

        private DataTable TranslateGamesListToDataTable(List<GamesModel> gamesModels, long mainTopicID)
        {
            DataTable dataTable = new DataTable();
            dataTable.Clear();

            //Create DataTable Columns

            dataTable.Columns.Add("GameDescription", typeof(string));
            dataTable.Columns.Add("MainTopicID", typeof(long));
            dataTable.Columns.Add("CreatedOn", typeof(DateTime));
            dataTable.Columns.Add("CreatedBy", typeof(int));
            dataTable.Columns.Add("ModifiedOn", typeof(DateTime));
            dataTable.Columns.Add("ModifiedBy", typeof(int));

            if (mainTopicID > 0)
            {
                if (gamesModels != null && gamesModels.Count > 0)
                {
                    foreach (GamesModel item in gamesModels)
                    {
                        DataRow dr = dataTable.NewRow();

                        dr["GameDescription"] = item.GameDescription;
                        dr["MainTopicID"] = mainTopicID;
                        dr["CreatedOn"] = item.CreatedOn;
                        dr["CreatedBy"] = item.CreatedBy;
                        dr["ModifiedOn"] = item.ModifiedOn;
                        dr["ModifiedBy"] = item.ModifiedBy;

                        dataTable.Rows.Add(dr);
                    }

                }
            }

            return dataTable;
        }

        private DataTable TranslateMoviesListToDataTable(List<MoviesModel> moviesModels, long mainTopicID)
        {
            DataTable dataTable = new DataTable();
            dataTable.Clear();

            //Create DataTable Columns

            dataTable.Columns.Add("MovieDescription", typeof(string));
            dataTable.Columns.Add("MainTopicID", typeof(long));
            dataTable.Columns.Add("CreatedOn", typeof(DateTime));
            dataTable.Columns.Add("CreatedBy", typeof(int));
            dataTable.Columns.Add("ModifiedOn", typeof(DateTime));
            dataTable.Columns.Add("ModifiedBy", typeof(int));

            if (mainTopicID > 0)
            {
                if (moviesModels != null && moviesModels.Count > 0)
                {
                    foreach (MoviesModel item in moviesModels)
                    {
                        DataRow dr = dataTable.NewRow();

                        dr["MovieDescription"] = item.MovieDescription;
                        dr["MainTopicID"] = mainTopicID;
                        dr["CreatedOn"] = item.CreatedOn;
                        dr["CreatedBy"] = item.CreatedBy;
                        dr["ModifiedOn"] = item.ModifiedOn;
                        dr["ModifiedBy"] = item.ModifiedBy;

                        dataTable.Rows.Add(dr);
                    }

                }
            }

            return dataTable;
        }

        private DataTable TranslateDocumentariesListToDataTable(List<DocumentariesModel> documentariesModels, long mainTopicID)
        {
            DataTable dataTable = new DataTable();
            dataTable.Clear();
            //Create DataTable Columns

            dataTable.Columns.Add("DocumentaryDescription", typeof(string));
            dataTable.Columns.Add("MainTopicID", typeof(long));
            dataTable.Columns.Add("CreatedOn", typeof(DateTime));
            dataTable.Columns.Add("CreatedBy", typeof(int));
            dataTable.Columns.Add("ModifiedOn", typeof(DateTime));
            dataTable.Columns.Add("ModifiedBy", typeof(int));

            if (mainTopicID > 0)
            {
                if (documentariesModels != null && documentariesModels.Count > 0)
                {
                    foreach (DocumentariesModel item in documentariesModels)
                    {
                        DataRow dr = dataTable.NewRow();

                        dr["DocumentaryDescription"] = item.DocumentaryDescription;
                        dr["MainTopicID"] = mainTopicID;
                        dr["CreatedOn"] = item.CreatedOn;
                        dr["CreatedBy"] = item.CreatedBy;
                        dr["ModifiedOn"] = item.ModifiedOn;
                        dr["ModifiedBy"] = item.ModifiedBy;

                        dataTable.Rows.Add(dr);
                    }

                }
            }

            return dataTable;
        }

        private DataTable TranslateBooksListToDataTable(List<BooksModel> booksModels, long mainTopicID)
        {
            DataTable dataTable = new DataTable();
            dataTable.Clear();
            //Create DataTable Columns

            dataTable.Columns.Add("BookDescription", typeof(string));
            dataTable.Columns.Add("MainTopicID", typeof(long));
            dataTable.Columns.Add("CreatedOn", typeof(DateTime));
            dataTable.Columns.Add("CreatedBy", typeof(int));
            dataTable.Columns.Add("ModifiedOn", typeof(DateTime));
            dataTable.Columns.Add("ModifiedBy", typeof(int));

            if (mainTopicID > 0)
            {
                if (booksModels != null && booksModels.Count > 0)
                {
                    foreach (BooksModel item in booksModels)
                    {
                        DataRow dr = dataTable.NewRow();

                        dr["BookDescription"] = item.BookDescription;
                        dr["MainTopicID"] = mainTopicID;
                        dr["CreatedOn"] = item.CreatedOn;
                        dr["CreatedBy"] = item.CreatedBy;
                        dr["ModifiedOn"] = item.ModifiedOn;
                        dr["ModifiedBy"] = item.ModifiedBy;

                        dataTable.Rows.Add(dr);
                    }

                }
            }

            return dataTable;
        }

        public DataTable GetAllLessonPlanners()
        {
            //List<LessonPlannerModel> lessonPlannerModels = new List<LessonPlannerModel>();
            DataTable dataTable = new DataTable();
            //try
            //{
            SqlConnection conn = new SqlConnection(DbHelper.ConnectionString);

            SqlCommand command = new SqlCommand(@"dbo.uspGetAllLessonPlanners", conn);
            command.CommandType = CommandType.StoredProcedure;
            //command.Parameters.AddWithValue("@ProviderID", ProviderID);

            conn.Open();

            //command.Connection = DatabaseContext.Connection;
            //command.Transaction = DatabaseContext.Transaction;

            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            dataAdapter.Fill(dataTable);
            conn.Close();

            //    foreach (DataRow row in dataTable.Rows)
            //    {
            //        LessonPlannerModel lessonPlannerModel = new LessonPlannerModel();
            //        lessonPlannerModel.LessonPlannerID = row["LessonPlannerID"] != DBNull.Value ? Convert.ToInt64(row["LessonPlannerID"].ToString()) : 0;
            //        lessonPlannerModel.GradeID = row["GradeID"] != DBNull.Value ? Convert.ToInt64(row["GradeID"].ToString()) : 0;
            //        lessonPlannerModel.GradeName = row["GradeName"] != DBNull.Value ? Convert.ToString(row["GradeName"]) : string.Empty;
            //        lessonPlannerModel.SubjectID = row["SubjectID"] != DBNull.Value ? Convert.ToInt64(row["SubjectID"].ToString()) : 0;
            //        lessonPlannerModel.SubjectName = row["SubjectName"] != DBNull.Value ? Convert.ToString(row["SubjectName"]) : string.Empty;
            //        lessonPlannerModel.MainTopicID = row["MainTopicID"] != DBNull.Value ? Convert.ToInt64(row["MainTopicID"].ToString()) : 0;
            //        lessonPlannerModel.MainTopicNumber = row["MainTopicNumber"] != DBNull.Value ? Convert.ToString(row["MainTopicNumber"]) : string.Empty;
            //        lessonPlannerModel.TitleMainTopic = row["MainTopicTitle"] != DBNull.Value ? Convert.ToString(row["MainTopicTitle"]) : string.Empty;

            //        lessonPlannerModel.Introduction = row["Introduction"] != DBNull.Value ? Convert.ToString(row["Introduction"]) : string.Empty;
            //        lessonPlannerModel.Objectives = row["Objectives"] != DBNull.Value ? Convert.ToString(row["Objectives"]) : string.Empty;
            //        lessonPlannerModel.Material = row["Material"] != DBNull.Value ? Convert.ToString(row["Material"]) : string.Empty;

            //        lessonPlannerModels.Add(lessonPlannerModel);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}
            //finally
            //{

            //    dataTable.Clear();
            //    dataTable = null;
            //}

            return dataTable;
        }

        public List<LessonPlannerModel> GetAllLessonPlannersByGradeIDandSubjectID(long gradeID, long subjectID)
        {
            List<LessonPlannerModel> lessonPlannerModels = new List<LessonPlannerModel>();
            DataTable dataTable = new DataTable();
            try
            {
                SqlConnection conn = new SqlConnection(DbHelper.ConnectionString);

                SqlCommand command = new SqlCommand(@"dbo.uspGetAllLessonPlannersByGradeIDandSubjectID", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@GradeID", gradeID);
                command.Parameters.AddWithValue("@SubjectID", subjectID);

                conn.Open();

                //command.Connection = DatabaseContext.Connection;
                //command.Transaction = DatabaseContext.Transaction;

                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                dataAdapter.Fill(dataTable);

                foreach (DataRow row in dataTable.Rows)
                {
                    LessonPlannerModel lessonPlannerModel = new LessonPlannerModel();
                    lessonPlannerModel.LessonPlannerID = row["LessonPlannerID"] != DBNull.Value ? Convert.ToInt64(row["LessonPlannerID"].ToString()) : 0;
                    lessonPlannerModel.GradeID = row["GradeID"] != DBNull.Value ? Convert.ToInt64(row["GradeID"].ToString()) : 0;
                    lessonPlannerModel.GradeName = row["GradeName"] != DBNull.Value ? Convert.ToString(row["GradeName"]) : string.Empty;
                    lessonPlannerModel.SubjectID = row["SubjectID"] != DBNull.Value ? Convert.ToInt64(row["SubjectID"].ToString()) : 0;
                    lessonPlannerModel.SubjectName = row["SubjectName"] != DBNull.Value ? Convert.ToString(row["SubjectName"]) : string.Empty;
                    lessonPlannerModel.MainTopicID = row["MainTopicID"] != DBNull.Value ? Convert.ToInt64(row["MainTopicID"].ToString()) : 0;
                    lessonPlannerModel.MainTopicNumber = row["MainTopicNumber"] != DBNull.Value ? Convert.ToString(row["MainTopicNumber"]) : string.Empty;
                    lessonPlannerModel.TitleMainTopic = row["MainTopicTitle"] != DBNull.Value ? Convert.ToString(row["MainTopicTitle"]) : string.Empty;

                    lessonPlannerModel.Introduction = row["Introduction"] != DBNull.Value ? Convert.ToString(row["Introduction"]) : string.Empty;
                    lessonPlannerModel.Objectives = row["Objectives"] != DBNull.Value ? Convert.ToString(row["Objectives"]) : string.Empty;
                    lessonPlannerModel.Material = row["Material"] != DBNull.Value ? Convert.ToString(row["Material"]) : string.Empty;

                    lessonPlannerModels.Add(lessonPlannerModel);
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

            return lessonPlannerModels;
        }

        public DataTable GetAllSubTopicByMainTopicID(long mainTopicID)
        {
            //List<SubTopicModel> subTopicModels = new List<SubTopicModel>();
            DataTable dataTable = new DataTable();
            //try
            //{
            SqlConnection conn = new SqlConnection(DbHelper.ConnectionString);

            SqlCommand command = new SqlCommand(@"dbo.uspGetAllSubTopicByMainTopicID", conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@MainTopicID", mainTopicID);

            conn.Open();

            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            dataAdapter.Fill(dataTable);

            conn.Close();
            //foreach (DataRow row in dataTable.Rows)
            //{
            //    SubTopicModel subTopicModel = new SubTopicModel();
            //    subTopicModel.SubTopicID = row["SubTopicID"] != DBNull.Value ? Convert.ToInt64(row["SubTopicID"].ToString()) : 0;
            //    subTopicModel.SubTopicNumber = row["SubTopicNumber"] != DBNull.Value ? Convert.ToString(row["SubTopicNumber"]) : string.Empty;
            //    subTopicModel.MainTopicNumber = row["MainTopicNumber"] != DBNull.Value ? Convert.ToString(row["MainTopicNumber"]) : string.Empty;
            //    subTopicModel.SubTopicTitle = row["SubTopicTitle"] != DBNull.Value ? Convert.ToString(row["SubTopicTitle"]) : string.Empty;
            //    subTopicModel.Introduction = row["Introduction"] != DBNull.Value ? Convert.ToString(row["Introduction"]) : string.Empty;
            //    subTopicModel.Objectives = row["Objectives"] != DBNull.Value ? Convert.ToString(row["Objectives"]) : string.Empty;
            //    subTopicModel.Material = row["Material"] != DBNull.Value ? Convert.ToString(row["Material"]) : string.Empty;
            //    subTopicModel.MainTopicID = row["MainTopicID"] != DBNull.Value ? Convert.ToInt64(row["MainTopicID"].ToString()) : 0;                    

            //    subTopicModels.Add(subTopicModel);
            //}
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}
            //finally
            //{

            //    dataTable.Clear();
            //    dataTable = null;
            //}

            return dataTable;
        }

        public DataTable GetAllMovies()
        {
            //List<MoviesModel> moviesModels = new List<MoviesModel>();
            DataTable dataTable = new DataTable();
            //try
            //{
            SqlConnection conn = new SqlConnection(DbHelper.ConnectionString);

            SqlCommand command = new SqlCommand(@"dbo.uspGetAllMovies", conn);
            command.CommandType = CommandType.StoredProcedure;
            //command.Parameters.AddWithValue("@ProviderID", ProviderID);

            conn.Open();

            //command.Connection = DatabaseContext.Connection;
            //command.Transaction = DatabaseContext.Transaction;

            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            dataAdapter.Fill(dataTable);
            conn.Close();

            //    foreach (DataRow row in dataTable.Rows)
            //    {
            //        MoviesModel movies = new MoviesModel();
            //        movies.MovieID = row["MovieID"] != DBNull.Value ? Convert.ToInt64(row["MovieID"].ToString()) : 0;
            //        movies.MainTopicID = row["MainTopicID"] != DBNull.Value ? Convert.ToInt64(row["MainTopicID"].ToString()) : 0;
            //        movies.MainTopicNumber = row["MainTopicNumber"] != DBNull.Value ? Convert.ToString(row["MainTopicNumber"]) : string.Empty;
            //        movies.MovieDescription = row["MovieDescription"] != DBNull.Value ? Convert.ToString(row["MovieDescription"].ToString()) : string.Empty;

            //        moviesModels.Add(movies);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}
            //finally
            //{

            //    dataTable.Clear();
            //    dataTable = null;
            //}

            return dataTable;
        }

        public DataTable GetAllDocumentaries()
        {
            //List<DocumentariesModel> documentariesModels = new List<DocumentariesModel>();
            DataTable dataTable = new DataTable();
            try
            {
                SqlConnection conn = new SqlConnection(DbHelper.ConnectionString);

                SqlCommand command = new SqlCommand(@"dbo.uspGetAllDocumentaries", conn);
                command.CommandType = CommandType.StoredProcedure;
                //command.Parameters.AddWithValue("@ProviderID", ProviderID);

                conn.Open();

                //command.Connection = DatabaseContext.Connection;
                //command.Transaction = DatabaseContext.Transaction;

                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                dataAdapter.Fill(dataTable);

                conn.Close();

                //foreach (DataRow row in dataTable.Rows)
                //{
                //    DocumentariesModel documentaries = new DocumentariesModel();
                //    documentaries.DocumentaryID = row["DocumentaryID"] != DBNull.Value ? Convert.ToInt64(row["DocumentaryID"].ToString()) : 0;
                //    documentaries.MainTopicID = row["MainTopicID"] != DBNull.Value ? Convert.ToInt64(row["MainTopicID"].ToString()) : 0;
                //    documentaries.MainTopicNumber = row["MainTopicNumber"] != DBNull.Value ? Convert.ToString(row["MainTopicNumber"]) : string.Empty;
                //    documentaries.DocumentaryDescription = row["DocumentaryDescription"] != DBNull.Value ? Convert.ToString(row["DocumentaryDescription"].ToString()) : string.Empty;

                //    documentariesModels.Add(documentaries);
                //}
            }
            catch (Exception ex)
            {
                throw ex;
            }
            //finally
            //{

            //    dataTable.Clear();
            //    dataTable = null;
            //}

            return dataTable;
        }

        public DataTable GetAllGames()
        {
            //List<GamesModel> gamesModels = new List<GamesModel>();
            DataTable dataTable = new DataTable();
            //try
            //{
            SqlConnection conn = new SqlConnection(DbHelper.ConnectionString);

            SqlCommand command = new SqlCommand(@"dbo.uspGetAllGames", conn);
            command.CommandType = CommandType.StoredProcedure;
            //command.Parameters.AddWithValue("@ProviderID", ProviderID);

            conn.Open();

            //command.Connection = DatabaseContext.Connection;
            //command.Transaction = DatabaseContext.Transaction;

            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            dataAdapter.Fill(dataTable);
            conn.Close();

            //foreach (DataRow row in dataTable.Rows)
            //{
            //    GamesModel gamesModel = new GamesModel();
            //    gamesModel.GameID = row["GameID"] != DBNull.Value ? Convert.ToInt64(row["GameID"].ToString()) : 0;
            //    gamesModel.MainTopicID = row["MainTopicID"] != DBNull.Value ? Convert.ToInt64(row["MainTopicID"].ToString()) : 0;
            //    gamesModel.MainTopicNumber = row["MainTopicNumber"] != DBNull.Value ? Convert.ToString(row["MainTopicNumber"]) : string.Empty;
            //    gamesModel.GameDescription = row["GameDescription"] != DBNull.Value ? Convert.ToString(row["GameDescription"].ToString()) : string.Empty;

            //    gamesModels.Add(gamesModel);
            //}
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}
            //finally
            //{

            //    dataTable.Clear();
            //    dataTable = null;
            //}

            return dataTable;
        }

        public DataTable GetAllBooks()
        {
            //List<BooksModel> booksModels = new List<BooksModel>();
            DataTable dataTable = new DataTable();
            //try
            //{
            SqlConnection conn = new SqlConnection(DbHelper.ConnectionString);

            SqlCommand command = new SqlCommand(@"dbo.uspGetAllBooks", conn);
            command.CommandType = CommandType.StoredProcedure;
            //command.Parameters.AddWithValue("@ProviderID", ProviderID);

            conn.Open();

            //command.Connection = DatabaseContext.Connection;
            //command.Transaction = DatabaseContext.Transaction;

            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            dataAdapter.Fill(dataTable);
            conn.Close();

            //    foreach (DataRow row in dataTable.Rows)
            //    {
            //        BooksModel booksModel = new BooksModel();
            //        booksModel.BookID = row["BookID"] != DBNull.Value ? Convert.ToInt64(row["BookID"].ToString()) : 0;
            //        booksModel.MainTopicID = row["MainTopicID"] != DBNull.Value ? Convert.ToInt64(row["MainTopicID"].ToString()) : 0;
            //        booksModel.MainTopicNumber = row["MainTopicNumber"] != DBNull.Value ? Convert.ToString(row["MainTopicNumber"]) : string.Empty;
            //        booksModel.BookDescription = row["BookDescription"] != DBNull.Value ? Convert.ToString(row["BookDescription"].ToString()) : string.Empty;

            //        booksModels.Add(booksModel);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}
            //finally
            //{

            //    dataTable.Clear();
            //    dataTable = null;
            //}

            return dataTable;
        }
        public int DeleteLessonPlannerByID(long lessonPlannerID)
        {

            string strSql = "delete from LessonPlanner where LessonPlannerID =" + lessonPlannerID;

            int rows = 0;

            rows = DbHelper.ExecuteSql(strSql.ToString());

            return rows;
        }

        public int DeleteGameByID(long gameID)
        {

            string strSql = "DELETE FROM Games WHERE GameID =" + gameID;

            int rows = 0;

            rows = DbHelper.ExecuteSql(strSql.ToString());

            return rows;
        }

        public int DeleteBookByID(long bookID)
        {

            string strSql = "DELETE FROM Books WHERE BookID =" + bookID;

            int rows = 0;

            rows = DbHelper.ExecuteSql(strSql.ToString());

            return rows;
        }

        public int DeleteDocumentayByID(long documentaryID)
        {

            string strSql = "DELETE FROM Documentaries WHERE DocumentaryID =" + documentaryID;

            int rows = 0;

            rows = DbHelper.ExecuteSql(strSql.ToString());

            return rows;
        }

        public int DeleteMovieByID(long moviedID)
        {

            string strSql = "DELETE FROM Movies WHERE MovieID =" + moviedID;

            int rows = 0;

            rows = DbHelper.ExecuteSql(strSql.ToString());

            return rows;
        }

        public long EditSubTopic(SubTopicModel subTopicModel)
        {
            long result = 0;
            StringBuilder strSql = new StringBuilder();
            strSql.Append("UPDATE SubTopic SET ");
            strSql.Append("SubTopicTitle=@SubTopicTitle,Material=@Material,");
            strSql.Append("ModifiedOn=@ModifiedOn,ModifiedBy=@ModifiedBy");
            strSql.Append(" where SubTopicID=@SubTopicID");

            SqlParameter[] parameters = {
                    new SqlParameter("@SubTopicTitle", SqlDbType.NVarChar,-1),
                    new SqlParameter("@Material", SqlDbType.NVarChar,-1),
                    new SqlParameter("@ModifiedOn", SqlDbType.DateTime),
                    new SqlParameter("@ModifiedBy", SqlDbType.Int),
                    new SqlParameter("@SubTopicID", SqlDbType.BigInt),

                };
            parameters[0].Value = subTopicModel.SubTopicTitle;
            parameters[1].Value = subTopicModel.Material;
            parameters[2].Value = subTopicModel.ModifiedOn;
            parameters[3].Value = subTopicModel.ModifiedBy;
            parameters[4].Value = subTopicModel.SubTopicID;

            result = DbHelper.ExecuteSql(strSql.ToString(), parameters);
            if (result > 1)
            {
                result = subTopicModel.MainTopicID;
            }
            return result;
        }

        public long DeleteSubTopic(long subTopicID)
        {
            long result = 0;
            StringBuilder strSql = new StringBuilder();
            strSql.Append("DELETE FROM SubTopic ");
            strSql.Append("WHERE SubTopicID=@SubTopicID");

            SqlParameter[] parameters = {
                    new SqlParameter("@SubTopicID", SqlDbType.BigInt)
                };
            parameters[0].Value = subTopicID;

            result = DbHelper.ExecuteSql(strSql.ToString(), parameters);
            if (result > 1)
            {
                result = subTopicID;
            }
            return result;
        }

    }
}
