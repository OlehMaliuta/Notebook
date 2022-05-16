using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notebook
{
    public partial class MainForm : System.Windows.Forms.Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void settings_button_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm();
            settingsForm.Show();
        }

        private void addList_button_Click(object sender, EventArgs e)
        {
            ListNameForm listNameForm = new ListNameForm();
            listNameForm.Show();
        }

        private void deleteList_button_Click(object sender, EventArgs e)
        {
            ConfirmationForm confirmationForm = new ConfirmationForm();
            confirmationForm.Show();
        }
    }
}
