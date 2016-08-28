using System;
using System.Windows.Forms;

namespace Kalkulator
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.Run(new StandardView());
        }
    }
}