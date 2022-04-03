using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Aplikacija_za_izvjestaj_o_uspjehu_i_vladanju_ucenika
{
    public partial class ViewSubject : Form
    {
        public ViewSubject()
        {
            InitializeComponent();
        }

        private List<Subject> subjects = new List<Subject>();

        private void ViewSubject_Load(object sender, EventArgs e)
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

        private void cb_subjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cb_subjects.SelectedIndex >= 0)
                {
                    Subject subject = subjects[cb_subjects.SelectedIndex];

                    lb_professor.Text = subject.Professor;
                }
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ViewSubject_FormClosed(object sender, FormClosedEventArgs e)
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
    }
}