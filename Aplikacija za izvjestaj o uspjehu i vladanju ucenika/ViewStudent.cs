using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Aplikacija_za_izvjestaj_o_uspjehu_i_vladanju_ucenika
{
    public partial class ViewStudent : Form
    {
        public ViewStudent()
        {
            InitializeComponent();
        }

        public static ViewStudent _ViewStudent;
        public static Student _Student;
        private List<Student> students;

        private void ViewStudent_Load(object sender, EventArgs e)
        {
            try
            {
                _ViewStudent = this;

                LoadCbItems();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadCbItems()
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

        private void cb_students_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cb_students.SelectedIndex >= 0)
                {
                    Student student = students[cb_students.SelectedIndex];

                    lb_firstName.Text = student.FirstName;
                    lb_lastName.Text = student.LastName;
                    lb_JMBG.Text = student.JMBG;
                    lb_address.Text = student.Address;
                    lb_behavior.Text = student.Behavior.ToString();
                }
                else
                    MessageBox.Show("Greška pri odabiru učenika!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_grades_Click(object sender, EventArgs e)
        {
            try
            {
                if (cb_students.SelectedIndex >= 0)
                {
                    Student student = students[cb_students.SelectedIndex];

                    if (student.Subjects.Count > 0)
                    {
                        _Student = student;

                        ViewGrades viewGrades = new ViewGrades();
                        viewGrades.Show();
                    }
                    else
                        MessageBox.Show("Učenik nema unešenih ocijena", "Nema ocijena", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Greška pri odabiru učenika!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void ViewStudent_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!closedByButton)
                btn_return.PerformClick();
        }

        private void Btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}