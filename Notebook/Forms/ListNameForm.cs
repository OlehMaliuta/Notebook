using System;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using Notebook.Classes;

namespace Notebook
{
    public partial class ListNameForm : Form
    {
        private readonly ListsStorage listsStorage;
        private readonly string reviewingList;

        public ListNameForm(string listName)
        {
            InitializeComponent();

            this.listsStorage =
                JsonConvert.DeserializeObject<ListsStorage>(
                    File.ReadAllText("ListsStorageInfo.json"));

            this.reviewingList = listName;
        }

        private void ListNameFormLoad(object sender, EventArgs e)
        {
            // localization

            listNameTextBox.Text = reviewingList == null
                ? ""
                : reviewingList;

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
            if (listNameTextBox.Text == "")
            {
                MessageBox.Show(
                    LanguageManager.Get("list-name-form.list-must-have-name-message"),
                    LanguageManager.Get("general.warning-message-title"));
            }
            else if (this.listsStorage.PeopleLists.Find
                        (
                        item => item.ListName == listNameTextBox.Text
                        ) != null
                    )
            {
                MessageBox.Show(
                    LanguageManager.Get("list-name-form.same-name-message"),
                    LanguageManager.Get("general.warning-message-title"));
            }
            else
            {
                if (this.reviewingList != null)
                {
                    int idx = this.listsStorage.PeopleLists.FindIndex
                        (
                        item => item.ListName == this.reviewingList
                        );

                    this.listsStorage.PeopleLists[idx].ListName =
                        listNameTextBox.Text;

                    this.listsStorage.PeopleLists[idx].UpdatingDate =
                        DateTime.Now.ToShortDateString() +
                        "\n" + DateTime.Now.ToLongTimeString();

                    this.Close();
                }
                else
                {
                    string fileDate = DateTime.Now.ToShortDateString() +
                        "\n" + DateTime.Now.ToLongTimeString();

                    this.listsStorage.PeopleLists.Add(new PeopleList
                    (
                    listName: listNameTextBox.Text,
                    creatingDate: fileDate,
                    updatingDate: fileDate
                    ));

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
            File.WriteAllText(
                "ListsStorageInfo.json",
                JsonConvert.SerializeObject(this.listsStorage));

            MainForm mainForm = new MainForm();
            mainForm.Show();
        }
    }
}
