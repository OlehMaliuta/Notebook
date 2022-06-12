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
    public partial class ListForm : Form
    {
        private ListsStorage listsStorage = new ListsStorage();
        private ProgVarStorage progVarStorage = new ProgVarStorage();
        private PeopleList reviewList = new PeopleList();

        public ListForm()
        {
            InitializeComponent();
        }

        private void ListForm_Load(object sender, EventArgs e)
        {
            elements_dataGridView.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            this.listsStorage =
                JsonConvert.DeserializeObject<ListsStorage>(File.ReadAllText("ListsStorageInfo.json"));

            this.progVarStorage =
                JsonConvert.DeserializeObject<ProgVarStorage>(File.ReadAllText("ProgVarStorageInfo.json"));

            reviewList = listsStorage.peopleLists.Single(item => item.listName == progVarStorage.reviewListName);

            foreach (var el in reviewList.elements)
            {
                elements_dataGridView.Rows.Add
                    (
                    el.name
                    );
            }

            this.Text = reviewList.listName;
        }

        private void addElement_button_Click(object sender, EventArgs e)
        {
            progVarStorage.elementFormVariant = "create";

            this.Close();
            ElementForm elementForm = new ElementForm();
            elementForm.Show();
        }

        private void settings_button_Click(object sender, EventArgs e)
        {
            progVarStorage.prevWindow = "listForm";

            this.Close();
            SettingsForm settingsForm = new SettingsForm();
            settingsForm.Show();
        }

        private void mainMenu_button_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void elements_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            switch (elements_dataGridView.Columns[e.ColumnIndex].Name)
            {
                case "open":
                    {
                        progVarStorage.elementFormVariant = "change";
                        progVarStorage.revievElementName =
                            elements_dataGridView[0, e.RowIndex].Value.ToString();

                        this.Close();
                        ElementForm elementForm = new ElementForm();
                        elementForm.Show();
                    }
                    break;

                case "delete":
                    {
                        DialogResult result = MessageBox.Show
                            (
                            "Ви впевнені, що хочите видалити елемент зі списку",
                            "Попередження!",
                            MessageBoxButtons.YesNo
                            );

                        if (result == DialogResult.Yes)
                        {
                            reviewList.elements.RemoveAt(reviewList.elements.FindIndex(item => item.name == elements_dataGridView[0, e.RowIndex].Value.ToString()));

                            while (elements_dataGridView.Rows.Count > 0)
                            {
                                elements_dataGridView.Rows.Remove(elements_dataGridView.Rows[elements_dataGridView.Rows.Count - 1]);
                            }

                            foreach (var el in reviewList.elements)
                            {
                                elements_dataGridView.Rows.Add
                                    (
                                    el.name
                                    );
                            }
                        }
                    }
                    break;
            }
        }

        private void createTxtFile_button_Click(object sender, EventArgs e)
        {
            SaveFileDialog fileDialog = new SaveFileDialog();
            fileDialog.Filter = "txt files (*.txt)|*.txt";
            fileDialog.DefaultExt = ".txt";
            fileDialog.InitialDirectory = "C:\\Users\\User\\Downloads";

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                List<Element> people = reviewList.elements;
                string listData = "";
                int count1 = 1;
                int count2 = 0;
                listData = "\"" + reviewList.listName + "\"\n";
                while (count1 <= people.Count)
                {
                    count2 = 0;
                    listData += $"\n{count1}. {people[count1 - 1].name}\n";
                    List<string> fields = new List<string>();
                    fields.Add("День народження: " + 
                        people[count1 - 1].birthday);
                    fields.Add("Номера телефонів: " +
                        people[count1 - 1].phone);
                    fields.Add("Анкетні дані: " +
                        people[count1 - 1].personalData);
                    fields.Add("Місце проживання: " +
                        people[count1 - 1].restdentialAddress);
                    fields.Add("Посада знайомих: " +
                        people[count1 - 1].locale);
                    fields.Add("Місце праці або навчання: " +
                        people[count1 - 1].familarPeoplePosition);
                    fields.Add("Характер знайомства: " +
                        people[count1 - 1].firstMeeting);
                    fields.Add("Ділові якості: " +
                        people[count1 - 1].goodSides);
                    fields.Add("Додаткова інформація: " +
                        people[count1 - 1].extraInfo);

                    while (count2 < fields.Count)
                    {
                        listData += "\n" + fields[count2] + "\n";
                        count2++;
                    }
                    listData += "\n";
                    count1++;
                }

                string path = fileDialog.FileName;
                File.WriteAllText(path, listData);
            }
        }

        private void ListForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            File.WriteAllText("ListsStorageInfo.json", JsonConvert.SerializeObject(this.listsStorage));

            File.WriteAllText("ProgVarStorageInfo.json", JsonConvert.SerializeObject(this.progVarStorage));
        }
    }
}
