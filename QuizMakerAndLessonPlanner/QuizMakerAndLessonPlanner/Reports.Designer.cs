namespace QuizMakerAndLessonPlanner
{
    partial class Reports
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reports));
            this.btnLessons = new System.Windows.Forms.Button();
            this.btnMovies = new System.Windows.Forms.Button();
            this.btnDocumentaries = new System.Windows.Forms.Button();
            this.btnGames = new System.Windows.Forms.Button();
            this.btnBooks = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnLessons
            // 
            this.btnLessons.Location = new System.Drawing.Point(70, 25);
            this.btnLessons.Name = "btnLessons";
            this.btnLessons.Size = new System.Drawing.Size(90, 25);
            this.btnLessons.TabIndex = 0;
            this.btnLessons.Text = "Lessons";
            this.btnLessons.UseVisualStyleBackColor = true;
            this.btnLessons.Click += new System.EventHandler(this.btnLessons_Click);
            // 
            // btnMovies
            // 
            this.btnMovies.Location = new System.Drawing.Point(200, 25);
            this.btnMovies.Name = "btnMovies";
            this.btnMovies.Size = new System.Drawing.Size(90, 25);
            this.btnMovies.TabIndex = 2;
            this.btnMovies.Text = "Movies";
            this.btnMovies.UseVisualStyleBackColor = true;
            this.btnMovies.Click += new System.EventHandler(this.btnMovies_Click);
            // 
            // btnDocumentaries
            // 
            this.btnDocumentaries.Location = new System.Drawing.Point(330, 25);
            this.btnDocumentaries.Name = "btnDocumentaries";
            this.btnDocumentaries.Size = new System.Drawing.Size(90, 25);
            this.btnDocumentaries.TabIndex = 3;
            this.btnDocumentaries.Text = "Documentaries";
            this.btnDocumentaries.UseVisualStyleBackColor = true;
            this.btnDocumentaries.Click += new System.EventHandler(this.btnDocumentaries_Click);
            // 
            // btnGames
            // 
            this.btnGames.Location = new System.Drawing.Point(460, 25);
            this.btnGames.Name = "btnGames";
            this.btnGames.Size = new System.Drawing.Size(90, 25);
            this.btnGames.TabIndex = 4;
            this.btnGames.Text = "Games";
            this.btnGames.UseVisualStyleBackColor = true;
            this.btnGames.Click += new System.EventHandler(this.btnGames_Click);
            // 
            // btnBooks
            // 
            this.btnBooks.Location = new System.Drawing.Point(590, 25);
            this.btnBooks.Name = "btnBooks";
            this.btnBooks.Size = new System.Drawing.Size(90, 25);
            this.btnBooks.TabIndex = 5;
            this.btnBooks.Text = "Books";
            this.btnBooks.UseVisualStyleBackColor = true;
            this.btnBooks.Click += new System.EventHandler(this.btnBooks_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(744, 27);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Visible = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1037, 507);
            this.panel1.TabIndex = 7;
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1061, 575);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnBooks);
            this.Controls.Add(this.btnGames);
            this.Controls.Add(this.btnDocumentaries);
            this.Controls.Add(this.btnMovies);
            this.Controls.Add(this.btnLessons);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Reports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reports";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLessons;
        private System.Windows.Forms.Button btnMovies;
        private System.Windows.Forms.Button btnDocumentaries;
        private System.Windows.Forms.Button btnGames;
        private System.Windows.Forms.Button btnBooks;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel panel1;
    }
}