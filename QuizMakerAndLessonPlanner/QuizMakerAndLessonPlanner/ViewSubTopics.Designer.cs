namespace QuizMakerAndLessonPlanner
{
    partial class ViewSubTopics
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewSubTopics));
            this.dataGridViewViewSubTopics = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewViewSubTopics)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewViewSubTopics
            // 
            this.dataGridViewViewSubTopics.AllowUserToAddRows = false;
            this.dataGridViewViewSubTopics.AllowUserToDeleteRows = false;
            this.dataGridViewViewSubTopics.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewViewSubTopics.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewViewSubTopics.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewViewSubTopics.Location = new System.Drawing.Point(58, 39);
            this.dataGridViewViewSubTopics.Name = "dataGridViewViewSubTopics";
            this.dataGridViewViewSubTopics.ReadOnly = true;
            this.dataGridViewViewSubTopics.Size = new System.Drawing.Size(666, 341);
            this.dataGridViewViewSubTopics.TabIndex = 1;
            this.dataGridViewViewSubTopics.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewViewSubTopics_CellClick);
            this.dataGridViewViewSubTopics.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridViewViewSubTopics_DataBindingComplete);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(649, 399);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // ViewSubTopics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dataGridViewViewSubTopics);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ViewSubTopics";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewSubTopics";
            this.Load += new System.EventHandler(this.ViewSubTopics_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewViewSubTopics)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewViewSubTopics;
        private System.Windows.Forms.Button btnBack;
    }
}