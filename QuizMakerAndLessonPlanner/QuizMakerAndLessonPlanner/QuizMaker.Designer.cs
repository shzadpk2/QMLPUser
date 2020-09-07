namespace QuizMakerAndLessonPlanner
{
    partial class QuizMaker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuizMaker));
            this.txtTimeLimit = new System.Windows.Forms.TextBox();
            this.lblTimeLimit = new System.Windows.Forms.Label();
            this.txtQuizNumber = new System.Windows.Forms.TextBox();
            this.lblQuizNumber = new System.Windows.Forms.Label();
            this.txtInstructions = new System.Windows.Forms.TextBox();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.txtTotalScores = new System.Windows.Forms.TextBox();
            this.lblTotalScores = new System.Windows.Forms.Label();
            this.txtTotalQuestions = new System.Windows.Forms.TextBox();
            this.lblTotalQuestions = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblQuizMakerID = new System.Windows.Forms.Label();
            this.cmbSubjects = new System.Windows.Forms.ComboBox();
            this.lblSubject = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddMultiple = new System.Windows.Forms.Button();
            this.txtOptionsNumeric = new System.Windows.Forms.NumericUpDown();
            this.lblMultipleOptions = new System.Windows.Forms.Label();
            this.rdbTF = new System.Windows.Forms.RadioButton();
            this.rdbFillBlank = new System.Windows.Forms.RadioButton();
            this.rdbMultiple = new System.Windows.Forms.RadioButton();
            this.lblTopicNo = new System.Windows.Forms.Label();
            this.cmbTopicNo = new System.Windows.Forms.ComboBox();
            this.lblGrades = new System.Windows.Forms.Label();
            this.cmbGrades = new System.Windows.Forms.ComboBox();
            this.pnlQuestions = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtOptionsNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTimeLimit
            // 
            this.txtTimeLimit.Location = new System.Drawing.Point(435, 8);
            this.txtTimeLimit.Name = "txtTimeLimit";
            this.txtTimeLimit.Size = new System.Drawing.Size(140, 20);
            this.txtTimeLimit.TabIndex = 3;
            // 
            // lblTimeLimit
            // 
            this.lblTimeLimit.AutoSize = true;
            this.lblTimeLimit.Location = new System.Drawing.Point(350, 11);
            this.lblTimeLimit.Name = "lblTimeLimit";
            this.lblTimeLimit.Size = new System.Drawing.Size(54, 13);
            this.lblTimeLimit.TabIndex = 2;
            this.lblTimeLimit.Text = "Time Limit";
            // 
            // txtQuizNumber
            // 
            this.txtQuizNumber.Enabled = false;
            this.txtQuizNumber.Location = new System.Drawing.Point(127, 105);
            this.txtQuizNumber.Name = "txtQuizNumber";
            this.txtQuizNumber.Size = new System.Drawing.Size(140, 20);
            this.txtQuizNumber.TabIndex = 5;
            // 
            // lblQuizNumber
            // 
            this.lblQuizNumber.AutoSize = true;
            this.lblQuizNumber.Location = new System.Drawing.Point(24, 108);
            this.lblQuizNumber.Name = "lblQuizNumber";
            this.lblQuizNumber.Size = new System.Drawing.Size(68, 13);
            this.lblQuizNumber.TabIndex = 4;
            this.lblQuizNumber.Text = "Quiz Number";
            // 
            // txtInstructions
            // 
            this.txtInstructions.Location = new System.Drawing.Point(435, 108);
            this.txtInstructions.Multiline = true;
            this.txtInstructions.Name = "txtInstructions";
            this.txtInstructions.Size = new System.Drawing.Size(237, 38);
            this.txtInstructions.TabIndex = 7;
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Location = new System.Drawing.Point(350, 112);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(64, 13);
            this.lblInstructions.TabIndex = 6;
            this.lblInstructions.Text = "Intstructions";
            // 
            // txtTotalScores
            // 
            this.txtTotalScores.Enabled = false;
            this.txtTotalScores.Location = new System.Drawing.Point(435, 42);
            this.txtTotalScores.Name = "txtTotalScores";
            this.txtTotalScores.Size = new System.Drawing.Size(140, 20);
            this.txtTotalScores.TabIndex = 9;
            // 
            // lblTotalScores
            // 
            this.lblTotalScores.AutoSize = true;
            this.lblTotalScores.Location = new System.Drawing.Point(350, 45);
            this.lblTotalScores.Name = "lblTotalScores";
            this.lblTotalScores.Size = new System.Drawing.Size(67, 13);
            this.lblTotalScores.TabIndex = 8;
            this.lblTotalScores.Text = "Total Scores";
            // 
            // txtTotalQuestions
            // 
            this.txtTotalQuestions.Enabled = false;
            this.txtTotalQuestions.Location = new System.Drawing.Point(435, 75);
            this.txtTotalQuestions.Name = "txtTotalQuestions";
            this.txtTotalQuestions.Size = new System.Drawing.Size(140, 20);
            this.txtTotalQuestions.TabIndex = 11;
            // 
            // lblTotalQuestions
            // 
            this.lblTotalQuestions.AutoSize = true;
            this.lblTotalQuestions.Location = new System.Drawing.Point(350, 79);
            this.lblTotalQuestions.Name = "lblTotalQuestions";
            this.lblTotalQuestions.Size = new System.Drawing.Size(81, 13);
            this.lblTotalQuestions.TabIndex = 10;
            this.lblTotalQuestions.Text = "Total Questions";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(509, 440);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(85, 25);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(910, 45);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(88, 23);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Back To Home";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click_1);
            // 
            // lblQuizMakerID
            // 
            this.lblQuizMakerID.AutoSize = true;
            this.lblQuizMakerID.Location = new System.Drawing.Point(907, 14);
            this.lblQuizMakerID.Name = "lblQuizMakerID";
            this.lblQuizMakerID.Size = new System.Drawing.Size(69, 13);
            this.lblQuizMakerID.TabIndex = 21;
            this.lblQuizMakerID.Text = "QuizMakerID";
            this.lblQuizMakerID.Visible = false;
            // 
            // cmbSubjects
            // 
            this.cmbSubjects.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSubjects.FormattingEnabled = true;
            this.cmbSubjects.Location = new System.Drawing.Point(127, 41);
            this.cmbSubjects.Name = "cmbSubjects";
            this.cmbSubjects.Size = new System.Drawing.Size(140, 21);
            this.cmbSubjects.TabIndex = 23;
            this.cmbSubjects.SelectedIndexChanged += new System.EventHandler(this.cmbSubjects_SelectedIndexChanged);
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Location = new System.Drawing.Point(24, 44);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(43, 13);
            this.lblSubject.TabIndex = 22;
            this.lblSubject.Text = "Subject";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnAddMultiple);
            this.panel1.Controls.Add(this.txtOptionsNumeric);
            this.panel1.Controls.Add(this.lblMultipleOptions);
            this.panel1.Controls.Add(this.rdbTF);
            this.panel1.Controls.Add(this.rdbFillBlank);
            this.panel1.Controls.Add(this.rdbMultiple);
            this.panel1.Controls.Add(this.lblTopicNo);
            this.panel1.Controls.Add(this.cmbTopicNo);
            this.panel1.Controls.Add(this.lblGrades);
            this.panel1.Controls.Add(this.cmbGrades);
            this.panel1.Controls.Add(this.lblSubject);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.cmbSubjects);
            this.panel1.Controls.Add(this.txtInstructions);
            this.panel1.Controls.Add(this.txtTotalQuestions);
            this.panel1.Controls.Add(this.lblInstructions);
            this.panel1.Controls.Add(this.lblTotalQuestions);
            this.panel1.Controls.Add(this.lblQuizMakerID);
            this.panel1.Controls.Add(this.txtTotalScores);
            this.panel1.Controls.Add(this.lblQuizNumber);
            this.panel1.Controls.Add(this.lblTotalScores);
            this.panel1.Controls.Add(this.lblTimeLimit);
            this.panel1.Controls.Add(this.txtTimeLimit);
            this.panel1.Controls.Add(this.txtQuizNumber);
            this.panel1.Location = new System.Drawing.Point(22, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1017, 227);
            this.panel1.TabIndex = 24;
            // 
            // btnAddMultiple
            // 
            this.btnAddMultiple.Location = new System.Drawing.Point(435, 160);
            this.btnAddMultiple.Name = "btnAddMultiple";
            this.btnAddMultiple.Size = new System.Drawing.Size(85, 25);
            this.btnAddMultiple.TabIndex = 37;
            this.btnAddMultiple.Text = "Add Question";
            this.btnAddMultiple.UseVisualStyleBackColor = true;
            this.btnAddMultiple.Visible = false;
            this.btnAddMultiple.Click += new System.EventHandler(this.btnAddMultiple_Click);
            // 
            // txtOptionsNumeric
            // 
            this.txtOptionsNumeric.Location = new System.Drawing.Point(161, 164);
            this.txtOptionsNumeric.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.txtOptionsNumeric.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.txtOptionsNumeric.Name = "txtOptionsNumeric";
            this.txtOptionsNumeric.Size = new System.Drawing.Size(43, 20);
            this.txtOptionsNumeric.TabIndex = 36;
            this.txtOptionsNumeric.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.txtOptionsNumeric.Visible = false;
            // 
            // lblMultipleOptions
            // 
            this.lblMultipleOptions.AutoSize = true;
            this.lblMultipleOptions.Location = new System.Drawing.Point(91, 166);
            this.lblMultipleOptions.Name = "lblMultipleOptions";
            this.lblMultipleOptions.Size = new System.Drawing.Size(64, 13);
            this.lblMultipleOptions.TabIndex = 34;
            this.lblMultipleOptions.Text = "Options(2-4)";
            this.lblMultipleOptions.Visible = false;
            // 
            // rdbTF
            // 
            this.rdbTF.AutoSize = true;
            this.rdbTF.Location = new System.Drawing.Point(227, 164);
            this.rdbTF.Name = "rdbTF";
            this.rdbTF.Size = new System.Drawing.Size(43, 17);
            this.rdbTF.TabIndex = 33;
            this.rdbTF.TabStop = true;
            this.rdbTF.Text = "T/F";
            this.rdbTF.UseVisualStyleBackColor = true;
            this.rdbTF.CheckedChanged += new System.EventHandler(this.rdbTF_CheckedChanged);
            // 
            // rdbFillBlank
            // 
            this.rdbFillBlank.AutoSize = true;
            this.rdbFillBlank.Location = new System.Drawing.Point(327, 164);
            this.rdbFillBlank.Name = "rdbFillBlank";
            this.rdbFillBlank.Size = new System.Drawing.Size(67, 17);
            this.rdbFillBlank.TabIndex = 32;
            this.rdbFillBlank.TabStop = true;
            this.rdbFillBlank.Text = "Fill Blank";
            this.rdbFillBlank.UseVisualStyleBackColor = true;
            this.rdbFillBlank.CheckedChanged += new System.EventHandler(this.rdbFillBlank_CheckedChanged);
            // 
            // rdbMultiple
            // 
            this.rdbMultiple.AutoSize = true;
            this.rdbMultiple.Location = new System.Drawing.Point(27, 164);
            this.rdbMultiple.Name = "rdbMultiple";
            this.rdbMultiple.Size = new System.Drawing.Size(61, 17);
            this.rdbMultiple.TabIndex = 31;
            this.rdbMultiple.TabStop = true;
            this.rdbMultiple.Text = "Multiple";
            this.rdbMultiple.UseVisualStyleBackColor = true;
            this.rdbMultiple.CheckedChanged += new System.EventHandler(this.rdbMultiple_CheckedChanged);
            // 
            // lblTopicNo
            // 
            this.lblTopicNo.AutoSize = true;
            this.lblTopicNo.Location = new System.Drawing.Point(25, 79);
            this.lblTopicNo.Name = "lblTopicNo";
            this.lblTopicNo.Size = new System.Drawing.Size(77, 13);
            this.lblTopicNo.TabIndex = 26;
            this.lblTopicNo.Text = "Topic Number:";
            // 
            // cmbTopicNo
            // 
            this.cmbTopicNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTopicNo.FormattingEnabled = true;
            this.cmbTopicNo.Location = new System.Drawing.Point(127, 74);
            this.cmbTopicNo.Name = "cmbTopicNo";
            this.cmbTopicNo.Size = new System.Drawing.Size(140, 21);
            this.cmbTopicNo.TabIndex = 27;
            this.cmbTopicNo.SelectedIndexChanged += new System.EventHandler(this.cmbTopicNo_SelectedIndexChanged);
            // 
            // lblGrades
            // 
            this.lblGrades.AutoSize = true;
            this.lblGrades.Location = new System.Drawing.Point(24, 11);
            this.lblGrades.Name = "lblGrades";
            this.lblGrades.Size = new System.Drawing.Size(44, 13);
            this.lblGrades.TabIndex = 24;
            this.lblGrades.Text = "Grades:";
            // 
            // cmbGrades
            // 
            this.cmbGrades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGrades.FormattingEnabled = true;
            this.cmbGrades.Location = new System.Drawing.Point(127, 8);
            this.cmbGrades.Name = "cmbGrades";
            this.cmbGrades.Size = new System.Drawing.Size(140, 21);
            this.cmbGrades.TabIndex = 25;
            this.cmbGrades.SelectedIndexChanged += new System.EventHandler(this.cmbGrades_SelectedIndexChanged);
            // 
            // pnlQuestions
            // 
            this.pnlQuestions.BackColor = System.Drawing.Color.White;
            this.pnlQuestions.Location = new System.Drawing.Point(22, 237);
            this.pnlQuestions.Name = "pnlQuestions";
            this.pnlQuestions.Size = new System.Drawing.Size(775, 188);
            this.pnlQuestions.TabIndex = 25;
            // 
            // QuizMaker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1061, 475);
            this.Controls.Add(this.pnlQuestions);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSave);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "QuizMaker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuizMaker";
            this.Load += new System.EventHandler(this.QuizMaker_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtOptionsNumeric)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtTimeLimit;
        private System.Windows.Forms.Label lblTimeLimit;
        private System.Windows.Forms.TextBox txtQuizNumber;
        private System.Windows.Forms.Label lblQuizNumber;
        private System.Windows.Forms.TextBox txtInstructions;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.TextBox txtTotalScores;
        private System.Windows.Forms.Label lblTotalScores;
        public System.Windows.Forms.TextBox txtTotalQuestions;
        private System.Windows.Forms.Label lblTotalQuestions;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.Label lblQuizMakerID;
        public System.Windows.Forms.ComboBox cmbSubjects;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblGrades;
        public System.Windows.Forms.ComboBox cmbGrades;
        private System.Windows.Forms.Label lblTopicNo;
        public System.Windows.Forms.ComboBox cmbTopicNo;
        private System.Windows.Forms.RadioButton rdbMultiple;
        private System.Windows.Forms.RadioButton rdbTF;
        private System.Windows.Forms.RadioButton rdbFillBlank;
        private System.Windows.Forms.Label lblMultipleOptions;
        private System.Windows.Forms.NumericUpDown txtOptionsNumeric;
        private System.Windows.Forms.Button btnAddMultiple;
        private System.Windows.Forms.Panel pnlQuestions;
    }
}