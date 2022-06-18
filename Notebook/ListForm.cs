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
using Microsoft.Office.Interop.Word;
using Newtonsoft.Json;
using Application = System.Windows.Forms.Application;
using Word = Microsoft.Office.Interop.Word.Application;

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

            this.listsStorage = JsonConvert.DeserializeObject<ListsStorage>(
                File.ReadAllText("ListsStorageInfo.json"));

            this.progVarStorage =
                JsonConvert.DeserializeObject<ProgVarStorage>(File.ReadAllText("ProgVarStorageInfo.json"));

            reviewList = listsStorage.peopleLists.Single(item => item.listName == progVarStorage.reviewListName);

            var pl =
                reviewList.elements.OrderBy(item => item.name);

            foreach (Element el in pl)
            {
                elements_dataGridView.Rows.Add
                    (
                    el.name,
                    el.birthday,
                    el.creatingDate,
                    el.updatingDate
                    );
            }

            sortingElements_comboBox.SelectedIndex = 0;

            searchElement_comboBox.SelectedIndex = 0;

            this.Text = $"\"{reviewList.listName}\"";
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
            LanguageForm languageForm = new LanguageForm();
            languageForm.Show();
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
            if (e.RowIndex != -1)
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

                                foreach (Element el in reviewList.elements)
                                {
                                    elements_dataGridView.Rows.Add
                                        (
                                        el.name,
                                        el.birthday,
                                        el.creatingDate,
                                        el.updatingDate
                                        );
                                }

                                switch (sortingElements_comboBox.SelectedIndex)
                                {
                                    case 0:
                                        elements_dataGridView.Sort(elements_dataGridView.Columns[0], ListSortDirection.Ascending);
                                        break;

                                    case 1:
                                        elements_dataGridView.Sort(elements_dataGridView.Columns[1], ListSortDirection.Ascending);
                                        break;

                                    case 2:
                                        elements_dataGridView.Sort(elements_dataGridView.Columns[2], ListSortDirection.Ascending);
                                        break;

                                    case 3:
                                        elements_dataGridView.Sort(elements_dataGridView.Columns[3], ListSortDirection.Ascending);
                                        break;
                                }
                            }
                        }
                        break;
                }
            }
        }

        private void createTxtFile_button_Click(object sender, EventArgs e)
        {
            p_a:

            SaveFileDialog fileDialog = new SaveFileDialog();
            fileDialog.Filter = "All files (*.*)|*.*";
            fileDialog.InitialDirectory = @"C:\Users\User\Downloads";

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                if (fileDialog.FileName.Contains('.'))
                {
                    string text = "Ви не можете використовувати " +
                        "для іменування файлу даний символ: \".\".";

                    MessageBox.Show(text, "Попередження!");
                    goto p_a;
                }

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
                File.WriteAllText(fileDialog.FileName + ".txt", listData);
            }
        }

        private void createDocxFile_button_Click(object sender, EventArgs e)
        {
            p_b:

            SaveFileDialog fileDialog = new SaveFileDialog();
            fileDialog.Filter = "All files (*.*)|*.*";
            fileDialog.DefaultExt = ".docx";
            fileDialog.InitialDirectory = @"C:\Users\User\Downloads";

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                if (fileDialog.FileName.Contains('.'))
                {
                    string text = "Ви не можете використовувати " +
                        "для іменування файлу даний символ: \".\".";

                    MessageBox.Show(text, "Попередження!");
                    goto p_b;
                }

                Word app = new Word();
                Document docx = app.Documents.Add(Visible: false);
                Range r = docx.Range();

                List<Element> people = reviewList.elements;
                int count1 = 1;
                int count2 = 0;
                r.Text = "\"" + reviewList.listName + "\"\n";
                while (count1 <= people.Count)
                {
                    count2 = 0;
                    r.Text += $"\n{count1}. {people[count1 - 1].name}\n";
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
                        r.Text += "\n" + fields[count2] + "\n";
                        count2++;
                    }
                    r.Text += "\n";
                    count1++;
                }

                docx.SaveAs(fileDialog.FileName);
                docx.Close();
                app.Quit();
            }
        }

        private void sortingElements_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (sortingElements_comboBox.SelectedIndex)
            {
                case 0:
                    {
                        elements_dataGridView.Sort(elements_dataGridView.Columns[0], ListSortDirection.Ascending);
                    }
                    break;

                case 1:
                    {
                        elements_dataGridView.Sort(elements_dataGridView.Columns[1], ListSortDirection.Ascending);
                    }
                    break;

                case 2:
                    {
                        elements_dataGridView.Sort(elements_dataGridView.Columns[2], ListSortDirection.Ascending);
                    }
                    break;

                case 3:
                    {
                        elements_dataGridView.Sort(elements_dataGridView.Columns[3], ListSortDirection.Ascending);
                    }
                    break;
            }
        }

        private void searchElement_textBox_TextChanged(object sender, EventArgs e)
        {
            List<Element> pl = new List<Element>();

            IOrderedEnumerable<Element> persons = default;

            switch (sortingElements_comboBox.SelectedIndex)
            {
                case 0:
                    persons = reviewList.elements.OrderBy(p => p.name);
                    break;

                case 1:
                    persons = reviewList.elements.OrderBy(p => p.birthday);
                    break;

                case 2:
                    persons = reviewList.elements.OrderBy(p => p.creatingDate);
                    break;

                case 3:
                    persons = reviewList.elements.OrderBy(p => p.updatingDate);
                    break;
            }

            foreach (Element el in persons)
            {
                pl.Add(el);
            }

            while (elements_dataGridView.Rows.Count > 0)
            {
                elements_dataGridView.Rows.Remove(elements_dataGridView.Rows[elements_dataGridView.Rows.Count - 1]);
            }

            List<Element> spl = new List<Element>();

            switch (searchElement_comboBox.SelectedIndex)
            {
                case 0:
                    spl = pl.FindAll(item => item.name.Contains(searchElement_textBox.Text));
                    break;

                case 1:
                    spl = pl.FindAll(item => item.phone.Contains(searchElement_textBox.Text));
                    break;

                case 2:
                    spl = pl.FindAll(item => item.birthday.Contains(searchElement_textBox.Text));
                    break;

                case 3:
                    spl = pl.FindAll(item => item.personalData.Contains(searchElement_textBox.Text));
                    break;

                case 4:
                    spl = pl.FindAll(item => item.restdentialAddress.Contains(searchElement_textBox.Text));
                    break;

                case 5:
                    spl = pl.FindAll(item => item.locale.Contains(searchElement_textBox.Text));
                    break;

                case 6:
                    spl = pl.FindAll(item => item.firstMeeting.Contains(searchElement_textBox.Text));
                    break;
            }

            foreach (Element el in spl)
            {
                elements_dataGridView.Rows.Add
                    (
                    el.name,
                    el.birthday,
                    el.creatingDate,
                    el.updatingDate
                    );
            }
        }

        private void ListForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            File.WriteAllText("ListsStorageInfo.json", JsonConvert.SerializeObject(this.listsStorage));

            File.WriteAllText("ProgVarStorageInfo.json", JsonConvert.SerializeObject(this.progVarStorage));
        }
    }
}
