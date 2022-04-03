namespace Aplikacija_za_izvjestaj_o_uspjehu_i_vladanju_ucenika
{
    partial class ViewSubject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewSubject));
            this.lb_professor = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_return = new System.Windows.Forms.Button();
            this.lb_avgGrade = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_subjects = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lb_professor
            // 
            this.lb_professor.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lb_professor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_professor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_professor.Location = new System.Drawing.Point(157, 42);
            this.lb_professor.Name = "lb_professor";
            this.lb_professor.Size = new System.Drawing.Size(183, 20);
            this.lb_professor.TabIndex = 1;
            this.lb_professor.Text = "Ime Prezime";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(14, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(143, 20);
            this.label8.TabIndex = 4;
            this.label8.Text = "Naziv";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Profesor";
            // 
            // btn_return
            // 
            this.btn_return.BackColor = System.Drawing.Color.Lime;
            this.btn_return.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LimeGreen;
            this.btn_return.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LawnGreen;
            this.btn_return.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_return.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_return.Location = new System.Drawing.Point(15, 106);
            this.btn_return.Name = "btn_return";
            this.btn_return.Size = new System.Drawing.Size(325, 50);
            this.btn_return.TabIndex = 3;
            this.btn_return.Text = "Nazad";
            this.btn_return.UseVisualStyleBackColor = false;
            this.btn_return.Click += new System.EventHandler(this.btn_return_Click);
            // 
            // lb_avgGrade
            // 
            this.lb_avgGrade.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lb_avgGrade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_avgGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_avgGrade.Location = new System.Drawing.Point(157, 70);
            this.lb_avgGrade.Name = "lb_avgGrade";
            this.lb_avgGrade.Size = new System.Drawing.Size(183, 20);
            this.lb_avgGrade.TabIndex = 2;
            this.lb_avgGrade.Text = "5,0";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Prosječna ocjena";
            // 
            // cb_subjects
            // 
            this.cb_subjects.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_subjects.FormattingEnabled = true;
            this.cb_subjects.Location = new System.Drawing.Point(157, 13);
            this.cb_subjects.Name = "cb_subjects";
            this.cb_subjects.Size = new System.Drawing.Size(183, 21);
            this.cb_subjects.Sorted = true;
            this.cb_subjects.TabIndex = 0;
            this.cb_subjects.SelectedIndexChanged += new System.EventHandler(this.cb_subjects_SelectedIndexChanged);
            // 
            // ViewSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(354, 171);
            this.Controls.Add(this.cb_subjects);
            this.Controls.Add(this.lb_professor);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_return);
            this.Controls.Add(this.lb_avgGrade);
            this.Controls.Add(this.label6);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ViewSubject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pregled predmeta";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ViewSubject_FormClosed);
            this.Load += new System.EventHandler(this.ViewSubject_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lb_professor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_return;
        private System.Windows.Forms.Label lb_avgGrade;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cb_subjects;
    }
}