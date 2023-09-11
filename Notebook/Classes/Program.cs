using Notebook.Classes.DB;
using System;
using System.Windows.Forms;

namespace Notebook
{
    internal static class Program
    {
        public static int MeasureTimeStr(string time)
        {
            string[] dt = time.Split('\n');
            string[] d = dt[0].Split('.');
            string[] t = dt[1].Split(':');

            return int.Parse(d[0]) + int.Parse(d[1]) + int.Parse(d[2])
                + int.Parse(t[0]) + int.Parse(t[1]) + int.Parse(t[2]);
        }

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
