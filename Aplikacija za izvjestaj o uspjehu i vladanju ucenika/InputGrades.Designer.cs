namespace Aplikacija_za_izvjestaj_o_uspjehu_i_vladanju_ucenika
{
    partial class InputGrades
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InputGrades));
            this.btn_return = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.cb_students = new System.Windows.Forms.ComboBox();
            this.cb_subjects = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.num_grade = new System.Windows.Forms.NumericUpDown();
            this.btn_addGrade = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.num_grade)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_return
            // 
            this.btn_return.BackColor = System.Drawing.Color.Lime;
            this.btn_return.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LimeGreen;
            this.btn_return.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LawnGreen;
            this.btn_return.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_return.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_return.Location = new System.Drawing.Point(16, 164);
            this.btn_return.Name = "btn_return";
            this.btn_return.Size = new System.Drawing.Size(136, 50);
            this.btn_return.TabIndex = 4;
            this.btn_return.Text = "Nazad";
            this.btn_return.UseVisualStyleBackColor = false;
            this.btn_return.Click += new System.EventHandler(this.btn_return_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.Lime;
            this.btn_exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LimeGreen;
            this.btn_exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LawnGreen;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.Location = new System.Drawing.Point(161, 164);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(136, 50);
            this.btn_exit.TabIndex = 5;
            this.btn_exit.Text = "Izlaz";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // cb_students
            // 
            this.cb_students.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_students.FormattingEnabled = true;
            this.cb_students.Location = new System.Drawing.Point(92, 12);
            this.cb_students.Name = "cb_students";
            this.cb_students.Size = new System.Drawing.Size(205, 21);
            this.cb_students.Sorted = true;
            this.cb_students.TabIndex = 0;
            // 
            // cb_subjects
            // 
            this.cb_subjects.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_subjects.FormattingEnabled = true;
            this.cb_subjects.Location = new System.Drawing.Point(92, 41);
            this.cb_subjects.Name = "cb_subjects";
            this.cb_subjects.Size = new System.Drawing.Size(205, 21);
            this.cb_subjects.Sorted = true;
            this.cb_subjects.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Predmet";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Učenik";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Ocjena";
            // 
            // num_grade
            // 
            this.num_grade.Location = new System.Drawing.Point(92, 70);
            this.num_grade.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.num_grade.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_grade.Name = "num_grade";
            this.num_grade.Size = new System.Drawing.Size(205, 20);
            this.num_grade.TabIndex = 2;
            this.num_grade.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // btn_addGrade
            // 
            this.btn_addGrade.BackColor = System.Drawing.Color.Lime;
            this.btn_addGrade.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LimeGreen;
            this.btn_addGrade.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LawnGreen;
            this.btn_addGrade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addGrade.Location = new System.Drawing.Point(16, 106);
            this.btn_addGrade.Name = "btn_addGrade";
            this.btn_addGrade.Size = new System.Drawing.Size(281, 50);
            this.btn_addGrade.TabIndex = 3;
            this.btn_addGrade.Text = "Dodaj ocjenu";
            this.btn_addGrade.UseVisualStyleBackColor = false;
            this.btn_addGrade.Click += new System.EventHandler(this.btn_addGrade_Click);
            // 
            // InputGrades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(309, 226);
            this.Controls.Add(this.btn_addGrade);
            this.Controls.Add(this.num_grade);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_subjects);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cb_students);
            this.Controls.Add(this.btn_return);
            this.Controls.Add(this.btn_exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "InputGrades";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Unos ocjene";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.InputGrades_FormClosed);
            this.Load += new System.EventHandler(this.InputGrades_Load);
            ((System.ComponentModel.ISupportInitialize)(this.num_grade)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_return;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.ComboBox cb_students;
        private System.Windows.Forms.ComboBox cb_subjects;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown num_grade;
        private System.Windows.Forms.Button btn_addGrade;
    }
}