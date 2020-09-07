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
    public partial class SubTopic : Form
    {
        private long _mainTopicID = 0;
        public SubTopic()
        {
            InitializeComponent();
            lblSubTopicID.Text = "0";

        }
        public SubTopic(SubTopicModel subTopicModel) ////EDIT
        {
            InitializeComponent();
            
            lblSubTopicID.Text = Convert.ToString(subTopicModel.SubTopicID);
        }
        public SubTopic(long mainTopicID)
        {
            InitializeComponent();
            _mainTopicID = mainTopicID;
            lblSubTopicID.Text = "0";
        }

        //Constructor With MainTopic Model
        public SubTopic(MainTopicModel mainTopicModel)
        {
            InitializeComponent();

            if (mainTopicModel != null)
            {
                if (!string.IsNullOrEmpty(mainTopicModel.MainTopicNumber))
                {
                    string mainTopicNumber = mainTopicModel.MainTopicNumber;

                    //Get The Last Created SubTopic Against The Main Topic
                    string subTopicNumber = mainTopicNumber + "A";
                    txtMainTopic.Text = mainTopicNumber;
                    txtSubTopicNo.Text = subTopicNumber;
                } 
            }


        }

        private void SubTopic_Load(object sender, EventArgs e)
        {
            if (lblSubTopicID.Text == "0")
            {
                string[] subTopicPostLetters = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
                txtMainTopic.Text = LessonPlanner.MainTopicNumberGlobal;
                if (LessonPlanner.subTopicModelsListGlobal == null || LessonPlanner.subTopicModelsListGlobal.Count == 0)
                {
                    txtSubTopicNo.Text = LessonPlanner.MainTopicNumberGlobal + "A";
                }
                else
                {
                    int countOfAlreadyAdded = LessonPlanner.subTopicModelsListGlobal.Count();

                    txtSubTopicNo.Text = LessonPlanner.MainTopicNumberGlobal + subTopicPostLetters[countOfAlreadyAdded];

                } 
            }
        }

        private static int GetclosestMultiple(int n, int x)
        {

            if (x > n)
                return x;
            n = n + x / 2;
            n = n - (n % x);
            return n;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            LessonPlanner lessonPlanner = new LessonPlanner();

            if (lblSubTopicID.Text == "0")           //ADD
            {
                SubTopicModel subTopicModel = new SubTopicModel();
                subTopicModel.MainTopicID = _mainTopicID;
                subTopicModel.MainTopicNumber = txtMainTopic.Text;
                subTopicModel.SubTopicNumber = txtSubTopicNo.Text;
                subTopicModel.SubTopicTitle = txtTitleSubTopic.Text;
                subTopicModel.Material = txtMaterial.Text;
                subTopicModel.CreatedOn = DateTime.Now;
                subTopicModel.CreatedBy = 1;
                subTopicModel.ModifiedOn = DateTime.Now;
                subTopicModel.ModifiedBy = 1;

                LessonPlanner.subTopicModelsListGlobal.Add(subTopicModel);

                if (LessonPlanner.subTopicModelsListGlobal != null && LessonPlanner.subTopicModelsListGlobal.Count() > 0)
                {
                    LessonPlanner lesson = (LessonPlanner)Application.OpenForms["LessonPlanner"];
                    if (lesson != null)
                    {
                        //int subTopicMaterialAdded = LessonPlanner.subTopicModelsListGlobal.Where(x => !string.IsNullOrEmpty(x.Material)).Count();
                        //if (subTopicMaterialAdded > 0)
                        //{

                        //}
                        lesson.txtMaterial.Text = "";
                    }
                } 
            }
            else            //EDIT
            {
                SubTopicModel subTopicModel = new SubTopicModel();
                //subTopicModel.MainTopicID = Convert.ToInt64();
                subTopicModel.SubTopicID = Convert.ToInt64(lblSubTopicID.Text);
                subTopicModel.MainTopicNumber = txtMainTopic.Text;
                subTopicModel.SubTopicNumber = txtSubTopicNo.Text;
                subTopicModel.SubTopicTitle = txtTitleSubTopic.Text;
                subTopicModel.Material = txtMaterial.Text;
                subTopicModel.ModifiedOn = DateTime.Now;
                subTopicModel.ModifiedBy = 1;

                LessonPlannerRepository lessonPlannerRepository = new LessonPlannerRepository();
                long result = lessonPlannerRepository.EditSubTopic(subTopicModel);
                if (result > 0)
                {
                    ShowStatus(true, "ADD");
                }
                //SaveToDB
            }

            this.Close();
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
