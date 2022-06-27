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
                    languageWindowLabel.Text = "Вибрати мову:";
                    goBackButton.Text = "назад";
                    mainMenuButton.Text = "головне меню";
                    changeLanguageButton.Text = "прийняти зміни";
                    break;

                case Language.Russian:
                    this.Text = "Настройки";
                    languageWindowLabel.Text = "Выбрать язык:";
                    goBackButton.Text = "назад";
                    mainMenuButton.Text = "главное меню";
                    changeLanguageButton.Text = "принять измнинения";
                    break;

                case Language.English:
                    this.Text = "Settings";
                    languageWindowLabel.Text = "Choose language:";
                    goBackButton.Text = "back";
                    mainMenuButton.Text = "main menu";
                    changeLanguageButton.Text = "apply";
                    break;
            }
        }

        private void LanguageFormLoad(object sender, EventArgs e)
        {
            this.progVarStorage =
                JsonConvert.DeserializeObject<ProgVarStorage>(
                    File.ReadAllText("ProgVarStorageInfo.json"));

            SetWindowLang(progVarStorage.AppLanguage);

            languageComboBox.SelectedIndex = (int)progVarStorage.AppLanguage;
        }

        private void MainMenuButtonClick(object sender, EventArgs e)
        {
            this.Close();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }

        private void GoBackButtonClick(object sender, EventArgs e)
        {
            string backoToWindow = progVarStorage.PrevWindow;

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

        private void ChangeLanguageButtonClick(object sender, EventArgs e)
        {
            switch (languageComboBox.SelectedIndex)
            {
                case 0:
                    progVarStorage.AppLanguage = Language.Ukranian;
                    break;

                case 1:
                    progVarStorage.AppLanguage = Language.Russian;
                    break;

                case 2:
                    progVarStorage.AppLanguage = Language.English;
                    break;
            }

            this.Close();
            LanguageForm languageForm = new LanguageForm();
            languageForm.Show();
        }

        private void LanguageFormFormClosing(
            object sender, FormClosingEventArgs e)
        {
            File.WriteAllText(
                "ProgVarStorageInfo.json",
                JsonConvert.SerializeObject(this.progVarStorage));
        }
    }
}
