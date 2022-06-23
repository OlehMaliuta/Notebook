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
        private string[] messageText;
        private string[] fieldNames;

        public ListForm()
        {
            InitializeComponent();
        }

        private void SetWindowLang(Language language)
        {
            switch (language)
            {
                case Language.Ukranian:
                    addElement_button.Text = "додати елемент";
                    createTxtFile_button.Text = "зберегти список у файлі .txt";
                    createDocxFile_button.Text = "зберегти список у файлі .docx";

                    elements_dataGridView.Columns[0].HeaderText = "Ім'я";
                    elements_dataGridView.Columns[1].HeaderText = "Дата народження";
                    elements_dataGridView.Columns[2].HeaderText = "Дата створення ел.";
                    elements_dataGridView.Columns[3].HeaderText = "Дата оновлення ел.";
                    elements_dataGridView.Columns[4].HeaderText = "*Детальніше*";
                    elements_dataGridView.Columns[5].HeaderText = "*Видалити*";

                    search_label.Text = "Пошук за:";
                    sort_label.Text = "Сортування за:";
                    
                    searchElement_comboBox.Items.Add("ім'ям");
                    searchElement_comboBox.Items.Add("телефоном");
                    searchElement_comboBox.Items.Add("датою народження");
                    searchElement_comboBox.Items.Add("анкетними даними");
                    searchElement_comboBox.Items.Add("місцем проживання");
                    searchElement_comboBox.Items.Add("місцем роботи/навчання");
                    searchElement_comboBox.Items.Add("характером знайомства");
                    searchElement_comboBox.Items.Add("посадою знайомих");
                    searchElement_comboBox.Items.Add("діловими якостями");
                    searchElement_comboBox.Items.Add("додатковими даними");

                    sortingElements_comboBox.Items.Add("ім'ям");
                    sortingElements_comboBox.Items.Add("датою народження");
                    sortingElements_comboBox.Items.Add("датою створення ел.");
                    sortingElements_comboBox.Items.Add("датою оновлення ел.");

                    settings_button.Text = "меню налаштування";
                    mainMenu_button.Text = "головне меню";
                    exit_button.Text = "вихід";

                    messageText = new string[]
                    {
                        "Попередження!",
                        "Ви впевнені, що хочите видалити елемент зі списку",
                        "Ви не можете використовувати для іменування файлу даний символ: \".\".",
                        "Документ був успішно створений.",
                        "Повідомлення!"
                    };

                    fieldNames = new string[]
                    {
                        "День народження: ",
                        "Номера телефонів: ",
                        "Анкетні дані: ",
                        "Місце проживання: ",
                        "Посада знайомих: ",
                        "Місце праці або навчання: ",
                        "Характер знайомства: ",
                        "Ділові якості: ",
                        "Додаткова інформація: "
                    };
                    break;

                case Language.Russian:
                    addElement_button.Text = "добавить элемент";
                    createTxtFile_button.Text = "сохранить список в файле .txt";
                    createDocxFile_button.Text = "сохранить список в файле .docx";

                    elements_dataGridView.Columns[0].HeaderText = "Имя";
                    elements_dataGridView.Columns[1].HeaderText = "Дата рождения";
                    elements_dataGridView.Columns[2].HeaderText = "Дата создания эл.";
                    elements_dataGridView.Columns[3].HeaderText = "Дата обновления эл.";
                    elements_dataGridView.Columns[4].HeaderText = "*Подробнее*";
                    elements_dataGridView.Columns[5].HeaderText = "*Удалить*";

                    search_label.Text = "Поиск по:";
                    sort_label.Text = "Сортировка по:";

                    searchElement_comboBox.Items.Add("имени");
                    searchElement_comboBox.Items.Add("телефону");
                    searchElement_comboBox.Items.Add("датой рождения");
                    searchElement_comboBox.Items.Add("анкетными данними");
                    searchElement_comboBox.Items.Add("местом проживания");
                    searchElement_comboBox.Items.Add("местом работы/учёбы");
                    searchElement_comboBox.Items.Add("характером знакомства");
                    searchElement_comboBox.Items.Add("положением знакомых");
                    searchElement_comboBox.Items.Add("деловыми качествами");
                    searchElement_comboBox.Items.Add("дополнительными данными");

                    sortingElements_comboBox.Items.Add("имени");
                    sortingElements_comboBox.Items.Add("датой рождения");
                    sortingElements_comboBox.Items.Add("датой создания ел.");
                    sortingElements_comboBox.Items.Add("датой обновления ел.");

                    settings_button.Text = "меню настроек";
                    mainMenu_button.Text = "главное меню";
                    exit_button.Text = "выход";

                    messageText = new string[]
                    {
                        "Предупреждение!",
                        "Вы уверены, что хотите удалить элемент из списка?",
                        "Вы не можете использовать для именования файла даный символ: \".\".",
                        "Документ был успешно создан.",
                        "Сообщение!"
                    };

                    fieldNames = new string[]
                    {
                        "День роджения: ",
                        "Номера телефонов: ",
                        "Анкетные данные: ",
                        "Место проживания: ",
                        "Положение знакомых: ",
                        "Место работы или учёбы: ",
                        "Характер знакомства: ",
                        "Деловые качества: ",
                        "Дополнительная информация: "
                    };
                    break;

                case Language.English:
                    addElement_button.Text = "add element";
                    createTxtFile_button.Text = "save the list at .txt file";
                    createDocxFile_button.Text = "save the list at .docx file";

                    elements_dataGridView.Columns[0].HeaderText = "Name";
                    elements_dataGridView.Columns[1].HeaderText = "Birth date";
                    elements_dataGridView.Columns[2].HeaderText = "Creation el. date";
                    elements_dataGridView.Columns[3].HeaderText = "Update el. date";
                    elements_dataGridView.Columns[4].HeaderText = "*More*";
                    elements_dataGridView.Columns[5].HeaderText = "*Delete*";

                    search_label.Text = "Search by:";
                    sort_label.Text = "Sort by:";

                    searchElement_comboBox.Items.Add("name");
                    searchElement_comboBox.Items.Add("phone");
                    searchElement_comboBox.Items.Add("birth date");
                    searchElement_comboBox.Items.Add("personal data");
                    searchElement_comboBox.Items.Add("residentional address");
                    searchElement_comboBox.Items.Add("locale");
                    searchElement_comboBox.Items.Add("first meeting");
                    searchElement_comboBox.Items.Add("familar people position");
                    searchElement_comboBox.Items.Add("good sides");
                    searchElement_comboBox.Items.Add("extra info");

                    sortingElements_comboBox.Items.Add("name");
                    sortingElements_comboBox.Items.Add("birth date");
                    sortingElements_comboBox.Items.Add("creation el. date");
                    sortingElements_comboBox.Items.Add("update el. date");

                    settings_button.Text = "settings";
                    mainMenu_button.Text = "main menu";
                    exit_button.Text = "exit";

                    messageText = new string[]
                    {
                        "Warning!",
                        "Are you sure you want to remove the element from the list?",
                        "You cannot use this character for naming a file: \".\".",
                        "Document has created successfully.",
                        "Message!"
                    };

                    fieldNames = new string[]
                    {
                        "Birth date: ",
                        "Phone numbers: ",
                        "Personal data: ",
                        "Residentional address: ",
                        "Familiar people position: ",
                        "Locale: ",
                        "First meeting: ",
                        "Good sides: ",
                        "Extra information: "
                    };
                    break;
            }
        }

        private void ListForm_Load(object sender, EventArgs e)
        {
            elements_dataGridView.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            this.listsStorage = JsonConvert.DeserializeObject<ListsStorage>(
                File.ReadAllText("ListsStorageInfo.json"));

            this.progVarStorage =
                JsonConvert.DeserializeObject<ProgVarStorage>(File.ReadAllText("ProgVarStorageInfo.json"));

            SetWindowLang(progVarStorage.language);

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

        private void addElementTool_Click(object sender, EventArgs e)
        {
            addElement_button_Click(sender, e);
        }

        private void createTxtTool_Click(object sender, EventArgs e)
        {
            createTxtFile_button_Click(sender, e);
        }

        private void createDocxTool_Click(object sender, EventArgs e)
        {
            createDocxFile_button_Click(sender, e);
        }

        private void exitTool_Click(object sender, EventArgs e)
        {
            exit_button_Click(sender, e);
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
                                messageText[1],
                                messageText[0],
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
                    MessageBox.Show(messageText[2], messageText[0]);
                    goto p_a;
                }

                List<Element> people = new List<Element>();

                for (int i = 0; i < elements_dataGridView.Rows.Count; i++)
                {
                    people.Add(reviewList.elements.Single(p => p.name == elements_dataGridView[0, i].Value.ToString()));
                }

                string listData = "";
                int count1 = 1;
                int count2 = 0;
                listData = "\"" + reviewList.listName + "\"\n\n";
                while (count1 <= people.Count)
                {
                    count2 = 0;
                    listData += $"\n{count1}. {people[count1 - 1].name}\n";
                    List<string> fields = new List<string>();
                    fields.Add(fieldNames[0] + 
                        people[count1 - 1].birthday);
                    fields.Add(fieldNames[1] +
                        people[count1 - 1].phone);
                    fields.Add(fieldNames[2] +
                        people[count1 - 1].personalData);
                    fields.Add(fieldNames[3] +
                        people[count1 - 1].restdentialAddress);
                    fields.Add(fieldNames[4] +
                        people[count1 - 1].locale);
                    fields.Add(fieldNames[5] +
                        people[count1 - 1].familarPeoplePosition);
                    fields.Add(fieldNames[6] +
                        people[count1 - 1].firstMeeting);
                    fields.Add(fieldNames[7] +
                        people[count1 - 1].goodSides);
                    fields.Add(fieldNames[8] +
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
                MessageBox.Show(messageText[3], messageText[4]);
            }
        }

        private void createDocxFile_button_Click(object sender, EventArgs e)
        {
            p_b:

            SaveFileDialog fileDialog = new SaveFileDialog();
            fileDialog.Filter = "All files (*.*)|*.*";
            fileDialog.InitialDirectory = @"C:\Users\User\Downloads";

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                if (fileDialog.FileName.Contains('.'))
                {
                    MessageBox.Show(messageText[2], messageText[0]);
                    goto p_b;
                }

                Word app = new Word();
                Document docx = app.Documents.Add(Visible: false);
                Range r = docx.Range();

                List<Element> people = new List<Element>();

                for (int i = 0; i < elements_dataGridView.Rows.Count; i++)
                {
                    people.Add(reviewList.elements.Single(p => p.name == elements_dataGridView[0, i].Value.ToString()));
                }

                int count1 = 1;
                int count2 = 0;
                r.Text = "\"" + reviewList.listName + "\"\n\n";
                while (count1 <= people.Count)
                {
                    count2 = 0;
                    r.Text += $"\n{count1}. {people[count1 - 1].name}\n";
                    List<string> fields = new List<string>();
                    fields.Add(fieldNames[0] +
                        people[count1 - 1].birthday);
                    fields.Add(fieldNames[1] +
                        people[count1 - 1].phone);
                    fields.Add(fieldNames[2] +
                        people[count1 - 1].personalData);
                    fields.Add(fieldNames[3] +
                        people[count1 - 1].restdentialAddress);
                    fields.Add(fieldNames[4] +
                        people[count1 - 1].locale);
                    fields.Add(fieldNames[5] +
                        people[count1 - 1].familarPeoplePosition);
                    fields.Add(fieldNames[6] +
                        people[count1 - 1].firstMeeting);
                    fields.Add(fieldNames[7] +
                        people[count1 - 1].goodSides);
                    fields.Add(fieldNames[8] +
                        people[count1 - 1].extraInfo);

                    while (count2 < fields.Count)
                    {
                        r.Text += "\n" + fields[count2] + "\n";
                        count2++;
                    }
                    r.Text += "\n";
                    count1++;
                }

                docx.SaveAs(fileDialog.FileName + ".docx");
                docx.Close();
                app.Quit();
                MessageBox.Show(messageText[3], messageText[4]);
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
                    spl = pl.FindAll(item => item.name.ToLower().Contains(searchElement_textBox.Text.ToLower()));
                    break;

                case 1:
                    spl = pl.FindAll(item => item.phone.ToLower().Contains(searchElement_textBox.Text.ToLower()));
                    break;

                case 2:
                    spl = pl.FindAll(item => item.birthday.ToLower().Contains(searchElement_textBox.Text.ToLower()));
                    break;

                case 3:
                    spl = pl.FindAll(item => item.personalData.ToLower().Contains(searchElement_textBox.Text.ToLower()));
                    break;

                case 4:
                    spl = pl.FindAll(item => item.restdentialAddress.ToLower().Contains(searchElement_textBox.Text.ToLower()));
                    break;

                case 5:
                    spl = pl.FindAll(item => item.locale.ToLower().Contains(searchElement_textBox.Text.ToLower()));
                    break;

                case 6:
                    spl = pl.FindAll(item => item.firstMeeting.ToLower().Contains(searchElement_textBox.Text.ToLower()));
                    break;

                case 7:
                    spl = pl.FindAll(item => item.familarPeoplePosition.ToLower().Contains(searchElement_textBox.Text.ToLower()));
                    break;

                case 8:
                    spl = pl.FindAll(item => item.goodSides.ToLower().Contains(searchElement_textBox.Text.ToLower()));
                    break;

                case 9:
                    spl = pl.FindAll(item => item.extraInfo.ToLower().Contains(searchElement_textBox.Text.ToLower()));
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
