﻿using System;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace Notebook
{
    public partial class LanguageForm : Form
    {
        private ProgVarStorage progVarStorage = new ProgVarStorage();
        private string nextWindow = "";

        public LanguageForm()
        {
            InitializeComponent();
        }

        private void SetWindowLang(Language language)
        {
            switch (language)
            {
                case Language.Ukraіnian:
                    this.Text = "Notebook - Налаштування";
                    languageWindowLabel.Text = "Вибрати мову:";
                    goBackButton.Text = "назад";
                    mainMenuButton.Text = "головне меню";
                    changeLanguageButton.Text = "прийняти зміни";
                    break;

                case Language.Russian:
                    this.Text = "Notebook - Настройки";
                    languageWindowLabel.Text = "Выбрать язык:";
                    goBackButton.Text = "назад";
                    mainMenuButton.Text = "главное меню";
                    changeLanguageButton.Text = "принять измнинения";
                    break;

                case Language.English:
                    this.Text = "Notebook - Settings";
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

            switch (progVarStorage.PrevWindow)
            {
                case "mainForm":
                    {
                        nextWindow = "";
                    }
                    break;
                case "listForm":
                    {
                        nextWindow = "ListForm";
                    }
                    break;
            }
        }

        private void MainMenuButtonClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GoBackButtonClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ChangeLanguageButtonClick(object sender, EventArgs e)
        {
            switch (languageComboBox.SelectedIndex)
            {
                case 0:
                    progVarStorage.AppLanguage = Language.Ukraіnian;
                    break;

                case 1:
                    progVarStorage.AppLanguage = Language.Russian;
                    break;

                case 2:
                    progVarStorage.AppLanguage = Language.English;
                    break;
            }

            nextWindow = "LanguageForm";
            this.Close();
        }

        private void LanguageFormFormClosing(
            object sender, FormClosingEventArgs e)
        {
            File.WriteAllText(
                "ProgVarStorageInfo.json",
                JsonConvert.SerializeObject(this.progVarStorage));

            switch (nextWindow)
            {
                case "LanguageForm":
                    LanguageForm languageForm = new LanguageForm();
                    languageForm.Show();
                    break;

                case "ListForm":
                    ListForm listForm = new ListForm();
                    listForm.Show();
                    break;

                case "":
                    MainForm mainForm = new MainForm();
                    mainForm.Show();
                    break;

                default:
                    MainForm defForm = new MainForm();
                    defForm.Show();
                    MessageBox.Show("ERROR");
                    break;
            }
        }
    }
}
