using System;
using System.Windows.Forms;

namespace Aplikacija_za_izvjestaj_o_uspjehu_i_vladanju_ucenika
{
    public partial class ViewClass : Form
    {
        public ViewClass()
        {
            InitializeComponent();
        }

        private void ViewClass_Load(object sender, EventArgs e)
        {
            try
            {
                lb_className.Text = Global.CurrentClass.Name;
                lb_profName.Text = Global.CurrentClass.Professor;
                lb_numStudents.Text = Global.GetStudentCount().ToString();
                lb_numSubjects.Text = Global.GetSubjectCount().ToString();
                lb_avgGrade.Text = GetAvgGrade() != 0 ? GetAvgGrade().ToString() : "Učenici nemaju ocijena";
                lb_avgBehavior.Text = Global.GetStudentCount() > 0 ? GetAvgBehavior().ToString() : "Nema unesenih učenika";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private float GetAvgGrade()
        {
            try
            {
                float avgGrade = 0;
                float i = 0;

                foreach (Student student in Global.GetStudents())
                {
                    if (student.Subjects.Count > 0)
                    {
                        avgGrade += Global.GetStudentAvgGrade(student.Subjects);
                        i++;
                    }
                }

                if (i > 0)
                    return avgGrade / i;
                else
                    return 0;
            }
            catch
            {
                throw;
            }
        }

        private float GetAvgBehavior()
        {
            try
            {
                float averageBehavior = 0;

                foreach (Student student in Global.GetStudents())
                    averageBehavior += student.Behavior;

                return averageBehavior / Global.GetStudentCount();
            }
            catch
            {
                throw;
            }
        }

        private bool closedByButton = false;
        private void Btn_return_Click(object sender, EventArgs e)
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

        private void ViewClass_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!closedByButton)
                btn_return.PerformClick();
        }
    }
}