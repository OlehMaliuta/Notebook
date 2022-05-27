using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace Notebook
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void birthdaySettings_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            BirthdayForm birthdayForm = new BirthdayForm();
            birthdayForm.Show();
        }

        private void languageSettings_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            LanguageForm languageForm = new LanguageForm();
            languageForm.Show();
        }

        private void goBack_button_Click(object sender, EventArgs e)
        {
            ProgVarStorage progVarStorage = 
                JsonConvert.DeserializeObject<ProgVarStorage>
                    (File.ReadAllText("ProgVarStorageInfo.json"));

            string back_to_window = progVarStorage.prevWindow;

            switch (back_to_window)
            {
                case "mainForm":
                    {
                        this.Hide();
                        MainForm mainForm = new MainForm();
                        mainForm.Show();
                    }
                    break;
                case "listForm":
                    {
                        this.Hide();
                        ListForm listForm = new ListForm();
                        listForm.Show();
                    }
                    break;
            }
        }
    }
}
