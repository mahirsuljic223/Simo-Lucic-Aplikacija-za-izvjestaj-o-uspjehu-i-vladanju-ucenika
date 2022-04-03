using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Aplikacija_za_izvjestaj_o_uspjehu_i_vladanju_ucenika
{
    public partial class DeleteStudent : Form
    {
        public DeleteStudent()
        {
            InitializeComponent();
        }

        private List<Student> students;

        private void DeleteStudent_Load(object sender, EventArgs e)
        {
            try
            {
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

        private void btn_deleteStudent_Click(object sender, EventArgs e)
        {
            try
            {
                if (cb_students.SelectedIndex >= 0)
                {
                    Student student = students[cb_students.SelectedIndex];
                    string fileName = Global.CurrentClass.Name + "\\Students\\" + student.LastName + " " + student.FirstName + ".json";

                    if (File.Exists(fileName))
                    {
                        cb_students.Text = String.Empty;

                        File.Delete(fileName);
                        LoadCbItems();
                    }

                    MessageBox.Show("Učenik uspješno izbrisan!", "Učenik izbrisan", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
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

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DeleteStudent_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!closedByButton)
                Application.Exit();
        }
    }
}