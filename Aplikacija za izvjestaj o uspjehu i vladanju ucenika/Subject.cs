using System;

namespace Aplikacija_za_izvjestaj_o_uspjehu_i_vladanju_ucenika
{
    internal class Subject
    {
        public int ID = 0;
        public string Name = String.Empty;
        public string Professor = String.Empty;

        public Subject(int ID, string name, string professor)
        {
            this.ID = ID;
            this.Name = name;
            this.Professor = professor;
        }
    }
}