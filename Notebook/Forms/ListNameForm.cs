using System;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using Notebook.Classes;
using Notebook.Classes.DB;
using Notebook.Classes.DB.Models;
using System.Linq;

namespace Notebook
{
    public partial class ListNameForm : Form
    {
        private readonly DbApp DB;
        private PersonList reviewingList;

        public ListNameForm(DbApp db, PersonList list)
        {
            InitializeComponent();

            this.DB = db;
            this.reviewingList = list;
        }

        private void ListNameFormLoad(object sender, EventArgs e)
        {
            listNameTextBox.Text = reviewingList == null ? "" : reviewingList.Name;

            // localization

            this.Text = reviewingList == null
                ? $"{LanguageManager.Get("general.app-name")} - {LanguageManager.Get("list-name-form.form-name-create")}"
                : $"{LanguageManager.Get("general.app-name")} - {LanguageManager.Get("list-name-form.form-name-rename")}";

            listNameWindowLabel.Text = reviewingList == null
                ? LanguageManager.Get("list-name-form.name-input-option-title-create")
                : LanguageManager.Get("list-name-form.name-input-option-title-rename");

            giveListNameButton.Text = reviewingList == null
                ? LanguageManager.Get("list-name-form.create-button")
                : LanguageManager.Get("list-name-form.rename-button");

            cancelButton.Text = LanguageManager.Get("list-name-form.cancel-button");
        }

        private void GiveListNameButtonClick(object sender, EventArgs e)
        {
            string input = listNameTextBox.Text;

            if (input == "")
            {
                MessageBox.Show(
                    LanguageManager.Get("list-name-form.list-must-have-name-message"),
                    LanguageManager.Get("general.warning-message-title"));
            }
            else if (this.DB.PersonLists.FirstOrDefault(p => p.Name == input) != null)
            {
                MessageBox.Show(
                    LanguageManager.Get("list-name-form.same-name-message"),
                    LanguageManager.Get("general.warning-message-title"));
            }
            else
            {
                if (this.reviewingList != null)
                {
                    this.reviewingList.Name = input;
                    this.reviewingList.UpdatedAt = DateTime.Now;
                    this.DB.SaveChanges();
                    this.Close();
                }
                else
                {
                    this.DB.PersonLists.Add(new PersonList() { Name = input });
                    this.DB.SaveChanges();
                    this.Close();
                }
            }
        }

        private void GoBackButtonClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ListNameFormFormClosing(object sender, FormClosingEventArgs e)
        {
            MainForm mainForm = new MainForm(this.DB);
            mainForm.Show();
        }
    }
}
