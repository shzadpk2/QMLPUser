namespace QuizMakerAndLessonPlanner
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.btnLessonPlanner = new System.Windows.Forms.Button();
            this.btnQuizMaker = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLessonPlanner
            // 
            this.btnLessonPlanner.Location = new System.Drawing.Point(12, 7);
            this.btnLessonPlanner.Name = "btnLessonPlanner";
            this.btnLessonPlanner.Size = new System.Drawing.Size(109, 32);
            this.btnLessonPlanner.TabIndex = 0;
            this.btnLessonPlanner.Text = "Lesson Planner";
            this.btnLessonPlanner.UseVisualStyleBackColor = true;
            this.btnLessonPlanner.Click += new System.EventHandler(this.btnLessonPlanner_Click);
            // 
            // btnQuizMaker
            // 
            this.btnQuizMaker.Location = new System.Drawing.Point(121, 7);
            this.btnQuizMaker.Name = "btnQuizMaker";
            this.btnQuizMaker.Size = new System.Drawing.Size(109, 32);
            this.btnQuizMaker.TabIndex = 1;
            this.btnQuizMaker.Text = "Quiz Maker";
            this.btnQuizMaker.UseVisualStyleBackColor = true;
            this.btnQuizMaker.Click += new System.EventHandler(this.btnQuizMaker_Click);
            // 
            // btnReports
            // 
            this.btnReports.Location = new System.Drawing.Point(231, 7);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(109, 32);
            this.btnReports.TabIndex = 2;
            this.btnReports.Text = "Reports";
            this.btnReports.UseVisualStyleBackColor = true;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Controls.Add(this.btnLessonPlanner);
            this.panel1.Controls.Add(this.btnReports);
            this.panel1.Controls.Add(this.btnQuizMaker);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1086, 48);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 54);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1083, 519);
            this.panel2.TabIndex = 4;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1084, 611);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLessonPlanner;
        private System.Windows.Forms.Button btnQuizMaker;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}