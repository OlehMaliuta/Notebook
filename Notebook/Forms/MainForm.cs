using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using Notebook.Classes;

namespace Notebook
{
    public partial class MainForm : Form
    {
        private ListsStorage listsStorage = new ListsStorage();
        private ProgVarStorage progVarStorage = new ProgVarStorage();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainFormLoad(object sender, EventArgs e)
        {
            // localization

            this.Text = $"{Locale.Get("general.app-name")} - {Locale.Get("main-form.form-name")}";

            listDataGridView.Columns[0].HeaderText = Locale.Get("main-form.column-header-1");
            listDataGridView.Columns[1].HeaderText = Locale.Get("main-form.column-header-2");
            listDataGridView.Columns[2].HeaderText = Locale.Get("main-form.column-header-3");
            listDataGridView.Columns[3].HeaderText = Locale.Get("main-form.column-header-4");
            listDataGridView.Columns[4].HeaderText = Locale.Get("main-form.column-header-5");
            listDataGridView.Columns[5].HeaderText = Locale.Get("main-form.column-header-6");

            createListButton.Text = Locale.Get("main-form.add-list-option");

            sortLabel.Text = Locale.Get("main-form.sorting-option-title");

            sortingListsComboBox.Items.Add(Locale.Get("main-form.sorting-variant-1"));
            sortingListsComboBox.Items.Add(Locale.Get("main-form.sorting-variant-2"));
            sortingListsComboBox.Items.Add(Locale.Get("main-form.sorting-variant-3"));

            settingsButton.Text = Locale.Get("main-form.settings-option");

            exitButton.Text = Locale.Get("main-form.exit-option");

            fileMenuSection.Text = Locale.Get("main-form.top-menu-option-file");
            addListTool.Text = Locale.Get("main-form.add-list-option");
            settingsTool.Text = Locale.Get("main-form.settings-option");
            exitTool.Text = Locale.Get("main-form.exit-option");

            // form settings

            listDataGridView.DefaultCellStyle.WrapMode =
                DataGridViewTriState.True;

            this.listsStorage =
                JsonConvert.DeserializeObject<ListsStorage>(
                    File.ReadAllText("ListsStorageInfo.json"));

            this.progVarStorage =
                JsonConvert.DeserializeObject<ProgVarStorage>(
                    File.ReadAllText("ProgVarStorageInfo.json"));

            var pl = listsStorage.PeopleLists.OrderBy(item => item.ListName);

            foreach (PeopleList el in pl)
            {
                listDataGridView.Rows.Add(
                    el.ListName,
                    el.CreatingDate,
                    el.UpdatingDate);
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
                            DialogResult result = MessageBox.Show(
                                Locale.Get("main-form.remove-list-message"),
                                Locale.Get("general.warning-message-title"),
                                MessageBoxButtons.YesNo);

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

                                listDataGridView.Sort(
                                            listDataGridView.Columns[sortingListsComboBox.SelectedIndex],
                                            ListSortDirection.Ascending);
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
