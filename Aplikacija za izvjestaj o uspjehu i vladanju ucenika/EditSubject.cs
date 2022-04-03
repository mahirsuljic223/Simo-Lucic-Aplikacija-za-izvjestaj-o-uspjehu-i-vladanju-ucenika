using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Aplikacija_za_izvjestaj_o_uspjehu_i_vladanju_ucenika
{
    public partial class EditSubject : Form
    {
        public EditSubject()
        {
            InitializeComponent();
        }

        private List<Subject> subjects = new List<Subject>();

        private void EditSubject_Load(object sender, EventArgs e)
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
                cb_subjects.Items.Clear();
                subjects = Global.GetSubjects();

                foreach (Subject s in subjects)
                    cb_subjects.Items.Add(s.Name);

                if (cb_subjects.Items.Count > 0)
                    cb_subjects.SelectedIndex = index;
            }
            catch
            {
                throw;
            }
        }

        private void EditSubject_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!closedByButton)
                Application.Exit();
        }

        private void cb_subjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cb_subjects.SelectedIndex >= 0)
                {
                    Subject subject = subjects[cb_subjects.SelectedIndex];

                    tb_subjectName.Text = subject.Name;
                    tb_professor.Text = subject.Professor;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrWhiteSpace(tb_subjectName.Text) &&
                    !String.IsNullOrWhiteSpace(tb_professor.Text))
                {
                    Subject subject = new Subject(subjects[cb_subjects.SelectedIndex].ID, tb_subjectName.Text, tb_professor.Text);

                    string oldFileName = Global.CurrentClass.Name + "\\Subjects\\" + subjects[cb_subjects.SelectedIndex].Name + ".json";
                    string newFileName = Global.CurrentClass.Name + "\\Subjects\\" + subject.Name + ".json";

                    File.Delete(oldFileName);
                    Global.WriteToJSON(subject, newFileName);

                    subjects = Global.GetSubjects();
                    LoadCbItems(cb_subjects.SelectedIndex);

                    MessageBox.Show("Predmet uspješno izmijenjen!", "Predmet izmijenjen", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                    MessageBox.Show("Molimo ispunite sva polja!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            try
            {
                tb_subjectName.Text = subjects[cb_subjects.SelectedIndex].Name;
                tb_professor.Text = subjects[cb_subjects.SelectedIndex].Professor;
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
    }
}