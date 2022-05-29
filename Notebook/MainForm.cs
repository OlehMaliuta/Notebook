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

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.listsStorage = 
                JsonConvert.DeserializeObject<ListsStorage>(File.ReadAllText("ListsStorageInfo.json"));

            this.progVarStorage = 
                JsonConvert.DeserializeObject<ProgVarStorage>(File.ReadAllText("ProgVarStorageInfo.json"));

            var pl =
                listsStorage.peopleLists.OrderBy(item => item.listName);

            lists_dataGridView.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            foreach (var el in pl)
            {
                lists_dataGridView.Rows.Add
                    (
                    el.listName,
                    el.creatingDate,
                    el.updatingDate
                    );
            }

            sortingLists_comboBox.Text = "назвою";
        }

        private void nameForList_button_Click(object sender, EventArgs e)
        {
            progVarStorage.listNameFormVariant = "create";

            File.WriteAllText("ListsStorageInfo.json", JsonConvert.SerializeObject(this.listsStorage));

            File.WriteAllText("ProgVarStorageInfo.json", JsonConvert.SerializeObject(this.progVarStorage));

            this.Hide();
            ListNameForm listNameForm = new ListNameForm();
            listNameForm.Show();
        }

        private void settings_button_Click(object sender, EventArgs e)
        {
            progVarStorage.prevWindow = "mainForm";

            File.WriteAllText("ListsStorageInfo.json", JsonConvert.SerializeObject(this.listsStorage));

            File.WriteAllText("ProgVarStorageInfo.json", JsonConvert.SerializeObject(this.progVarStorage));

            this.Hide();
            SettingsForm settingsForm = new SettingsForm();
            settingsForm.Show();
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            File.WriteAllText("ListsStorageInfo.json", JsonConvert.SerializeObject(this.listsStorage));

            File.WriteAllText("ProgVarStorageInfo.json", JsonConvert.SerializeObject(this.progVarStorage));

            Application.Exit();
        }

        private void lists_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                switch (lists_dataGridView.Columns[e.ColumnIndex].Name)
                {
                    case "open":
                        {
                            progVarStorage.index = listsStorage.peopleLists.FindIndex(
                                item => item.listName == lists_dataGridView[0, e.RowIndex].Value.ToString());

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
                                lists_dataGridView[0, e.RowIndex].Value.ToString();

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
                                        item => item.listName == lists_dataGridView[0, e.RowIndex].Value.ToString()
                                        );

                                this.listsStorage.peopleLists.Remove(person);

                                for (int i = 0; i < listsStorage.peopleLists.Count; i++)
                                {
                                    lists_dataGridView.Rows.Add
                                        (
                                        listsStorage.peopleLists[i].listName,
                                        listsStorage.peopleLists[i].creatingDate,
                                        listsStorage.peopleLists[i].updatingDate
                                        );
                                }
                            }
                        }
                        break;
                }
            }
        }

        private void sortingLists_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            IOrderedEnumerable<PeopleList> persons = default;

            switch (sortingLists_comboBox.SelectedIndex)
            {
                case 0:
                    {
                        IOrderedEnumerable<PeopleList> pl =
                            listsStorage.peopleLists.OrderBy(item => item.listName);
                        persons = pl;
                    }
                    break;
                case 1:
                    {
                        IOrderedEnumerable<PeopleList> pl =
                            listsStorage.peopleLists.OrderBy(item => item.creatingDate);
                        persons = pl;
                    }
                    break;
                case 2:
                    {
                        IOrderedEnumerable<PeopleList> pl =
                            listsStorage.peopleLists.OrderBy(item => item.updatingDate);
                        persons = pl;
                    }
                    break;
            }

            while (lists_dataGridView.Rows.Count > 0)
            {
                lists_dataGridView.Rows.Remove(lists_dataGridView.Rows[lists_dataGridView.Rows.Count - 1]);
            }

            foreach (PeopleList el in persons)
            {
                lists_dataGridView.Rows.Add
                    (
                    el.listName,
                    el.creatingDate,
                    el.updatingDate
                    );
            }
        }

        private void searchList_textBox_TextChanged(object sender, EventArgs e)
        {
            List<PeopleList> pl = new List<PeopleList>();

            IOrderedEnumerable<PeopleList> persons = default;

            switch (sortingLists_comboBox.SelectedIndex)
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

            while (lists_dataGridView.Rows.Count > 0)
            {
                lists_dataGridView.Rows.Remove(lists_dataGridView.Rows[lists_dataGridView.Rows.Count - 1]);
            }

            while (pl.FindIndex(item => item.listName.Contains(searchList_textBox.Text)) != -1)
            {
                int idx = pl.FindIndex(item => item.listName.Contains(searchList_textBox.Text));

                lists_dataGridView.Rows.Add
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
