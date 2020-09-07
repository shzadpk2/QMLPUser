namespace QuizMakerAndLessonPlanner
{
    partial class AddFillBlankQuestions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddFillBlankQuestions));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.btnCancelFillBlankQuestion = new System.Windows.Forms.Button();
            this.btnAddFillBlankQuestion = new System.Windows.Forms.Button();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.txtQuestion = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblAnswer);
            this.panel1.Controls.Add(this.txtAnswer);
            this.panel1.Controls.Add(this.btnCancelFillBlankQuestion);
            this.panel1.Controls.Add(this.btnAddFillBlankQuestion);
            this.panel1.Controls.Add(this.lblQuestion);
            this.panel1.Controls.Add(this.txtQuestion);
            this.panel1.Location = new System.Drawing.Point(6, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(491, 190);
            this.panel1.TabIndex = 2;
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Location = new System.Drawing.Point(41, 67);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(45, 13);
            this.lblAnswer.TabIndex = 20;
            this.lblAnswer.Text = "Answer:";
            // 
            // txtAnswer
            // 
            this.txtAnswer.Location = new System.Drawing.Point(99, 58);
            this.txtAnswer.Multiline = true;
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(363, 38);
            this.txtAnswer.TabIndex = 21;
            // 
            // btnCancelFillBlankQuestion
            // 
            this.btnCancelFillBlankQuestion.Location = new System.Drawing.Point(251, 111);
            this.btnCancelFillBlankQuestion.Name = "btnCancelFillBlankQuestion";
            this.btnCancelFillBlankQuestion.Size = new System.Drawing.Size(85, 25);
            this.btnCancelFillBlankQuestion.TabIndex = 19;
            this.btnCancelFillBlankQuestion.Text = "Cancel";
            this.btnCancelFillBlankQuestion.UseVisualStyleBackColor = true;
            this.btnCancelFillBlankQuestion.Visible = false;
            this.btnCancelFillBlankQuestion.Click += new System.EventHandler(this.btnCancelFillBlankQuestion_Click);
            // 
            // btnAddFillBlankQuestion
            // 
            this.btnAddFillBlankQuestion.Location = new System.Drawing.Point(99, 111);
            this.btnAddFillBlankQuestion.Name = "btnAddFillBlankQuestion";
            this.btnAddFillBlankQuestion.Size = new System.Drawing.Size(85, 25);
            this.btnAddFillBlankQuestion.TabIndex = 18;
            this.btnAddFillBlankQuestion.Text = "Add";
            this.btnAddFillBlankQuestion.UseVisualStyleBackColor = true;
            this.btnAddFillBlankQuestion.Click += new System.EventHandler(this.btnAddFillBlankQuestion_Click);
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Location = new System.Drawing.Point(41, 25);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(52, 13);
            this.lblQuestion.TabIndex = 6;
            this.lblQuestion.Text = "Question:";
            // 
            // txtQuestion
            // 
            this.txtQuestion.Location = new System.Drawing.Point(99, 12);
            this.txtQuestion.Multiline = true;
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.Size = new System.Drawing.Size(363, 38);
            this.txtQuestion.TabIndex = 7;
            // 
            // AddFillBlankQuestions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(509, 208);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddFillBlankQuestions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddFillBlankQuestions";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancelFillBlankQuestion;
        private System.Windows.Forms.Button btnAddFillBlankQuestion;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.TextBox txtQuestion;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.TextBox txtAnswer;
    }
}