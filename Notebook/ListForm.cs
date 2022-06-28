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
                    addElementButton.Text = "додати елемент";

                    createTxtFileButton.Text = 
                        "зберегти список у файлі .txt";

                    createDocxFileButton.Text = 
                        "зберегти список у файлі .docx";

                    elementDataGridView.Columns[0].HeaderText = 
                        "Ім'я";
                    elementDataGridView.Columns[1].HeaderText = 
                        "Дата народження";
                    elementDataGridView.Columns[2].HeaderText = 
                        "Дата створення ел.";
                    elementDataGridView.Columns[3].HeaderText = 
                        "Дата оновлення ел.";
                    elementDataGridView.Columns[4].HeaderText = 
                        "*Детальніше*";
                    elementDataGridView.Columns[5].HeaderText = 
                        "*Видалити*";

                    searchLabel.Text = "Пошук за:";
                    sortLabel.Text = "Сортування за:";
                    
                    searchElementComboBox.Items.Add("ім'ям");
                    searchElementComboBox.Items.Add("телефоном");
                    searchElementComboBox.Items.Add("датою народження");
                    searchElementComboBox.Items.Add("анкетними даними");
                    searchElementComboBox.Items.Add("місцем проживання");
                    searchElementComboBox.Items.Add("місцем роботи/навчання");
                    searchElementComboBox.Items.Add("характером знайомства");
                    searchElementComboBox.Items.Add("посадою знайомих");
                    searchElementComboBox.Items.Add("діловими якостями");
                    searchElementComboBox.Items.Add("додатковими даними");

                    sortingElementsComboBox.Items.Add("ім'ям");
                    sortingElementsComboBox.Items.Add("датою народження");
                    sortingElementsComboBox.Items.Add("датою створення ел.");
                    sortingElementsComboBox.Items.Add("датою оновлення ел.");

                    settingsButton.Text = "меню налаштування";
                    mainMenuButton.Text = "головне меню";
                    exitButton.Text = "вихід";

                    fileMenuSection.Text = "Файл";
                    addElementTool.Text = "Додати елемент";
                    createTxtTool.Text = "Зберегти список у файлі .txt";
                    createDocxTool.Text = "Зберегти список у файлі .docx";
                    settingsTool.Text = "Налаштування";
                    exitTool.Text = "Вихід";

                    messageText = new string[]
                    {
                        "Попередження!",

                        "Ви впевнені, що хочите видалити елемент зі списку",

                        "Ви не можете використовувати для " +
                        "іменування файлу даний символ: \".\".",

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
                    addElementButton.Text = "добавить элемент";
                    createTxtFileButton.Text = 
                        "сохранить список в файле .txt";
                    createDocxFileButton.Text = 
                        "сохранить список в файле .docx";

                    elementDataGridView.Columns[0].HeaderText = 
                        "Имя";
                    elementDataGridView.Columns[1].HeaderText = 
                        "Дата рождения";
                    elementDataGridView.Columns[2].HeaderText = 
                        "Дата создания эл.";
                    elementDataGridView.Columns[3].HeaderText = 
                        "Дата обновления эл.";
                    elementDataGridView.Columns[4].HeaderText = 
                        "*Подробнее*";
                    elementDataGridView.Columns[5].HeaderText = 
                        "*Удалить*";

                    searchLabel.Text = "Поиск по:";
                    sortLabel.Text = "Сортировка по:";

                    searchElementComboBox.Items.Add("имени");
                    searchElementComboBox.Items.Add("телефону");
                    searchElementComboBox.Items.Add("датой рождения");
                    searchElementComboBox.Items.Add("анкетными данними");
                    searchElementComboBox.Items.Add("местом проживания");
                    searchElementComboBox.Items.Add("местом работы/учёбы");
                    searchElementComboBox.Items.Add("характером знакомства");
                    searchElementComboBox.Items.Add("положением знакомых");
                    searchElementComboBox.Items.Add("деловыми качествами");
                    searchElementComboBox.Items.Add("дополнительными данными");

                    sortingElementsComboBox.Items.Add("имени");
                    sortingElementsComboBox.Items.Add("датой рождения");
                    sortingElementsComboBox.Items.Add("датой создания ел.");
                    sortingElementsComboBox.Items.Add("датой обновления ел.");

                    settingsButton.Text = "меню настроек";
                    mainMenuButton.Text = "главное меню";
                    exitButton.Text = "выход";

                    fileMenuSection.Text = "Файл";
                    addElementTool.Text = "Добавить элемент";
                    createTxtTool.Text = "Сохранить список в файле .txt";
                    createDocxTool.Text = "Сохранить список в файле .docx";
                    settingsTool.Text = "Настройки";
                    exitTool.Text = "Выход";

                    messageText = new string[]
                    {
                        "Предупреждение!",

                        "Вы уверены, что хотите удалить элемент из списка?",

                        "Вы не можете использовать для " +
                        "именования файла даный символ: \".\".",

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
                    addElementButton.Text = "add element";
                    createTxtFileButton.Text = "save the list at .txt file";
                    createDocxFileButton.Text = "save the list at .docx file";

                    elementDataGridView.Columns[0].HeaderText = 
                        "Name";
                    elementDataGridView.Columns[1].HeaderText = 
                        "Birthday";
                    elementDataGridView.Columns[2].HeaderText = 
                        "Creation el. date";
                    elementDataGridView.Columns[3].HeaderText = 
                        "Update el. date";
                    elementDataGridView.Columns[4].HeaderText = 
                        "*More*";
                    elementDataGridView.Columns[5].HeaderText = 
                        "*Delete*";

                    searchLabel.Text = "Search by:";
                    sortLabel.Text = "Sort by:";

                    searchElementComboBox.Items.Add("name");
                    searchElementComboBox.Items.Add("phone");
                    searchElementComboBox.Items.Add("birthday");
                    searchElementComboBox.Items.Add("personal data");
                    searchElementComboBox.Items.Add("residentional address");
                    searchElementComboBox.Items.Add("locale");
                    searchElementComboBox.Items.Add("first meeting");
                    searchElementComboBox.Items.Add("familar people position");
                    searchElementComboBox.Items.Add("good sides");
                    searchElementComboBox.Items.Add("extra info");

                    sortingElementsComboBox.Items.Add("name");
                    sortingElementsComboBox.Items.Add("birth date");
                    sortingElementsComboBox.Items.Add("creation el. date");
                    sortingElementsComboBox.Items.Add("update el. date");

                    settingsButton.Text = "settings";
                    mainMenuButton.Text = "main menu";
                    exitButton.Text = "exit";

                    fileMenuSection.Text = "File";
                    addElementTool.Text = "Add element";
                    createTxtTool.Text = "Save the list at .txt file";
                    createDocxTool.Text = "Save the list at .docx file";
                    settingsTool.Text = "Settings";
                    exitTool.Text = "Exit";

                    messageText = new string[]
                    {
                        "Warning!",

                        "Are you sure you want to " +
                        "remove the element from the list?",

                        "You cannot use this character " +
                        "for naming a file: \".\".",

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

        private void ListFormLoad(object sender, EventArgs e)
        {
            elementDataGridView.DefaultCellStyle.WrapMode = 
                DataGridViewTriState.True;

            this.listsStorage = 
                JsonConvert.DeserializeObject<ListsStorage>(
                    File.ReadAllText("ListsStorageInfo.json"));

            this.progVarStorage =
                JsonConvert.DeserializeObject<ProgVarStorage>(
                    File.ReadAllText("ProgVarStorageInfo.json"));

            SetWindowLang(progVarStorage.AppLanguage);

            reviewList = listsStorage.PeopleLists.Single(
                item => item.ListName == progVarStorage.ReviewListName);

            var pl =
                reviewList.Elements.OrderBy(item => item.Name);

            foreach (Element el in pl)
            {
                elementDataGridView.Rows.Add
                    (
                    el.Name,
                    el.Birthday,
                    el.CreatingDate,
                    el.UpdatingDate
                    );
            }

            sortingElementsComboBox.SelectedIndex = 0;

            searchElementComboBox.SelectedIndex = 0;

            this.Text = $"\"{reviewList.ListName}\"";
        }

        private void AddElementToolClick(object sender, EventArgs e)
        {
            AddElementButtonClick(sender, e);
        }

        private void CreateTxtToolClick(object sender, EventArgs e)
        {
            CreateTxtFileButtonClick(sender, e);
        }

        private void CreateDocxToolClick(object sender, EventArgs e)
        {
            CreateDocxFileButtonClick(sender, e);
        }

        private void SettingsToolClick(object sender, EventArgs e)
        {
            SettingsButtonClick(sender, e);
        }

        private void ExitToolClick(object sender, EventArgs e)
        {
            ExitButtonClick(sender, e);
        }

        private void AddElementButtonClick(object sender, EventArgs e)
        {
            progVarStorage.ElementFormVariant = "create";

            this.Close();
            ElementForm elementForm = new ElementForm();
            elementForm.Show();
        }

        private void SettingsButtonClick(object sender, EventArgs e)
        {
            progVarStorage.PrevWindow = "listForm";

            this.Close();
            LanguageForm languageForm = new LanguageForm();
            languageForm.Show();
        }

        private void MainMenuButtonClick(object sender, EventArgs e)
        {
            this.Close();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }

        private void ExitButtonClick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ElementDataGridViewCellClick(
            object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                switch (elementDataGridView.Columns[e.ColumnIndex].Name)
                {
                    case "open":
                        {
                            progVarStorage.ElementFormVariant = "change";
                            progVarStorage.ReviewElementName =
                                elementDataGridView[0, e.RowIndex]
                                    .Value.ToString();

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
                                reviewList.Elements.RemoveAt(
                                    reviewList.Elements.FindIndex(
                                        item => 
                                            item.Name == 
                                            elementDataGridView[0, e.RowIndex]
                                            .Value.ToString()));

                                while (elementDataGridView.Rows.Count > 0)
                                {
                                    elementDataGridView.Rows.Remove(
                                        elementDataGridView.Rows[
                                            elementDataGridView.
                                               Rows.Count - 1]);
                                }

                                foreach (Element el in reviewList.Elements)
                                {
                                    elementDataGridView.Rows.Add
                                        (
                                        el.Name,
                                        el.Birthday,
                                        el.CreatingDate,
                                        el.UpdatingDate
                                        );
                                }

                                switch (sortingElementsComboBox.SelectedIndex)
                                {
                                    case 0:
                                        elementDataGridView.Sort(
                                            elementDataGridView.Columns[0],
                                            ListSortDirection.Ascending);
                                        break;

                                    case 1:
                                        elementDataGridView.Sort(
                                            elementDataGridView.Columns[1],
                                            ListSortDirection.Ascending);
                                        break;

                                    case 2:
                                        elementDataGridView.Sort(
                                            elementDataGridView.Columns[2],
                                            ListSortDirection.Ascending);
                                        break;

                                    case 3:
                                        elementDataGridView.Sort(
                                            elementDataGridView.Columns[3],
                                            ListSortDirection.Ascending);
                                        break;
                                }
                            }
                        }
                        break;
                }
            }
        }

        private void CreateTxtFileButtonClick(object sender, EventArgs e)
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

                for (int i = 0; i < elementDataGridView.Rows.Count; i++)
                {
                    people.Add(reviewList.Elements.Single(
                        p => p.Name == elementDataGridView[0, i].
                            Value.ToString()));
                }

                string listData = "";
                int count1 = 1;
                int count2 = 0;
                listData = "\"" + reviewList.ListName + "\"\n\n";
                while (count1 <= people.Count)
                {
                    count2 = 0;
                    listData += $"\n{count1}. {people[count1 - 1].Name}\n";
                    List<string> fields = new List<string>();
                    fields.Add(fieldNames[0] + 
                        people[count1 - 1].Birthday);
                    fields.Add(fieldNames[1] +
                        people[count1 - 1].Phone);
                    fields.Add(fieldNames[2] +
                        people[count1 - 1].PersonalData);
                    fields.Add(fieldNames[3] +
                        people[count1 - 1].ResidentialAddress);
                    fields.Add(fieldNames[4] +
                        people[count1 - 1].Locale);
                    fields.Add(fieldNames[5] +
                        people[count1 - 1].FamilarPeoplePosition);
                    fields.Add(fieldNames[6] +
                        people[count1 - 1].FirstMeeting);
                    fields.Add(fieldNames[7] +
                        people[count1 - 1].Skills);
                    fields.Add(fieldNames[8] +
                        people[count1 - 1].ExtraInfo);

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

        private void CreateDocxFileButtonClick(object sender, EventArgs e)
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

                for (int i = 0; i < elementDataGridView.Rows.Count; i++)
                {
                    people.Add(reviewList.Elements.Single(
                        p => p.Name == elementDataGridView[0, i]
                            .Value.ToString()));
                }

                int count1 = 1;
                int count2 = 0;
                r.Text = "\"" + reviewList.ListName + "\"\n\n";
                while (count1 <= people.Count)
                {
                    count2 = 0;
                    r.Text += $"\n{count1}. {people[count1 - 1].Name}\n";
                    List<string> fields = new List<string>();
                    fields.Add(fieldNames[0] +
                        people[count1 - 1].Birthday);
                    fields.Add(fieldNames[1] +
                        people[count1 - 1].Phone);
                    fields.Add(fieldNames[2] +
                        people[count1 - 1].PersonalData);
                    fields.Add(fieldNames[3] +
                        people[count1 - 1].ResidentialAddress);
                    fields.Add(fieldNames[4] +
                        people[count1 - 1].Locale);
                    fields.Add(fieldNames[5] +
                        people[count1 - 1].FamilarPeoplePosition);
                    fields.Add(fieldNames[6] +
                        people[count1 - 1].FirstMeeting);
                    fields.Add(fieldNames[7] +
                        people[count1 - 1].Skills);
                    fields.Add(fieldNames[8] +
                        people[count1 - 1].ExtraInfo);

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

        private void SortingElementsComboBoxSelectedIndexChanged(
            object sender, EventArgs e)
        {
            switch (sortingElementsComboBox.SelectedIndex)
            {
                case 0:
                    {
                        elementDataGridView.Sort(
                            elementDataGridView.Columns[0],
                            ListSortDirection.Ascending);
                    }
                    break;

                case 1:
                    {
                        elementDataGridView.Sort(
                            elementDataGridView.Columns[1],
                            ListSortDirection.Ascending);
                    }
                    break;

                case 2:
                    {
                        elementDataGridView.Sort(
                            elementDataGridView.Columns[2],
                            ListSortDirection.Ascending);
                    }
                    break;

                case 3:
                    {
                        elementDataGridView.Sort(
                            elementDataGridView.Columns[3],
                            ListSortDirection.Ascending);
                    }
                    break;
            }
        }

        private void SearchElementTextBoxTextChanged(
            object sender, EventArgs e)
        {
            List<Element> pl = new List<Element>();

            IOrderedEnumerable<Element> persons = default;

            switch (sortingElementsComboBox.SelectedIndex)
            {
                case 0:
                    persons = reviewList.Elements.OrderBy(p => p.Name);
                    break;

                case 1:
                    persons = reviewList.Elements.OrderBy(p => p.Birthday);
                    break;

                case 2:
                    persons = reviewList.Elements.OrderBy(
                        p => p.CreatingDate);
                    break;

                case 3:
                    persons = reviewList.Elements.OrderBy(
                        p => p.UpdatingDate);
                    break;
            }

            foreach (Element el in persons)
            {
                pl.Add(el);
            }

            while (elementDataGridView.Rows.Count > 0)
            {
                elementDataGridView.Rows.Remove(
                    elementDataGridView.Rows[
                        elementDataGridView.Rows.Count - 1]);
            }

            List<Element> spl = new List<Element>();

            switch (searchElementComboBox.SelectedIndex)
            {
                case 0:
                    spl = pl.FindAll(
                        item => item.Name.ToLower().Contains(
                            searchElementTextBox.Text.ToLower()));
                    break;

                case 1:
                    spl = pl.FindAll(
                        item => item.Phone.ToLower().Contains(
                            searchElementTextBox.Text.ToLower()));
                    break;

                case 2:
                    spl = pl.FindAll(
                        item => item.Birthday.ToLower().Contains(
                            searchElementTextBox.Text.ToLower()));
                    break;

                case 3:
                    spl = pl.FindAll(
                        item => item.PersonalData.ToLower().Contains(
                            searchElementTextBox.Text.ToLower()));
                    break;

                case 4:
                    spl = pl.FindAll(
                        item => item.ResidentialAddress.ToLower().Contains(
                            searchElementTextBox.Text.ToLower()));
                    break;

                case 5:
                    spl = pl.FindAll(
                        item => item.Locale.ToLower().Contains(
                            searchElementTextBox.Text.ToLower()));
                    break;

                case 6:
                    spl = pl.FindAll(
                        item => item.FirstMeeting.ToLower().Contains(
                            searchElementTextBox.Text.ToLower()));
                    break;

                case 7:
                    spl = pl.FindAll(
                        item => item.FamilarPeoplePosition.ToLower().Contains(
                            searchElementTextBox.Text.ToLower()));
                    break;

                case 8:
                    spl = pl.FindAll(
                        item => item.Skills.ToLower().Contains(
                            searchElementTextBox.Text.ToLower()));
                    break;

                case 9:
                    spl = pl.FindAll(
                        item => item.ExtraInfo.ToLower().Contains(
                            searchElementTextBox.Text.ToLower()));
                    break;
            }

            foreach (Element el in spl)
            {
                elementDataGridView.Rows.Add
                    (
                    el.Name,
                    el.Birthday,
                    el.CreatingDate,
                    el.UpdatingDate
                    );
            }
        }

        private void ListFormFormClosing(
            object sender, FormClosingEventArgs e)
        {
            File.WriteAllText(
                "ListsStorageInfo.json",
                JsonConvert.SerializeObject(this.listsStorage));

            File.WriteAllText(
                "ProgVarStorageInfo.json",
                JsonConvert.SerializeObject(this.progVarStorage));
        }
    }
}
