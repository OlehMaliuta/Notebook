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
    public partial class LanguageForm : Form
    {
        private ProgVarStorage progVarStorage = new ProgVarStorage();

        public LanguageForm()
        {
            InitializeComponent();
        }

        private void SetWindowLang(Language language)
        {
            switch (language)
            {
                case Language.Ukranian:
                    this.Text = "Налаштування";
                    languageWindow_label.Text = "Вибрати мову:";
                    goBack_button.Text = "назад";
                    mainMenu_button.Text = "головне меню";
                    changeLanguage_button.Text = "прийняти зміни";
                    break;

                case Language.Russian:
                    this.Text = "Настройки";
                    languageWindow_label.Text = "Выбрать язык:";
                    goBack_button.Text = "назад";
                    mainMenu_button.Text = "главное меню";
                    changeLanguage_button.Text = "принять измнинения";
                    break;

                case Language.English:
                    this.Text = "Settings";
                    languageWindow_label.Text = "Choose language:";
                    goBack_button.Text = "back";
                    mainMenu_button.Text = "main menu";
                    changeLanguage_button.Text = "apply";
                    break;
            }
        }

        private void LanguageForm_Load(object sender, EventArgs e)
        {
            this.progVarStorage =
                JsonConvert.DeserializeObject<ProgVarStorage>(File.ReadAllText("ProgVarStorageInfo.json"));

            SetWindowLang(progVarStorage.language);

            language_comboBox.SelectedIndex = (int)progVarStorage.language;
        }

        private void mainMenu_button_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }

        private void goBack_button_Click(object sender, EventArgs e)
        {
            string backoToWindow = progVarStorage.prevWindow;

            switch (backoToWindow)
            {
                case "mainForm":
                    {
                        this.Close();
                        MainForm mainForm = new MainForm();
                        mainForm.Show();
                    }
                    break;
                case "listForm":
                    {
                        this.Close();
                        ListForm listForm = new ListForm();
                        listForm.Show();
                    }
                    break;
            }
        }

        private void changeLanguage_button_Click(object sender, EventArgs e)
        {
            switch (language_comboBox.SelectedIndex)
            {
                case 0:
                    progVarStorage.language = Language.Ukranian;
                    break;

                case 1:
                    progVarStorage.language = Language.Russian;
                    break;

                case 2:
                    progVarStorage.language = Language.English;
                    break;
            }

            this.Close();
            LanguageForm languageForm = new LanguageForm();
            languageForm.Show();
        }

        private void LanguageForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            File.WriteAllText("ProgVarStorageInfo.json", JsonConvert.SerializeObject(this.progVarStorage));
        }
    }
}
