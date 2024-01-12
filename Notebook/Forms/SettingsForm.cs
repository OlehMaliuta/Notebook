using System;
using System.Windows.Forms;
using MemoMates.Tools;
using MemoMates.Classes.DB;
using MemoMates.Classes.DB.Models;

namespace MemoMates
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

            this.Text = $"{StringTool.Get("general.app-name")} - {StringTool.Get("language-form.form-name")}";
            languageWindowLabel.Text = StringTool.Get("language-form.app-language-setting-title");
            changeLanguageButton.Text = StringTool.Get("language-form.apply-button");
            mainMenuButton.Text = StringTool.Get("language-form.main-menu-button");
            goBackButton.Text = StringTool.Get("language-form.go-back-button");

            languageComboBox.Items.Add(StringTool.Get("language-form.language-option-en"));
            languageComboBox.Items.Add(StringTool.Get("language-form.language-option-ua"));
            languageComboBox.Items.Add(StringTool.Get("language-form.language-option-ru"));

            // form settings

            switch (StringTool.CurrentLang)
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
                    StringTool.CurrentLang = "en";
                    break;

                case 1:
                    StringTool.CurrentLang = "ua";
                    break;

                case 2:
                    StringTool.CurrentLang = "ru";
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
