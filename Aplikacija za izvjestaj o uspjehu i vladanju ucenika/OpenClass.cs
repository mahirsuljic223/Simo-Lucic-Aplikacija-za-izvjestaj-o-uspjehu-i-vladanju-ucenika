using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Aplikacija_za_izvjestaj_o_uspjehu_i_vladanju_ucenika
{
    public partial class OpenClass : Form
    {
        public OpenClass()
        {
            InitializeComponent();
        }

        private List<Class> classes = new List<Class>();

        private void OpenClass_Load(object sender, EventArgs e)
        {
            try
            {
                classes = Global.GetClasses();

                foreach (Class s in classes)
                    cb_classes.Items.Add(s.Name);

                if (cb_classes.Items.Count > 0)
                    cb_classes.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OpenClass_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!closedByButton)
                btn_return.PerformClick();
        }

        private void btn_openClass_Click(object sender, EventArgs e)
        {
            try
            {
                Global.CurrentClass = classes[cb_classes.SelectedIndex];
                Global.StudentsPath = Global.CurrentClass.Name + "\\Students\\";
                Global.SubjectsPath = Global.CurrentClass.Name + "\\Subjects\\";

                ClassMenu classMenu = new ClassMenu();
                classMenu.Show();

                closedByButton = true;
                this.Close();
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