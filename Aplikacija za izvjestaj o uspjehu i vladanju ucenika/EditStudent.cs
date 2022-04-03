using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Aplikacija_za_izvjestaj_o_uspjehu_i_vladanju_ucenika
{
    public partial class EditStudent : Form
    {
        public EditStudent()
        {
            InitializeComponent();
        }

        private List<Student> students = new List<Student>();

        private void EditStudent_Load(object sender, EventArgs e)
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

        private void LoadCbItems(int index = 0)
        {
            try
            {
                cb_students.Items.Clear();
                students = Global.GetStudents();

                foreach (Student s in students)
                    cb_students.Items.Add(s.LastName + " " + s.FirstName);

                if (cb_students.Items.Count > 0)
                    cb_students.SelectedIndex = index;
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
                btn_reset.PerformClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region Button Events
        private void Btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrWhiteSpace(tb_firstName.Text) &&
                    !String.IsNullOrWhiteSpace(tb_lastName.Text) &&
                    !String.IsNullOrWhiteSpace(tb_address.Text) &&
                    !String.IsNullOrWhiteSpace(tb_JMBG.Text))
                {
                    if (tb_JMBG.Text.Length < 13)
                    {
                        MessageBox.Show("Matični broj nije validan!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    Student student = new Student(
                        tb_firstName.Text,
                        tb_lastName.Text,
                        tb_JMBG.Text,
                        tb_address.Text,
                        int.Parse(num_behavior.Value.ToString())
                    );

                    string oldFileName = Global.CurrentClass.Name + "\\Students\\" + students[cb_students.SelectedIndex].LastName + " " + students[cb_students.SelectedIndex].FirstName + ".json";
                    string newFileName = Global.CurrentClass.Name + "\\Students\\" + student.LastName + " " + student.FirstName + ".json";

                    File.Delete(oldFileName);
                    Global.WriteToJSON(student, newFileName);

                    students = Global.GetStudents();
                    LoadCbItems(cb_students.SelectedIndex);

                    MessageBox.Show("Učenik uspješno izmijenjen!", "Učenik izmijenjen", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                    MessageBox.Show("Molimo ispunite sva polja!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_reset_Click(object sender, EventArgs e)
        {
            try
            {
                tb_firstName.Text = students[cb_students.SelectedIndex].FirstName;
                tb_lastName.Text = students[cb_students.SelectedIndex].LastName;
                tb_JMBG.Text = students[cb_students.SelectedIndex].JMBG;
                tb_address.Text = students[cb_students.SelectedIndex].Address;
                num_behavior.Value = students[cb_students.SelectedIndex].Behavior;
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

        private void Btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        private void Tb_JMBG_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != 8)
                    e.Handled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EditStudent_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!closedByButton)
                btn_return.PerformClick();
        }
    }
}