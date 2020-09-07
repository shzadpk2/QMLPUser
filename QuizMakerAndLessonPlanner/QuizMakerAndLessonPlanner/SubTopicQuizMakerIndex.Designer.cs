namespace QuizMakerAndLessonPlanner
{
    partial class SubTopicQuizMakerIndex
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SubTopicQuizMakerIndex));
            this.dataGridViewSubTopicQuizMaker = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSubTopicQuizMaker)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewSubTopicQuizMaker
            // 
            this.dataGridViewSubTopicQuizMaker.AllowUserToAddRows = false;
            this.dataGridViewSubTopicQuizMaker.AllowUserToDeleteRows = false;
            this.dataGridViewSubTopicQuizMaker.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewSubTopicQuizMaker.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewSubTopicQuizMaker.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSubTopicQuizMaker.Location = new System.Drawing.Point(59, 46);
            this.dataGridViewSubTopicQuizMaker.Name = "dataGridViewSubTopicQuizMaker";
            this.dataGridViewSubTopicQuizMaker.ReadOnly = true;
            this.dataGridViewSubTopicQuizMaker.Size = new System.Drawing.Size(683, 359);
            this.dataGridViewSubTopicQuizMaker.TabIndex = 2;
            this.dataGridViewSubTopicQuizMaker.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSubTopicQuizMaker_CellClick);
            this.dataGridViewSubTopicQuizMaker.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSubTopicQuizMaker_CellContentClick);
            this.dataGridViewSubTopicQuizMaker.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridViewSubTopicQuizMaker_DataBindingComplete);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(667, 415);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // SubTopicQuizMakerIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dataGridViewSubTopicQuizMaker);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SubTopicQuizMakerIndex";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SubTopicQuizMakerIndex";
            this.Load += new System.EventHandler(this.SubTopicQuizMakerIndex_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSubTopicQuizMaker)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewSubTopicQuizMaker;
        private System.Windows.Forms.Button btnBack;
    }
}