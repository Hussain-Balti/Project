namespace Student_Project
{
    partial class ManageScoreForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonAddScore = new System.Windows.Forms.Button();
            this.comboBoxSelectCourse = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxScore = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxStudentId = new System.Windows.Forms.TextBox();
            this.labelStudentId = new System.Windows.Forms.Label();
            this.buttonRemoveScore = new System.Windows.Forms.Button();
            this.buttonAverageScore = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonShowStudent = new System.Windows.Forms.Button();
            this.buttonShowScores = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(477, 62);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(648, 425);
            this.dataGridView1.TabIndex = 39;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // buttonAddScore
            // 
            this.buttonAddScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(106)))));
            this.buttonAddScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddScore.ForeColor = System.Drawing.Color.White;
            this.buttonAddScore.Location = new System.Drawing.Point(30, 345);
            this.buttonAddScore.Name = "buttonAddScore";
            this.buttonAddScore.Size = new System.Drawing.Size(173, 50);
            this.buttonAddScore.TabIndex = 38;
            this.buttonAddScore.Text = " Add";
            this.buttonAddScore.UseVisualStyleBackColor = false;
            this.buttonAddScore.Click += new System.EventHandler(this.buttonAddScore_Click);
            // 
            // comboBoxSelectCourse
            // 
            this.comboBoxSelectCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSelectCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSelectCourse.FormattingEnabled = true;
            this.comboBoxSelectCourse.Location = new System.Drawing.Point(168, 104);
            this.comboBoxSelectCourse.Name = "comboBoxSelectCourse";
            this.comboBoxSelectCourse.Size = new System.Drawing.Size(247, 28);
            this.comboBoxSelectCourse.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(26, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 20);
            this.label2.TabIndex = 36;
            this.label2.Text = "Select Course:";
            // 
            // textBoxScore
            // 
            this.textBoxScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxScore.Location = new System.Drawing.Point(168, 167);
            this.textBoxScore.Name = "textBoxScore";
            this.textBoxScore.Size = new System.Drawing.Size(247, 26);
            this.textBoxScore.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(92, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 34;
            this.label1.Text = "Score:";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDescription.Location = new System.Drawing.Point(168, 229);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(247, 73);
            this.textBoxDescription.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(48, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 20);
            this.label6.TabIndex = 32;
            this.label6.Text = "Description:";
            // 
            // textBoxStudentId
            // 
            this.textBoxStudentId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxStudentId.Location = new System.Drawing.Point(168, 48);
            this.textBoxStudentId.Name = "textBoxStudentId";
            this.textBoxStudentId.ReadOnly = true;
            this.textBoxStudentId.Size = new System.Drawing.Size(126, 26);
            this.textBoxStudentId.TabIndex = 31;
            // 
            // labelStudentId
            // 
            this.labelStudentId.AutoSize = true;
            this.labelStudentId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStudentId.ForeColor = System.Drawing.Color.White;
            this.labelStudentId.Location = new System.Drawing.Point(51, 51);
            this.labelStudentId.Name = "labelStudentId";
            this.labelStudentId.Size = new System.Drawing.Size(102, 20);
            this.labelStudentId.TabIndex = 30;
            this.labelStudentId.Text = "Student ID:";
            // 
            // buttonRemoveScore
            // 
            this.buttonRemoveScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(38)))), ((int)(((byte)(19)))));
            this.buttonRemoveScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRemoveScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemoveScore.ForeColor = System.Drawing.Color.White;
            this.buttonRemoveScore.Location = new System.Drawing.Point(209, 345);
            this.buttonRemoveScore.Name = "buttonRemoveScore";
            this.buttonRemoveScore.Size = new System.Drawing.Size(185, 50);
            this.buttonRemoveScore.TabIndex = 40;
            this.buttonRemoveScore.Text = "Remove";
            this.buttonRemoveScore.UseVisualStyleBackColor = false;
            this.buttonRemoveScore.Click += new System.EventHandler(this.buttonRemoveScore_Click);
            // 
            // buttonAverageScore
            // 
            this.buttonAverageScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(131)))), ((int)(((byte)(215)))));
            this.buttonAverageScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAverageScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAverageScore.ForeColor = System.Drawing.Color.White;
            this.buttonAverageScore.Location = new System.Drawing.Point(30, 411);
            this.buttonAverageScore.Name = "buttonAverageScore";
            this.buttonAverageScore.Size = new System.Drawing.Size(364, 50);
            this.buttonAverageScore.TabIndex = 41;
            this.buttonAverageScore.Text = " Average Score By Course";
            this.buttonAverageScore.UseVisualStyleBackColor = false;
            this.buttonAverageScore.Click += new System.EventHandler(this.buttonAverageScore_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(27, 513);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(449, 18);
            this.label3.TabIndex = 42;
            this.label3.Text = "to edit a score to have to delete it and RE with the values you went. ";
            // 
            // buttonShowStudent
            // 
            this.buttonShowStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShowStudent.Location = new System.Drawing.Point(477, 28);
            this.buttonShowStudent.Name = "buttonShowStudent";
            this.buttonShowStudent.Size = new System.Drawing.Size(276, 28);
            this.buttonShowStudent.TabIndex = 43;
            this.buttonShowStudent.Text = "Show Student";
            this.buttonShowStudent.UseVisualStyleBackColor = true;
            this.buttonShowStudent.Click += new System.EventHandler(this.buttonShowStudent_Click);
            // 
            // buttonShowScores
            // 
            this.buttonShowScores.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShowScores.Location = new System.Drawing.Point(849, 28);
            this.buttonShowScores.Name = "buttonShowScores";
            this.buttonShowScores.Size = new System.Drawing.Size(276, 28);
            this.buttonShowScores.TabIndex = 44;
            this.buttonShowScores.Text = "Show Scores";
            this.buttonShowScores.UseVisualStyleBackColor = true;
            this.buttonShowScores.Click += new System.EventHandler(this.buttonShowScores_Click);
            // 
            // ManageScoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(68)))), ((int)(((byte)(173)))));
            this.ClientSize = new System.Drawing.Size(1162, 552);
            this.Controls.Add(this.buttonShowScores);
            this.Controls.Add(this.buttonShowStudent);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonAverageScore);
            this.Controls.Add(this.buttonRemoveScore);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonAddScore);
            this.Controls.Add(this.comboBoxSelectCourse);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxScore);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxStudentId);
            this.Controls.Add(this.labelStudentId);
            this.Name = "ManageScoreForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageScoreForm";
            this.Load += new System.EventHandler(this.ManageScoreForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonAddScore;
        private System.Windows.Forms.ComboBox comboBoxSelectCourse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxScore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxStudentId;
        private System.Windows.Forms.Label labelStudentId;
        private System.Windows.Forms.Button buttonRemoveScore;
        private System.Windows.Forms.Button buttonAverageScore;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonShowStudent;
        private System.Windows.Forms.Button buttonShowScores;
    }
}