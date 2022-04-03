using System;
using System.IO;
using System.Windows.Forms;

namespace Aplikacija_za_izvjestaj_o_uspjehu_i_vladanju_ucenika
{
    public partial class InputClass : Form
    {
        public InputClass()
        {
            InitializeComponent();
        }

        private void InputClass_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!closedByButton)
                Application.Exit();
        }

        private void btn_inputClass_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(tb_className.Text) &&
                    !String.IsNullOrEmpty(tb_professor.Text))
                {
                    if (!Directory.Exists(tb_className.Text))
                    {
                        string JSONfile = Global.ClassesJSON;
                        Class newClass = new Class(tb_className.Text, tb_professor.Text);

                        Global.AppendJSON(newClass, JSONfile);

                        Directory.CreateDirectory(newClass.Name);
                        Directory.CreateDirectory(newClass.Name + "\\Students");
                        Directory.CreateDirectory(newClass.Name + "\\Subjects");

                        if (MessageBox.Show("Razred napravljen!\n\nDa li želite otvoriti napravljeni razred?", "Uspjeh",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            Global.CurrentClass = newClass;
                            Global.StudentsPath = newClass.Name + "\\Students\\";
                            Global.SubjectsPath = newClass.Name + "\\Subjects\\";

                            ClassMenu classMenu = new ClassMenu();
                            classMenu.Show();

                            closedByButton = true;
                            this.Close();
                        }
                    }
                    else
                        MessageBox.Show("Razred već postoji!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                    MessageBox.Show("Molimo ispunite sva polja!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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