namespace Aplikacija_za_izvjestaj_o_uspjehu_i_vladanju_ucenika
{
    partial class ViewGrades
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewGrades));
            this.cb_subjects = new System.Windows.Forms.ComboBox();
            this.lb_grades = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_return = new System.Windows.Forms.Button();
            this.lb_avgGrade = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lb_student = new System.Windows.Forms.Label();
            this.lb_studentAvg = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cb_subjects
            // 
            this.cb_subjects.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_subjects.FormattingEnabled = true;
            this.cb_subjects.Location = new System.Drawing.Point(157, 51);
            this.cb_subjects.Name = "cb_subjects";
            this.cb_subjects.Size = new System.Drawing.Size(183, 21);
            this.cb_subjects.Sorted = true;
            this.cb_subjects.TabIndex = 7;
            this.cb_subjects.SelectedIndexChanged += new System.EventHandler(this.cb_subjects_SelectedIndexChanged);
            // 
            // lb_grades
            // 
            this.lb_grades.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lb_grades.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_grades.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_grades.Location = new System.Drawing.Point(157, 79);
            this.lb_grades.Name = "lb_grades";
            this.lb_grades.Size = new System.Drawing.Size(183, 20);
            this.lb_grades.TabIndex = 8;
            this.lb_grades.Text = "5, 5";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(14, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(143, 20);
            this.label8.TabIndex = 11;
            this.label8.Text = "Predmet";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Ocjene";
            // 
            // btn_return
            // 
            this.btn_return.BackColor = System.Drawing.Color.Lime;
            this.btn_return.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LimeGreen;
            this.btn_return.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LawnGreen;
            this.btn_return.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_return.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_return.Location = new System.Drawing.Point(15, 172);
            this.btn_return.Name = "btn_return";
            this.btn_return.Size = new System.Drawing.Size(325, 50);
            this.btn_return.TabIndex = 10;
            this.btn_return.Text = "Nazad";
            this.btn_return.UseVisualStyleBackColor = false;
            this.btn_return.Click += new System.EventHandler(this.btn_return_Click);
            // 
            // lb_avgGrade
            // 
            this.lb_avgGrade.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lb_avgGrade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_avgGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_avgGrade.Location = new System.Drawing.Point(157, 107);
            this.lb_avgGrade.Name = "lb_avgGrade";
            this.lb_avgGrade.Size = new System.Drawing.Size(183, 20);
            this.lb_avgGrade.TabIndex = 9;
            this.lb_avgGrade.Text = "5.0";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Prosjek predmeta";
            // 
            // lb_student
            // 
            this.lb_student.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_student.Location = new System.Drawing.Point(14, 14);
            this.lb_student.Name = "lb_student";
            this.lb_student.Size = new System.Drawing.Size(326, 29);
            this.lb_student.TabIndex = 14;
            this.lb_student.Text = "Učenik";
            this.lb_student.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lb_studentAvg
            // 
            this.lb_studentAvg.BackColor = System.Drawing.Color.DodgerBlue;
            this.lb_studentAvg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_studentAvg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_studentAvg.Location = new System.Drawing.Point(157, 136);
            this.lb_studentAvg.Name = "lb_studentAvg";
            this.lb_studentAvg.Size = new System.Drawing.Size(183, 20);
            this.lb_studentAvg.TabIndex = 15;
            this.lb_studentAvg.Text = "5.0";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Prosjek učenika";
            // 
            // ViewGrades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(354, 236);
            this.Controls.Add(this.lb_studentAvg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb_student);
            this.Controls.Add(this.cb_subjects);
            this.Controls.Add(this.lb_grades);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_return);
            this.Controls.Add(this.lb_avgGrade);
            this.Controls.Add(this.label6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ViewGrades";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pregled ocijena";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ViewGrades_FormClosed);
            this.Load += new System.EventHandler(this.ViewGrades_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_subjects;
        private System.Windows.Forms.Label lb_grades;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_return;
        private System.Windows.Forms.Label lb_avgGrade;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lb_student;
        private System.Windows.Forms.Label lb_studentAvg;
        private System.Windows.Forms.Label label2;
    }
}