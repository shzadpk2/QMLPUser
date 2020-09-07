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
    public partial class DocumentariesIndex : Form
    {
        public DocumentariesIndex()
        {
            InitializeComponent();
        }

        private void DocumentariesIndex_Load(object sender, EventArgs e)
        {
            BindGridViewDocumentaries();

            //DataGridViewLinkColumn Editlink = new DataGridViewLinkColumn();
            //Editlink.UseColumnTextForLinkValue = true;
            //Editlink.HeaderText = "Edit";
            //Editlink.Name = "Edit";
            //Editlink.DataPropertyName = "lnkColumn";
            //Editlink.LinkBehavior = LinkBehavior.SystemDefault;
            //Editlink.Text = "Edit";
            //dataGridViewQuizMaker.Columns.Add(Editlink);

            //DataGridViewLinkColumn Deletelink = new DataGridViewLinkColumn();
            //Deletelink.UseColumnTextForLinkValue = true;
            //Deletelink.HeaderText = "Delete";
            //Deletelink.Name = "Delete";
            //Deletelink.DataPropertyName = "lnkColumn";
            //Deletelink.LinkBehavior = LinkBehavior.SystemDefault;
            //Deletelink.Text = "Delete";
            //dataGridViewDocumentaries.Columns.Add(Deletelink);
        }

        private void BindGridViewDocumentaries()
        {
            LessonPlannerRepository lessonPlannerRepository = new LessonPlannerRepository();
            List<DocumentariesModel> documentariesModels = new List<DocumentariesModel>();
            DataTable dataTable = new DataTable();

            try
            {
                dataTable = lessonPlannerRepository.GetAllDocumentaries();

                documentariesModels = TranslateDataTableToDocumentariesModel(dataTable);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Network error...Please try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {

                dataTable.Clear();
                dataTable = null;
                dataGridViewDocumentaries.DataSource = documentariesModels;

            }
        }

        private List<DocumentariesModel> TranslateDataTableToDocumentariesModel(DataTable dataTable)
        {
            List<DocumentariesModel> documentariesModels = new List<DocumentariesModel>();


            foreach (DataRow row in dataTable.Rows)
            {
                DocumentariesModel documentaries = new DocumentariesModel();
                documentaries.DocumentaryID = row["DocumentaryID"] != DBNull.Value ? Convert.ToInt64(row["DocumentaryID"].ToString()) : 0;
                documentaries.MainTopicID = row["MainTopicID"] != DBNull.Value ? Convert.ToInt64(row["MainTopicID"].ToString()) : 0;
                documentaries.MainTopicNumber = row["MainTopicNumber"] != DBNull.Value ? Convert.ToString(row["MainTopicNumber"]) : string.Empty;
                documentaries.DocumentaryDescription = row["DocumentaryDescription"] != DBNull.Value ? Convert.ToString(row["DocumentaryDescription"].ToString()) : string.Empty;

                documentariesModels.Add(documentaries);
            }


            return documentariesModels;
        }


        private void dataGridViewDocumentaries_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //Width
            this.dataGridViewDocumentaries.Columns["DocumentaryDescription"].Width = 400;
            this.dataGridViewDocumentaries.Columns["MainTopicNumber"].Width = 150;

            //Visibility
            //this.dataGridViewMovies.Columns["MovieID"].Visible = false;
            this.dataGridViewDocumentaries.Columns["MainTopicID"].Visible = false;
            this.dataGridViewDocumentaries.Columns["CreatedOn"].Visible = false;
            this.dataGridViewDocumentaries.Columns["CreatedBy"].Visible = false;
            this.dataGridViewDocumentaries.Columns["ModifiedOn"].Visible = false;
            this.dataGridViewDocumentaries.Columns["ModifiedBy"].Visible = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Reports reports = new Reports();
            reports.Show();
        }

        private void dataGridViewDocumentaries_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.ColumnIndex == dataGridViewDocumentaries.Columns["Delete"].Index)
            //{
            //    int rowCount = 0;
            //    long documentaryID = Convert.ToInt64(dataGridViewDocumentaries.Rows[e.RowIndex].Cells["DocumentaryID"].Value);

            //    LessonPlannerRepository lessonPlannerRepository = new LessonPlannerRepository();
            //    rowCount = lessonPlannerRepository.DeleteDocumentayByID(documentaryID);

            //    if (rowCount > 0)
            //    {
            //        ShowStatus(true, "DELETE");
            //        BindGridViewDocumentaries();
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
