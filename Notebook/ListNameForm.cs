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

        public ListNameForm()
        {
            InitializeComponent();
        }

        private void ListNameForm_Load(object sender, EventArgs e)
        {
            this.listsStorage =
                JsonConvert.DeserializeObject<ListsStorage>(File.ReadAllText("ListsStorageInfo.json"));

            this.progVarStorage =
                JsonConvert.DeserializeObject<ProgVarStorage>(File.ReadAllText("ProgVarStorageInfo.json"));

            this.variant = this.progVarStorage.listNameFormVariant;

            if (variant == "rename")
            {
                listNameWindow_label.Text = "Інша назва списку:";
                giveListName_button.Text = "Переіменувати";
            }
        }

        private void giveListName_button_Click(object sender, EventArgs e)
        {
            if (listName_textBox.Text == "")
            {
                if (this.variant == "rename")
                {
                    MessageBox.Show("Список повинен мати назву.", "Попередження!");
                }
                else
                {
                    MessageBox.Show("Ви не можете створити список без назви.", "Попередження!");
                }
            }
            else if (this.listsStorage.peopleLists.Find
                        (
                        item => item.listName == listName_textBox.Text
                        ) != null
                    )
            {
                MessageBox.Show("Список із даною назвою вже існує.", "Попередження!");
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
