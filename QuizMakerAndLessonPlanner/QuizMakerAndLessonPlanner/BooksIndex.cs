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
    public partial class BooksIndex : Form
    {
        public BooksIndex()
        {
            InitializeComponent();
        }

        private void dataGridViewBooks_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //Width
            this.dataGridViewBooks.Columns["BookDescription"].Width = 400;
            this.dataGridViewBooks.Columns["MainTopicNumber"].Width = 150;

            //Visibility
            //this.dataGridViewMovies.Columns["MovieID"].Visible = false;
            this.dataGridViewBooks.Columns["MainTopicID"].Visible = false;
            this.dataGridViewBooks.Columns["CreatedOn"].Visible = false;
            this.dataGridViewBooks.Columns["CreatedBy"].Visible = false;
            this.dataGridViewBooks.Columns["ModifiedOn"].Visible = false;
            this.dataGridViewBooks.Columns["ModifiedBy"].Visible = false;
        }

        private void BindGridViewBooks()
        {
            LessonPlannerRepository lessonPlannerRepository = new LessonPlannerRepository();
            List<BooksModel> booksModels = new List<BooksModel>();
            DataTable dataTable = new DataTable();

            try
            {
                dataTable = lessonPlannerRepository.GetAllBooks();

                booksModels = TranslateDataTableToBooksModel(dataTable);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Network error...Please try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {

                dataTable.Clear();
                dataTable = null;
                dataGridViewBooks.DataSource = booksModels;
            }
        }

        private List<BooksModel> TranslateDataTableToBooksModel(DataTable dataTable)
        {
            List<BooksModel> booksModels = new List<BooksModel>();


            foreach (DataRow row in dataTable.Rows)
            {
                BooksModel booksModel = new BooksModel();
                booksModel.BookID = row["BookID"] != DBNull.Value ? Convert.ToInt64(row["BookID"].ToString()) : 0;
                booksModel.MainTopicID = row["MainTopicID"] != DBNull.Value ? Convert.ToInt64(row["MainTopicID"].ToString()) : 0;
                booksModel.MainTopicNumber = row["MainTopicNumber"] != DBNull.Value ? Convert.ToString(row["MainTopicNumber"]) : string.Empty;
                booksModel.BookDescription = row["BookDescription"] != DBNull.Value ? Convert.ToString(row["BookDescription"].ToString()) : string.Empty;

                booksModels.Add(booksModel);
            }


            return booksModels;
        }

        private void BooksIndex_Load(object sender, EventArgs e)
        {
            BindGridViewBooks();

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
            //dataGridViewBooks.Columns.Add(Deletelink);

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Reports reports = new Reports();
            reports.Show();
        }

        private void dataGridViewBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.ColumnIndex == dataGridViewBooks.Columns["Delete"].Index)
            //{
            //    int rowCount = 0;
            //    long bookID = Convert.ToInt64(dataGridViewBooks.Rows[e.RowIndex].Cells["BookID"].Value);

            //    LessonPlannerRepository lessonPlannerRepository = new LessonPlannerRepository();
            //    rowCount = lessonPlannerRepository.DeleteBookByID(bookID);

            //    if (rowCount > 0)
            //    {
            //        ShowStatus(true, "DELETE");
            //        BindGridViewBooks();
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
