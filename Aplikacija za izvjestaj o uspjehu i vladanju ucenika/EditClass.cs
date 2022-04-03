using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Aplikacija_za_izvjestaj_o_uspjehu_i_vladanju_ucenika
{
    public partial class EditClass : Form
    {
        public EditClass()
        {
            InitializeComponent();
        }

        public static EditClass _EditClass;
        private List<Class> classes = new List<Class>();

        private void EditClass_Load(object sender, EventArgs e)
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
                classes = Global.GetClasses();

                foreach (Class s in classes)
                    cb_classes.Items.Add(s.Name);

                if (cb_classes.Items.Count > 0)
                    cb_classes.SelectedIndex = index;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EditClass_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!closedByButton)
                Application.Exit();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrWhiteSpace(tb_className.Text) &&
                    !String.IsNullOrWhiteSpace(tb_professor.Text))
                {
                    if (classes[cb_classes.SelectedIndex].Name != tb_className.Text)
                        Directory.Move(classes[cb_classes.SelectedIndex].Name, tb_className.Text);

                    classes[cb_classes.SelectedIndex].Name = tb_className.Text;
                    classes[cb_classes.SelectedIndex].Professor = tb_professor.Text;

                    Global.WriteToJSON(classes, Global.ClassesJSON);
                    LoadCbItems(cb_classes.SelectedIndex);

                    MessageBox.Show("Promjene sačuvane", "Uspjeh", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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
                tb_className.Text = classes[cb_classes.SelectedIndex].Name;
                tb_professor.Text = classes[cb_classes.SelectedIndex].Professor;
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

        private void cb_classes_SelectedIndexChanged(object sender, EventArgs e)
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
    }
}