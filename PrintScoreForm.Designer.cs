namespace Student_Project
{
    partial class PrintScoreForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxCourses = new System.Windows.Forms.ListBox();
            this.dataGridViewStudentScore = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonPrintScore = new System.Windows.Forms.Button();
            this.labelReset = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudentScore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Courses List";
            // 
            // listBoxCourses
            // 
            this.listBoxCourses.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxCourses.FormattingEnabled = true;
            this.listBoxCourses.ItemHeight = 24;
            this.listBoxCourses.Location = new System.Drawing.Point(12, 97);
            this.listBoxCourses.Name = "listBoxCourses";
            this.listBoxCourses.Size = new System.Drawing.Size(227, 316);
            this.listBoxCourses.TabIndex = 1;
            this.listBoxCourses.Click += new System.EventHandler(this.listBoxCourses_Click);
            // 
            // dataGridViewStudentScore
            // 
            this.dataGridViewStudentScore.AllowUserToAddRows = false;
            this.dataGridViewStudentScore.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewStudentScore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudentScore.Location = new System.Drawing.Point(255, 77);
            this.dataGridViewStudentScore.Name = "dataGridViewStudentScore";
            this.dataGridViewStudentScore.Size = new System.Drawing.Size(446, 352);
            this.dataGridViewStudentScore.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(331, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 33;
            this.label2.Text = "Score List";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(716, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 20);
            this.label3.TabIndex = 34;
            this.label3.Text = "Student List";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(720, 97);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(237, 316);
            this.dataGridView1.TabIndex = 35;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // buttonPrintScore
            // 
            this.buttonPrintScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(131)))), ((int)(((byte)(215)))));
            this.buttonPrintScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPrintScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrintScore.ForeColor = System.Drawing.Color.White;
            this.buttonPrintScore.Location = new System.Drawing.Point(12, 450);
            this.buttonPrintScore.Name = "buttonPrintScore";
            this.buttonPrintScore.Size = new System.Drawing.Size(945, 47);
            this.buttonPrintScore.TabIndex = 36;
            this.buttonPrintScore.Text = "Print To Text File";
            this.buttonPrintScore.UseVisualStyleBackColor = false;
            this.buttonPrintScore.Click += new System.EventHandler(this.buttonPrintScore_Click);
            // 
            // labelReset
            // 
            this.labelReset.AutoSize = true;
            this.labelReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReset.ForeColor = System.Drawing.Color.Coral;
            this.labelReset.Location = new System.Drawing.Point(460, 40);
            this.labelReset.Name = "labelReset";
            this.labelReset.Size = new System.Drawing.Size(52, 20);
            this.labelReset.TabIndex = 37;
            this.labelReset.Text = "Reset";
            this.labelReset.Click += new System.EventHandler(this.labelReset_Click);
            // 
            // PrintScoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(978, 519);
            this.Controls.Add(this.labelReset);
            this.Controls.Add(this.buttonPrintScore);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewStudentScore);
            this.Controls.Add(this.listBoxCourses);
            this.Controls.Add(this.label1);
            this.Name = "PrintScoreForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PrintScoreForm";
            this.Load += new System.EventHandler(this.PrintScoreForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudentScore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxCourses;
        private System.Windows.Forms.DataGridView dataGridViewStudentScore;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonPrintScore;
        private System.Windows.Forms.Label labelReset;
    }
}