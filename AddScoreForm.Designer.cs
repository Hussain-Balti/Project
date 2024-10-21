namespace Student_Project
{
    partial class AddScoreForm
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
            this.textBoxStudentId = new System.Windows.Forms.TextBox();
            this.labelStudentId = new System.Windows.Forms.Label();
            this.textBoxScore = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxSelectCourse = new System.Windows.Forms.ComboBox();
            this.buttonAddScore = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDescription.Location = new System.Drawing.Point(173, 225);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(247, 73);
            this.textBoxDescription.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(53, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 20);
            this.label6.TabIndex = 22;
            this.label6.Text = "Description:";
            // 
            // textBoxStudentId
            // 
            this.textBoxStudentId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxStudentId.Location = new System.Drawing.Point(173, 44);
            this.textBoxStudentId.Name = "textBoxStudentId";
            this.textBoxStudentId.ReadOnly = true;
            this.textBoxStudentId.Size = new System.Drawing.Size(126, 26);
            this.textBoxStudentId.TabIndex = 20;
            // 
            // labelStudentId
            // 
            this.labelStudentId.AutoSize = true;
            this.labelStudentId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStudentId.ForeColor = System.Drawing.Color.White;
            this.labelStudentId.Location = new System.Drawing.Point(56, 47);
            this.labelStudentId.Name = "labelStudentId";
            this.labelStudentId.Size = new System.Drawing.Size(102, 20);
            this.labelStudentId.TabIndex = 19;
            this.labelStudentId.Text = "Student ID:";
            // 
            // textBoxScore
            // 
            this.textBoxScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxScore.Location = new System.Drawing.Point(173, 163);
            this.textBoxScore.Name = "textBoxScore";
            this.textBoxScore.Size = new System.Drawing.Size(247, 26);
            this.textBoxScore.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(97, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "Score:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(31, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 20);
            this.label2.TabIndex = 26;
            this.label2.Text = "Select Course:";
            // 
            // comboBoxSelectCourse
            // 
            this.comboBoxSelectCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSelectCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSelectCourse.FormattingEnabled = true;
            this.comboBoxSelectCourse.Location = new System.Drawing.Point(173, 100);
            this.comboBoxSelectCourse.Name = "comboBoxSelectCourse";
            this.comboBoxSelectCourse.Size = new System.Drawing.Size(247, 28);
            this.comboBoxSelectCourse.TabIndex = 27;
            // 
            // buttonAddScore
            // 
            this.buttonAddScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(106)))));
            this.buttonAddScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddScore.ForeColor = System.Drawing.Color.White;
            this.buttonAddScore.Location = new System.Drawing.Point(35, 329);
            this.buttonAddScore.Name = "buttonAddScore";
            this.buttonAddScore.Size = new System.Drawing.Size(385, 46);
            this.buttonAddScore.TabIndex = 28;
            this.buttonAddScore.Text = " Add Score";
            this.buttonAddScore.UseVisualStyleBackColor = false;
            this.buttonAddScore.Click += new System.EventHandler(this.buttonAddScore_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(459, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(320, 352);
            this.dataGridView1.TabIndex = 29;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // AddScoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(68)))), ((int)(((byte)(173)))));
            this.ClientSize = new System.Drawing.Size(803, 421);
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
            this.Name = "AddScoreForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddScoreForm";
            this.Load += new System.EventHandler(this.AddScoreForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxStudentId;
        private System.Windows.Forms.Label labelStudentId;
        private System.Windows.Forms.TextBox textBoxScore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxSelectCourse;
        private System.Windows.Forms.Button buttonAddScore;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}