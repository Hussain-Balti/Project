namespace Student_Project
{
    partial class StatisticForm
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
            this.panelTotal = new System.Windows.Forms.Panel();
            this.panelMale = new System.Windows.Forms.Panel();
            this.panelFemale = new System.Windows.Forms.Panel();
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelMale = new System.Windows.Forms.Label();
            this.labelFemale = new System.Windows.Forms.Label();
            this.panelTotal.SuspendLayout();
            this.panelMale.SuspendLayout();
            this.panelFemale.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTotal
            // 
            this.panelTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(68)))), ((int)(((byte)(173)))));
            this.panelTotal.Controls.Add(this.labelTotal);
            this.panelTotal.Location = new System.Drawing.Point(0, 0);
            this.panelTotal.Name = "panelTotal";
            this.panelTotal.Size = new System.Drawing.Size(436, 126);
            this.panelTotal.TabIndex = 0;
            // 
            // panelMale
            // 
            this.panelMale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(49)))), ((int)(((byte)(63)))));
            this.panelMale.Controls.Add(this.labelMale);
            this.panelMale.Location = new System.Drawing.Point(0, 126);
            this.panelMale.Name = "panelMale";
            this.panelMale.Size = new System.Drawing.Size(220, 121);
            this.panelMale.TabIndex = 0;
            // 
            // panelFemale
            // 
            this.panelFemale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(105)))), ((int)(((byte)(14)))));
            this.panelFemale.Controls.Add(this.labelFemale);
            this.panelFemale.Location = new System.Drawing.Point(218, 126);
            this.panelFemale.Name = "panelFemale";
            this.panelFemale.Size = new System.Drawing.Size(218, 121);
            this.panelFemale.TabIndex = 1;
            // 
            // labelTotal
            // 
            this.labelTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.ForeColor = System.Drawing.Color.White;
            this.labelTotal.Location = new System.Drawing.Point(0, 0);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(436, 126);
            this.labelTotal.TabIndex = 0;
            this.labelTotal.Text = "Total Students: 100";
            this.labelTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTotal.Click += new System.EventHandler(this.labelTotal_Click);
            this.labelTotal.MouseEnter += new System.EventHandler(this.labelTotal_MouseEnter);
            this.labelTotal.MouseLeave += new System.EventHandler(this.labelTotal_MouseLeave);
            // 
            // labelMale
            // 
            this.labelMale.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMale.ForeColor = System.Drawing.Color.White;
            this.labelMale.Location = new System.Drawing.Point(0, 0);
            this.labelMale.Name = "labelMale";
            this.labelMale.Size = new System.Drawing.Size(220, 121);
            this.labelMale.TabIndex = 1;
            this.labelMale.Text = "Male: 50%";
            this.labelMale.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelMale.MouseEnter += new System.EventHandler(this.labelMale_MouseEnter);
            this.labelMale.MouseLeave += new System.EventHandler(this.labelMale_MouseLeave);
            // 
            // labelFemale
            // 
            this.labelFemale.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFemale.ForeColor = System.Drawing.Color.White;
            this.labelFemale.Location = new System.Drawing.Point(0, 0);
            this.labelFemale.Name = "labelFemale";
            this.labelFemale.Size = new System.Drawing.Size(218, 121);
            this.labelFemale.TabIndex = 2;
            this.labelFemale.Text = "Female: 50%";
            this.labelFemale.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelFemale.MouseEnter += new System.EventHandler(this.labelFemale_MouseEnter);
            this.labelFemale.MouseLeave += new System.EventHandler(this.labelFemale_MouseLeave);
            // 
            // StatisticForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 246);
            this.Controls.Add(this.panelFemale);
            this.Controls.Add(this.panelMale);
            this.Controls.Add(this.panelTotal);
            this.Name = "StatisticForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StatisticForm";
            this.Load += new System.EventHandler(this.StatisticForm_Load);
            this.panelTotal.ResumeLayout(false);
            this.panelMale.ResumeLayout(false);
            this.panelFemale.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTotal;
        private System.Windows.Forms.Panel panelFemale;
        private System.Windows.Forms.Panel panelMale;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label labelMale;
        private System.Windows.Forms.Label labelFemale;
    }
}