using QMLPModels;
using QMLPRepository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizMakerAndLessonPlanner
{
    public partial class LessonPlannerIndex : Form
    {
        public LessonPlannerIndex()
        {
            InitializeComponent();
        }

        private void Index_Load(object sender, EventArgs e)
        {
            FillGradesCombo();

        }

        private void FillGradesCombo()
        {
            GradeRepository gradeRepository = new GradeRepository();
            List<GradeModel> gradeModels = new List<GradeModel>();
            DataTable dataTable = new DataTable();

            try
            {
                dataTable = gradeRepository.GetAllGrades();

                gradeModels = TranslateDataTableToGradeModel(dataTable);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Network error...Please try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {

                dataTable.Clear();
                dataTable = null;
            }

            this.cmbGrades.SelectedIndexChanged -= new EventHandler(cmbGrades_SelectedIndexChanged);

            BindingSource bs = new BindingSource();
            bs.DataSource = gradeModels;

            cmbGrades.ValueMember = "GradeID";
            cmbGrades.DisplayMember = "GradeName";
            cmbGrades.DataSource = bs;

            cmbGrades.SelectedIndex = -1;

            this.cmbGrades.SelectedIndexChanged += new EventHandler(cmbGrades_SelectedIndexChanged);

        }

        private List<GradeModel> TranslateDataTableToGradeModel(DataTable dataTable)
        {
            List<GradeModel> gradeModels = new List<GradeModel>();

            foreach (DataRow row in dataTable.Rows)
            {
                GradeModel gradeModel = new GradeModel();
                gradeModel.GradeID = row["GradeID"] != DBNull.Value ? Convert.ToInt32(row["GradeID"].ToString()) : 0;
                gradeModel.GradeName = row["GradeName"] != DBNull.Value ? Convert.ToString(row["GradeName"]) : string.Empty;

                gradeModels.Add(gradeModel);
            }

            return gradeModels;
        }

        private void FillSubjectComboByGradeID(long gradeID)
        {
            SubjectsRepository subjectsRepository = new SubjectsRepository();
            List<SubjectModel> subjectModels = new List<SubjectModel>();

            DataTable dataTable = new DataTable();

            try
            {
                dataTable = subjectsRepository.GetAllSubjectsByGradeID(gradeID);

                subjectModels = TranslateDataTableToSubjectsModel(dataTable);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Network error...Please try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {

                dataTable.Clear();
                dataTable = null;
            }




            this.cmbSubjects.SelectedIndexChanged -= new EventHandler(cmbSubjects_SelectedIndexChanged);

            BindingSource bs = new BindingSource();
            bs.DataSource = subjectModels;
            cmbSubjects.ValueMember = "SubjectID";
            cmbSubjects.DisplayMember = "SubjectName";
            cmbSubjects.DataSource = bs;
            cmbSubjects.SelectedIndex = -1;

            this.cmbSubjects.SelectedIndexChanged += new EventHandler(cmbSubjects_SelectedIndexChanged);
        }
        private List<SubjectModel> TranslateDataTableToSubjectsModel(DataTable dataTable)
        {
            List<SubjectModel> subjectModels = new List<SubjectModel>();

            foreach (DataRow row in dataTable.Rows)
            {
                SubjectModel subjectModel = new SubjectModel();
                subjectModel.SubjectID = row["SubjectID"] != DBNull.Value ? Convert.ToInt32(row["SubjectID"].ToString()) : 0;
                subjectModel.SubjectName = row["SubjectName"] != DBNull.Value ? Convert.ToString(row["SubjectName"]) : string.Empty;

                subjectModels.Add(subjectModel);
            }

            return subjectModels;
        }

        private void FillSubjectCombo()
        {
            SubjectsRepository subjectsRepository = new SubjectsRepository();
            List<SubjectModel> subjectModels = subjectsRepository.GetAllSubjects();

            BindingSource bs = new BindingSource();
            bs.DataSource = subjectModels;

            cmbSubjects.ValueMember = "SubjectID";
            cmbSubjects.DisplayMember = "SubjectName";

            cmbSubjects.SelectedValue = -1;

            cmbSubjects.DataSource = bs;
        }

        private void BindGridViewLessonPlanner()
        {
            LessonPlannerRepository lessonPlannerRepository = new LessonPlannerRepository();
            List<LessonPlannerModel> lessonPlannerModels = new List<LessonPlannerModel>();

            DataTable dataTable = new DataTable();

            try
            {
                dataTable = lessonPlannerRepository.GetAllLessonPlanners();

                lessonPlannerModels = TranslateDataTableToLessonPlannersModel(dataTable);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Network error...Please try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {

                dataTable.Clear();
                dataTable = null;
                dataGridViewLessonPlanner.DataSource = lessonPlannerModels;
            }
        }

        private List<LessonPlannerModel> TranslateDataTableToLessonPlannersModel(DataTable dataTable)
        {
            List<LessonPlannerModel> lessonPlannerModels = new List<LessonPlannerModel>();


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

            return lessonPlannerModels;
        }

        private void BindGridViewLessonPlannerByGradeIDAndSubjectID(long gradeID, long subjecID)
        {
            LessonPlannerRepository lessonPlannerRepository = new LessonPlannerRepository();
            
            List<LessonPlannerModel> lessonPlannerModels = lessonPlannerRepository.GetAllLessonPlannersByGradeIDandSubjectID(gradeID, subjecID);

            dataGridViewLessonPlanner.DataSource = lessonPlannerModels;

            if (lessonPlannerModels != null && lessonPlannerModels.Count() > 0)
            {
                AddGridButtons();
            }
        }


        private void AddGridButtons()
        {
            DataGridViewLinkColumn Quizzeslink = new DataGridViewLinkColumn();
            Quizzeslink.UseColumnTextForLinkValue = true;
            Quizzeslink.HeaderText = "Quizzes";
            Quizzeslink.Name = "Quizzes";
            Quizzeslink.DataPropertyName = "lnkColumn";
            Quizzeslink.LinkBehavior = LinkBehavior.SystemDefault;
            Quizzeslink.Text = "Quizzes";
            dataGridViewLessonPlanner.Columns.Add(Quizzeslink);

            DataGridViewLinkColumn ViewSubTopiclink = new DataGridViewLinkColumn();
            ViewSubTopiclink.UseColumnTextForLinkValue = true;
            ViewSubTopiclink.HeaderText = "View SubTopic";
            ViewSubTopiclink.Name = "ViewSubTopic";
            ViewSubTopiclink.DataPropertyName = "lnkColumn";
            ViewSubTopiclink.LinkBehavior = LinkBehavior.SystemDefault;
            ViewSubTopiclink.Text = "View SubTopic";
            dataGridViewLessonPlanner.Columns.Add(ViewSubTopiclink);

            //DataGridViewLinkColumn Editlink = new DataGridViewLinkColumn();
            //Editlink.UseColumnTextForLinkValue = true;
            //Editlink.HeaderText = "Edit";
            //Editlink.Name = "Edit";
            //Editlink.DataPropertyName = "lnkColumn";
            //Editlink.LinkBehavior = LinkBehavior.SystemDefault;
            //Editlink.Text = "Edit";
            //dataGridViewLessonPlanner.Columns.Add(Editlink);

            //DataGridViewLinkColumn Deletelink = new DataGridViewLinkColumn();
            //Deletelink.UseColumnTextForLinkValue = true;
            //Deletelink.HeaderText = "Delete";
            //Deletelink.Name = "Delete";
            //Deletelink.DataPropertyName = "lnkColumn";
            //Deletelink.LinkBehavior = LinkBehavior.SystemDefault;
            //Deletelink.Text = "Delete";
            //dataGridViewLessonPlanner.Columns.Add(Deletelink);
        }
        private void dataGridViewLessonPlanner_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == dataGridViewLessonPlanner.NewRowIndex || e.RowIndex < 0)
                return;

            //else if (e.ColumnIndex == dataGridViewLessonPlanner.Columns["Delete"].Index)
            //{
            //    //Put some logic here, for example to remove row from your binding list.
            //    //yourBindingList.RemoveAt(e.RowIndex);

            //    // Or
            //    // var data = (Product)dataGridView1.Rows[e.RowIndex].DataBoundItem;
            //    // do something 

            //    int rowCount = 0;
            //    long lessonPlannerID = Convert.ToInt64(dataGridViewLessonPlanner.Rows[e.RowIndex].Cells["LessonPlannerID"].Value);

            //    LessonPlannerRepository lessonPlannerRepository = new LessonPlannerRepository();
            //    rowCount = lessonPlannerRepository.DeleteLessonPlannerByID(lessonPlannerID);

            //    if (rowCount > 0)
            //    {
            //        ShowStatus(true, "DELETE");
            //        BindGridViewLessonPlanner();
            //    }


            //}
            //if (e.ColumnIndex == dataGridViewLessonPlanner.Columns["Edit"].Index)
            //{
            //    var data = (LessonPlannerModel)dataGridViewLessonPlanner.Rows[e.RowIndex].DataBoundItem;

            //    LessonPlanner lessonPlanner = new LessonPlanner(data);
            //    lessonPlanner.lblLessonPlannerID.Text = Convert.ToString(data.LessonPlannerID);
            //    lessonPlanner.lblMainTopicID.Text = Convert.ToString(data.MainTopicID);
            //    //lessonPlanner.txtGrade.Text = data.Grade;
            //    lessonPlanner.cmbSubjects.SelectedValue = data.SubjectID;
            //    lessonPlanner.txtMainTopic.Text = data.MainTopicNumber;
            //    lessonPlanner.txtTitleMainTopic.Text = data.TitleMainTopic;
            //    lessonPlanner.txtIntroduction.Text = data.Introduction;
            //    lessonPlanner.txtObjectives.Text = data.Objectives;
            //    lessonPlanner.txtMaterial.Text = data.Material;

            //    lessonPlanner.Show();
            //}
            //else 
            if (e.ColumnIndex == dataGridViewLessonPlanner.Columns["ViewSubTopic"].Index)
            {
                var data = (LessonPlannerModel)dataGridViewLessonPlanner.Rows[e.RowIndex].DataBoundItem;
                if (data != null)
                {
                    ViewSubTopics viewSubTopics = new ViewSubTopics(Convert.ToInt64(data.MainTopicID));
                    viewSubTopics.Show();
                }
            }
            else if (e.ColumnIndex == dataGridViewLessonPlanner.Columns["Quizzes"].Index)
            {
                var data = (LessonPlannerModel)dataGridViewLessonPlanner.Rows[e.RowIndex].DataBoundItem;
                if (data != null)
                {
                    QuizMakerIndex quizMakerIndex = new QuizMakerIndex(Convert.ToInt64(data.MainTopicID));
                    quizMakerIndex.Show();
                }
            }

        }
        public void ShowStatus(bool result, string Action)
        {
            if (result)
            {
                if (Action.ToUpper() == "ADD")
                {
                    MessageBox.Show("Saved Successfully!..", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (Action.ToUpper() == "UPDATE")
                {
                    MessageBox.Show("Updated Successfully!..", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Deleted Successfully!..", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Something went wrong!. Please try again!..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void dataGridViewLessonPlanner_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            this.dataGridViewLessonPlanner.Columns["LessonPlannerID"].Visible = false;
            this.dataGridViewLessonPlanner.Columns["GradeID"].Visible = false;
            this.dataGridViewLessonPlanner.Columns["SubjectID"].Visible = false;
            this.dataGridViewLessonPlanner.Columns["MainTopicID"].Visible = false;
            this.dataGridViewLessonPlanner.Columns["Introduction"].Visible = false;
            this.dataGridViewLessonPlanner.Columns["Objectives"].Visible = false;
            this.dataGridViewLessonPlanner.Columns["Material"].Visible = false;
            this.dataGridViewLessonPlanner.Columns["CreatedOn"].Visible = false;
            this.dataGridViewLessonPlanner.Columns["CreatedBy"].Visible = false;
            this.dataGridViewLessonPlanner.Columns["ModifiedOn"].Visible = false;
            this.dataGridViewLessonPlanner.Columns["ModifiedBy"].Visible = false;
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Reports reports = new Reports();
            reports.Show();
        }

        private void cmbGrades_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridViewLessonPlanner.DataSource = null;
            dataGridViewLessonPlanner.Rows.Clear();
            dataGridViewLessonPlanner.Columns.Clear();

            if (Convert.ToInt64(cmbGrades.SelectedValue) > 0)
            {
                FillSubjectComboByGradeID(Convert.ToInt64(cmbGrades.SelectedValue));

                if (Convert.ToInt64(cmbSubjects.SelectedValue) > 0)
                {
                    BindGridViewLessonPlannerByGradeIDAndSubjectID(Convert.ToInt64(cmbGrades.SelectedValue), Convert.ToInt64(cmbSubjects.SelectedValue));
                }
                else
                {
                    BindGridViewLessonPlannerByGradeIDAndSubjectID(Convert.ToInt64(cmbGrades.SelectedValue), 0);
                }
            }
        }

        private void cmbSubjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridViewLessonPlanner.DataSource = null;
            dataGridViewLessonPlanner.Rows.Clear();
            dataGridViewLessonPlanner.Columns.Clear();

            if (Convert.ToInt64(cmbSubjects.SelectedValue) > 0)
            {
                if (Convert.ToInt64(cmbGrades.SelectedValue) > 0)
                {
                    BindGridViewLessonPlannerByGradeIDAndSubjectID(Convert.ToInt64(cmbGrades.SelectedValue), Convert.ToInt64(cmbSubjects.SelectedValue));
                }
            }
        }
    }
}
