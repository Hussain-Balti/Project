namespace Student_Project
{
    partial class ManageCourseForm
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
            this.numericUpDownHours = new System.Windows.Forms.NumericUpDown();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.labelCredit_hour = new System.Windows.Forms.Label();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelSelectCourse = new System.Windows.Forms.Label();
            this.buttonEditCourse = new System.Windows.Forms.Button();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.listBoxCourse = new System.Windows.Forms.ListBox();
            this.labelTotalCourse = new System.Windows.Forms.Label();
            this.buttonAddCourse = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonFirst = new System.Windows.Forms.Button();
            this.buttonLast = new System.Windows.Forms.Button();
            this.buttonPrevious = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHours)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownHours
            // 
            this.numericUpDownHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownHours.Location = new System.Drawing.Point(170, 129);
            this.numericUpDownHours.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDownHours.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownHours.Name = "numericUpDownHours";
            this.numericUpDownHours.Size = new System.Drawing.Size(120, 26);
            this.numericUpDownHours.TabIndex = 25;
            this.numericUpDownHours.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDescription.Location = new System.Drawing.Point(170, 185);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(247, 73);
            this.textBoxDescription.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(50, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 20);
            this.label6.TabIndex = 23;
            this.label6.Text = "Description:";
            // 
            // labelCredit_hour
            // 
            this.labelCredit_hour.AutoSize = true;
            this.labelCredit_hour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCredit_hour.ForeColor = System.Drawing.Color.White;
            this.labelCredit_hour.Location = new System.Drawing.Point(47, 135);
            this.labelCredit_hour.Name = "labelCredit_hour";
            this.labelCredit_hour.Size = new System.Drawing.Size(108, 20);
            this.labelCredit_hour.TabIndex = 22;
            this.labelCredit_hour.Text = "Credit_hour:";
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTitle.Location = new System.Drawing.Point(170, 80);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(247, 26);
            this.textBoxTitle.TabIndex = 21;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(107, 86);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(48, 20);
            this.labelTitle.TabIndex = 20;
            this.labelTitle.Text = "Title:";
            // 
            // labelSelectCourse
            // 
            this.labelSelectCourse.AutoSize = true;
            this.labelSelectCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelectCourse.ForeColor = System.Drawing.Color.White;
            this.labelSelectCourse.Location = new System.Drawing.Point(122, 38);
            this.labelSelectCourse.Name = "labelSelectCourse";
            this.labelSelectCourse.Size = new System.Drawing.Size(33, 20);
            this.labelSelectCourse.TabIndex = 26;
            this.labelSelectCourse.Text = "ID:";
            // 
            // buttonEditCourse
            // 
            this.buttonEditCourse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(106)))));
            this.buttonEditCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditCourse.ForeColor = System.Drawing.Color.White;
            this.buttonEditCourse.Location = new System.Drawing.Point(197, 391);
            this.buttonEditCourse.Name = "buttonEditCourse";
            this.buttonEditCourse.Size = new System.Drawing.Size(107, 34);
            this.buttonEditCourse.TabIndex = 28;
            this.buttonEditCourse.Text = " Edit";
            this.buttonEditCourse.UseVisualStyleBackColor = false;
            this.buttonEditCourse.Click += new System.EventHandler(this.buttonEditCourse_Click);
            // 
            // textBoxID
            // 
            this.textBoxID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxID.Location = new System.Drawing.Point(170, 32);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(247, 26);
            this.textBoxID.TabIndex = 29;
            // 
            // listBoxCourse
            // 
            this.listBoxCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxCourse.FormattingEnabled = true;
            this.listBoxCourse.ItemHeight = 25;
            this.listBoxCourse.Location = new System.Drawing.Point(518, 31);
            this.listBoxCourse.Name = "listBoxCourse";
            this.listBoxCourse.Size = new System.Drawing.Size(286, 304);
            this.listBoxCourse.TabIndex = 30;
            this.listBoxCourse.Click += new System.EventHandler(this.listBoxCourse_Click);
            this.listBoxCourse.SelectedIndexChanged += new System.EventHandler(this.listBoxCourse_SelectedIndexChanged);
            // 
            // labelTotalCourse
            // 
            this.labelTotalCourse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(105)))), ((int)(((byte)(14)))));
            this.labelTotalCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalCourse.ForeColor = System.Drawing.Color.White;
            this.labelTotalCourse.Location = new System.Drawing.Point(597, 338);
            this.labelTotalCourse.Name = "labelTotalCourse";
            this.labelTotalCourse.Size = new System.Drawing.Size(207, 46);
            this.labelTotalCourse.TabIndex = 31;
            this.labelTotalCourse.Text = "Total Courses:";
            this.labelTotalCourse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonAddCourse
            // 
            this.buttonAddCourse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(131)))), ((int)(((byte)(215)))));
            this.buttonAddCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddCourse.ForeColor = System.Drawing.Color.White;
            this.buttonAddCourse.Location = new System.Drawing.Point(70, 391);
            this.buttonAddCourse.Name = "buttonAddCourse";
            this.buttonAddCourse.Size = new System.Drawing.Size(108, 34);
            this.buttonAddCourse.TabIndex = 32;
            this.buttonAddCourse.Text = " Add";
            this.buttonAddCourse.UseVisualStyleBackColor = false;
            this.buttonAddCourse.Click += new System.EventHandler(this.buttonAddCourse_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(38)))), ((int)(((byte)(19)))));
            this.buttonRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemove.ForeColor = System.Drawing.Color.White;
            this.buttonRemove.Location = new System.Drawing.Point(323, 391);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(109, 34);
            this.buttonRemove.TabIndex = 33;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = false;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonFirst
            // 
            this.buttonFirst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.buttonFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFirst.ForeColor = System.Drawing.Color.White;
            this.buttonFirst.Location = new System.Drawing.Point(55, 300);
            this.buttonFirst.Name = "buttonFirst";
            this.buttonFirst.Size = new System.Drawing.Size(91, 35);
            this.buttonFirst.TabIndex = 34;
            this.buttonFirst.Text = " <<";
            this.buttonFirst.UseVisualStyleBackColor = false;
            this.buttonFirst.Click += new System.EventHandler(this.buttonFirst_Click);
            // 
            // buttonLast
            // 
            this.buttonLast.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.buttonLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLast.ForeColor = System.Drawing.Color.White;
            this.buttonLast.Location = new System.Drawing.Point(372, 300);
            this.buttonLast.Name = "buttonLast";
            this.buttonLast.Size = new System.Drawing.Size(91, 35);
            this.buttonLast.TabIndex = 35;
            this.buttonLast.Text = " >>";
            this.buttonLast.UseVisualStyleBackColor = false;
            this.buttonLast.Click += new System.EventHandler(this.buttonLast_Click);
            // 
            // buttonPrevious
            // 
            this.buttonPrevious.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.buttonPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrevious.ForeColor = System.Drawing.Color.White;
            this.buttonPrevious.Location = new System.Drawing.Point(266, 300);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Size = new System.Drawing.Size(91, 35);
            this.buttonPrevious.TabIndex = 36;
            this.buttonPrevious.Text = " <";
            this.buttonPrevious.UseVisualStyleBackColor = false;
            this.buttonPrevious.Click += new System.EventHandler(this.buttonPrevious_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.buttonNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNext.ForeColor = System.Drawing.Color.White;
            this.buttonNext.Location = new System.Drawing.Point(159, 300);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(91, 35);
            this.buttonNext.TabIndex = 37;
            this.buttonNext.Text = " >";
            this.buttonNext.UseVisualStyleBackColor = false;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // ManageCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(201)))), ((int)(((byte)(169)))));
            this.ClientSize = new System.Drawing.Size(826, 451);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonPrevious);
            this.Controls.Add(this.buttonLast);
            this.Controls.Add(this.buttonFirst);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonAddCourse);
            this.Controls.Add(this.labelTotalCourse);
            this.Controls.Add(this.listBoxCourse);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.buttonEditCourse);
            this.Controls.Add(this.labelSelectCourse);
            this.Controls.Add(this.numericUpDownHours);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelCredit_hour);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.labelTitle);
            this.Name = "ManageCourseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageCourseForm";
            this.Load += new System.EventHandler(this.ManageCourseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHours)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDownHours;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelCredit_hour;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelSelectCourse;
        private System.Windows.Forms.Button buttonEditCourse;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.ListBox listBoxCourse;
        private System.Windows.Forms.Label labelTotalCourse;
        private System.Windows.Forms.Button buttonAddCourse;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonFirst;
        private System.Windows.Forms.Button buttonLast;
        private System.Windows.Forms.Button buttonPrevious;
        private System.Windows.Forms.Button buttonNext;
    }
}