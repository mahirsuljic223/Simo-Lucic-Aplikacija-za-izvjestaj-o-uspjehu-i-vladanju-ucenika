using System;
using System.Windows.Forms;

namespace Aplikacija_za_izvjestaj_o_uspjehu_i_vladanju_ucenika
{
    public partial class StartMenu : Form
    {
        public StartMenu()
        {
            InitializeComponent();
        }

        public static StartMenu _StartMenu;

        private void StartMenu_Load(object sender, EventArgs e)
        {
            _StartMenu = this;
        }

        #region Button Events
        private void Btn_newClass_Click(object sender, EventArgs e)
        {
            try
            {
                InputClass inputClass = new InputClass();
                inputClass.Show();

                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_openClass_Click(object sender, EventArgs e)
        {
            try
            {
                if (Global.GetClasses() != null && Global.GetClasses().Count > 0)
                {
                    OpenClass openClass = new OpenClass();
                    openClass.Show();

                    this.Hide();
                }
                else if (MessageBox.Show("Nema unešenih razreda, želite li napraviti novi razred?", "Nema razreda",
                         MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    InputClass inputClass = new InputClass();
                    inputClass.Show();

                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_editClass_Click(object sender, EventArgs e)
        {
            try
            {
                if (Global.GetClasses() != null && Global.GetClasses().Count > 0)
                {
                    EditClass editClass = new EditClass();
                    editClass.Show();

                    this.Hide();
                }
                else if (MessageBox.Show("Nema unešenih razreda, želite li napraviti novi razred?", "Nema razreda",
                         MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    InputClass inputClass = new InputClass();
                    inputClass.Show();

                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_deleteClass_Click(object sender, EventArgs e)
        {
            try
            {
                if (Global.GetClasses() != null && Global.GetClasses().Count > 0)
                {
                    DeleteClass deleteClass = new DeleteClass();
                    deleteClass.Show();

                    this.Hide();
                }
                else if (MessageBox.Show("Nema unešenih razreda, želite li napraviti novi razred?", "Nema razreda",
                         MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    InputClass inputClass = new InputClass();
                    inputClass.Show();

                    this.Hide();
                }
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
    }
}