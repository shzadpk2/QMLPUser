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
    public partial class ViewSubTopics : Form
    {
        private long _mainTopicID = 0;
        public ViewSubTopics()
        {
            InitializeComponent();
        }

        public ViewSubTopics(long mainTopicID)
        {
            _mainTopicID = mainTopicID;
            InitializeComponent();
            BindGridViewViewSubTopicsByMainTopicID(mainTopicID);
        }

        private void ViewSubTopics_Load(object sender, EventArgs e)
        {

        }

        private void BindGridViewViewSubTopicsByMainTopicID(long mainTopicID)
        {
            LessonPlannerRepository lessonPlannerRepository = new LessonPlannerRepository();

            List<SubTopicModel> subTopicModels = new List<SubTopicModel>();

            DataTable dataTable = new DataTable();

            try
            {
                dataTable = lessonPlannerRepository.GetAllSubTopicByMainTopicID(mainTopicID);

                subTopicModels = TranslateDataTableToSubTopicsModel(dataTable);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Network error...Please try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {

                dataTable.Clear();
                dataTable = null;
                dataGridViewViewSubTopics.DataSource = subTopicModels;
            }

            if (subTopicModels != null && subTopicModels.Count() > 0)
            {
                AddGridButtons();
            }
        }

        private List<SubTopicModel>  TranslateDataTableToSubTopicsModel(DataTable dataTable)
        {
            List<SubTopicModel> subTopicModels = new List<SubTopicModel>();

            foreach (DataRow row in dataTable.Rows)
            {
                SubTopicModel subTopicModel = new SubTopicModel();
                subTopicModel.SubTopicID = row["SubTopicID"] != DBNull.Value ? Convert.ToInt64(row["SubTopicID"].ToString()) : 0;
                subTopicModel.SubTopicNumber = row["SubTopicNumber"] != DBNull.Value ? Convert.ToString(row["SubTopicNumber"]) : string.Empty;
                subTopicModel.MainTopicNumber = row["MainTopicNumber"] != DBNull.Value ? Convert.ToString(row["MainTopicNumber"]) : string.Empty;
                subTopicModel.SubTopicTitle = row["SubTopicTitle"] != DBNull.Value ? Convert.ToString(row["SubTopicTitle"]) : string.Empty;
                subTopicModel.Introduction = row["Introduction"] != DBNull.Value ? Convert.ToString(row["Introduction"]) : string.Empty;
                subTopicModel.Objectives = row["Objectives"] != DBNull.Value ? Convert.ToString(row["Objectives"]) : string.Empty;
                subTopicModel.Material = row["Material"] != DBNull.Value ? Convert.ToString(row["Material"]) : string.Empty;
                subTopicModel.MainTopicID = row["MainTopicID"] != DBNull.Value ? Convert.ToInt64(row["MainTopicID"].ToString()) : 0;

                subTopicModels.Add(subTopicModel);
            }

            return subTopicModels;

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
            dataGridViewViewSubTopics.Columns.Add(Quizzeslink);

            //DataGridViewLinkColumn Editlink = new DataGridViewLinkColumn();
            //Editlink.UseColumnTextForLinkValue = true;
            //Editlink.HeaderText = "Edit";
            //Editlink.Name = "Edit";
            //Editlink.DataPropertyName = "lnkColumn";
            //Editlink.LinkBehavior = LinkBehavior.SystemDefault;
            //Editlink.Text = "Edit";
            //dataGridViewViewSubTopics.Columns.Add(Editlink);

            //DataGridViewLinkColumn Deletelink = new DataGridViewLinkColumn();
            //Deletelink.UseColumnTextForLinkValue = true;
            //Deletelink.HeaderText = "Delete";
            //Deletelink.Name = "Delete";
            //Deletelink.DataPropertyName = "lnkColumn";
            //Deletelink.LinkBehavior = LinkBehavior.SystemDefault;
            //Deletelink.Text = "Delete";
            //dataGridViewViewSubTopics.Columns.Add(Deletelink);
        }

        private void dataGridViewViewSubTopics_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            this.dataGridViewViewSubTopics.Columns["MainTopicID"].Visible = false;
            this.dataGridViewViewSubTopics.Columns["Introduction"].Visible = false;
            this.dataGridViewViewSubTopics.Columns["Objectives"].Visible = false;
            this.dataGridViewViewSubTopics.Columns["Material"].Visible = false;
            this.dataGridViewViewSubTopics.Columns["CreatedOn"].Visible = false;
            this.dataGridViewViewSubTopics.Columns["CreatedBy"].Visible = false;
            this.dataGridViewViewSubTopics.Columns["ModifiedOn"].Visible = false;
            this.dataGridViewViewSubTopics.Columns["ModifiedBy"].Visible = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridViewViewSubTopics_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == dataGridViewViewSubTopics.NewRowIndex || e.RowIndex < 0)
                return;

            //if (e.ColumnIndex == dataGridViewViewSubTopics.Columns["Edit"].Index)
            //{
            //    var data = (SubTopicModel)dataGridViewViewSubTopics.Rows[e.RowIndex].DataBoundItem;

            //    SubTopic subTopic = new SubTopic(data);
            //    subTopic.lblSubTopicID.Text = Convert.ToString(data.SubTopicID);
            //    subTopic.txtMainTopic.Text = data.MainTopicNumber;
            //    subTopic.txtSubTopicNo.Text = data.SubTopicNumber;
            //    subTopic.txtTitleSubTopic.Text = data.SubTopicTitle;
            //    subTopic.txtMaterial.Text = data.Material;

            //    subTopic.Show();

            //    this.Close();
            //}
            //else 
            if (e.ColumnIndex == dataGridViewViewSubTopics.Columns["Quizzes"].Index)
            {
                long subTopicID = Convert.ToInt64(dataGridViewViewSubTopics.Rows[e.RowIndex].Cells["SubTopicID"].Value);
                if (subTopicID > 0)
                {
                    SubTopicQuizMakerIndex quizMakerIndex = new SubTopicQuizMakerIndex(Convert.ToInt64(subTopicID));
                    quizMakerIndex.Show();
                }
            }
            //else if (e.ColumnIndex == dataGridViewViewSubTopics.Columns["Delete"].Index)
            //{

            //    long rowCount = 0;
            //    long subTopicID = Convert.ToInt64(dataGridViewViewSubTopics.Rows[e.RowIndex].Cells["SubTopicID"].Value);

            //    LessonPlannerRepository lessonPlannerRepository = new LessonPlannerRepository();
            //    rowCount = lessonPlannerRepository.DeleteSubTopic(subTopicID);

            //    if (rowCount > 0)
            //    {
            //        ShowStatus(true, "DELETE");

            //        dataGridViewViewSubTopics.DataSource = null;
            //        dataGridViewViewSubTopics.Rows.Clear();
            //        dataGridViewViewSubTopics.Columns.Clear();

            //        BindGridViewViewSubTopicsByMainTopicID(_mainTopicID);
            //    }


            //}
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

    }
}
