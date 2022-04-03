using System;
using System.IO;
using System.Windows.Forms;

namespace Aplikacija_za_izvjestaj_o_uspjehu_i_vladanju_ucenika
{
    public partial class InputSubject : Form
    {
        public InputSubject()
        {
            InitializeComponent();
        }

        private void btn_inputSubject_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrWhiteSpace(tb_subjectName.Text) &&
                    !String.IsNullOrWhiteSpace(tb_professor.Text))
                {
                    Subject subject = new Subject(Global.GetSubjectCount() + 1, tb_subjectName.Text, tb_professor.Text);

                    string fileName = Global.CurrentClass.Name + "\\Subjects\\" + subject.Name + ".json";

                    if (!File.Exists(fileName))
                        Global.WriteToJSON(subject, fileName);
                    else
                        MessageBox.Show("Predmet je već unešen!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    MessageBox.Show("Predmet uspješno unešen!", "Predmet unešen", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                    MessageBox.Show("Molimo ispunite sva polja!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InputSubject_FormClosed(object sender, FormClosedEventArgs e)
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

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}