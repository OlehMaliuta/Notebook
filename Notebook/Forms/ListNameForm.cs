using System;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using Notebook.Classes;

namespace Notebook
{
    public partial class ListNameForm : Form
    {
        private ListsStorage listsStorage = new ListsStorage();
        private ProgVarStorage progVarStorage = new ProgVarStorage();
        private string variant = "";

        public ListNameForm()
        {
            InitializeComponent();
        }

        private void ListNameFormLoad(object sender, EventArgs e)
        {
            // form settings

            this.listsStorage =
                JsonConvert.DeserializeObject<ListsStorage>(
                    File.ReadAllText("ListsStorageInfo.json"));

            this.progVarStorage =
                JsonConvert.DeserializeObject<ProgVarStorage>(
                    File.ReadAllText("ProgVarStorageInfo.json"));

            this.variant = this.progVarStorage.ListNameFormVariant;

            // localization

            this.Text = variant == "create"
                    ? $"{Locale.Get("general.app-name")} - {Locale.Get("list-name-form.form-name-create")}"
                    : $"{Locale.Get("general.app-name")} - {Locale.Get("list-name-form.form-name-rename")}";

            listNameWindowLabel.Text = variant == "create"
                ? Locale.Get("list-name-form.name-input-option-title-create")
                : Locale.Get("list-name-form.name-input-option-title-rename");

            giveListNameButton.Text = variant == "create"
                ? Locale.Get("list-name-form.create-button")
                : Locale.Get("list-name-form.rename-button");

            cancelButton.Text = Locale.Get("list-name-form.cancel-button");
        }

        private void GiveListNameButtonClick(object sender, EventArgs e)
        {
            if (listNameTextBox.Text == "")
            {
                MessageBox.Show(
                    Locale.Get("list-name-form.list-must-have-name-message"), 
                    Locale.Get("general.warning-message-title"));
            }
            else if (this.listsStorage.PeopleLists.Find
                        (
                        item => item.ListName == listNameTextBox.Text
                        ) != null
                    )
            {
                MessageBox.Show(
                    Locale.Get("list-name-form.same-name-message"), 
                    Locale.Get("general.warning-message-title"));
            }
            else
            {
                if (this.variant == "rename")
                {
                    int idx = this.listsStorage.PeopleLists.FindIndex
                        (
                        item => item.ListName == progVarStorage.Name
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

        private void ListNameFormFormClosing(
            object sender, FormClosingEventArgs e)
        {
            File.WriteAllText(
                "ListsStorageInfo.json",
                JsonConvert.SerializeObject(this.listsStorage));

            File.WriteAllText(
                "ProgVarStorageInfo.json",
                JsonConvert.SerializeObject(this.progVarStorage));

            MainForm mainForm = new MainForm();
            mainForm.Show();
        }
    }
}
