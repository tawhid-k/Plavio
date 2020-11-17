namespace SchedulingWizard.frames
{
    partial class adminShowCourseInfo
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
            this.namelbl = new System.Windows.Forms.Label();
            this.idlbl = new System.Windows.Forms.Label();
            this.seclbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.day1lbl = new System.Windows.Forms.Label();
            this.day2lbl = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // namelbl
            // 
            this.namelbl.AutoSize = true;
            this.namelbl.Font = new System.Drawing.Font("Calisto MT", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namelbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.namelbl.Location = new System.Drawing.Point(12, 27);
            this.namelbl.Name = "namelbl";
            this.namelbl.Size = new System.Drawing.Size(188, 32);
            this.namelbl.TabIndex = 1;
            this.namelbl.Text = "Course Name:";
            // 
            // idlbl
            // 
            this.idlbl.AutoSize = true;
            this.idlbl.Font = new System.Drawing.Font("Calisto MT", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idlbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.idlbl.Location = new System.Drawing.Point(12, 70);
            this.idlbl.Name = "idlbl";
            this.idlbl.Size = new System.Drawing.Size(147, 32);
            this.idlbl.TabIndex = 2;
            this.idlbl.Text = "Course ID:";
            // 
            // seclbl
            // 
            this.seclbl.AutoSize = true;
            this.seclbl.Font = new System.Drawing.Font("Calisto MT", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seclbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.seclbl.Location = new System.Drawing.Point(12, 115);
            this.seclbl.Name = "seclbl";
            this.seclbl.Size = new System.Drawing.Size(110, 32);
            this.seclbl.TabIndex = 3;
            this.seclbl.Text = "Section:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calisto MT", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(12, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "Class Timing";
            // 
            // day1lbl
            // 
            this.day1lbl.AutoSize = true;
            this.day1lbl.Font = new System.Drawing.Font("Calisto MT", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.day1lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.day1lbl.Location = new System.Drawing.Point(12, 212);
            this.day1lbl.Name = "day1lbl";
            this.day1lbl.Size = new System.Drawing.Size(68, 32);
            this.day1lbl.TabIndex = 5;
            this.day1lbl.Text = "Sun:";
            // 
            // day2lbl
            // 
            this.day2lbl.AutoSize = true;
            this.day2lbl.Font = new System.Drawing.Font("Calisto MT", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.day2lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.day2lbl.Location = new System.Drawing.Point(12, 256);
            this.day2lbl.Name = "day2lbl";
            this.day2lbl.Size = new System.Drawing.Size(68, 32);
            this.day2lbl.TabIndex = 6;
            this.day2lbl.Text = "Sun:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(319, 321);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 52);
            this.button1.TabIndex = 7;
            this.button1.Text = "Okay";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Okay);
            // 
            // adminShowCourseInfo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(762, 385);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.day2lbl);
            this.Controls.Add(this.day1lbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.seclbl);
            this.Controls.Add(this.idlbl);
            this.Controls.Add(this.namelbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "adminShowCourseInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "adminShowCourseInfo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label namelbl;
        private System.Windows.Forms.Label idlbl;
        private System.Windows.Forms.Label seclbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label day1lbl;
        private System.Windows.Forms.Label day2lbl;
        private System.Windows.Forms.Button button1;
    }
}