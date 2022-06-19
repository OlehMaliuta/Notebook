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

        public MainForm()
        {
            InitializeComponent();
        }

        private void SetWindowLang(Language language)
        {
            switch (language)
            {
                case Language.Ukranian:

                    break;

                case Language.Russian:
                    break;

                case Language.English:
                    break;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            listDataGridView.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            this.listsStorage = 
                JsonConvert.DeserializeObject<ListsStorage>(File.ReadAllText("ListsStorageInfo.json"));

            this.progVarStorage = 
                JsonConvert.DeserializeObject<ProgVarStorage>(File.ReadAllText("ProgVarStorageInfo.json"));

            var pl =
                listsStorage.peopleLists.OrderBy(item => item.listName);

            foreach (PeopleList el in pl)
            {
                listDataGridView.Rows.Add
                    (
                    el.listName,
                    el.creatingDate,
                    el.updatingDate
                    );
            }

            sortingListsComboBox.SelectedIndex = 0;
        }

        private void nameForListButton_Click(object sender, EventArgs e)
        {
            progVarStorage.listNameFormVariant = "create";

            File.WriteAllText("ListsStorageInfo.json", JsonConvert.SerializeObject(this.listsStorage));

            File.WriteAllText("ProgVarStorageInfo.json", JsonConvert.SerializeObject(this.progVarStorage));

            this.Hide();
            ListNameForm listNameForm = new ListNameForm();
            listNameForm.Show();
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            progVarStorage.prevWindow = "mainForm";

            File.WriteAllText("ListsStorageInfo.json", JsonConvert.SerializeObject(this.listsStorage));

            File.WriteAllText("ProgVarStorageInfo.json", JsonConvert.SerializeObject(this.progVarStorage));

            this.Hide();
            LanguageForm languageForm = new LanguageForm();
            languageForm.Show();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            File.WriteAllText("ListsStorageInfo.json", JsonConvert.SerializeObject(this.listsStorage));

            File.WriteAllText("ProgVarStorageInfo.json", JsonConvert.SerializeObject(this.progVarStorage));

            Application.Exit();
        }

        private void listDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                switch (listDataGridView.Columns[e.ColumnIndex].Name)
                {
                    case "open":
                        {
                            progVarStorage.reviewListName = listsStorage.peopleLists.Find(
                                item => item.listName == listDataGridView[0, e.RowIndex].Value.ToString()).listName;

                            File.WriteAllText("ListsStorageInfo.json", JsonConvert.SerializeObject(this.listsStorage));

                            File.WriteAllText("ProgVarStorageInfo.json", JsonConvert.SerializeObject(this.progVarStorage));

                            this.Hide();
                            ListForm listForm = new ListForm();
                            listForm.Show();
                        }
                        break;
                    case "rename":
                        {
                            progVarStorage.listNameFormVariant = "rename";
                            progVarStorage.name =
                                listDataGridView[0, e.RowIndex].Value.ToString();

                            File.WriteAllText("ListsStorageInfo.json", JsonConvert.SerializeObject(this.listsStorage));

                            File.WriteAllText("ProgVarStorageInfo.json", JsonConvert.SerializeObject(this.progVarStorage));

                            this.Hide();
                            ListNameForm listNameForm = new ListNameForm();
                            listNameForm.Show();
                        }
                        break;
                    case "delete":
                        {
                            DialogResult result = MessageBox.Show
                            (
                            "Ви впевнені, що хочите видалити список",
                            "Попередження!",
                            MessageBoxButtons.YesNo
                            );

                            if (result == DialogResult.Yes)
                            {
                                PeopleList person = 
                                    this.listsStorage.peopleLists.Find(
                                        item => item.listName == listDataGridView[0, e.RowIndex].Value.ToString()
                                        );

                                this.listsStorage.peopleLists.Remove(person);

                                while (listDataGridView.Rows.Count > 0)
                                {
                                    listDataGridView.Rows.Remove(listDataGridView.Rows[listDataGridView.Rows.Count - 1]);
                                }

                                for (int i = 0; i < listsStorage.peopleLists.Count; i++)
                                {
                                    listDataGridView.Rows.Add
                                        (
                                        listsStorage.peopleLists[i].listName,
                                        listsStorage.peopleLists[i].creatingDate,
                                        listsStorage.peopleLists[i].updatingDate
                                        );
                                }

                                switch (sortingListsComboBox.SelectedIndex)
                                {
                                    case 0:
                                        {
                                            listDataGridView.Sort(listDataGridView.Columns[0], ListSortDirection.Ascending);
                                        }
                                        break;
                                    case 1:
                                        {
                                            listDataGridView.Sort(listDataGridView.Columns[1], ListSortDirection.Ascending);
                                        }
                                        break;
                                    case 2:
                                        {
                                            listDataGridView.Sort(listDataGridView.Columns[2], ListSortDirection.Ascending);
                                        }
                                        break;
                                }
                            }
                        }
                        break;
                }
            }
        }

        private void sortingListsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (sortingListsComboBox.SelectedIndex)
            {
                case 0:
                    {
                        listDataGridView.Sort(listDataGridView.Columns[0], ListSortDirection.Ascending);
                    }
                    break;
                case 1:
                    {
                        listDataGridView.Sort(listDataGridView.Columns[1], ListSortDirection.Ascending);
                    }
                    break;
                case 2:
                    {
                        listDataGridView.Sort(listDataGridView.Columns[2], ListSortDirection.Ascending);
                    }
                    break;
            }
        }

        private void searchListTextBox_TextChanged(object sender, EventArgs e)
        {
            List<PeopleList> pl = new List<PeopleList>();

            IOrderedEnumerable<PeopleList> persons = default;

            switch (sortingListsComboBox.SelectedIndex)
            {
                case 0:
                    persons = listsStorage.peopleLists.OrderBy(item => item.listName);
                    break;
                case 1:
                    persons = listsStorage.peopleLists.OrderBy(item => item.creatingDate);
                    break;
                case 2:
                    persons = listsStorage.peopleLists.OrderBy(item => item.updatingDate);
                    break;
            }

            foreach (PeopleList el in persons)
            {
                pl.Add(new PeopleList(el.listName, el.creatingDate, el.updatingDate));
            }

            while (listDataGridView.Rows.Count > 0)
            {
                listDataGridView.Rows.Remove(listDataGridView.Rows[listDataGridView.Rows.Count - 1]);
            }

            while (pl.FindIndex(item => item.listName.Contains(searchListTextBox.Text)) != -1)
            {
                int idx = pl.FindIndex(item => item.listName.Contains(searchListTextBox.Text));

                listDataGridView.Rows.Add
                    (
                    pl[idx].listName,
                    pl[idx].creatingDate,
                    pl[idx].updatingDate
                    );

                pl.RemoveAt(idx);
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            File.WriteAllText("ListsStorageInfo.json", JsonConvert.SerializeObject(this.listsStorage));

            File.WriteAllText("ProgVarStorageInfo.json", JsonConvert.SerializeObject(this.progVarStorage));
        }
    }
}
