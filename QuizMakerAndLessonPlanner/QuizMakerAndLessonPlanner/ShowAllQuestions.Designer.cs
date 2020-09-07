namespace QuizMakerAndLessonPlanner
{
    partial class ShowAllQuestions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowAllQuestions));
            this.dataGridViewShowMultipleQuestions = new System.Windows.Forms.DataGridView();
            this.cmbQuestionType = new System.Windows.Forms.ComboBox();
            this.lblGrade = new System.Windows.Forms.Label();
            this.dataGridViewTrueFalseQuestions = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewFillBlankQuestion = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShowMultipleQuestions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTrueFalseQuestions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFillBlankQuestion)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewShowMultipleQuestions
            // 
            this.dataGridViewShowMultipleQuestions.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewShowMultipleQuestions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewShowMultipleQuestions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewShowMultipleQuestions.Location = new System.Drawing.Point(44, 56);
            this.dataGridViewShowMultipleQuestions.Name = "dataGridViewShowMultipleQuestions";
            this.dataGridViewShowMultipleQuestions.Size = new System.Drawing.Size(762, 288);
            this.dataGridViewShowMultipleQuestions.TabIndex = 0;
            this.dataGridViewShowMultipleQuestions.Visible = false;
            this.dataGridViewShowMultipleQuestions.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewShowMultipleQuestions_CellClick);
            this.dataGridViewShowMultipleQuestions.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridViewShowMultipleQuestions_DataBindingComplete);
            // 
            // cmbQuestionType
            // 
            this.cmbQuestionType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbQuestionType.FormattingEnabled = true;
            this.cmbQuestionType.Location = new System.Drawing.Point(151, 29);
            this.cmbQuestionType.Name = "cmbQuestionType";
            this.cmbQuestionType.Size = new System.Drawing.Size(121, 21);
            this.cmbQuestionType.TabIndex = 40;
            this.cmbQuestionType.SelectedIndexChanged += new System.EventHandler(this.cmbQuestionType_SelectedIndexChanged);
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.Location = new System.Drawing.Point(52, 32);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(79, 13);
            this.lblGrade.TabIndex = 39;
            this.lblGrade.Text = "Question Type:";
            // 
            // dataGridViewTrueFalseQuestions
            // 
            this.dataGridViewTrueFalseQuestions.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewTrueFalseQuestions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTrueFalseQuestions.Location = new System.Drawing.Point(44, 100);
            this.dataGridViewTrueFalseQuestions.Name = "dataGridViewTrueFalseQuestions";
            this.dataGridViewTrueFalseQuestions.Size = new System.Drawing.Size(762, 214);
            this.dataGridViewTrueFalseQuestions.TabIndex = 41;
            this.dataGridViewTrueFalseQuestions.Visible = false;
            this.dataGridViewTrueFalseQuestions.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTrueFalseQuestions_CellClick);
            this.dataGridViewTrueFalseQuestions.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridViewTrueFalseQuestions_DataBindingComplete);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(731, 358);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 42;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewFillBlankQuestion
            // 
            this.dataGridViewFillBlankQuestion.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewFillBlankQuestion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewFillBlankQuestion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFillBlankQuestion.Location = new System.Drawing.Point(38, 89);
            this.dataGridViewFillBlankQuestion.Name = "dataGridViewFillBlankQuestion";
            this.dataGridViewFillBlankQuestion.Size = new System.Drawing.Size(762, 214);
            this.dataGridViewFillBlankQuestion.TabIndex = 43;
            this.dataGridViewFillBlankQuestion.Visible = false;
            this.dataGridViewFillBlankQuestion.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewFillBlankQuestion_CellClick);
            this.dataGridViewFillBlankQuestion.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridViewFillBlankQuestion_DataBindingComplete);
            // 
            // ShowAllQuestions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(839, 393);
            this.Controls.Add(this.dataGridViewFillBlankQuestion);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridViewTrueFalseQuestions);
            this.Controls.Add(this.cmbQuestionType);
            this.Controls.Add(this.lblGrade);
            this.Controls.Add(this.dataGridViewShowMultipleQuestions);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ShowAllQuestions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShowAllQuestions";
            this.Load += new System.EventHandler(this.ShowAllQuestions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShowMultipleQuestions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTrueFalseQuestions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFillBlankQuestion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewShowMultipleQuestions;
        public System.Windows.Forms.ComboBox cmbQuestionType;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.DataGridView dataGridViewTrueFalseQuestions;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridViewFillBlankQuestion;
    }
}