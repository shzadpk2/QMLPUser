namespace QuizMakerAndLessonPlanner
{
    partial class LessonPlanner
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LessonPlanner));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblMainTopicID = new System.Windows.Forms.Label();
            this.cmbGrades = new System.Windows.Forms.ComboBox();
            this.btnAddMovies = new System.Windows.Forms.Button();
            this.btnAddDocumentaries = new System.Windows.Forms.Button();
            this.btnAddBooks = new System.Windows.Forms.Button();
            this.btnAddGames = new System.Windows.Forms.Button();
            this.txtBooks = new System.Windows.Forms.TextBox();
            this.lblBooks = new System.Windows.Forms.Label();
            this.txtDocumentaries = new System.Windows.Forms.TextBox();
            this.lblDocumentaries = new System.Windows.Forms.Label();
            this.txtMovies = new System.Windows.Forms.TextBox();
            this.lblMovies = new System.Windows.Forms.Label();
            this.txtGames = new System.Windows.Forms.TextBox();
            this.lblGames = new System.Windows.Forms.Label();
            this.btnAddSubTopic = new System.Windows.Forms.Button();
            this.lblLessonPlannerID = new System.Windows.Forms.Label();
            this.txtMaterial = new System.Windows.Forms.TextBox();
            this.txtIntroduction = new System.Windows.Forms.TextBox();
            this.txtObjectives = new System.Windows.Forms.TextBox();
            this.txtTitleMainTopic = new System.Windows.Forms.TextBox();
            this.txtMainTopic = new System.Windows.Forms.TextBox();
            this.cmbSubjects = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblObjectives = new System.Windows.Forms.Label();
            this.lblMaterial = new System.Windows.Forms.Label();
            this.lblIntroduction = new System.Windows.Forms.Label();
            this.lblTitleMainTopic = new System.Windows.Forms.Label();
            this.lblMainTopic = new System.Windows.Forms.Label();
            this.lblSubject = new System.Windows.Forms.Label();
            this.lblGrade = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.errorProviderApp = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlSubTopic = new System.Windows.Forms.Panel();
            this.subtopicMaterial = new System.Windows.Forms.TextBox();
            this.txtTitleSubTopic = new System.Windows.Forms.TextBox();
            this.btnCancelSubTopic = new System.Windows.Forms.Button();
            this.btnSaveSubTopic = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTitleSubTopic = new System.Windows.Forms.Label();
            this.txtSubTopicNo = new System.Windows.Forms.TextBox();
            this.lbSubTopicNo = new System.Windows.Forms.Label();
            this.subtopicMainTopic = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderApp)).BeginInit();
            this.pnlSubTopic.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblMainTopicID);
            this.panel1.Controls.Add(this.cmbGrades);
            this.panel1.Controls.Add(this.btnAddMovies);
            this.panel1.Controls.Add(this.btnAddDocumentaries);
            this.panel1.Controls.Add(this.btnAddBooks);
            this.panel1.Controls.Add(this.btnAddGames);
            this.panel1.Controls.Add(this.txtBooks);
            this.panel1.Controls.Add(this.lblBooks);
            this.panel1.Controls.Add(this.txtDocumentaries);
            this.panel1.Controls.Add(this.lblDocumentaries);
            this.panel1.Controls.Add(this.txtMovies);
            this.panel1.Controls.Add(this.lblMovies);
            this.panel1.Controls.Add(this.txtGames);
            this.panel1.Controls.Add(this.lblGames);
            this.panel1.Controls.Add(this.btnAddSubTopic);
            this.panel1.Controls.Add(this.lblLessonPlannerID);
            this.panel1.Controls.Add(this.txtMaterial);
            this.panel1.Controls.Add(this.txtIntroduction);
            this.panel1.Controls.Add(this.txtObjectives);
            this.panel1.Controls.Add(this.txtTitleMainTopic);
            this.panel1.Controls.Add(this.txtMainTopic);
            this.panel1.Controls.Add(this.cmbSubjects);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.lblObjectives);
            this.panel1.Controls.Add(this.lblMaterial);
            this.panel1.Controls.Add(this.lblIntroduction);
            this.panel1.Controls.Add(this.lblTitleMainTopic);
            this.panel1.Controls.Add(this.lblMainTopic);
            this.panel1.Controls.Add(this.lblSubject);
            this.panel1.Controls.Add(this.lblGrade);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1038, 211);
            this.panel1.TabIndex = 0;
            // 
            // lblMainTopicID
            // 
            this.lblMainTopicID.AutoSize = true;
            this.lblMainTopicID.Location = new System.Drawing.Point(151, 4);
            this.lblMainTopicID.Name = "lblMainTopicID";
            this.lblMainTopicID.Size = new System.Drawing.Size(68, 13);
            this.lblMainTopicID.TabIndex = 35;
            this.lblMainTopicID.Text = "MainTopicID";
            this.lblMainTopicID.Visible = false;
            // 
            // cmbGrades
            // 
            this.cmbGrades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGrades.FormattingEnabled = true;
            this.cmbGrades.Location = new System.Drawing.Point(117, 28);
            this.cmbGrades.Name = "cmbGrades";
            this.cmbGrades.Size = new System.Drawing.Size(140, 21);
            this.cmbGrades.TabIndex = 34;
            this.cmbGrades.SelectedIndexChanged += new System.EventHandler(this.cmbGrades_SelectedIndexChanged);
            // 
            // btnAddMovies
            // 
            this.btnAddMovies.Location = new System.Drawing.Point(720, 65);
            this.btnAddMovies.Name = "btnAddMovies";
            this.btnAddMovies.Size = new System.Drawing.Size(37, 20);
            this.btnAddMovies.TabIndex = 33;
            this.btnAddMovies.Text = "Add";
            this.btnAddMovies.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddMovies.UseVisualStyleBackColor = true;
            this.btnAddMovies.Click += new System.EventHandler(this.btnAddMovies_Click);
            // 
            // btnAddDocumentaries
            // 
            this.btnAddDocumentaries.Location = new System.Drawing.Point(720, 94);
            this.btnAddDocumentaries.Name = "btnAddDocumentaries";
            this.btnAddDocumentaries.Size = new System.Drawing.Size(37, 20);
            this.btnAddDocumentaries.TabIndex = 32;
            this.btnAddDocumentaries.Text = "Add";
            this.btnAddDocumentaries.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddDocumentaries.UseVisualStyleBackColor = true;
            this.btnAddDocumentaries.Click += new System.EventHandler(this.btnAddDocumentaries_Click);
            // 
            // btnAddBooks
            // 
            this.btnAddBooks.Location = new System.Drawing.Point(720, 125);
            this.btnAddBooks.Name = "btnAddBooks";
            this.btnAddBooks.Size = new System.Drawing.Size(37, 20);
            this.btnAddBooks.TabIndex = 31;
            this.btnAddBooks.Text = "Add";
            this.btnAddBooks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddBooks.UseVisualStyleBackColor = true;
            this.btnAddBooks.Click += new System.EventHandler(this.btnAddBooks_Click);
            // 
            // btnAddGames
            // 
            this.btnAddGames.Location = new System.Drawing.Point(720, 33);
            this.btnAddGames.Name = "btnAddGames";
            this.btnAddGames.Size = new System.Drawing.Size(37, 20);
            this.btnAddGames.TabIndex = 30;
            this.btnAddGames.Text = "Add";
            this.btnAddGames.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddGames.UseVisualStyleBackColor = true;
            this.btnAddGames.Click += new System.EventHandler(this.btnAddGames_Click);
            // 
            // txtBooks
            // 
            this.txtBooks.Location = new System.Drawing.Point(462, 125);
            this.txtBooks.Multiline = true;
            this.txtBooks.Name = "txtBooks";
            this.txtBooks.Size = new System.Drawing.Size(237, 20);
            this.txtBooks.TabIndex = 29;
            // 
            // lblBooks
            // 
            this.lblBooks.AutoSize = true;
            this.lblBooks.Location = new System.Drawing.Point(382, 128);
            this.lblBooks.Name = "lblBooks";
            this.lblBooks.Size = new System.Drawing.Size(40, 13);
            this.lblBooks.TabIndex = 28;
            this.lblBooks.Text = "Books:";
            // 
            // txtDocumentaries
            // 
            this.txtDocumentaries.Location = new System.Drawing.Point(462, 95);
            this.txtDocumentaries.Multiline = true;
            this.txtDocumentaries.Name = "txtDocumentaries";
            this.txtDocumentaries.Size = new System.Drawing.Size(237, 20);
            this.txtDocumentaries.TabIndex = 27;
            // 
            // lblDocumentaries
            // 
            this.lblDocumentaries.AutoSize = true;
            this.lblDocumentaries.Location = new System.Drawing.Point(381, 98);
            this.lblDocumentaries.Name = "lblDocumentaries";
            this.lblDocumentaries.Size = new System.Drawing.Size(81, 13);
            this.lblDocumentaries.TabIndex = 26;
            this.lblDocumentaries.Text = "Documentaries:";
            // 
            // txtMovies
            // 
            this.txtMovies.Location = new System.Drawing.Point(462, 64);
            this.txtMovies.Multiline = true;
            this.txtMovies.Name = "txtMovies";
            this.txtMovies.Size = new System.Drawing.Size(237, 20);
            this.txtMovies.TabIndex = 25;
            // 
            // lblMovies
            // 
            this.lblMovies.AutoSize = true;
            this.lblMovies.Location = new System.Drawing.Point(381, 69);
            this.lblMovies.Name = "lblMovies";
            this.lblMovies.Size = new System.Drawing.Size(44, 13);
            this.lblMovies.TabIndex = 24;
            this.lblMovies.Text = "Movies:";
            // 
            // txtGames
            // 
            this.txtGames.Location = new System.Drawing.Point(462, 33);
            this.txtGames.Multiline = true;
            this.txtGames.Name = "txtGames";
            this.txtGames.Size = new System.Drawing.Size(237, 20);
            this.txtGames.TabIndex = 23;
            // 
            // lblGames
            // 
            this.lblGames.AutoSize = true;
            this.lblGames.Location = new System.Drawing.Point(382, 36);
            this.lblGames.Name = "lblGames";
            this.lblGames.Size = new System.Drawing.Size(43, 13);
            this.lblGames.TabIndex = 22;
            this.lblGames.Text = "Games:";
            // 
            // btnAddSubTopic
            // 
            this.btnAddSubTopic.Enabled = false;
            this.btnAddSubTopic.Location = new System.Drawing.Point(831, 116);
            this.btnAddSubTopic.Name = "btnAddSubTopic";
            this.btnAddSubTopic.Size = new System.Drawing.Size(85, 25);
            this.btnAddSubTopic.TabIndex = 21;
            this.btnAddSubTopic.Text = "Add SubTopic";
            this.btnAddSubTopic.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddSubTopic.UseVisualStyleBackColor = true;
            this.btnAddSubTopic.Visible = false;
            this.btnAddSubTopic.Click += new System.EventHandler(this.btnAddSubTopic_Click);
            // 
            // lblLessonPlannerID
            // 
            this.lblLessonPlannerID.AutoSize = true;
            this.lblLessonPlannerID.Location = new System.Drawing.Point(22, 4);
            this.lblLessonPlannerID.Name = "lblLessonPlannerID";
            this.lblLessonPlannerID.Size = new System.Drawing.Size(88, 13);
            this.lblLessonPlannerID.TabIndex = 20;
            this.lblLessonPlannerID.Text = "LessonPlannerID";
            this.lblLessonPlannerID.Visible = false;
            // 
            // txtMaterial
            // 
            this.txtMaterial.Location = new System.Drawing.Point(118, 154);
            this.txtMaterial.Multiline = true;
            this.txtMaterial.Name = "txtMaterial";
            this.txtMaterial.Size = new System.Drawing.Size(237, 38);
            this.txtMaterial.TabIndex = 19;
            // 
            // txtIntroduction
            // 
            this.txtIntroduction.Location = new System.Drawing.Point(864, 41);
            this.txtIntroduction.Name = "txtIntroduction";
            this.txtIntroduction.Size = new System.Drawing.Size(41, 20);
            this.txtIntroduction.TabIndex = 18;
            this.txtIntroduction.Visible = false;
            // 
            // txtObjectives
            // 
            this.txtObjectives.Location = new System.Drawing.Point(864, 64);
            this.txtObjectives.Name = "txtObjectives";
            this.txtObjectives.Size = new System.Drawing.Size(41, 20);
            this.txtObjectives.TabIndex = 17;
            this.txtObjectives.Visible = false;
            // 
            // txtTitleMainTopic
            // 
            this.txtTitleMainTopic.Location = new System.Drawing.Point(117, 121);
            this.txtTitleMainTopic.Multiline = true;
            this.txtTitleMainTopic.Name = "txtTitleMainTopic";
            this.txtTitleMainTopic.Size = new System.Drawing.Size(140, 20);
            this.txtTitleMainTopic.TabIndex = 14;
            // 
            // txtMainTopic
            // 
            this.txtMainTopic.Location = new System.Drawing.Point(117, 91);
            this.txtMainTopic.Name = "txtMainTopic";
            this.txtMainTopic.ReadOnly = true;
            this.txtMainTopic.Size = new System.Drawing.Size(140, 20);
            this.txtMainTopic.TabIndex = 13;
            // 
            // cmbSubjects
            // 
            this.cmbSubjects.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSubjects.FormattingEnabled = true;
            this.cmbSubjects.Location = new System.Drawing.Point(117, 60);
            this.cmbSubjects.Name = "cmbSubjects";
            this.cmbSubjects.Size = new System.Drawing.Size(140, 21);
            this.cmbSubjects.TabIndex = 11;
            this.cmbSubjects.SelectedIndexChanged += new System.EventHandler(this.cmbSubjects_SelectedIndexChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(789, 73);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(105, 23);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Back";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblObjectives
            // 
            this.lblObjectives.AutoSize = true;
            this.lblObjectives.Location = new System.Drawing.Point(900, 71);
            this.lblObjectives.Name = "lblObjectives";
            this.lblObjectives.Size = new System.Drawing.Size(57, 13);
            this.lblObjectives.TabIndex = 8;
            this.lblObjectives.Text = "Objectives";
            this.lblObjectives.Visible = false;
            // 
            // lblMaterial
            // 
            this.lblMaterial.AutoSize = true;
            this.lblMaterial.Location = new System.Drawing.Point(19, 161);
            this.lblMaterial.Name = "lblMaterial";
            this.lblMaterial.Size = new System.Drawing.Size(47, 13);
            this.lblMaterial.TabIndex = 7;
            this.lblMaterial.Text = "Material:";
            // 
            // lblIntroduction
            // 
            this.lblIntroduction.AutoSize = true;
            this.lblIntroduction.Location = new System.Drawing.Point(900, 48);
            this.lblIntroduction.Name = "lblIntroduction";
            this.lblIntroduction.Size = new System.Drawing.Size(63, 13);
            this.lblIntroduction.TabIndex = 6;
            this.lblIntroduction.Text = "Introduction";
            this.lblIntroduction.Visible = false;
            // 
            // lblTitleMainTopic
            // 
            this.lblTitleMainTopic.AutoSize = true;
            this.lblTitleMainTopic.Location = new System.Drawing.Point(18, 128);
            this.lblTitleMainTopic.Name = "lblTitleMainTopic";
            this.lblTitleMainTopic.Size = new System.Drawing.Size(86, 13);
            this.lblTitleMainTopic.TabIndex = 3;
            this.lblTitleMainTopic.Text = "Title Main Topic:";
            // 
            // lblMainTopic
            // 
            this.lblMainTopic.AutoSize = true;
            this.lblMainTopic.Location = new System.Drawing.Point(19, 98);
            this.lblMainTopic.Name = "lblMainTopic";
            this.lblMainTopic.Size = new System.Drawing.Size(70, 13);
            this.lblMainTopic.TabIndex = 2;
            this.lblMainTopic.Text = "Main Topic #";
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Location = new System.Drawing.Point(19, 68);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(46, 13);
            this.lblSubject.TabIndex = 1;
            this.lblSubject.Text = "Subject:";
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.Location = new System.Drawing.Point(19, 36);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(39, 13);
            this.lblGrade.TabIndex = 0;
            this.lblGrade.Text = "Grade:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(464, 399);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(85, 25);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // errorProviderApp
            // 
            this.errorProviderApp.ContainerControl = this;
            // 
            // pnlSubTopic
            // 
            this.pnlSubTopic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSubTopic.Controls.Add(this.subtopicMaterial);
            this.pnlSubTopic.Controls.Add(this.txtTitleSubTopic);
            this.pnlSubTopic.Controls.Add(this.btnCancelSubTopic);
            this.pnlSubTopic.Controls.Add(this.btnSaveSubTopic);
            this.pnlSubTopic.Controls.Add(this.label1);
            this.pnlSubTopic.Controls.Add(this.lblTitleSubTopic);
            this.pnlSubTopic.Controls.Add(this.txtSubTopicNo);
            this.pnlSubTopic.Controls.Add(this.lbSubTopicNo);
            this.pnlSubTopic.Controls.Add(this.subtopicMainTopic);
            this.pnlSubTopic.Controls.Add(this.label2);
            this.pnlSubTopic.Location = new System.Drawing.Point(1, 218);
            this.pnlSubTopic.Name = "pnlSubTopic";
            this.pnlSubTopic.Size = new System.Drawing.Size(1038, 155);
            this.pnlSubTopic.TabIndex = 1;
            // 
            // subtopicMaterial
            // 
            this.subtopicMaterial.Location = new System.Drawing.Point(462, 58);
            this.subtopicMaterial.Multiline = true;
            this.subtopicMaterial.Name = "subtopicMaterial";
            this.subtopicMaterial.Size = new System.Drawing.Size(237, 38);
            this.subtopicMaterial.TabIndex = 35;
            // 
            // txtTitleSubTopic
            // 
            this.txtTitleSubTopic.Location = new System.Drawing.Point(462, 32);
            this.txtTitleSubTopic.Name = "txtTitleSubTopic";
            this.txtTitleSubTopic.Size = new System.Drawing.Size(140, 20);
            this.txtTitleSubTopic.TabIndex = 34;
            // 
            // btnCancelSubTopic
            // 
            this.btnCancelSubTopic.Location = new System.Drawing.Point(144, 123);
            this.btnCancelSubTopic.Name = "btnCancelSubTopic";
            this.btnCancelSubTopic.Size = new System.Drawing.Size(75, 23);
            this.btnCancelSubTopic.TabIndex = 33;
            this.btnCancelSubTopic.Text = "Cancel";
            this.btnCancelSubTopic.UseVisualStyleBackColor = true;
            this.btnCancelSubTopic.Visible = false;
            this.btnCancelSubTopic.Click += new System.EventHandler(this.btnCancelSubTopic_Click);
            // 
            // btnSaveSubTopic
            // 
            this.btnSaveSubTopic.Location = new System.Drawing.Point(24, 123);
            this.btnSaveSubTopic.Name = "btnSaveSubTopic";
            this.btnSaveSubTopic.Size = new System.Drawing.Size(85, 25);
            this.btnSaveSubTopic.TabIndex = 32;
            this.btnSaveSubTopic.Text = "Add";
            this.btnSaveSubTopic.UseVisualStyleBackColor = true;
            this.btnSaveSubTopic.Click += new System.EventHandler(this.btnSaveSubTopic_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(381, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Material:";
            // 
            // lblTitleSubTopic
            // 
            this.lblTitleSubTopic.AutoSize = true;
            this.lblTitleSubTopic.Location = new System.Drawing.Point(381, 35);
            this.lblTitleSubTopic.Name = "lblTitleSubTopic";
            this.lblTitleSubTopic.Size = new System.Drawing.Size(82, 13);
            this.lblTitleSubTopic.TabIndex = 30;
            this.lblTitleSubTopic.Text = "Title Sub Topic:";
            // 
            // txtSubTopicNo
            // 
            this.txtSubTopicNo.Location = new System.Drawing.Point(117, 68);
            this.txtSubTopicNo.Name = "txtSubTopicNo";
            this.txtSubTopicNo.ReadOnly = true;
            this.txtSubTopicNo.Size = new System.Drawing.Size(140, 20);
            this.txtSubTopicNo.TabIndex = 29;
            // 
            // lbSubTopicNo
            // 
            this.lbSubTopicNo.AutoSize = true;
            this.lbSubTopicNo.Location = new System.Drawing.Point(21, 71);
            this.lbSubTopicNo.Name = "lbSubTopicNo";
            this.lbSubTopicNo.Size = new System.Drawing.Size(66, 13);
            this.lbSubTopicNo.TabIndex = 28;
            this.lbSubTopicNo.Text = "Sub Topic #";
            // 
            // subtopicMainTopic
            // 
            this.subtopicMainTopic.Location = new System.Drawing.Point(117, 32);
            this.subtopicMainTopic.Name = "subtopicMainTopic";
            this.subtopicMainTopic.ReadOnly = true;
            this.subtopicMainTopic.Size = new System.Drawing.Size(140, 20);
            this.subtopicMainTopic.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Main Topic #";
            // 
            // LessonPlanner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1061, 475);
            this.Controls.Add(this.pnlSubTopic);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSave);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LessonPlanner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lesson Planner";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderApp)).EndInit();
            this.pnlSubTopic.ResumeLayout(false);
            this.pnlSubTopic.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblObjectives;
        private System.Windows.Forms.Label lblMaterial;
        private System.Windows.Forms.Label lblIntroduction;
        private System.Windows.Forms.Label lblTitleMainTopic;
        private System.Windows.Forms.Label lblMainTopic;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        public System.Windows.Forms.ComboBox cmbSubjects;
        public System.Windows.Forms.TextBox txtMainTopic;
        public System.Windows.Forms.TextBox txtTitleMainTopic;
        public System.Windows.Forms.TextBox txtMaterial;
        public System.Windows.Forms.TextBox txtIntroduction;
        public System.Windows.Forms.TextBox txtObjectives;
        public System.Windows.Forms.Label lblLessonPlannerID;
        private System.Windows.Forms.ErrorProvider errorProviderApp;
        private System.Windows.Forms.Button btnAddSubTopic;
        public System.Windows.Forms.TextBox txtGames;
        private System.Windows.Forms.Label lblGames;
        public System.Windows.Forms.TextBox txtMovies;
        private System.Windows.Forms.Label lblMovies;
        public System.Windows.Forms.TextBox txtDocumentaries;
        private System.Windows.Forms.Label lblDocumentaries;
        public System.Windows.Forms.TextBox txtBooks;
        private System.Windows.Forms.Label lblBooks;
        private System.Windows.Forms.Button btnAddGames;
        private System.Windows.Forms.Button btnAddMovies;
        private System.Windows.Forms.Button btnAddDocumentaries;
        private System.Windows.Forms.Button btnAddBooks;
        public System.Windows.Forms.ComboBox cmbGrades;
        public System.Windows.Forms.Label lblMainTopicID;
        private System.Windows.Forms.Panel pnlSubTopic;
        public System.Windows.Forms.TextBox subtopicMaterial;
        public System.Windows.Forms.TextBox txtTitleSubTopic;
        private System.Windows.Forms.Button btnCancelSubTopic;
        private System.Windows.Forms.Button btnSaveSubTopic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTitleSubTopic;
        public System.Windows.Forms.TextBox txtSubTopicNo;
        private System.Windows.Forms.Label lbSubTopicNo;
        public System.Windows.Forms.TextBox subtopicMainTopic;
        private System.Windows.Forms.Label label2;
    }
}