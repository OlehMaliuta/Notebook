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
        private ProgVarStorage ProgVarStorage = new ProgVarStorage();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            lists_dataGridView.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            ListsStorage listsStorage = JsonConvert.DeserializeObject<ListsStorage>(File.ReadAllText("ListsStorageInfo.json"));
            for (int i = 0; i < listsStorage.peopleLists.Count; i++)
            {
                lists_dataGridView.Rows.Add
                    (
                    listsStorage.peopleLists[i].listName,
                    listsStorage.peopleLists[i].creatingDate,
                    listsStorage.peopleLists[i].updatingDate
                    );
            }

            sortingLists_comboBox.Text = "назвою";
        }

        private void nameForList_button_Click(object sender, EventArgs e)
        {
            ProgVarStorage progVarStorage = JsonConvert.DeserializeObject<ProgVarStorage>(File.ReadAllText("ProgVarStorageInfo.json"));
            progVarStorage.listNameFormVariant = "create";

            StreamWriter stream = new StreamWriter("ProgVarStorageInfo.json");
            stream.Write(JsonConvert.SerializeObject(progVarStorage));
            stream.Close();

            this.Hide();
            ListNameForm listNameForm = new ListNameForm();
            listNameForm.Show();
        }

        private void settings_button_Click(object sender, EventArgs e)
        {
            ProgVarStorage progVarStorage = 
                JsonConvert.DeserializeObject<ProgVarStorage>
                    (File.ReadAllText("ProgVarStorageInfo.json"));

            progVarStorage.prevWindow = "mainForm";

            StreamWriter stream = new StreamWriter("ProgVarStorageInfo.json");
            stream.Write(JsonConvert.SerializeObject(progVarStorage));
            stream.Close();

            this.Hide();
            SettingsForm settingsForm = new SettingsForm();
            settingsForm.Show();
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
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
                            ListsStorage listsStorage =
                                JsonConvert.DeserializeObject<ListsStorage>(File.ReadAllText("ListsStorageInfo.json"));

                            ProgVarStorage progVarStorage =
                                JsonConvert.DeserializeObject<ProgVarStorage>(File.ReadAllText("ProgVarStorageInfo.json"));

                            progVarStorage.index = listsStorage.peopleLists.FindIndex(
                                item => item.listName == lists_dataGridView[0, e.RowIndex].Value.ToString());

                            StreamWriter stream = new StreamWriter("ProgVarStorageInfo.json");
                            stream.Write(JsonConvert.SerializeObject(progVarStorage));
                            stream.Close();

                            ListForm listForm = new ListForm();
                            listForm.Show();
                            this.Hide();
                        }
                        break;
                    case "rename":
                        {
                            ProgVarStorage progVarStorage =
                                JsonConvert.DeserializeObject<ProgVarStorage>
                                (File.ReadAllText("ProgVarStorageInfo.json"));

                            progVarStorage.listNameFormVariant = "rename";
                            progVarStorage.name =
                                lists_dataGridView[0, e.RowIndex].Value.ToString();

                            StreamWriter stream = new StreamWriter("ProgVarStorageInfo.json");
                            stream.Write(JsonConvert.SerializeObject(progVarStorage));
                            stream.Close();

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
                                ListsStorage listsStorage = 
                                    JsonConvert.DeserializeObject<ListsStorage>
                                        (File.ReadAllText("ListsStorageInfo.json"));

                                listsStorage.peopleLists.RemoveAt(e.RowIndex);

                                StreamWriter stream = new StreamWriter("ListsStorageInfo.json");
                                stream.Write(JsonConvert.SerializeObject(listsStorage));
                                stream.Close();

                                while (lists_dataGridView.Rows.Count > 0)
                                {
                                    lists_dataGridView.Rows.Remove(lists_dataGridView.Rows[lists_dataGridView.Rows.Count - 1]);
                                }

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
    }
}
