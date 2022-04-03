using System;
using System.Windows.Forms;

namespace Aplikacija_za_izvjestaj_o_uspjehu_i_vladanju_ucenika
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new StartMenu());
        }
    }
}