using System;
using System.Collections.Generic;

namespace Aplikacija_za_izvjestaj_o_uspjehu_i_vladanju_ucenika
{
    public class Student
    { 
        public string FirstName = String.Empty;
        public string LastName = String.Empty;
        public string JMBG = String.Empty;
        public string Address = String.Empty;
        public int Behavior = 0;
        public List<StudentSubjects> Subjects = new List<StudentSubjects>();

        public Student( string firstName, string lastName, string JMBG, string address, int behavior)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.JMBG = JMBG;
            this.Address = address;
            this.Behavior = behavior;
        }
    }
}