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
    public partial class ListNameForm : Form
    {
        private ListsStorage listsStorage = new ListsStorage();
        private ProgVarStorage progVarStorage = new ProgVarStorage();
        private string variant = "";
        private string[] messageText = new string[3];

        public ListNameForm()
        {
            InitializeComponent();
        }

        private void SetWindowLanguage(Language language, string variant)
        {
            switch (language)
            {
                case Language.Ukraіnian:
                    if (variant == "create")
                    {
                        this.Text = "Новий список";
                        listNameWindowLabel.Text = "Введіть ім'я списку:";
                        giveListNameButton.Text = "створити";
                    }
                    else if (variant == "rename")
                    {
                        this.Text = "Перейменувати список";
                        listNameWindowLabel.Text = "Нове ім'я списку:";
                        giveListNameButton.Text = "перейменувати";
                    }

                    goBackButton.Text = "назад";

                    messageText = new string[] 
                    {
                        "Попередження!",
                        "Список повинен мати назву.",
                        "Список із даною назвою вже існує."
                    };
                    break;

                case Language.Russian:
                    if (variant == "create")
                    {
                        this.Text = "Новый список";
                        listNameWindowLabel.Text = "Введите имя списка:";
                        giveListNameButton.Text = "создать";
                    }
                    else if (variant == "rename")
                    {
                        this.Text = "Переименовать список";
                        listNameWindowLabel.Text = "Новое имя списка:";
                        giveListNameButton.Text = "переименовать";
                    }

                    goBackButton.Text = "назад";

                    messageText = new string[] 
                    {
                        "Предупреждение!",
                        "У списка должно быть название.",
                        "Список с этим наванием уже есть."
                    };
                    break;

                case Language.English:
                    if (variant == "create")
                    {
                        this.Text = "New list";
                        listNameWindowLabel.Text = "Enter a list name:";
                        giveListNameButton.Text = "create";
                    }
                    else if (variant == "rename")
                    {
                        this.Text = "Rename the list";
                        listNameWindowLabel.Text = "Enter a new list name:";
                        giveListNameButton.Text = "rename";
                    }

                    goBackButton.Text = "back";

                    messageText = new string[] 
                    {
                        "Warning!",
                        "A list must have a name.",
                        "A list with the same name already exists."
                    };
                    break;
            }
        }

        private void ListNameFormLoad(object sender, EventArgs e)
        {
            this.listsStorage =
                JsonConvert.DeserializeObject<ListsStorage>(
                    File.ReadAllText("ListsStorageInfo.json"));

            this.progVarStorage =
                JsonConvert.DeserializeObject<ProgVarStorage>(
                    File.ReadAllText("ProgVarStorageInfo.json"));

            this.variant = this.progVarStorage.ListNameFormVariant;

            SetWindowLanguage(progVarStorage.AppLanguage, variant);
        }

        private void GiveListNameButtonClick(object sender, EventArgs e)
        {
            if (listNameTextBox.Text == "")
            {
                MessageBox.Show(messageText[1], messageText[0]);
            }
            else if (this.listsStorage.PeopleLists.Find
                        (
                        item => item.ListName == listNameTextBox.Text
                        ) != null
                    )
            {
                MessageBox.Show(messageText[2], messageText[0]);
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
