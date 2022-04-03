using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Aplikacija_za_izvjestaj_o_uspjehu_i_vladanju_ucenika
{
    public partial class DeleteSubject : Form
    {
        public DeleteSubject()
        {
            InitializeComponent();
        }

        private List<Subject> subjects = new List<Subject>();

        private void DeleteSubject_Load(object sender, EventArgs e)
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

        private void btn_deleteSubject_Click(object sender, EventArgs e)
        {
            try
            {
                if (cb_subjects.SelectedIndex >= 0)
                {
                    Subject subject = subjects[cb_subjects.SelectedIndex];
                    string fileName = Global.CurrentClass.Name + "\\Subjects\\" + subject.Name + ".json";

                    if (File.Exists(fileName))
                    {
                        cb_subjects.Text = String.Empty;

                        File.Delete(fileName);
                        LoadCbItems();
                    }

                    MessageBox.Show("Predmet uspješno izbrisan!", "Predmet izbrisan", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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

        private void DeleteSubject_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!closedByButton)
                Application.Exit();
        }
    }
}