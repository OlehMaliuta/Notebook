using System;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using Notebook.Classes;
using Notebook.Classes.DB;
using Notebook.Classes.DB.Models;

namespace Notebook
{
    public partial class SettingsForm : Form
    {
        public enum PrevForm
        {
            MainForm,
            ListForm
        }

        private readonly DbApp DB;
        private readonly PersonList reviewingList;
        private readonly PrevForm prevForm;
        private bool xIsPressed;

        public SettingsForm(DbApp db, PersonList pl, PrevForm prevForm)
        {
            InitializeComponent();

            this.DB = db;
            this.reviewingList = pl;
            this.prevForm = prevForm;
            this.xIsPressed = true;
        }

        private void LanguageFormLoad(object sender, EventArgs e)
        {
            // localization

            this.Text = $"{LanguageManager.Get("general.app-name")} - {LanguageManager.Get("language-form.form-name")}";
            languageWindowLabel.Text = LanguageManager.Get("language-form.app-language-setting-title");
            changeLanguageButton.Text = LanguageManager.Get("language-form.apply-button");
            mainMenuButton.Text = LanguageManager.Get("language-form.main-menu-button");
            goBackButton.Text = LanguageManager.Get("language-form.go-back-button");

            languageComboBox.Items.Add(LanguageManager.Get("language-form.language-option-en"));
            languageComboBox.Items.Add(LanguageManager.Get("language-form.language-option-ua"));
            languageComboBox.Items.Add(LanguageManager.Get("language-form.language-option-ru"));

            // form settings

            switch (LanguageManager.CurrentLang)
            {
                case "en":
                    languageComboBox.SelectedIndex = 0; 
                    break;
                case "ua":
                    languageComboBox.SelectedIndex = 1;
                    break;
                case "ru":
                    languageComboBox.SelectedIndex = 2;
                    break;
            }
        }

        private void MainMenuButtonClick(object sender, EventArgs e)
        {
            this.xIsPressed = false;

            this.Close();
            MainForm mainForm = new MainForm(this.DB);
            mainForm.Show();

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
                    LanguageManager.CurrentLang = "en";
                    break;

                case 1:
                    LanguageManager.CurrentLang = "ua";
                    break;

                case 2:
                    LanguageManager.CurrentLang = "ru";
                    break;
            }

            this.xIsPressed = false;

            this.Close();
            SettingsForm settingsForm = new SettingsForm(this.DB, this.reviewingList, this.prevForm);
            settingsForm.Show();
        }

        private void LanguageFormFormClosing(object sender, FormClosingEventArgs e)
        {
            if (xIsPressed)
            {
                switch (this.prevForm)
                {
                    case PrevForm.MainForm:
                        MainForm mainForm = new MainForm(this.DB);
                        mainForm.Show();
                        break;
                    case PrevForm.ListForm:
                        ListForm listForm = new ListForm(this.DB, this.reviewingList);
                        listForm.Show();
                        break;
                }
            }
        }
    }
}
