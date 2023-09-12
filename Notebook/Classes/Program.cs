using MemoMates.Classes.DB;
using System;
using System.Threading;
using System.Windows.Forms;

namespace MemoMates
{
    internal static class Program
    {
        private static Mutex mutex = null;

        [STAThread]
        static void Main()
        {
            const string appName = "MemoMates";
            bool createdNew;

            mutex = new Mutex(true, appName, out createdNew);

            if (!createdNew)
            {
                return;
            }

            using (DbApp DB = new DbApp())
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MainForm(DB));
            }
        }
    }
}
