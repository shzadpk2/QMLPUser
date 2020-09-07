namespace QuizMakerAndLessonPlanner
{
    partial class AddMoreQuestions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddMoreQuestions));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddMultiple = new System.Windows.Forms.Button();
            this.txtOptionsNumeric = new System.Windows.Forms.NumericUpDown();
            this.lblMultipleOptions = new System.Windows.Forms.Label();
            this.rdbTF = new System.Windows.Forms.RadioButton();
            this.rdbFillBlank = new System.Windows.Forms.RadioButton();
            this.rdbMultiple = new System.Windows.Forms.RadioButton();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblQuizMakerID = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtOptionsNumeric)).BeginInit();
            this.SuspendLayout();
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
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.lblQuizMakerID);
            this.panel1.Location = new System.Drawing.Point(43, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(647, 369);
            this.panel1.TabIndex = 25;
            // 
            // btnAddMultiple
            // 
            this.btnAddMultiple.Location = new System.Drawing.Point(27, 106);
            this.btnAddMultiple.Name = "btnAddMultiple";
            this.btnAddMultiple.Size = new System.Drawing.Size(134, 23);
            this.btnAddMultiple.TabIndex = 37;
            this.btnAddMultiple.Text = "Add Questions";
            this.btnAddMultiple.UseVisualStyleBackColor = true;
            this.btnAddMultiple.Visible = false;
            this.btnAddMultiple.Click += new System.EventHandler(this.btnAddMultiple_Click);
            // 
            // txtOptionsNumeric
            // 
            this.txtOptionsNumeric.Location = new System.Drawing.Point(182, 50);
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
            this.lblMultipleOptions.Location = new System.Drawing.Point(112, 52);
            this.lblMultipleOptions.Name = "lblMultipleOptions";
            this.lblMultipleOptions.Size = new System.Drawing.Size(64, 13);
            this.lblMultipleOptions.TabIndex = 34;
            this.lblMultipleOptions.Text = "Options(2-4)";
            this.lblMultipleOptions.Visible = false;
            // 
            // rdbTF
            // 
            this.rdbTF.AutoSize = true;
            this.rdbTF.Location = new System.Drawing.Point(257, 49);
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
            this.rdbFillBlank.Location = new System.Drawing.Point(369, 53);
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
            this.rdbMultiple.Location = new System.Drawing.Point(27, 49);
            this.rdbMultiple.Name = "rdbMultiple";
            this.rdbMultiple.Size = new System.Drawing.Size(61, 17);
            this.rdbMultiple.TabIndex = 31;
            this.rdbMultiple.TabStop = true;
            this.rdbMultiple.Text = "Multiple";
            this.rdbMultiple.UseVisualStyleBackColor = true;
            this.rdbMultiple.CheckedChanged += new System.EventHandler(this.rdbMultiple_CheckedChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(348, 155);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(88, 23);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(182, 155);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblQuizMakerID
            // 
            this.lblQuizMakerID.AutoSize = true;
            this.lblQuizMakerID.Location = new System.Drawing.Point(536, 14);
            this.lblQuizMakerID.Name = "lblQuizMakerID";
            this.lblQuizMakerID.Size = new System.Drawing.Size(69, 13);
            this.lblQuizMakerID.TabIndex = 21;
            this.lblQuizMakerID.Text = "QuizMakerID";
            this.lblQuizMakerID.Visible = false;
            // 
            // AddMoreQuestions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddMoreQuestions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddMoreQuestions";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtOptionsNumeric)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAddMultiple;
        private System.Windows.Forms.NumericUpDown txtOptionsNumeric;
        private System.Windows.Forms.Label lblMultipleOptions;
        private System.Windows.Forms.RadioButton rdbTF;
        private System.Windows.Forms.RadioButton rdbFillBlank;
        private System.Windows.Forms.RadioButton rdbMultiple;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        public System.Windows.Forms.Label lblQuizMakerID;
    }
}