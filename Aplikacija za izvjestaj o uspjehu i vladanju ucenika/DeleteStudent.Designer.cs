namespace Aplikacija_za_izvjestaj_o_uspjehu_i_vladanju_ucenika
{
    partial class DeleteStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteStudent));
            this.btn_deleteStudent = new System.Windows.Forms.Button();
            this.btn_return = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.cb_students = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btn_deleteStudent
            // 
            this.btn_deleteStudent.BackColor = System.Drawing.Color.Lime;
            this.btn_deleteStudent.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LimeGreen;
            this.btn_deleteStudent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LawnGreen;
            this.btn_deleteStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deleteStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deleteStudent.Location = new System.Drawing.Point(14, 41);
            this.btn_deleteStudent.Name = "btn_deleteStudent";
            this.btn_deleteStudent.Size = new System.Drawing.Size(281, 50);
            this.btn_deleteStudent.TabIndex = 1;
            this.btn_deleteStudent.Text = "Izbriši učenika";
            this.btn_deleteStudent.UseVisualStyleBackColor = false;
            this.btn_deleteStudent.Click += new System.EventHandler(this.btn_deleteStudent_Click);
            // 
            // btn_return
            // 
            this.btn_return.BackColor = System.Drawing.Color.Lime;
            this.btn_return.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LimeGreen;
            this.btn_return.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LawnGreen;
            this.btn_return.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_return.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_return.Location = new System.Drawing.Point(14, 113);
            this.btn_return.Name = "btn_return";
            this.btn_return.Size = new System.Drawing.Size(136, 50);
            this.btn_return.TabIndex = 2;
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
            this.btn_exit.Location = new System.Drawing.Point(159, 113);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(136, 50);
            this.btn_exit.TabIndex = 3;
            this.btn_exit.Text = "Izlaz";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // cb_students
            // 
            this.cb_students.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_students.FormattingEnabled = true;
            this.cb_students.Location = new System.Drawing.Point(14, 14);
            this.cb_students.Name = "cb_students";
            this.cb_students.Size = new System.Drawing.Size(281, 21);
            this.cb_students.Sorted = true;
            this.cb_students.TabIndex = 0;
            // 
            // DeleteStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(309, 176);
            this.Controls.Add(this.btn_deleteStudent);
            this.Controls.Add(this.btn_return);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.cb_students);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DeleteStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Brisanje učenika";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DeleteStudent_FormClosed);
            this.Load += new System.EventHandler(this.DeleteStudent_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_deleteStudent;
        private System.Windows.Forms.Button btn_return;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.ComboBox cb_students;
    }
}