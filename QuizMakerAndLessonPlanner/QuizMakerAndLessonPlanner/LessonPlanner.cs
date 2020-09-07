using QMLPModels;
using QMLPRepository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizMakerAndLessonPlanner
{
    public partial class LessonPlanner : Form
    {
        private long _lessonPlannerID = 0;
        private static LessonPlanner _instance;
        public static string MainTopicNumberGlobal = string.Empty;
        public static List<SubTopicModel> subTopicModelsListGlobal = new List<SubTopicModel>();
        public static List<GamesModel> gamesModelsListGlobal = new List<GamesModel>();
        public static List<MoviesModel> moviesModelsListGlobal = new List<MoviesModel>();
        public static List<DocumentariesModel> documentariesModelsListGlobal = new List<DocumentariesModel>();
        public static List<BooksModel> booksModelsListGlobal = new List<BooksModel>();

        public static LessonPlanner Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new LessonPlanner();
                return _instance;
            }
        }
        public LessonPlanner()  //ADD
        {

            InitializeComponent();
            FillGradesCombo(0);
            lblLessonPlannerID.Text = "0";
            lblMainTopicID.Text = "0";
        }

        public LessonPlanner(LessonPlannerModel lessonPlannerModel) ////EDIT
        {
            InitializeComponent();
            _lessonPlannerID = lessonPlannerModel.LessonPlannerID;

            FillGradesCombo(lessonPlannerModel.GradeID);
            FillSubjectCombo(lessonPlannerModel.SubjectID);
            lblLessonPlannerID.Text = Convert.ToString(lessonPlannerModel.LessonPlannerID);
            lblMainTopicID.Text = Convert.ToString(lessonPlannerModel.MainTopicID);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            Home home = new Home();
            home.Show();
        }

        private void FillGradesCombo(long gradeID)
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

            if (gradeID > 0)
            {
                cmbGrades.SelectedValue = gradeID;
            }
            else
            {
                cmbGrades.SelectedIndex = -1;
            }

            this.cmbGrades.SelectedIndexChanged += new EventHandler(cmbGrades_SelectedIndexChanged);

            if(_lessonPlannerID > 0) cmbGrades.Enabled = false;
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
        private void FillSubjectCombo(long subjectID)
        {
            SubjectsRepository subjectsRepository = new SubjectsRepository();
            List<SubjectModel> subjectModels = subjectsRepository.GetAllSubjects();

            BindingSource bs = new BindingSource();
            bs.DataSource = subjectModels;

            cmbSubjects.ValueMember = "SubjectID";
            cmbSubjects.DisplayMember = "SubjectName";

            cmbSubjects.SelectedValue = subjectID;

            cmbSubjects.DataSource = bs;

            if (_lessonPlannerID > 0) cmbSubjects.Enabled = false;
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmbGrades.Text))
            {
                MessageBox.Show("Grade can't be blank!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (string.IsNullOrEmpty(cmbSubjects.Text))
            {
                MessageBox.Show("Subject can't be blank!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (string.IsNullOrEmpty(txtTitleMainTopic.Text))
            {
                MessageBox.Show("Title main topic can't be blank!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if ((subTopicModelsListGlobal ==  null || subTopicModelsListGlobal.Count == 0) && txtMaterial.Text == string.Empty)
            {
                MessageBox.Show("Main topic's material can't be blank!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                LessonPlannerModel lessonPlannerModel = new LessonPlannerModel();

                lessonPlannerModel.LessonPlannerID = Convert.ToInt32(lblLessonPlannerID.Text);
                lessonPlannerModel.MainTopicID = Convert.ToInt32(lblMainTopicID.Text);
                lessonPlannerModel.GradeID = Convert.ToInt64(cmbGrades.SelectedValue);
                lessonPlannerModel.SubjectID = Convert.ToInt64(cmbSubjects.SelectedValue);
                lessonPlannerModel.MainTopicNumber = txtMainTopic.Text;
                lessonPlannerModel.TitleMainTopic = txtTitleMainTopic.Text;
                lessonPlannerModel.Introduction = txtIntroduction.Text;
                lessonPlannerModel.Objectives = txtObjectives.Text;
                lessonPlannerModel.Material = txtMaterial.Text;
                lessonPlannerModel.CreatedOn = DateTime.Now;
                lessonPlannerModel.CreatedBy = 1; // It will be added from users
                lessonPlannerModel.ModifiedOn = DateTime.Now;
                lessonPlannerModel.ModifiedBy = 1; // It will be added from users

                lessonPlannerModel.subTopicModels = subTopicModelsListGlobal;
                lessonPlannerModel.gamesModels = gamesModelsListGlobal;
                lessonPlannerModel.moviesModels = moviesModelsListGlobal;
                lessonPlannerModel.documentariesModels = documentariesModelsListGlobal;
                lessonPlannerModel.booksModels = booksModelsListGlobal;

                try
                {
                    LessonPlannerRepository lessonPlannerRepository = new LessonPlannerRepository();
                    long result = lessonPlannerRepository.SaveUpdateLessonPlanner(lessonPlannerModel);
                    if (result > 0)
                    {
                        ShowStatus(true, "ADD");
                    }
                    else
                    {
                        ShowStatus(false, string.Empty);
                    }

                    lessonPlannerModel.subTopicModels = new List<SubTopicModel>();
                    lessonPlannerModel.gamesModels = new List<GamesModel>();
                    lessonPlannerModel.moviesModels = new List<MoviesModel>();
                    lessonPlannerModel.documentariesModels = new List<DocumentariesModel>();
                    lessonPlannerModel.booksModels = new List<BooksModel>();

                    subTopicModelsListGlobal = new List<SubTopicModel>();
                    gamesModelsListGlobal = new List<GamesModel>();
                    moviesModelsListGlobal = new List<MoviesModel>();
                    documentariesModelsListGlobal = new List<DocumentariesModel>();
                    booksModelsListGlobal = new List<BooksModel>();

                }
                catch (Exception ex)
                {
                    ShowStatus(false, string.Empty);
                }

                clearSubTopicFields();
            }
        }
        public void ClearFields() // Clear the fields after Insert or Update or Delete operation  
        {
            lblLessonPlannerID.Text = "0";
            cmbGrades.SelectedIndex = -1;
            cmbSubjects.SelectedIndex = -1;
            txtMainTopic.Text = "";
            txtTitleMainTopic.Text = "";
            txtIntroduction.Text = "";
            txtObjectives.Text = "";
            txtMaterial.Text = "";
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
            ClearFields();
        }

        private void btnAddGames_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtGames.Text))
            {
                gamesModelsListGlobal.Add(new GamesModel()
                {
                    MainTopicID = Convert.ToInt64(lblMainTopicID.Text),
                    GameDescription = txtGames.Text,
                    CreatedOn = DateTime.Now,
                    CreatedBy = 1,
                    ModifiedOn = DateTime.Now,
                    ModifiedBy = 1

                });

                txtGames.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Please Add Game!..", "Add Game", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
        private void btnAddMovies_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMovies.Text))
            {
                moviesModelsListGlobal.Add(new MoviesModel()
                {
                    MainTopicID = Convert.ToInt64(lblMainTopicID.Text),
                    MovieDescription = txtMovies.Text,
                    CreatedOn = DateTime.Now,
                    CreatedBy = 1,
                    ModifiedOn = DateTime.Now,
                    ModifiedBy = 1

                });

                txtMovies.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Please Add Movie!..", "Add Movie", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
        private void btnAddDocumentaries_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDocumentaries.Text))
            {
                documentariesModelsListGlobal.Add(new DocumentariesModel()
                {
                    MainTopicID = Convert.ToInt64(lblMainTopicID.Text),
                    DocumentaryDescription = txtDocumentaries.Text,
                    CreatedOn = DateTime.Now,
                    CreatedBy = 1,
                    ModifiedOn = DateTime.Now,
                    ModifiedBy = 1

                });

                txtDocumentaries.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Please Add Documentary!..", "Add Documentary", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
        private void btnAddBooks_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBooks.Text))
            {
                booksModelsListGlobal.Add(new BooksModel()
                {
                    MainTopicID = Convert.ToInt64(lblMainTopicID.Text),
                    BookDescription = txtBooks.Text,
                    CreatedOn = DateTime.Now,
                    CreatedBy = 1,
                    ModifiedOn = DateTime.Now,
                    ModifiedBy = 1

                });

                txtBooks.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Please Add Book!..", "Add Book", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void cmbGrades_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt64(cmbGrades.SelectedValue) > 0)
            {
                FillSubjectComboByGradeID(Convert.ToInt64(cmbGrades.SelectedValue));
            }

            string gradeText = "";
            string subjectText = "";

            if (!string.IsNullOrEmpty(cmbGrades.Text) && !string.IsNullOrEmpty(cmbSubjects.Text))
            {
                LessonPlannerRepository lessonPlannerRepository = new LessonPlannerRepository();
                long maxMainTopic = lessonPlannerRepository.GetMaxMainTopic(Convert.ToInt64(cmbGrades.SelectedValue), Convert.ToInt64(cmbSubjects.SelectedValue)) + 1;
                string maxmainTopic = maxMainTopic < 10 ? "0" + maxMainTopic : maxMainTopic.ToString();

                gradeText = cmbGrades.Text;
                subjectText = cmbSubjects.Text;
                string mainTopicNumber = gradeText + subjectText.Substring(0, 1) + maxmainTopic;
                txtMainTopic.Text = mainTopicNumber;
                btnAddSubTopic.Enabled = true;
                //MainTopicNumberGlobal = txtMainTopic.Text;
            }
            else
            {
                txtMainTopic.Text = "";
            }

            if (pnlSubTopic.Visible)
            {
                SetSubTopicValues();
            }
        }

        private void cmbSubjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            string gradeText = "";
            string subjectText = "";

            if (!string.IsNullOrEmpty(cmbGrades.Text) && !string.IsNullOrEmpty(cmbSubjects.Text))
            {
                LessonPlannerRepository lessonPlannerRepository = new LessonPlannerRepository();
                long maxMainTopic = lessonPlannerRepository.GetMaxMainTopic(Convert.ToInt64(cmbGrades.SelectedValue), Convert.ToInt64(cmbSubjects.SelectedValue)) + 1;
                string maxmainTopic = maxMainTopic < 10 ? "0" + maxMainTopic : maxMainTopic.ToString();

                gradeText = cmbGrades.Text;
                subjectText = cmbSubjects.Text;
                string mainTopicNumber = gradeText + subjectText.Substring(0, 1) + maxmainTopic;
                txtMainTopic.Text = mainTopicNumber;
                btnAddSubTopic.Enabled = true;
                //MainTopicNumberGlobal = txtMainTopic.Text;
            }
            else
            {
                txtMainTopic.Text = "";
            }
            if (pnlSubTopic.Visible)
            {
                SetSubTopicValues();
            }
        }

        private void btnAddSubTopic_Click(object sender, EventArgs e)
        {
            if (LessonPlanner.subTopicModelsListGlobal.Count() == 26)
            {
                MessageBox.Show("Maximum SubTopic Limit Reached!", "SubTopic Limit Reached", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //SubTopic subTopic = new SubTopic(Convert.ToInt64(lblMainTopicID.Text));
                //MainTopicNumberGlobal = txtMainTopic.Text;
                //subTopic.Show();
                SetSubTopicValues();
                txtSubTopicNo.Text = GetSubTopicNumber();
                //pnlSubTopic.Show();
            }

        }

        private void SetSubTopicValues()
        {
            MainTopicNumberGlobal = txtMainTopic.Text;
            subtopicMainTopic.Text = txtMainTopic.Text;
            if (!string.IsNullOrEmpty(txtMainTopic.Text))
            {
                txtSubTopicNo.Text = GetSubTopicNumber();
            }
            txtTitleSubTopic.Text = "";
            subtopicMaterial.Text = "";
            //pnlSubTopic.Show();
        }
        private string GetSubTopicNumber()
        {
            string result = "";
            string[] subTopicPostLetters = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
            txtMainTopic.Text = LessonPlanner.MainTopicNumberGlobal;
            if (LessonPlanner.subTopicModelsListGlobal == null || LessonPlanner.subTopicModelsListGlobal.Count == 0)
            {
                result = LessonPlanner.MainTopicNumberGlobal + "A";
            }
            else
            {
                int countOfAlreadyAdded = LessonPlanner.subTopicModelsListGlobal.Count();
                if (countOfAlreadyAdded < subTopicPostLetters.Length)
                {
                    result = LessonPlanner.MainTopicNumberGlobal + subTopicPostLetters[countOfAlreadyAdded];
                }
                //else
                //{
                  //  MessageBox.Show("Main Topic # can't be blank!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                   // return;
                //}

            }

            return result;
        }

        private void btnCancelSubTopic_Click(object sender, EventArgs e)
        {
            clearSubTopicFields();
            //pnlSubTopic.Hide();
        }

        private void clearSubTopicFields()
        {
            subtopicMainTopic.Text = "";
            txtSubTopicNo.Text = "";
            txtTitleSubTopic.Text = "";
            subtopicMaterial.Text = "";
        }

        private void btnSaveSubTopic_Click(object sender, EventArgs e)
        {
            if (LessonPlanner.subTopicModelsListGlobal.Count() == 26)
            {
                MessageBox.Show("Maximum SubTopic Limit Reached!", "SubTopic Limit Reached", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (string.IsNullOrEmpty(txtMainTopic.Text))
            {
                MessageBox.Show("Main Topic # can't be blank!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (string.IsNullOrEmpty(txtSubTopicNo.Text))
            {
                MessageBox.Show("Sub Topic # can't be blank!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (string.IsNullOrEmpty(txtTitleSubTopic.Text))
            {
                MessageBox.Show("Title Sub Topic can't be blank!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (string.IsNullOrEmpty(subtopicMaterial.Text))
            {
                MessageBox.Show("Sub Topic's Material can't be blank!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {

            
            SubTopicModel subTopicModel = new SubTopicModel();
            subTopicModel.MainTopicID = Convert.ToInt64(lblMainTopicID.Text);
            subTopicModel.MainTopicNumber = txtMainTopic.Text;
            subTopicModel.SubTopicNumber = txtSubTopicNo.Text;
            subTopicModel.SubTopicTitle = txtTitleSubTopic.Text;
            subTopicModel.Material = subtopicMaterial.Text;
            subTopicModel.CreatedOn = DateTime.Now;
            subTopicModel.CreatedBy = 1;
            subTopicModel.ModifiedOn = DateTime.Now;
            subTopicModel.ModifiedBy = 1;

            subTopicModelsListGlobal.Add(subTopicModel);

            if (LessonPlanner.subTopicModelsListGlobal != null && LessonPlanner.subTopicModelsListGlobal.Count() > 0)
            {
                txtMaterial.Text = "";
                    txtMaterial.ReadOnly = true;
            }
            }
            SetSubTopicValues();
            //pnlSubTopic.Hide();
        }
    }
}
