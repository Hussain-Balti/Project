namespace Student_Project
{
    partial class AddCourseForm
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
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.labelCredit_hour = new System.Windows.Forms.Label();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.numericUpDownHours = new System.Windows.Forms.NumericUpDown();
            this.buttonAddCourse = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHours)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDescription.Location = new System.Drawing.Point(140, 151);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(247, 73);
            this.textBoxDescription.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(20, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Description:";
            // 
            // labelCredit_hour
            // 
            this.labelCredit_hour.AutoSize = true;
            this.labelCredit_hour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCredit_hour.ForeColor = System.Drawing.Color.White;
            this.labelCredit_hour.Location = new System.Drawing.Point(17, 86);
            this.labelCredit_hour.Name = "labelCredit_hour";
            this.labelCredit_hour.Size = new System.Drawing.Size(108, 20);
            this.labelCredit_hour.TabIndex = 14;
            this.labelCredit_hour.Text = "Credit_hour:";
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTitle.Location = new System.Drawing.Point(140, 24);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(247, 26);
            this.textBoxTitle.TabIndex = 13;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(77, 30);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(48, 20);
            this.labelTitle.TabIndex = 12;
            this.labelTitle.Text = "Title:";
            // 
            // numericUpDownHours
            // 
            this.numericUpDownHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownHours.Location = new System.Drawing.Point(140, 80);
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
            this.numericUpDownHours.TabIndex = 18;
            this.numericUpDownHours.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // buttonAddCourse
            // 
            this.buttonAddCourse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(131)))), ((int)(((byte)(215)))));
            this.buttonAddCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddCourse.ForeColor = System.Drawing.Color.White;
            this.buttonAddCourse.Location = new System.Drawing.Point(21, 251);
            this.buttonAddCourse.Name = "buttonAddCourse";
            this.buttonAddCourse.Size = new System.Drawing.Size(366, 47);
            this.buttonAddCourse.TabIndex = 19;
            this.buttonAddCourse.Text = " Add";
            this.buttonAddCourse.UseVisualStyleBackColor = false;
            this.buttonAddCourse.Click += new System.EventHandler(this.buttonAddCourse_Click);
            // 
            // AddCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(201)))), ((int)(((byte)(169)))));
            this.ClientSize = new System.Drawing.Size(420, 318);
            this.Controls.Add(this.buttonAddCourse);
            this.Controls.Add(this.numericUpDownHours);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelCredit_hour);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.labelTitle);
            this.Name = "AddCourseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddCourseForm";
            this.Load += new System.EventHandler(this.AddCourseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHours)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelCredit_hour;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.NumericUpDown numericUpDownHours;
        private System.Windows.Forms.Button buttonAddCourse;
    }
}