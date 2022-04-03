using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Aplikacija_za_izvjestaj_o_uspjehu_i_vladanju_ucenika
{
    public partial class DeleteClass : Form
    {
        public DeleteClass()
        {
            InitializeComponent();
        }

        private List<Class> classes = new List<Class>();

        private void LoadClassNamesToComboBox()
        {
            try
            {
                cb_classes.Items.Clear();
                classes = Global.GetClasses();

                foreach (Class s in classes)
                    cb_classes.Items.Add(s.Name);

                if (cb_classes.Items.Count > 0)
                    cb_classes.SelectedIndex = 0;
                else
                    cb_classes.Text = String.Empty;
            }
            catch
            {
                throw;
            }
        }

        private void DeleteClass_Load(object sender, EventArgs e)
        {
            try
            {
                LoadClassNamesToComboBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteClass_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!closedByButton)
                Application.Exit();
        }

        private void btn_deleteClass_Click(object sender, EventArgs e)
        {
            try
            {
                if (cb_classes.SelectedIndex >= 0)
                {
                    Class deletingClass = classes[cb_classes.SelectedIndex];

                    if (MessageBox.Show("Jeste li sigurni da želite izbrisati razred \"" + deletingClass.Name + "\"", "Upozorenje",
                        MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes &&
                        Directory.Exists(deletingClass.Name))
                    {
                        Directory.Delete(deletingClass.Name, true);

                        classes.RemoveAt(cb_classes.SelectedIndex);

                        Global.WriteToJSON(classes, Global.ClassesJSON);
                        LoadClassNamesToComboBox();

                        MessageBox.Show("Razred izbrisan", "Uspjeh", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
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
                StartMenu._StartMenu.Show();
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