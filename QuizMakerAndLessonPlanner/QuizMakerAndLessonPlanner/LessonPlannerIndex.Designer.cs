namespace QuizMakerAndLessonPlanner
{
    partial class LessonPlannerIndex
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LessonPlannerIndex));
            this.dataGridViewLessonPlanner = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            this.cmbGrades = new System.Windows.Forms.ComboBox();
            this.cmbSubjects = new System.Windows.Forms.ComboBox();
            this.lblSubject = new System.Windows.Forms.Label();
            this.lblGrade = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLessonPlanner)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewLessonPlanner
            // 
            this.dataGridViewLessonPlanner.AllowUserToAddRows = false;
            this.dataGridViewLessonPlanner.AllowUserToDeleteRows = false;
            this.dataGridViewLessonPlanner.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewLessonPlanner.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewLessonPlanner.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLessonPlanner.Location = new System.Drawing.Point(12, 38);
            this.dataGridViewLessonPlanner.Name = "dataGridViewLessonPlanner";
            this.dataGridViewLessonPlanner.ReadOnly = true;
            this.dataGridViewLessonPlanner.Size = new System.Drawing.Size(1021, 390);
            this.dataGridViewLessonPlanner.TabIndex = 0;
            this.dataGridViewLessonPlanner.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewLessonPlanner_CellClick);
            this.dataGridViewLessonPlanner.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridViewLessonPlanner_DataBindingComplete);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(795, 479);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // cmbGrades
            // 
            this.cmbGrades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGrades.FormattingEnabled = true;
            this.cmbGrades.Location = new System.Drawing.Point(95, 3);
            this.cmbGrades.Name = "cmbGrades";
            this.cmbGrades.Size = new System.Drawing.Size(121, 21);
            this.cmbGrades.TabIndex = 38;
            this.cmbGrades.SelectedIndexChanged += new System.EventHandler(this.cmbGrades_SelectedIndexChanged);
            // 
            // cmbSubjects
            // 
            this.cmbSubjects.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSubjects.FormattingEnabled = true;
            this.cmbSubjects.Location = new System.Drawing.Point(356, 5);
            this.cmbSubjects.Name = "cmbSubjects";
            this.cmbSubjects.Size = new System.Drawing.Size(121, 21);
            this.cmbSubjects.TabIndex = 37;
            this.cmbSubjects.SelectedIndexChanged += new System.EventHandler(this.cmbSubjects_SelectedIndexChanged);
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Location = new System.Drawing.Point(307, 10);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(43, 13);
            this.lblSubject.TabIndex = 36;
            this.lblSubject.Text = "Subject";
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.Location = new System.Drawing.Point(53, 6);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(36, 13);
            this.lblGrade.TabIndex = 35;
            this.lblGrade.Text = "Grade";
            // 
            // LessonPlannerIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1059, 461);
            this.Controls.Add(this.cmbGrades);
            this.Controls.Add(this.cmbSubjects);
            this.Controls.Add(this.lblSubject);
            this.Controls.Add(this.lblGrade);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dataGridViewLessonPlanner);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LessonPlannerIndex";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Index";
            this.Load += new System.EventHandler(this.Index_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLessonPlanner)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewLessonPlanner;
        private System.Windows.Forms.Button btnBack;
        public System.Windows.Forms.ComboBox cmbGrades;
        public System.Windows.Forms.ComboBox cmbSubjects;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.Label lblGrade;
    }
}