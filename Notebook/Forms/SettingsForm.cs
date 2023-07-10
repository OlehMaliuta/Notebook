using System;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using Notebook.Classes;

namespace Notebook
{
    public partial class SettingsForm : Form
    {
        public enum PrevForm
        {
            MainForm,
            ListForm
        }

        private readonly PrevForm prevForm;
        private readonly string reviewListName;
        private bool xIsPressed;

        public SettingsForm(string reviewListName, PrevForm prevForm)
        {
            InitializeComponent();

            this.prevForm = prevForm;

            this.reviewListName = reviewListName;

            this.xIsPressed = true;
        }

        private void LanguageFormLoad(object sender, EventArgs e)
        {
            // localization

            this.Text = $"{Locale.Get("general.app-name")} - {Locale.Get("language-form.form-name")}";
            languageWindowLabel.Text = Locale.Get("language-form.app-language-setting-title");
            changeLanguageButton.Text = Locale.Get("language-form.apply-button");
            mainMenuButton.Text = Locale.Get("language-form.main-menu-button");
            goBackButton.Text = Locale.Get("language-form.go-back-button");

            languageComboBox.Items.Add(Locale.Get("language-form.language-option-en"));
            languageComboBox.Items.Add(Locale.Get("language-form.language-option-ua"));
            languageComboBox.Items.Add(Locale.Get("language-form.language-option-ru"));

            // form settings

            switch (Locale.CurrentLang)
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
            MainForm mainForm = new MainForm();
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
                    Locale.CurrentLang = "en";
                    break;

                case 1:
                    Locale.CurrentLang = "ua";
                    break;

                case 2:
                    Locale.CurrentLang = "ru";
                    break;
            }

            this.xIsPressed = false;

            this.Close();
            SettingsForm settingsForm = new SettingsForm(reviewListName, prevForm);
            settingsForm.Show();
        }

        private void LanguageFormFormClosing(object sender, FormClosingEventArgs e)
        {
            if (xIsPressed)
            {
                switch (this.prevForm)
                {
                    case PrevForm.MainForm:
                        MainForm mainForm = new MainForm();
                        mainForm.Show();
                        break;
                    case PrevForm.ListForm:
                        ListForm listForm = new ListForm(reviewListName);
                        listForm.Show();
                        break;
                }
            }
        }
    }
}
