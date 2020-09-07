namespace QuizMakerAndLessonPlanner
{
    partial class QuizMakerIndex
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuizMakerIndex));
            this.dataGridViewQuizMaker = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuizMaker)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewQuizMaker
            // 
            this.dataGridViewQuizMaker.AllowUserToAddRows = false;
            this.dataGridViewQuizMaker.AllowUserToDeleteRows = false;
            this.dataGridViewQuizMaker.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewQuizMaker.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewQuizMaker.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewQuizMaker.Location = new System.Drawing.Point(54, 25);
            this.dataGridViewQuizMaker.Name = "dataGridViewQuizMaker";
            this.dataGridViewQuizMaker.ReadOnly = true;
            this.dataGridViewQuizMaker.Size = new System.Drawing.Size(802, 359);
            this.dataGridViewQuizMaker.TabIndex = 1;
            this.dataGridViewQuizMaker.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewQuizMaker_CellClick);
            this.dataGridViewQuizMaker.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewQuizMaker_CellContentClick);
            this.dataGridViewQuizMaker.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridViewQuizMaker_DataBindingComplete);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(781, 402);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // QuizMakerIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(899, 472);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dataGridViewQuizMaker);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "QuizMakerIndex";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainTopicQuizzes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuizMaker)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewQuizMaker;
        private System.Windows.Forms.Button btnBack;
    }
}