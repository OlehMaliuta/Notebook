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
                case Language.Ukranian:
                    if (variant == "create")
                    {
                        this.Text = "Новий список";
                        listNameWindow_label.Text = "Введіть ім'я списку:";
                        giveListName_button.Text = "створити";
                    }
                    else if (variant == "rename")
                    {
                        this.Text = "Переіменувати список";
                        listNameWindow_label.Text = "Нова ім'я списку:";
                        giveListName_button.Text = "переіменувати";
                    }

                    goBack_button.Text = "назад";

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
                        listNameWindow_label.Text = "Введите имя списка:";
                        giveListName_button.Text = "создать";
                    }
                    else if (variant == "rename")
                    {
                        this.Text = "Переименовать список";
                        listNameWindow_label.Text = "новое имя списка:";
                        giveListName_button.Text = "переименовать";
                    }

                    goBack_button.Text = "назад";

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
                        listNameWindow_label.Text = "Enter a list name:";
                        giveListName_button.Text = "create";
                    }
                    else if (variant == "rename")
                    {
                        this.Text = "Rename the list";
                        listNameWindow_label.Text = "Enter a new list name:";
                        giveListName_button.Text = "rename";
                    }

                    goBack_button.Text = "back";

                    messageText = new string[] 
                    {
                        "Warning!",
                        "A list must have a name.",
                        "A list with the same name already exists."
                    };
                    break;
            }
        }

        private void ListNameForm_Load(object sender, EventArgs e)
        {
            this.listsStorage =
                JsonConvert.DeserializeObject<ListsStorage>(File.ReadAllText("ListsStorageInfo.json"));

            this.progVarStorage =
                JsonConvert.DeserializeObject<ProgVarStorage>(File.ReadAllText("ProgVarStorageInfo.json"));

            this.variant = this.progVarStorage.listNameFormVariant;

            SetWindowLanguage(progVarStorage.language, variant);
        }

        private void giveListName_button_Click(object sender, EventArgs e)
        {
            if (listName_textBox.Text == "")
            {
                MessageBox.Show(messageText[1], messageText[0]);
            }
            else if (this.listsStorage.peopleLists.Find
                        (
                        item => item.listName == listName_textBox.Text
                        ) != null
                    )
            {
                MessageBox.Show(messageText[2], messageText[0]);
            }
            else
            {
                if (this.variant == "rename")
                {
                    int idx = this.listsStorage.peopleLists.FindIndex
                        (
                        item => item.listName == progVarStorage.name
                        );

                    this.listsStorage.peopleLists[idx].listName = 
                        listName_textBox.Text;

                    this.listsStorage.peopleLists[idx].updatingDate =
                        DateTime.Now.ToShortDateString() +
                        "\n" + DateTime.Now.ToLongTimeString();

                    this.Close();
                    MainForm mainForm = new MainForm();
                    mainForm.Show();
                }
                else
                {
                    string fileDate = DateTime.Now.ToShortDateString() +
                        "\n" + DateTime.Now.ToLongTimeString();

                    this.listsStorage.peopleLists.Add(new PeopleList
                    (
                    listName: listName_textBox.Text,
                    creatingDate: fileDate,
                    updatingDate: fileDate
                    ));

                    this.Close();
                    MainForm mainForm = new MainForm();
                    mainForm.Show();
                }
            }
        }

        private void goBack_button_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }

        private void ListNameForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            File.WriteAllText("ListsStorageInfo.json", JsonConvert.SerializeObject(this.listsStorage));

            File.WriteAllText("ProgVarStorageInfo.json", JsonConvert.SerializeObject(this.progVarStorage));
        }
    }
}
