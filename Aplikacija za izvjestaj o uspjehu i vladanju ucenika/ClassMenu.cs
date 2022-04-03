using System;
using System.Windows.Forms;

namespace Aplikacija_za_izvjestaj_o_uspjehu_i_vladanju_ucenika
{
    public partial class ClassMenu : Form
    {
        public ClassMenu()
        {
            InitializeComponent();
        }

        public static ClassMenu _ClassMenu;

        private void ClassMenu_Load(object sender, EventArgs e)
        {
            try
            {
                _ClassMenu = this;

                lb_className.Text = Global.CurrentClass.Name;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region Button Events

        #region Student
        private void btn_inputStudent_Click(object sender, EventArgs e)
        {
            try
            {
                InputStudent inputStudent = new InputStudent();
                inputStudent.Show();

                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_viewStudent_Click(object sender, EventArgs e)
        {
            try
            {
                if (Global.GetStudentCount() > 0)
                {
                    ViewStudent viewStudent = new ViewStudent();
                    viewStudent.Show();

                    this.Hide();
                }
                else if (MessageBox.Show("Nema unešenih učenika, želite li unijeti novog učenika?", "Nema učenika",
                         MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    InputStudent inputStudent = new InputStudent();
                    inputStudent.Show();

                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_editStudent_Click(object sender, EventArgs e)
        {
            try
            {
                if (Global.GetStudentCount() > 0)
                {
                    EditStudent editStudent = new EditStudent();
                    editStudent.Show();

                    this.Hide();
                }
                else if (MessageBox.Show("Nema unešenih učenika, želite li unijeti novog učenika?", "Nema učenika",
                         MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    InputStudent inputStudent = new InputStudent();
                    inputStudent.Show();

                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_deleteStudent_Click(object sender, EventArgs e)
        {
            try
            {
                if (Global.GetStudentCount() > 0)
                {
                    DeleteStudent deleteStudent = new DeleteStudent();
                    deleteStudent.Show();

                    this.Hide();
                }
                else if (MessageBox.Show("Nema unešenih učenika, želite li unijeti novog učenika?", "Nema učenika",
                         MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    InputStudent inputStudent = new InputStudent();
                    inputStudent.Show();

                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Subject
        private void btn_inputSubject_Click(object sender, EventArgs e)
        {
            try
            {
                InputSubject inputSubject = new InputSubject();
                inputSubject.Show();

                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_viewSubject_Click(object sender, EventArgs e)
        {
            try
            {
                if (Global.GetSubjectCount() > 0)
                {
                    ViewSubject viewSubject = new ViewSubject();
                    viewSubject.Show();

                    this.Hide();
                }
                else if (MessageBox.Show("Nema unešenih predmeta, želite li unijeti novi predmet?", "Nema predmeta",
                         MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    InputSubject inputSubject = new InputSubject();
                    inputSubject.Show();

                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_editSubject_Click(object sender, EventArgs e)
        {
            try
            {
                if (Global.GetSubjectCount() > 0)
                {
                    EditSubject editSubject = new EditSubject();
                    editSubject.Show();

                    this.Hide();
                }
                else if (MessageBox.Show("Nema unešenih predmeta, želite li unijeti novi predmet?", "Nema predmeta",
                         MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    InputSubject inputSubject = new InputSubject();
                    inputSubject.Show();

                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_deleteSubject_Click(object sender, EventArgs e)
        {
            try
            {
                if (Global.GetSubjectCount() > 0)
                {
                    DeleteSubject deleteSubject = new DeleteSubject();
                    deleteSubject.Show();

                    this.Hide();
                }
                else if (MessageBox.Show("Nema unešenih predmeta, želite li unijeti novi predmet?", "Nema predmeta",
                         MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    InputSubject inputSubject = new InputSubject();
                    inputSubject.Show();

                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Other

        private void btn_inputGrades_Click(object sender, EventArgs e)
        {
            try
            {
                InputGrades inputGrades = new InputGrades();
                inputGrades.Show();

                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_viewClass_Click(object sender, EventArgs e)
        {
            try
            {
                ViewClass viewClass = new ViewClass();
                viewClass.Show();

                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool closedByButton = false;
        private void Btn_return_Click(object sender, EventArgs e)
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

        private void Btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #endregion

        private void ClassMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                if (!closedByButton)
                    btn_return.PerformClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}