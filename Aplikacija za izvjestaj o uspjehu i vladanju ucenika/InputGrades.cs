using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Aplikacija_za_izvjestaj_o_uspjehu_i_vladanju_ucenika
{
    public partial class InputGrades : Form
    {
        public InputGrades()
        {
            InitializeComponent();
        }

        private List<Student> students = new List<Student>();
        private List<Subject> subjects = new List<Subject>();

        private void InputGrades_Load(object sender, EventArgs e)
        {
            try
            {
                LoadStudents();
                LoadSubjects();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_addGrade_Click(object sender, EventArgs e)
        {
            try
            {
                if (cb_students.SelectedIndex >= 0 && cb_subjects.SelectedIndex >= 0 && num_grade.Value >= 1 && num_grade.Value <= 5)
                {
                    Student gradedStudent = students[cb_students.SelectedIndex];
                    Subject gradedSubject = subjects[cb_subjects.SelectedIndex];
                    StudentSubjects currentSubject = null;

                    int newGrade = int.Parse(num_grade.Value.ToString());

                    List<StudentSubjects> studentSubjectList = gradedStudent.Subjects;

                    int i;
                    for (i = 0; i < studentSubjectList.Count; i++)
                    {
                        if (studentSubjectList[i].SubjectID == gradedSubject.ID)
                        {
                            currentSubject = studentSubjectList[i];
                            break;
                        }
                    }

                    if (currentSubject == null)
                    {
                        currentSubject = new StudentSubjects(gradedSubject.ID, newGrade.ToString());
                        gradedStudent.Subjects.Add(currentSubject);
                    }
                    else
                    {
                        currentSubject._Grades += ";" + newGrade;
                        gradedStudent.Subjects[i] = currentSubject;
                    }

                    string fileName = Global.CurrentClass.Name + "\\Students\\" + gradedStudent.LastName + " " + gradedStudent.FirstName + ".json";

                    File.Delete(fileName);
                    Global.WriteToJSON(gradedStudent, fileName);

                    MessageBox.Show("Ocjena uspješno unešena!", "Ocjena unešena", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                    MessageBox.Show("Greška pri unošenju!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadStudents()
        {
            try
            {
                cb_students.Items.Clear();
                students = Global.GetStudents();

                foreach (Student s in students)
                    cb_students.Items.Add(s.LastName + " " + s.FirstName);

                if (cb_students.Items.Count > 0)
                    cb_students.SelectedIndex = 0;
            }
            catch
            {
                throw;
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

        private void InputGrades_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!closedByButton)
                Application.Exit();
        }

        private bool closedByButton = false;
        private void btn_return_Click(object sender, EventArgs e)
        {
            try
            {
                ClassMenu._ClassMenu.Show();
                closedByButton = true;

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}