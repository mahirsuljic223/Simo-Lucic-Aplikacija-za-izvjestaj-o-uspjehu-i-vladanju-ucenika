using System;
using System.IO;
using System.Windows.Forms;

namespace Aplikacija_za_izvjestaj_o_uspjehu_i_vladanju_ucenika
{
    public partial class InputStudent : Form
    {
        public InputStudent()
        {
            InitializeComponent();
        }

        private void InputStudent_Load(object sender, EventArgs e)
        {
            try
            {
                btn_clear.PerformClick();
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

                    string fileName = Global.CurrentClass.Name + "\\Students\\" + student.LastName + " " + student.FirstName + ".json";

                    if (!File.Exists(fileName))
                        Global.WriteToJSON(student, fileName);
                    else
                        MessageBox.Show("Učenik je već unešen!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    btn_clear.PerformClick();

                    MessageBox.Show("Učenik uspješno unešen!", "Učenik unešen", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                    MessageBox.Show("Molimo ispunite sva polja!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_clear_Click(object sender, EventArgs e)
        {
            try
            {
                tb_firstName.Text = String.Empty;
                tb_lastName.Text = String.Empty;
                tb_address.Text = String.Empty;
                tb_JMBG.Text = String.Empty;
                num_behavior.Value = 5;
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
            Application.Exit();
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

        private void InputStudent_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!closedByButton)
                btn_return.PerformClick();
        }
    }
}