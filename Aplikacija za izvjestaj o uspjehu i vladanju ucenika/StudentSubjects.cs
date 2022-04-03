using System;

namespace Aplikacija_za_izvjestaj_o_uspjehu_i_vladanju_ucenika
{
    public class StudentSubjects
    {
        public int SubjectID = 0;
        public string _Grades = String.Empty;

        public StudentSubjects(int subjectID, string grades = "")
        {
            this.SubjectID = subjectID;
            this._Grades = grades;
        }
    }
}