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
        private readonly ListsStorage listsStorage;
        private int sortMode;
        private bool sortByAsc;

        public MainForm()
        {
            InitializeComponent();

            this.listsStorage =
                JsonConvert.DeserializeObject<ListsStorage>(
                    File.ReadAllText("ListsStorageInfo.json"));

            this.sortMode = 0;

            this.sortByAsc = true;
        }

        private void MainFormLoad(object sender, EventArgs e)
        {
            // localization

            this.Text = $"{LanguageManager.Get("general.app-name")} - {LanguageManager.Get("main-form.form-name")}";

            listDataGridView.Columns[0].HeaderText = LanguageManager.Get("main-form.column-header-1");
            listDataGridView.Columns[1].HeaderText = LanguageManager.Get("main-form.column-header-2");
            listDataGridView.Columns[2].HeaderText = LanguageManager.Get("main-form.column-header-3");
            listDataGridView.Columns[3].HeaderText = LanguageManager.Get("main-form.column-header-4");
            listDataGridView.Columns[4].HeaderText = LanguageManager.Get("main-form.column-header-5");
            listDataGridView.Columns[5].HeaderText = LanguageManager.Get("main-form.column-header-6");

            createListButton.Text = LanguageManager.Get("main-form.add-list-option");

            searchLabel.Text = LanguageManager.Get("main-form.searching-option-title");

            settingsButton.Text = LanguageManager.Get("main-form.settings-option");

            exitButton.Text = LanguageManager.Get("main-form.exit-option");

            fileMenuSection.Text = LanguageManager.Get("main-form.top-menu-option-file");
            addListTool.Text = LanguageManager.Get("main-form.add-list-option");
            settingsTool.Text = LanguageManager.Get("main-form.settings-option");
            exitTool.Text = LanguageManager.Get("main-form.exit-option");

            // form settings

            listDataGridView.DefaultCellStyle.WrapMode =
                DataGridViewTriState.True;

            var pl = listsStorage.PeopleLists.OrderBy(item => item.ListName);

            foreach (PeopleList el in pl)
            {
                listDataGridView.Rows.Add(
                    el.ListName,
                    el.CreatingDate,
                    el.UpdatingDate);
            }
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
            File.WriteAllText(
                "ListsStorageInfo.json",
                JsonConvert.SerializeObject(this.listsStorage));

            this.Hide();
            ListNameForm listNameForm = new ListNameForm(null);
            listNameForm.Show();
        }

        private void SettingsButtonClick(object sender, EventArgs e)
        {
            File.WriteAllText(
                "ListsStorageInfo.json",
                JsonConvert.SerializeObject(this.listsStorage));

            this.Hide();
            SettingsForm settingsForm = new SettingsForm(null, SettingsForm.PrevForm.MainForm);
            settingsForm.Show();
        }

        private void ExitButtonClick(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                                LanguageManager.Get("general.exit-message"),
                                LanguageManager.Get("general.warning-message-title"),
                                MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void ListDataGridViewCellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                switch (listDataGridView.Columns[e.ColumnIndex].Name)
                {
                    case "open":
                        {
                            File.WriteAllText(
                                "ListsStorageInfo.json",
                                JsonConvert.SerializeObject(
                                    this.listsStorage));

                            this.Hide();

                            ListForm listForm = new ListForm(listsStorage.PeopleLists.Find(
                                item => item.ListName == listDataGridView[0, e.RowIndex].Value.ToString())
                                .ListName);

                            listForm.Show();
                        }
                        break;
                    case "rename":
                        {
                            File.WriteAllText(
                                "ListsStorageInfo.json",
                                JsonConvert.SerializeObject(
                                    this.listsStorage));

                            this.Hide();

                            ListNameForm listNameForm = 
                                new ListNameForm(
                                    listDataGridView[0, e.RowIndex]
                                   .Value
                                   .ToString());

                            listNameForm.Show();
                        }
                        break;
                    case "delete":
                        {
                            DialogResult result = MessageBox.Show(
                                LanguageManager.Get("main-form.remove-list-message"),
                                LanguageManager.Get("general.warning-message-title"),
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
                                            listDataGridView.Columns[sortMode],
                                            ListSortDirection.Ascending);
                            }
                        }
                        break;
                }
            }
        }

        private void SearchListTextBoxTextChanged(object sender, EventArgs e)
        {
            List<PeopleList> pl = new List<PeopleList>();

            foreach (PeopleList el in listsStorage.PeopleLists)
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

        private void ListDataGridViewColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex > 2)
            {
                return;
            }

            List<PeopleList> pl = new List<PeopleList>();

            if (sortMode == e.ColumnIndex)
            {
                this.sortByAsc = !sortByAsc;
            }
            else
            {
                this.sortByAsc = true;
            }

            this.sortMode = e.ColumnIndex;

            if (sortByAsc)
            {
                switch (sortMode)
                {
                    case 0:
                        listsStorage.PeopleLists = listsStorage.PeopleLists.OrderBy(
                            item => item.ListName).ToList();
                        break;
                    case 1:
                        listsStorage.PeopleLists = listsStorage.PeopleLists.OrderBy(
                            item => Program.MeasureTimeStr(item.CreatingDate)).ToList();
                        break;
                    case 2:
                        listsStorage.PeopleLists = listsStorage.PeopleLists.OrderBy(
                            item => Program.MeasureTimeStr(item.UpdatingDate)).ToList();
                        break;
                }
            }
            else
            {
                switch (sortMode)
                {
                    case 0:
                        listsStorage.PeopleLists = listsStorage.PeopleLists.OrderByDescending(
                            item => item.ListName).ToList();
                        break;
                    case 1:
                        listsStorage.PeopleLists = listsStorage.PeopleLists.OrderByDescending(
                            item => Program.MeasureTimeStr(item.CreatingDate)).ToList();
                        break;
                    case 2:
                        listsStorage.PeopleLists = listsStorage.PeopleLists.OrderByDescending(
                            item => Program.MeasureTimeStr(item.UpdatingDate)).ToList();
                        break;
                }
            }

            foreach (PeopleList el in listsStorage.PeopleLists)
            {
                pl.Add(new PeopleList(
                    el.ListName,
                    el.CreatingDate,
                    el.UpdatingDate));
            }

            listDataGridView.Rows.Clear();

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

        private void MainFormFormClosing(object sender, FormClosingEventArgs e)
        {
            File.WriteAllText(
                "ListsStorageInfo.json",
                JsonConvert.SerializeObject(this.listsStorage));

            Environment.Exit(0);
        }
    }
}
