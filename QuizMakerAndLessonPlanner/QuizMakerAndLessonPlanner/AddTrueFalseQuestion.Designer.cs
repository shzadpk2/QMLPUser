namespace QuizMakerAndLessonPlanner
{
    partial class AddTrueFalseQuestion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddTrueFalseQuestion));
            this.panel1 = new System.Windows.Forms.Panel();
            this.False = new System.Windows.Forms.Label();
            this.txtFlase = new System.Windows.Forms.TextBox();
            this.btnCancelTrueFalseQuestion = new System.Windows.Forms.Button();
            this.btnAddTrueFalseQuestion = new System.Windows.Forms.Button();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.txtTrue = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.False);
            this.panel1.Controls.Add(this.txtFlase);
            this.panel1.Controls.Add(this.btnCancelTrueFalseQuestion);
            this.panel1.Controls.Add(this.btnAddTrueFalseQuestion);
            this.panel1.Controls.Add(this.lblQuestion);
            this.panel1.Controls.Add(this.txtTrue);
            this.panel1.Location = new System.Drawing.Point(6, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(491, 190);
            this.panel1.TabIndex = 1;
            // 
            // False
            // 
            this.False.AutoSize = true;
            this.False.Location = new System.Drawing.Point(41, 76);
            this.False.Name = "False";
            this.False.Size = new System.Drawing.Size(35, 13);
            this.False.TabIndex = 22;
            this.False.Text = "False:";
            // 
            // txtFlase
            // 
            this.txtFlase.Location = new System.Drawing.Point(82, 58);
            this.txtFlase.Multiline = true;
            this.txtFlase.Name = "txtFlase";
            this.txtFlase.Size = new System.Drawing.Size(363, 38);
            this.txtFlase.TabIndex = 23;
            // 
            // btnCancelTrueFalseQuestion
            // 
            this.btnCancelTrueFalseQuestion.Location = new System.Drawing.Point(210, 113);
            this.btnCancelTrueFalseQuestion.Name = "btnCancelTrueFalseQuestion";
            this.btnCancelTrueFalseQuestion.Size = new System.Drawing.Size(75, 23);
            this.btnCancelTrueFalseQuestion.TabIndex = 19;
            this.btnCancelTrueFalseQuestion.Text = "Cancel";
            this.btnCancelTrueFalseQuestion.UseVisualStyleBackColor = true;
            this.btnCancelTrueFalseQuestion.Visible = false;
            this.btnCancelTrueFalseQuestion.Click += new System.EventHandler(this.btnCancelTrueFalseQuestion_Click);
            // 
            // btnAddTrueFalseQuestion
            // 
            this.btnAddTrueFalseQuestion.Location = new System.Drawing.Point(44, 111);
            this.btnAddTrueFalseQuestion.Name = "btnAddTrueFalseQuestion";
            this.btnAddTrueFalseQuestion.Size = new System.Drawing.Size(85, 25);
            this.btnAddTrueFalseQuestion.TabIndex = 18;
            this.btnAddTrueFalseQuestion.Text = "Add";
            this.btnAddTrueFalseQuestion.UseVisualStyleBackColor = true;
            this.btnAddTrueFalseQuestion.Click += new System.EventHandler(this.btnAddTrueFalseQuestion_Click);
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Location = new System.Drawing.Point(44, 29);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(32, 13);
            this.lblQuestion.TabIndex = 6;
            this.lblQuestion.Text = "True:";
            // 
            // txtTrue
            // 
            this.txtTrue.Location = new System.Drawing.Point(82, 12);
            this.txtTrue.Multiline = true;
            this.txtTrue.Name = "txtTrue";
            this.txtTrue.Size = new System.Drawing.Size(363, 38);
            this.txtTrue.TabIndex = 7;
            // 
            // AddTrueFalseQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(509, 208);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddTrueFalseQuestion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddTrueFalse";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancelTrueFalseQuestion;
        private System.Windows.Forms.Button btnAddTrueFalseQuestion;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.TextBox txtTrue;
        private System.Windows.Forms.Label False;
        private System.Windows.Forms.TextBox txtFlase;
    }
}