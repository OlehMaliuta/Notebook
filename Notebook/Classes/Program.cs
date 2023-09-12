using MemoMates.Classes.DB;
using System;
using System.Windows.Forms;

namespace MemoMates
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            using (DbApp DB = new DbApp())
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MainForm(DB));
            }
        }
    }
}
