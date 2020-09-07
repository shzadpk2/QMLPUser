namespace QuizMakerAndLessonPlanner
{
    partial class SubTopic
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SubTopic));
            this.txtMainTopic = new System.Windows.Forms.TextBox();
            this.lblMainTopic = new System.Windows.Forms.Label();
            this.txtSubTopicNo = new System.Windows.Forms.TextBox();
            this.lbSubTopicNo = new System.Windows.Forms.Label();
            this.txtMaterial = new System.Windows.Forms.TextBox();
            this.txtTitleSubTopic = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblMaterial = new System.Windows.Forms.Label();
            this.lblTitleSubTopic = new System.Windows.Forms.Label();
            this.lblSubTopicID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtMainTopic
            // 
            this.txtMainTopic.Location = new System.Drawing.Point(367, 52);
            this.txtMainTopic.Name = "txtMainTopic";
            this.txtMainTopic.ReadOnly = true;
            this.txtMainTopic.Size = new System.Drawing.Size(121, 20);
            this.txtMainTopic.TabIndex = 15;
            // 
            // lblMainTopic
            // 
            this.lblMainTopic.AutoSize = true;
            this.lblMainTopic.Location = new System.Drawing.Point(198, 59);
            this.lblMainTopic.Name = "lblMainTopic";
            this.lblMainTopic.Size = new System.Drawing.Size(70, 13);
            this.lblMainTopic.TabIndex = 14;
            this.lblMainTopic.Text = "Main Topic #";
            // 
            // txtSubTopicNo
            // 
            this.txtSubTopicNo.Location = new System.Drawing.Point(367, 91);
            this.txtSubTopicNo.Name = "txtSubTopicNo";
            this.txtSubTopicNo.ReadOnly = true;
            this.txtSubTopicNo.Size = new System.Drawing.Size(121, 20);
            this.txtSubTopicNo.TabIndex = 17;
            // 
            // lbSubTopicNo
            // 
            this.lbSubTopicNo.AutoSize = true;
            this.lbSubTopicNo.Location = new System.Drawing.Point(198, 98);
            this.lbSubTopicNo.Name = "lbSubTopicNo";
            this.lbSubTopicNo.Size = new System.Drawing.Size(66, 13);
            this.lbSubTopicNo.TabIndex = 16;
            this.lbSubTopicNo.Text = "Sub Topic #";
            // 
            // txtMaterial
            // 
            this.txtMaterial.Location = new System.Drawing.Point(368, 173);
            this.txtMaterial.Name = "txtMaterial";
            this.txtMaterial.Size = new System.Drawing.Size(121, 20);
            this.txtMaterial.TabIndex = 25;
            // 
            // txtTitleSubTopic
            // 
            this.txtTitleSubTopic.Location = new System.Drawing.Point(368, 129);
            this.txtTitleSubTopic.Name = "txtTitleSubTopic";
            this.txtTitleSubTopic.Size = new System.Drawing.Size(121, 20);
            this.txtTitleSubTopic.TabIndex = 24;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(415, 229);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 23;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(202, 229);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 22;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblMaterial
            // 
            this.lblMaterial.AutoSize = true;
            this.lblMaterial.Location = new System.Drawing.Point(198, 180);
            this.lblMaterial.Name = "lblMaterial";
            this.lblMaterial.Size = new System.Drawing.Size(44, 13);
            this.lblMaterial.TabIndex = 21;
            this.lblMaterial.Text = "Material";
            // 
            // lblTitleSubTopic
            // 
            this.lblTitleSubTopic.AutoSize = true;
            this.lblTitleSubTopic.Location = new System.Drawing.Point(198, 136);
            this.lblTitleSubTopic.Name = "lblTitleSubTopic";
            this.lblTitleSubTopic.Size = new System.Drawing.Size(79, 13);
            this.lblTitleSubTopic.TabIndex = 20;
            this.lblTitleSubTopic.Text = "Title Sub Topic";
            // 
            // lblSubTopicID
            // 
            this.lblSubTopicID.AutoSize = true;
            this.lblSubTopicID.Location = new System.Drawing.Point(199, 28);
            this.lblSubTopicID.Name = "lblSubTopicID";
            this.lblSubTopicID.Size = new System.Drawing.Size(64, 13);
            this.lblSubTopicID.TabIndex = 26;
            this.lblSubTopicID.Text = "SubTopicID";
            this.lblSubTopicID.Visible = false;
            // 
            // SubTopic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSubTopicID);
            this.Controls.Add(this.txtMaterial);
            this.Controls.Add(this.txtTitleSubTopic);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblMaterial);
            this.Controls.Add(this.lblTitleSubTopic);
            this.Controls.Add(this.txtSubTopicNo);
            this.Controls.Add(this.lbSubTopicNo);
            this.Controls.Add(this.txtMainTopic);
            this.Controls.Add(this.lblMainTopic);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SubTopic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SubTopic";
            this.Load += new System.EventHandler(this.SubTopic_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtMainTopic;
        private System.Windows.Forms.Label lblMainTopic;
        public System.Windows.Forms.TextBox txtSubTopicNo;
        private System.Windows.Forms.Label lbSubTopicNo;
        public System.Windows.Forms.TextBox txtMaterial;
        public System.Windows.Forms.TextBox txtTitleSubTopic;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblMaterial;
        private System.Windows.Forms.Label lblTitleSubTopic;
        public System.Windows.Forms.Label lblSubTopicID;
    }
}