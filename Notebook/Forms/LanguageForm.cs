using System;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using Notebook.Classes;

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

            this.progVarStorage =
                JsonConvert.DeserializeObject<ProgVarStorage>(
                    File.ReadAllText("ProgVarStorageInfo.json"));

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
                    Locale.CurrentLang = "en";
                    break;

                case 1:
                    Locale.CurrentLang = "ua";
                    break;

                case 2:
                    Locale.CurrentLang = "ru";
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
