using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Aplikacija_za_izvjestaj_o_uspjehu_i_vladanju_ucenika
{
    public partial class ViewGrades : Form
    {
        public ViewGrades()
        {
            InitializeComponent();
        }

        private List<Subject> subjects = new List<Subject>();
        private Student student = ViewStudent._Student;

        private void ViewGrades_Load(object sender, EventArgs e)
        {
            try
            {
                lb_student.Text = student.LastName + " " + student.FirstName;
                lb_studentAvg.Text = Global.GetStudentAvgGrade(student.Subjects).ToString();

                LoadSubjects();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cb_subjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Subject selectedSubject = subjects[cb_subjects.SelectedIndex];
                string grades = String.Empty;

                foreach (StudentSubjects subject in student.Subjects)
                {
                    if (subject.SubjectID == selectedSubject.ID)
                    {
                        grades = subject._Grades;
                        break;
                    }
                }

                lb_grades.Text = grades.Replace(";", ", ");
                lb_avgGrade.Text = Global.GetAvgGrade(grades).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadSubjects()
        {
            try
            {
                cb_subjects.Items.Clear();
                subjects = Global.GetSubjects();

                foreach (Subject s in subjects)
                    cb_subjects.Items.Add(s.Name);

                if (cb_subjects.Items.Count > 0)
                    cb_subjects.SelectedIndex = 0;
            }
            catch
            {
                throw;
            }
        }

        private void ViewGrades_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                ViewStudent._ViewStudent.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_return_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}