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
    public partial class MainForm : Form
    {
        private ListsStorage listsStorage = new ListsStorage();
        private ProgVarStorage progVarStorage = new ProgVarStorage();
        private string[] messageText = new string[2];

        public MainForm()
        {
            InitializeComponent();
        }

        private void SetWindowLang(Language language)
        {
            switch (language)
            {
                case Language.Ukraіnian:
                    this.Text = "Головне меню";

                    listDataGridView.Columns[0].HeaderText = "Назва списку";
                    listDataGridView.Columns[1].HeaderText = "Дата створення";
                    listDataGridView.Columns[2].HeaderText = "Дата оновлення";
                    listDataGridView.Columns[3].HeaderText = "*Відкрити*";
                    listDataGridView.Columns[4].HeaderText = "*Перейменувати*";
                    listDataGridView.Columns[5].HeaderText = "*Видалити*";

                    createListButton.Text = "додати список";

                    sortLabel.Text = "Сортування за:";

                    sortingListsComboBox.Items.Add("назвою");
                    sortingListsComboBox.Items.Add("датою створення");
                    sortingListsComboBox.Items.Add("датою оновлення");

                    settingsButton.Text = "меню налаштування";

                    exitButton.Text = "вихід";

                    messageText[0] = "Попередження!";
                    messageText[1] = "Ви впевнені, що хочите видалити список?";

                    fileMenuSection.Text = "Файл";
                    addListTool.Text = "Додати список";
                    settingsTool.Text = "Налаштування";
                    exitTool.Text = "Вихід";
                    break;

                case Language.Russian:
                    this.Text = "Главное меню";

                    listDataGridView.Columns[0].HeaderText = "Название списка";
                    listDataGridView.Columns[1].HeaderText = "Дата создания";
                    listDataGridView.Columns[2].HeaderText = "Дата обновления";
                    listDataGridView.Columns[3].HeaderText = "*Открыть*";
                    listDataGridView.Columns[4].HeaderText = "*Переименовать*";
                    listDataGridView.Columns[5].HeaderText = "*Удалить*";

                    createListButton.Text = "добавить список";

                    sortLabel.Text = "Сортировка по:";

                    sortingListsComboBox.Items.Add("названию");
                    sortingListsComboBox.Items.Add("дате создания");
                    sortingListsComboBox.Items.Add("дате обновления");

                    settingsButton.Text = "меню настроек";

                    exitButton.Text = "выход";

                    messageText[0] = "Предупреждение!";
                    messageText[1] = "Вы уверены, что хотите удалить список?";

                    fileMenuSection.Text = "Файл";
                    addListTool.Text = "Добавить список";
                    settingsTool.Text = "Настройки";
                    exitTool.Text = "Выход";
                    break;

                case Language.English:
                    this.Text = "Main menu";

                    listDataGridView.Columns[0].HeaderText = "List name";
                    listDataGridView.Columns[1].HeaderText = "Creation date";
                    listDataGridView.Columns[2].HeaderText = "Update date";
                    listDataGridView.Columns[3].HeaderText = "*Open*";
                    listDataGridView.Columns[4].HeaderText = "*Rename*";
                    listDataGridView.Columns[5].HeaderText = "*Delete*";

                    createListButton.Text = "add list";

                    sortLabel.Text = "Sort by:";

                    sortingListsComboBox.Items.Add("name");
                    sortingListsComboBox.Items.Add("creation date");
                    sortingListsComboBox.Items.Add("update date");

                    settingsButton.Text = "settings";

                    exitButton.Text = "exit";

                    messageText[0] = 
                        "Warning!";
                    messageText[1] = 
                        "Are you sure you want to remove the list?";

                    fileMenuSection.Text = "File";
                    addListTool.Text = "Add list";
                    settingsTool.Text = "Settings";
                    exitTool.Text = "Exit";
                    break;
            }
        }

        private void MainFormLoad(object sender, EventArgs e)
        {
            listDataGridView.DefaultCellStyle.WrapMode = 
                DataGridViewTriState.True;

            this.listsStorage = 
                JsonConvert.DeserializeObject<ListsStorage>(
                    File.ReadAllText("ListsStorageInfo.json"));

            this.progVarStorage = 
                JsonConvert.DeserializeObject<ProgVarStorage>(
                    File.ReadAllText("ProgVarStorageInfo.json"));

            SetWindowLang(progVarStorage.AppLanguage);

            var pl =
                listsStorage.PeopleLists.OrderBy(item => item.ListName);

            foreach (PeopleList el in pl)
            {
                listDataGridView.Rows.Add
                    (
                    el.ListName,
                    el.CreatingDate,
                    el.UpdatingDate
                    );
            }

            sortingListsComboBox.SelectedIndex = 0;
        }

        private void AddListToolClick(object sender, EventArgs e)
        {
            CreateListButtonClick(sender, e);
        }

        private void SettingsToolClick(object sender, EventArgs e)
        {
            SettingsButtonClick(sender, e);
        }

        private void ExitToolClick(object sender, EventArgs e)
        {
            ExitButtonClick(sender, e);
        }

        private void CreateListButtonClick(object sender, EventArgs e)
        {
            progVarStorage.ListNameFormVariant = "create";

            File.WriteAllText(
                "ListsStorageInfo.json",
                JsonConvert.SerializeObject(this.listsStorage));

            File.WriteAllText(
                "ProgVarStorageInfo.json",
                JsonConvert.SerializeObject(this.progVarStorage));

            this.Hide();
            ListNameForm listNameForm = new ListNameForm();
            listNameForm.Show();
        }

        private void SettingsButtonClick(object sender, EventArgs e)
        {
            progVarStorage.PrevWindow = "mainForm";

            File.WriteAllText(
                "ListsStorageInfo.json",
                JsonConvert.SerializeObject(this.listsStorage));

            File.WriteAllText(
                "ProgVarStorageInfo.json",
                JsonConvert.SerializeObject(this.progVarStorage));

            this.Hide();
            LanguageForm languageForm = new LanguageForm();
            languageForm.Show();
        }

        private void ExitButtonClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ListDataGridViewCellClick(
            object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                switch (listDataGridView.Columns[e.ColumnIndex].Name)
                {
                    case "open":
                        {
                            progVarStorage.ReviewListName = 
                                listsStorage.PeopleLists.Find(
                                item => item.ListName == listDataGridView[
                                    0, e.RowIndex].Value.ToString()).ListName;

                            File.WriteAllText(
                                "ListsStorageInfo.json",
                                JsonConvert.SerializeObject(
                                    this.listsStorage));

                            File.WriteAllText(
                                "ProgVarStorageInfo.json",
                                JsonConvert.SerializeObject(
                                    this.progVarStorage));

                            this.Hide();
                            ListForm listForm = new ListForm();
                            listForm.Show();
                        }
                        break;
                    case "rename":
                        {
                            progVarStorage.ListNameFormVariant = "rename";
                            progVarStorage.Name =
                                listDataGridView[0, e.RowIndex]
                                   .Value.ToString();

                            File.WriteAllText(
                                "ListsStorageInfo.json",
                                JsonConvert.SerializeObject(
                                    this.listsStorage));

                            File.WriteAllText(
                                "ProgVarStorageInfo.json",
                                JsonConvert.SerializeObject(
                                    this.progVarStorage));

                            this.Hide();
                            ListNameForm listNameForm = new ListNameForm();
                            listNameForm.Show();
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
                                PeopleList person = 
                                    this.listsStorage.PeopleLists.Find(
                                        item => item.ListName == 
                                        listDataGridView[0, e.RowIndex]
                                           .Value.ToString()
                                        );

                                this.listsStorage.PeopleLists.Remove(person);

                                while (listDataGridView.Rows.Count > 0)
                                {
                                    listDataGridView.Rows.Remove(
                                        listDataGridView.Rows[
                                            listDataGridView.Rows.Count - 1]);
                                }

                                for (
                                    int i = 0;
                                    i < listsStorage.PeopleLists.Count;
                                    i++)
                                {
                                    listDataGridView.Rows.Add
                                        (
                                        listsStorage.PeopleLists[i]
                                            .ListName,
                                        listsStorage.PeopleLists[i]
                                            .CreatingDate,
                                        listsStorage.PeopleLists[i]
                                            .UpdatingDate
                                        );
                                }

                                switch (sortingListsComboBox.SelectedIndex)
                                {
                                    case 0:
                                        {
                                            listDataGridView.Sort(
                                                listDataGridView.Columns[0],
                                                ListSortDirection.Ascending);
                                        }
                                        break;
                                    case 1:
                                        {
                                            listDataGridView.Sort(
                                                listDataGridView.Columns[1],
                                                ListSortDirection.Ascending);
                                        }
                                        break;
                                    case 2:
                                        {
                                            listDataGridView.Sort(
                                                listDataGridView.Columns[2],
                                                ListSortDirection.Ascending);
                                        }
                                        break;
                                }
                            }
                        }
                        break;
                }
            }
        }

        private void SortingListsComboBoxSelectedIndexChanged(
            object sender, EventArgs e)
        {
            switch (sortingListsComboBox.SelectedIndex)
            {
                case 0:
                    {
                        listDataGridView.Sort(
                            listDataGridView.Columns[0],
                            ListSortDirection.Ascending);
                    }
                    break;
                case 1:
                    {
                        listDataGridView.Sort(
                            listDataGridView.Columns[1],
                            ListSortDirection.Ascending);
                    }
                    break;
                case 2:
                    {
                        listDataGridView.Sort(
                            listDataGridView.Columns[2],
                            ListSortDirection.Ascending);
                    }
                    break;
            }
        }

        private void SearchListTextBoxTextChanged(object sender, EventArgs e)
        {
            List<PeopleList> pl = new List<PeopleList>();

            IOrderedEnumerable<PeopleList> persons = default;

            switch (sortingListsComboBox.SelectedIndex)
            {
                case 0:
                    persons = listsStorage.PeopleLists.OrderBy(
                        item => item.ListName);
                    break;
                case 1:
                    persons = listsStorage.PeopleLists.OrderBy(
                        item => item.CreatingDate);
                    break;
                case 2:
                    persons = listsStorage.PeopleLists.OrderBy(
                        item => item.UpdatingDate);
                    break;
            }

            foreach (PeopleList el in persons)
            {
                pl.Add(new PeopleList(
                    el.ListName,
                    el.CreatingDate,
                    el.UpdatingDate));
            }

            while (listDataGridView.Rows.Count > 0)
            {
                listDataGridView.Rows.Remove(
                    listDataGridView.Rows[listDataGridView.Rows.Count - 1]);
            }

            while (pl.FindIndex(item => 
                item.ListName.ToLower().Contains(
                    searchListTextBox.Text.ToLower())) != -1)
            {
                int idx = pl.FindIndex(item =>
                    item.ListName.ToLower().Contains(
                        searchListTextBox.Text.ToLower()));

                listDataGridView.Rows.Add
                    (
                    pl[idx].ListName,
                    pl[idx].CreatingDate,
                    pl[idx].UpdatingDate
                    );

                pl.RemoveAt(idx);
            }
        }

        private void MainFormFormClosing(
            object sender, FormClosingEventArgs e)
        {
            File.WriteAllText(
                "ListsStorageInfo.json",
                JsonConvert.SerializeObject(this.listsStorage));

            File.WriteAllText(
                "ProgVarStorageInfo.json",
                JsonConvert.SerializeObject(this.progVarStorage));

            Environment.Exit(0);
        }
    }
}
