using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using MemoMates.Tools;
using MemoMates.Classes.DB;
using MemoMates.Classes.DB.Models;

namespace MemoMates
{
    public partial class MainForm : Form
    {
        private readonly DbApp DB;
        private List<PersonList> personLists;
        private int sortMode;
        private bool sortByAsc;

        public MainForm(DbApp db)
        {
            InitializeComponent();

            this.DB = db;
            this.personLists = this.DB.PersonLists.OrderBy(p => p.Name).ToList();
            this.sortMode = 0;
            this.sortByAsc = true;
        }

        private void MainFormLoad(object sender, EventArgs e)
        {
            // localization

            this.Text = $"{StringTool.Get("general.app-name")} - {StringTool.Get("main-form.form-name")}";

            listDataGridView.Columns[0].HeaderText = StringTool.Get("main-form.column-header-1");
            listDataGridView.Columns[1].HeaderText = StringTool.Get("main-form.column-header-2");
            listDataGridView.Columns[2].HeaderText = StringTool.Get("main-form.column-header-3");
            listDataGridView.Columns[3].HeaderText = StringTool.Get("main-form.column-header-4");
            listDataGridView.Columns[4].HeaderText = StringTool.Get("main-form.column-header-5");
            listDataGridView.Columns[5].HeaderText = StringTool.Get("main-form.column-header-6");

            createListButton.Text = StringTool.Get("main-form.add-list-option");

            searchLabel.Text = StringTool.Get("main-form.searching-option-title");

            settingsButton.Text = StringTool.Get("main-form.settings-option");

            exitButton.Text = StringTool.Get("main-form.exit-option");

            fileMenuSection.Text = StringTool.Get("main-form.top-menu-option-file");
            addListTool.Text = StringTool.Get("main-form.add-list-option");
            settingsTool.Text = StringTool.Get("main-form.settings-option");
            exitTool.Text = StringTool.Get("main-form.exit-option");

            // form settings

            listDataGridView.DefaultCellStyle.WrapMode =
                DataGridViewTriState.True;

            foreach (var el in personLists)
            {
                listDataGridView.Rows.Add(el.Name, el.CreatedAt, el.UpdatedAt);
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
            ListNameForm listNameForm = new ListNameForm(this.DB, null);
            DialogResult dialog = listNameForm.ShowDialog();

            if (dialog == DialogResult.OK)
            {
                this.ReloadList();
            }
        }

        private void SettingsButtonClick(object sender, EventArgs e)
        {
            this.Hide();
            SettingsForm settingsForm = new SettingsForm(this.DB, null, SettingsForm.PrevForm.MainForm);
            settingsForm.Show();
        }

        private void ExitButtonClick(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                                StringTool.Get("general.exit-message"),
                                StringTool.Get("general.warning-message-title"),
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
                var currentList = this.personLists
                    .Where(p => p.Name.ToLower()
                    .Contains(searchListTextBox.Text.ToLower()))
                    .ToList()[e.RowIndex];

                switch (listDataGridView.Columns[e.ColumnIndex].Name)
                {
                    case "open":
                        {
                            ListForm listForm = new ListForm(this.DB, currentList);
                            this.Hide();
                            listForm.Show();
                        }
                        break;
                    case "rename":
                        {
                            ListNameForm listNameForm = 
                                new ListNameForm(this.DB, currentList);

                            DialogResult dialog = listNameForm.ShowDialog();

                            if (dialog == DialogResult.OK)
                            {
                                this.ReloadList();
                            }
                        }
                        break;
                    case "delete":
                        {
                            DialogResult result = MessageBox.Show(
                                StringTool.Get("main-form.remove-list-message"),
                                StringTool.Get("general.warning-message-title"),
                                MessageBoxButtons.YesNo);

                            if (result == DialogResult.Yes)
                            {
                                this.DB.PersonLists.Remove(currentList);
                                this.personLists.Remove(currentList);
                                this.listDataGridView.Rows.RemoveAt(e.RowIndex);

                                this.DB.SaveChanges();
                            }
                        }
                        break;
                }
            }
        }

        private void SearchListTextBoxTextChanged(object sender, EventArgs e)
        {
            this.listDataGridView.Rows.Clear();

            foreach (var el in this.personLists)
            {
                if (el.Name.ToLower().Contains(this.searchListTextBox.Text.ToLower()))
                {
                    this.listDataGridView.Rows.Add(el.Name, el.CreatedAt, el.UpdatedAt);
                }
            }
        }

        private void ListDataGridViewColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex > 2)
            {
                return;
            }

            this.sortByAsc = sortMode == e.ColumnIndex ? !this.sortByAsc : true;
            this.sortMode = e.ColumnIndex;

            if (sortByAsc)
            {
                switch (sortMode)
                {
                    case 0:
                        this.personLists = this.personLists.OrderBy(p => p.Name).ToList();
                        break;
                    case 1:
                        this.personLists = this.personLists.OrderBy(p => p.CreatedAt).ToList();
                        break;
                    case 2:
                        this.personLists = this.personLists.OrderBy(p => p.UpdatedAt).ToList();
                        break;
                }
            }
            else
            {
                switch (sortMode)
                {
                    case 0:
                        this.personLists = this.personLists.OrderByDescending(p => p.Name).ToList();
                        break;
                    case 1:
                        this.personLists = this.personLists.OrderByDescending(p => p.CreatedAt).ToList();
                        break;
                    case 2:
                        this.personLists = this.personLists.OrderByDescending(p => p.UpdatedAt).ToList();
                        break;
                }
            }

            listDataGridView.Rows.Clear();

            foreach (var el in this.personLists)
            {
                if (el.Name.ToLower().Contains(this.searchListTextBox.Text.ToLower()))
                {
                    listDataGridView.Rows.Add(el.Name, el.CreatedAt, el.UpdatedAt);
                }
            }
        }

        private void MainFormFormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void ReloadList()
        {
            if (sortByAsc)
            {
                switch (sortMode)
                {
                    case 0:
                        this.personLists = this.DB.PersonLists.OrderBy(p => p.Name).ToList();
                        break;
                    case 1:
                        this.personLists = this.DB.PersonLists.OrderBy(p => p.CreatedAt).ToList();
                        break;
                    case 2:
                        this.personLists = this.DB.PersonLists.OrderBy(p => p.UpdatedAt).ToList();
                        break;
                }
            }
            else
            {
                switch (sortMode)
                {
                    case 0:
                        this.personLists = this.DB.PersonLists.OrderByDescending(p => p.Name).ToList();
                        break;
                    case 1:
                        this.personLists = this.DB.PersonLists.OrderByDescending(p => p.CreatedAt).ToList();
                        break;
                    case 2:
                        this.personLists = this.DB.PersonLists.OrderByDescending(p => p.UpdatedAt).ToList();
                        break;
                }
            }

            listDataGridView.Rows.Clear();

            foreach (var el in this.personLists)
            {
                if (el.Name.ToLower().Contains(this.searchListTextBox.Text.ToLower()))
                {
                    listDataGridView.Rows.Add(el.Name, el.CreatedAt, el.UpdatedAt);
                }
            }
        }
    }
}
