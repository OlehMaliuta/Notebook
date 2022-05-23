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
        public string variant = "";

        public ListNameForm()
        {
            InitializeComponent();
        }

        private void ListNameForm_Load(object sender, EventArgs e)
        {
            ProgVarStorage progVarStorage =
                JsonConvert.DeserializeObject<ProgVarStorage>
                    (
                    File.ReadAllText("ProgVarStorageInfo.json"
                    ));

            this.variant = progVarStorage.listNameFormVariant;

            if (variant == "rename")
            {
                listNameWindow_label.Text = "Інша назва списку:";
                giveListName_button.Text = "Переіменувати";
            }
        }

        private void giveListName_button_Click(object sender, EventArgs e)
        {
            ListsStorage storage = JsonConvert.DeserializeObject<ListsStorage>(File.ReadAllText("ListsStorageInfo.json"));

            if (listName_textBox.Text == "")
            {
                if (this.variant == "rename")
                {
                    MessageBox.Show("Список не може не мати назви.", "Попередження!");
                }
                else
                {
                    MessageBox.Show("Ви не можете створити список без назви.", "Попередження!");
                }
            }
            else if (storage.peopleLists.Find
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
                    ProgVarStorage progVarStorage =
                        JsonConvert.DeserializeObject<ProgVarStorage>
                        (File.ReadAllText("ProgVarStorageInfo.json"));

                    storage.peopleLists[progVarStorage.index].listName =
                        listName_textBox.Text;

                    StreamWriter stream = new StreamWriter("ListsStorageInfo.json");
                    stream.Write(JsonConvert.SerializeObject(storage));
                    stream.Close();

                    this.Hide();
                    MainForm mainForm = new MainForm();
                    mainForm.Show();
                }
                else
                {
                    storage.peopleLists.Add(new PeopleList
                    (
                    listName: listName_textBox.Text,
                    creatingDate: DateTime.Now.ToShortDateString(),
                    updatingDate: DateTime.Now.ToShortDateString()
                    ));

                    StreamWriter stream = new StreamWriter("ListsStorageInfo.json");
                    stream.Write(JsonConvert.SerializeObject(storage));
                    stream.Close();

                    this.Hide();
                    MainForm mainForm = new MainForm();
                    mainForm.Show();
                }
            }
        }

        private void goBack_button_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }
    }
}
