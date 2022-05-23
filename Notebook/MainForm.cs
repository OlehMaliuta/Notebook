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
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ListsStorage storage = JsonConvert.DeserializeObject<ListsStorage>(File.ReadAllText("ListsStorageInfo.json"));
            for (int i = 0; i < storage.peopleLists.Count; i++)
            {
                lists_dataGridView.Rows.Add
                    (
                    storage.peopleLists[i].listName,
                    storage.peopleLists[i].creatingDate,
                    storage.peopleLists[i].updatingDate,
                    "..."
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

        private void exit_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void settings_button_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm();
            settingsForm.Show();
            this.Hide();
        }

        private void lists_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            switch (lists_dataGridView.Columns[e.ColumnIndex].Name)
            {
                case "open":
                    {


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
                        progVarStorage.index = e.RowIndex;

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
                            ListsStorage storage = JsonConvert.DeserializeObject<ListsStorage>(File.ReadAllText("ListsStorageInfo.json"));
                            storage.peopleLists.RemoveAt(e.RowIndex);

                            StreamWriter stream = new StreamWriter("ListsStorageInfo.json");
                            stream.Write(JsonConvert.SerializeObject(storage));
                            stream.Close();

                            this.Hide();
                            MainForm mainForm = new MainForm();
                            mainForm.Show();
                        }
                    }
                    break;
            }
        }
    }
}
