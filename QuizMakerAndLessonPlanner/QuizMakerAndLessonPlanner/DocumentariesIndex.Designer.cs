namespace QuizMakerAndLessonPlanner
{
    partial class DocumentariesIndex
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DocumentariesIndex));
            this.dataGridViewDocumentaries = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDocumentaries)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDocumentaries
            // 
            this.dataGridViewDocumentaries.AllowUserToAddRows = false;
            this.dataGridViewDocumentaries.AllowUserToDeleteRows = false;
            this.dataGridViewDocumentaries.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewDocumentaries.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewDocumentaries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDocumentaries.Location = new System.Drawing.Point(12, 38);
            this.dataGridViewDocumentaries.Name = "dataGridViewDocumentaries";
            this.dataGridViewDocumentaries.ReadOnly = true;
            this.dataGridViewDocumentaries.Size = new System.Drawing.Size(1021, 390);
            this.dataGridViewDocumentaries.TabIndex = 3;
            this.dataGridViewDocumentaries.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDocumentaries_CellClick);
            this.dataGridViewDocumentaries.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridViewDocumentaries_DataBindingComplete);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(958, 9);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Visible = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // DocumentariesIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1059, 461);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dataGridViewDocumentaries);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DocumentariesIndex";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DocumentariesIndex";
            this.Load += new System.EventHandler(this.DocumentariesIndex_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDocumentaries)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDocumentaries;
        private System.Windows.Forms.Button btnBack;
    }
}